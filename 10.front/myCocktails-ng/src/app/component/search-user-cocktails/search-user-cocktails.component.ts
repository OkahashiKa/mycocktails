import { Component, OnInit } from '@angular/core';
import { Store, Select } from '@ngxs/store';
import { Observable } from 'rxjs';
import { MatDialog } from '@angular/material/dialog';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { MaterialAction } from 'src/app/store/materials/materials.action';
import { MaterialSelector } from 'src/app/store/materials/materials.selector';
import { CocktailSelector } from 'src/app/store/cocktails/cocktails.selector';
import { CocktailModel } from 'src/app/model/cocktail/cocktailModel';
import { SearchCocktailConditionModel } from 'src/app/model/cocktail/searchCocktailConditionModel';
import { CocktailAction } from 'src/app/store/cocktails/cocktails.action';
import { CocktailDetailDialogComponent } from 'src/app/component/dialog/cocktail-detail-dialog/cocktail-detail-dialog.component'

export interface DialogData {
  cocktailId: number;
}

@Component({
  selector: 'app-search-user-cocktails',
  templateUrl: './search-user-cocktails.component.html',
  styleUrls: ['./search-user-cocktails.component.css']
})
export class SearchUserCocktailsComponent implements OnInit {
  @Select(MaterialSelector.userMaterialList) userMaterialList$: Observable<MaterialModel[]>;
  @Select(CocktailSelector.userCocktailList) userCocktailList$: Observable<CocktailModel[]>;

  constructor(
    private store: Store,
    private dialog: MatDialog,
  ) { }

  ngOnInit(): void {
    this.getUserMaterialList();
    this.userMaterialList$
      .subscribe((um) => this.getUserCocktail({
        materialIdList: um.map(um => um.materialId),
        materialSearchType: "AND",
      }));
  }

  getUserMaterialList(): void {
    this.store.dispatch(new MaterialAction.GetUserMaterialList("kazuki.okahashi"));
  }

  getUserCocktail(searchCocktailCondition: SearchCocktailConditionModel): void {
    this.store.dispatch(new CocktailAction.SearchCocktail(searchCocktailCondition));
  }

  openCocktailDetailDialog(cocktailId: number) {
    this.dialog.open(CocktailDetailDialogComponent, {
      width: '250',
      data: {
        cocktailId: cocktailId
      }
    });
  }
}
