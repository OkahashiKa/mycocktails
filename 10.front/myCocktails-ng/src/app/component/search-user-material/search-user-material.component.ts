import { Component, OnInit } from '@angular/core';
import { Store, Select } from '@ngxs/store';
import { Observable } from 'rxjs';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { MaterialAction } from 'src/app/store/materials/materials.action';
import { MaterialSelector } from 'src/app/store/materials/materials.selector';

@Component({
  selector: 'app-search-user-material',
  templateUrl: './search-user-material.component.html',
  styleUrls: ['./search-user-material.component.css']
})
export class SearchUserMaterialComponent implements OnInit {
  @Select(MaterialSelector.userMaterialList) userMaterialList$: Observable<MaterialModel[]>;

  constructor(
    private store: Store,
  ) { }

  ngOnInit(): void {
    this.getUserMaterialList();
  }

  getUserMaterialList(): void {
    this.store.dispatch(new MaterialAction.GetUserMaterialList("kazuki.okahashi"));
  }

}
