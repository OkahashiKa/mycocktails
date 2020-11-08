import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './main/main.component';
import { SearchCocktailsComponent } from './search-cocktails/search-cocktails.component';
import { ManagementMaterialsComponent } from './management-materials/management-materials.component'

const routes: Routes = [
  { path: '', component: MainComponent },
  { path: 'searchCocktails', component: SearchCocktailsComponent },
  { path: 'managementMaterials', component: ManagementMaterialsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
