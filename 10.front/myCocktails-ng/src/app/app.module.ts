import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './main/main.component';
import { SearchCocktailsComponent } from './search-cocktails/search-cocktails.component';
import { ManagementMaterialsComponent } from './management-materials/management-materials.component';
import { ManagementCocktailsComponent } from './management-cocktails/management-cocktails.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    SearchCocktailsComponent,
    ManagementMaterialsComponent,
    ManagementCocktailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
