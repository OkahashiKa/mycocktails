import { Component, Inject, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Select, Store } from '@ngxs/store';
import { Observable, of } from 'rxjs';
import { MatListOption } from '@angular/material/list';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { MaterialAction } from 'src/app/store/materials/materials.action';
import { MaterialSelector } from 'src/app/store/materials/materials.selector';
import { MaterialsService } from 'src/app/service/api/materials/materials.service';
import { UserMaterialModel } from 'src/app/model/material/userMaterialModel';
import { catchError, tap } from 'rxjs/operators';
import { CreateUserMaterialConfirmDialogComponent, ConfirmDialogData } from '../create-user-material-confirm-dialog/create-user-material-confirm-dialog.component';

@Component({
  selector: 'app-create-user-material-dialog',
  templateUrl: './create-user-material-dialog.component.html',
  styleUrls: ['./create-user-material-dialog.component.css']
})
export class CreateUserMaterialDialogComponent implements OnInit {
  @Select(MaterialSelector.materialList) materialList$: Observable<MaterialModel[]>;

  length: number; // 全件数
  perPage: number = 40; // 1ページの表示件数
  startIndex: number = 0; //　ページネーションbegin値
  endIndex: number = this.startIndex + this.perPage;　//　ページネーションbegin+perPage値

  selectedMaterial: MaterialModel[] = new Array;

  constructor(
    private store: Store,
    private materialService: MaterialsService,
    private dialog: MatDialog,
    public dialogRef: MatDialogRef<CreateUserMaterialDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: ConfirmDialogData
  ) { }

  ngOnInit(): void {
    this.store.dispatch(new MaterialAction.GetMaterialList());
    this.getDataSize();
  }

  onMaterialsChange(options: MatListOption[]): void {
    console.log(options.map(o => o.value));
  }

  getDataSize() {
    this.materialList$.subscribe(m => this.length = m.length);
  }

  // Paging.
  getPaginatorData(event) {
    this.startIndex = event.pageIndex * event.pageSize;
    this.endIndex = this.startIndex + event.pageSize;
    return event;
  }

  // When material is selected.
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
          confirmTitle: "こやつら登録していいのんか？",
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

        this.materialService.createUserMaterial(userMaterial).pipe(
          tap(result => {
            this.dialogRef.close(result.msg);
          }),
          catchError(error =>{
            alert('既に登録済みの材料が選択されています。');
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
}
