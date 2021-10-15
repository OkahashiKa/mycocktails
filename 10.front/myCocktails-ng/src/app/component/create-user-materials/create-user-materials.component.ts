import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CreateUserMaterialDialogData } from 'src/app/component/management-user-materials/management-user-materials.component';

@Component({
  selector: 'app-create-user-materials',
  templateUrl: './create-user-materials.component.html',
  styleUrls: ['./create-user-materials.component.css']
})
export class CreateUserMaterialsComponent implements OnInit {

  constructor(
    public dialogRef: MatDialogRef<CreateUserMaterialsComponent>,
    @Inject(MAT_DIALOG_DATA) public data: CreateUserMaterialDialogData
  ) { }

  ngOnInit(): void {
    
  }

}
