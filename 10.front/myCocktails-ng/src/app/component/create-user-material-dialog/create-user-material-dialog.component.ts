import { Component, Inject, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Select, Store } from '@ngxs/store';
import { forkJoin, Observable, of } from 'rxjs';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { MaterialAction } from 'src/app/store/materials/materials.action';
import { MaterialSelector } from 'src/app/store/materials/materials.selector';
import { MaterialsService } from 'src/app/service/api/materials/materials.service';
import { UserMaterialModel } from 'src/app/model/material/userMaterialModel';
import { catchError, tap } from 'rxjs/operators';
import { CreateUserMaterialConfirmDialogComponent } from '../create-user-material-confirm-dialog/create-user-material-confirm-dialog.component';

export interface CreateUserMaterialDialogData {
  userId: string;
}

@Component({
  selector: 'app-create-user-material-dialog',
  templateUrl: './create-user-material-dialog.component.html',
  styleUrls: ['./create-user-material-dialog.component.css']
})
export class CreateUserMaterialDialogComponent implements OnInit {
  @Select(MaterialSelector.materialList) materialList$: Observable<MaterialModel[]>;
  @Select(MaterialSelector.userMaterialList) userMaterialList$: Observable<MaterialModel[]>;

  length: number;
  perPage: number = 40;
  startIndex: number = 0;
  endIndex: number = this.startIndex + this.perPage;

  selectedMaterial: MaterialModel[] = new Array;
  userMaterialIdList: number[] = [];
  materialList: MaterialModel[];
  unRegisteredMaterial: MaterialModel[];

  constructor(
    private store: Store,
    private materialService: MaterialsService,
    private dialog: MatDialog,
    public dialogRef: MatDialogRef<CreateUserMaterialDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: CreateUserMaterialDialogData
  ) { }

  ngOnInit(): void {
    const taskList = [];
    taskList.push(this.store.dispatch(new MaterialAction.GetMaterialList()));
    taskList.push(this.store.dispatch(new MaterialAction.GetUserMaterialList(this.data.userId)));

    forkJoin(taskList).subscribe(result => {
      this.getUnregisteredMaterial();
      this.getDataSize();
    });
  }

  // Get unregistered user material.
  getUnregisteredMaterial() {
    this.userMaterialList$.subscribe(um => um.map(um => {
      this.userMaterialIdList.push(um.materialId);
    }));

    this.materialList$.subscribe(m => {
      this.materialList = m;
    });

    this.unRegisteredMaterial = this.materialList.filter(m => !this.userMaterialIdList.includes(m.materialId));
  };

  // Select material.
  selectMaterial(material: MaterialModel) {
    if(!this.selectedMaterial.some(sm => sm.materialId === material.materialId)) {
      // Add selected material to selectedMaterial.
      this.selectedMaterial.push(material);
    } else {
      // Remove selected material by selectedMaterial.
      this.selectedMaterial = this.selectedMaterial.filter(sm => sm.materialId != material.materialId);
    }
  }

  // Create user materials.
  createUserMaterials() {
    let selectMaterialNameList: string[] = [];
    this.selectedMaterial.map(m => selectMaterialNameList.push(m.materialName));

    const dialogRef = this.dialog.open(CreateUserMaterialConfirmDialogComponent,
      {
        width: '250',
        data: {
          confirmTitle: "Do you want to register this material?",
          confirmContent: selectMaterialNameList
        }
      }
    );

    // After closed confirm dialog.
    dialogRef.afterClosed().subscribe(result => {
      if(result) {
        let materialIdList: number[] = [];
        this.selectedMaterial.map(m => materialIdList.push(m.materialId));

        const userMaterial: UserMaterialModel = {
          userId: "kazuki.okahashi",
          materialIdList: materialIdList
        };

        // call create user material api.
        this.materialService.createUserMaterial(userMaterial).pipe(
          tap(result => {
            this.dialogRef.close(result.msg);
          }),
          catchError(error =>{
            return of(error);
          })
        ).subscribe();
      }
    })
  }

  // Cancel
  onCancelClick(): void {
    this.dialogRef.close();
  }

  // Get material list data size.
  getDataSize() {
    this.length = this.unRegisteredMaterial.length;
  }

  // Paging.
  getPaginatorData(event) {
    this.startIndex = event.pageIndex * event.pageSize;
    this.endIndex = this.startIndex + event.pageSize;
    return event;
  }
}
