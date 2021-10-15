import { Component, OnInit, Inject } from '@angular/core';
import { Store, Select } from '@ngxs/store';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DialogData } from 'src/app/component/search-user-cocktails/search-user-cocktails.component'
import { CocktailSelector } from 'src/app/store/cocktails/cocktails.selector';
import { Observable } from 'rxjs';
import { CocktailDetailModel } from 'src/app/model/cocktail/cocktailDetailModel';
import { CocktailAction } from 'src/app/store/cocktails/cocktails.action';

@Component({
  selector: 'app-cocktail-detail-dialog',
  templateUrl: './cocktail-detail-dialog.component.html',
  styleUrls: ['./cocktail-detail-dialog.component.css']
})
export class CocktailDetailDialogComponent implements OnInit {
  @Select(CocktailSelector.selectedCocktail) selectedCocktail$: Observable<CocktailDetailModel[]>;

  constructor(
    public store: Store,
    public dialogRef: MatDialogRef<CocktailDetailDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData
  ) {}

  ngOnInit(): void {
    this.getCocktailDetail(this.data.cocktailId);
  }

  getCocktailDetail(cocktailId: number): void {
    this.store.dispatch(new CocktailAction.GetCocktail(cocktailId));
  }

}
