import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './main/main.component';
import { SearchCocktailsComponent } from './search-cocktails/search-cocktails.component';
import { ManagementCocktailsComponent } from './management-cocktails/management-cocktails.component';
import { ManagementMaterialsComponent } from './management-materials/management-materials.component';

const routes: Routes = [
  { path: '', component: MainComponent },
  { path: 'searchCocktails', component: SearchCocktailsComponent },
  { path: 'managementCocktails', component: ManagementCocktailsComponent },
  { path: 'managementMaterials', component: ManagementMaterialsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
