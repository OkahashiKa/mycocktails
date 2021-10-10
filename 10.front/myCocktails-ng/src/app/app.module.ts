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
import { CocktailState } from 'src/app/store/cocktails/cocktails.state';
import { MaterialState } from 'src/app/store/materials/materials.state'
import { HttpClientModule } from '@angular/common/http';
import { StoreModule } from '@ngrx/store';
import { SearchUserMaterialComponent } from './component/search-user-material/search-user-material.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    //SearchCocktailsComponent,
    ManagementMaterialsComponent,
    ManagementCocktailsComponent,
    SearchUserMaterialComponent,
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
    HttpClientModule,
    StoreModule.forRoot({}, {}),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
