import { Component, OnInit } from '@angular/core';
import { Store, Select } from '@ngxs/store';
import { Observable } from 'rxjs';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { MaterialSelector } from 'src/app/store/materials/materials.selector';
import { MaterialAction } from 'src/app/store/materials/materials.action';

@Component({
    selector: 'app-management-materials',
    templateUrl: './management-materials.component.html',
    styleUrls: ['./management-materials.component.css']
})
export class ManagementMaterialsComponent implements OnInit {
  @Select(MaterialSelector.materialList) materialList$: Observable<MaterialModel[]>;

  displayedColumns: string[] = ['select', 'id', 'name', 'category', 'edit'];

  constructor(
    private store: Store,
  ) { }

  ngOnInit(): void {
    this.getMaterialList();
  }

  getMaterialList(): void {
    this.store.dispatch(new MaterialAction.GetMaterialList());
  }

  updateMaterial(id: number): void {
    // TODO: implement update materials.
  }

  deleteMaterial(id: number): void {
    // TODO: implement delete materials.
  }

  createMaterial(): void {
    // TODO: implement create materials.
  }
}
