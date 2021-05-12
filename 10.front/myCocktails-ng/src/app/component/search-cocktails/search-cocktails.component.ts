// import { Component, OnInit, ViewChild } from '@angular/core';
// import { CocktailsService } from '../../service/api/cocktail/cocktails-api.service';
// import { CocktailModel } from '@mycocktails/ng-cocktailapi-service'

// @Component({
//   selector: 'app-search-cocktails',
//   templateUrl: './search-cocktails.component.html',
//   styleUrls: ['./search-cocktails.component.css']
// })
// export class SearchCocktailsComponent implements OnInit {

//   @ViewChild('checkMaterials') item;
//   selectedIds = []; 
//   cocktail: CocktailModel;
//   cocktailList: CocktailModel[]; 

//   constructor(
//     private cocktailsService: CocktailsService
//   ) { }

//   ngOnInit(): void {
//     this.cocktailsService.getCocktailsList().
//       subscribe(cocktails => this.cocktailList = cocktails);
//   }

//   OnCheckboxSelect(id, event): void { 
//     if (event.target.checked === true) { 
//      this.selectedIds.push({id: id, checked: event.target.checked}); 
//      console.log('Selected Ids ', this.selectedIds); 
//     } 
//     if (event.target.checked === false) { 
//      this.selectedIds = this.selectedIds.filter((item) => item.id !== id); 
//     } 
//   }

//   serachCocktails(): void {
//     this.cocktailsService.getCocktailsList().
//     subscribe(cocktails => this.cocktailList = cocktails);
//   }
// }
