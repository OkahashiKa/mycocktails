import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './component/main/main.component';
//import { SearchCocktailsComponent } from './component/search-cocktails/search-cocktails.component';
import { ManagementMaterialsComponent } from './component/management-materials/management-materials.component';
import { ManagementCocktailsComponent } from './component/management-cocktails/management-cocktails.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgxsModule } from '@ngxs/store';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatDialogModule } from '@angular/material/dialog'
import { CocktailState } from 'src/app/store/cocktails/cocktails.state';
import { MaterialState } from 'src/app/store/materials/materials.state'
import { HttpClientModule } from '@angular/common/http';
import { StoreModule } from '@ngrx/store';
import { SearchUserCocktailsComponent } from './component/search-user-cocktails/search-user-cocktails.component';
import { ManagementUserMaterialsComponent } from './component/management-user-materials/management-user-materials.component';
import { CocktailDetailDialogComponent } from './component/dialog/cocktail-detail-dialog/cocktail-detail-dialog.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    //SearchCocktailsComponent,
    ManagementMaterialsComponent,
    ManagementCocktailsComponent,
    SearchUserCocktailsComponent,
    ManagementUserMaterialsComponent,
    CocktailDetailDialogComponent,
  ],
  imports: [
    NgxsModule.forRoot([
      CocktailState,
      MaterialState
    ]),
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatButtonModule,
    MatCardModule,
    MatDialogModule,
    HttpClientModule,
    StoreModule.forRoot({}, {}),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
