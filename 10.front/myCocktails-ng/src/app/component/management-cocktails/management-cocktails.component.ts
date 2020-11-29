import { Component, OnInit } from '@angular/core';
import { cocktail } from '../../cocktail';
import { CocktailService } from '../../service/cocktail/cocktail.service';

@Component({
  selector: 'app-management-cocktails',
  templateUrl: './management-cocktails.component.html',
  styleUrls: ['./management-cocktails.component.css']
})
export class ManagementCocktailsComponent implements OnInit {

  cocktails: cocktail[];

  displayedColumns: string[] = ['select', 'id', 'name', 'base', 'edit'];
  dataSource: cocktail[];

  constructor(
    private cocktailService: CocktailService
  ) { }

  ngOnInit(): void {
    this.cocktailService.getCocktails().
      subscribe(cocktails => {
        this.cocktails = cocktails
        this.dataSource = cocktails
      });
  }

  cocktailDetail(): void {
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
