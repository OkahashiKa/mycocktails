import { Component, OnInit } from '@angular/core';
import { Store, Select } from '@ngxs/store';
import { Observable } from 'rxjs';
import { CocktailModel } from 'src/app/model/cocktail/cocktailModel';
import { CocktailSelector } from 'src/app/store/cocktails/cocktails.selector';
import { CocktailAction } from 'src/app/store/cocktails//cocktails.action';

@Component({
  selector: 'app-management-cocktails',
  templateUrl: './management-cocktails.component.html',
  styleUrls: ['./management-cocktails.component.css']
})
export class ManagementCocktailsComponent implements OnInit {
  @Select(CocktailSelector.cocktailList) cocktailList$: Observable<CocktailModel[]>;

  displayedColumns: string[] = ['select', 'id', 'name', 'edit'];

  constructor(
    private store: Store,
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
