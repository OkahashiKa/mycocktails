import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Select, Store } from '@ngxs/store';
import { Observable, of } from 'rxjs';
import { MatListOption } from '@angular/material/list';
import { CreateUserMaterialDialogData } from 'src/app/component/management-user-materials/management-user-materials.component';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { MaterialAction } from 'src/app/store/materials/materials.action';
import { MaterialSelector } from 'src/app/store/materials/materials.selector';
import { MaterialsService } from 'src/app/service/api/materials/materials.service';
import { UserMaterialModel } from 'src/app/model/material/userMaterialModel';
import { catchError, tap } from 'rxjs/operators';

@Component({
  selector: 'app-create-user-materials',
  templateUrl: './create-user-materials.component.html',
  styleUrls: ['./create-user-materials.component.css']
})
export class CreateUserMaterialsComponent implements OnInit {
  @Select(MaterialSelector.materialList) materialList$: Observable<MaterialModel[]>;

  length: number; // 全件数
  perPage: number = 40; // 1ページの表示件数
  startIndex: number = 0; //　ページネーションbegin値
  endIndex: number = this.startIndex + this.perPage;　//　ページネーションbegin+perPage値

  selectedMaterial: MaterialModel[] = new Array;

  constructor(
    private store: Store,
    private materialService: MaterialsService,
    public dialogRef: MatDialogRef<CreateUserMaterialsComponent>,
    @Inject(MAT_DIALOG_DATA) public data: CreateUserMaterialDialogData
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
  public getPaginatorData(event) {
    this.startIndex = event.pageIndex * event.pageSize;
    this.endIndex = this.startIndex + event.pageSize;
    return event;
  }

  // When material is selected.
  public selectMaterial(material: MaterialModel) {
    if(!this.selectedMaterial.some(sm => sm.materialId === material.materialId)) {
      // Add selected material to selectedMaterial.
      this.selectedMaterial.push(material);
    } else {
      // Remove selected material by selectedMaterial.
      this.selectedMaterial = this.selectedMaterial.filter(sm => sm.materialId != material.materialId);
    }
  }

  // create user materials.
  public createUserMaterials() {
      let materialIdList: number[] = [];
      this.selectedMaterial.map(m => materialIdList.push(m.materialId));

      const userMaterial: UserMaterialModel = {
        userId: "kazuki.okahashi",
        materialIdList: materialIdList
      };

      this.materialService.createUserMaterial(userMaterial).subscribe();
  }

  // Cancel
  onCancelClick(): void {
    this.dialogRef.close();
  }
}
