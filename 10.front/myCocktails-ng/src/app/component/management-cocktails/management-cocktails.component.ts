import { Component, OnInit } from '@angular/core';
import { Store, Select } from '@ngxs/store';
import { Observable } from 'rxjs';
import { CocktailsService } from 'src/app/service/api/cocktails/cocktails.service';
import { CocltailSelector } from 'src/app/store/cocktails/cocktails.selector'
import { CocktailAction } from 'src/app/store/cocktails//cocktails.action';
import { CocktailModel } from '@mycocktails/ng-cocktailapi-service'

@Component({
  selector: 'app-management-cocktails',
  templateUrl: './management-cocktails.component.html',
  styleUrls: ['./management-cocktails.component.css']
})
export class ManagementCocktailsComponent implements OnInit {
  @Select(CocltailSelector.cocktailList) cocktailList$: Observable<CocktailModel[]>;

  cocktailList: CocktailModel[];

  displayedColumns: string[] = ['select', 'id', 'name', 'edit'];

  constructor(
    private store: Store,
    private cocktailsService: CocktailsService,
  ) { }

  ngOnInit(): void {
    this.getCocktailList();
  }

  getCocktailList(): void {
    this.cocktailsService.getCocktailsList()
      .subscribe
      (
        result => {
          this.cocktailList = result;
        }
      );
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
