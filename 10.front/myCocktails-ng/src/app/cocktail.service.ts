import { Injectable } from '@angular/core';
import { cocktail } from './cocktail';
import { COCKTAILS } from './moc-cocktails';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CocktailService {

  constructor() { }

  getCocktails(): Observable<cocktail[]>{
    return of(COCKTAILS);
  }
}
