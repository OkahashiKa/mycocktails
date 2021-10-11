import { Component, OnInit } from '@angular/core';
import { CocktailModel } from 'src/app/model/cocktail/cocktailModel'

@Component({
  selector: 'app-search-user-material',
  templateUrl: './search-user-material.component.html',
  styleUrls: ['./search-user-material.component.css']
})
export class SearchUserMaterialComponent implements OnInit {

  displayedColumns: string[] = ['id', 'name'];

  userCocktailList$: CocktailModel[] = [
    {cocktailId: 1, cocktailName: "ジントニック"},
    {cocktailId: 2, cocktailName: "マティーニ"},
  ];

  constructor()
  {

  }

  ngOnInit(): void {
  }

}
