import { Component, OnInit, ViewChild } from '@angular/core';
import { material } from '../../material';
import { MaterialService } from '../../service/api/material/material.service';

@Component({
  selector: 'app-search-cocktails',
  templateUrl: './search-cocktails.component.html',
  styleUrls: ['./search-cocktails.component.css']
})
export class SearchCocktailsComponent implements OnInit {

  @ViewChild('checkMaterials') item;
  selectedIds = []; 
  materials: material[];
  result: material[]; 

  constructor(
    private materialService: MaterialService
  ) { }

  ngOnInit(): void {
    this.materialService.getMaterials().
      subscribe(materials => this.materials = materials);
  }

  OnCheckboxSelect(id, event): void { 
    if (event.target.checked === true) { 
     this.selectedIds.push({id: id, checked: event.target.checked}); 
     console.log('Selected Ids ', this.selectedIds); 
    } 
    if (event.target.checked === false) { 
     this.selectedIds = this.selectedIds.filter((item) => item.id !== id); 
    } 
  }

  serachCocktails(): void {
    this.materialService.getMaterials().
    subscribe(materials => this.result = materials);
  }
}
