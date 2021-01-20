import { Component, OnInit } from '@angular/core';
import { Store, Select } from '@ngxs/store';
import { Observable } from 'rxjs';
import { cocktail } from '../../cocktail';
import { CocltailSelectors } from 'src/app/store/cocktail/cocktail.selectors'
import { CocktailModel } from '@mycocktails/ng-cocktailapi-service'
import { CocktailAction } from 'src/app/store/cocktail/cocktail.actions';

@Component({
  selector: 'app-management-cocktails',
  templateUrl: './management-cocktails.component.html',
  styleUrls: ['./management-cocktails.component.css']
})
export class ManagementCocktailsComponent implements OnInit {
  @Select(CocltailSelectors.cocktailList) cocktailList$: Observable<CocktailModel[]>;

  cocktails: cocktail[];

  displayedColumns: string[] = ['select', 'id', 'name', 'base', 'edit'];

  constructor(
    private store: Store
  ) { }

  ngOnInit(): void {
    this.getCocktailList();
  }

  getCocktailList(): void {
    this.store.dispatch(new CocktailAction.GetCocktailList());
  }

  getCocktailDetail(): void {
    // TODO: implement cocktail detail.
  }

  updateCocktail(id: number): void {
    // TODO: implement update cocktails.
  }

  deleteCocktail(id: number): void {
    // TODO: implement delete cocktails.
  }

  createCocktail(): void {
    // TODO: implement create cocktails.
  }
}
