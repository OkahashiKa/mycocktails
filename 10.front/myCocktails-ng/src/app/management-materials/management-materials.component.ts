import { Component, OnInit } from '@angular/core';
import { material } from '../material';
import { MaterialService } from '../material.service';

@Component({
  selector: 'app-management-materials',
  templateUrl: './management-materials.component.html',
  styleUrls: ['./management-materials.component.css']
})
export class ManagementMaterialsComponent implements OnInit {

  materials: material[];

  constructor(
    private materialService: MaterialService
  ) { }

  ngOnInit(): void {
    this.materialService.getMaterials().
      subscribe(materials => this.materials = materials);
  }

  updateMaterials(id: number): void {
    // TODO: implement update materials.
  }

  deleteMaterials(id: number): void {
    // TODO: implement delete materials.
  }

  createMaterials(): void {
    // TODO: implement create materials.
  }
}
