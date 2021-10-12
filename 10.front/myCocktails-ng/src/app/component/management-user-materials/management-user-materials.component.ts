import { Component, OnInit } from '@angular/core';
import { Select, Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { MaterialAction } from 'src/app/store/materials/materials.action';
import { MaterialSelector } from 'src/app/store/materials/materials.selector';

@Component({
  selector: 'app-management-user-materials',
  templateUrl: './management-user-materials.component.html',
  styleUrls: ['./management-user-materials.component.css']
})
export class ManagementUserMaterialsComponent implements OnInit {
  @Select(MaterialSelector.userMaterialList) userMaterialList$: Observable<MaterialModel[]>;

  displayedColumns: string[] = ['id', 'name', 'category', 'delete'];

  constructor(
    private store: Store,
  ) { }

  ngOnInit(): void {
    this.getUserMaterialList();
  }

  getUserMaterialList(): void {
    this.store.dispatch(new MaterialAction.GetUserMaterialList("kazuki.okahashi"));
  }

  createUserMaterial(): void {
    
  }
}
