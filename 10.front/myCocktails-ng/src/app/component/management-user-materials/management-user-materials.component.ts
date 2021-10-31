import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Select, Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { MaterialAction } from 'src/app/store/materials/materials.action';
import { MaterialSelector } from 'src/app/store/materials/materials.selector';
import { CreateUserMaterialDialogComponent } from 'src/app/component/create-user-material-dialog/create-user-material-dialog.component';

export interface CreateUserMaterialDialogData {
  userId: string;
}

@Component({
  selector: 'app-management-user-materials',
  templateUrl: './management-user-materials.component.html',
  styleUrls: ['./management-user-materials.component.css']
})
export class ManagementUserMaterialsComponent implements OnInit {
  @Select(MaterialSelector.userMaterialList) userMaterialList$: Observable<MaterialModel[]>;

  displayedColumns: string[] = ['id', 'name', 'category', 'delete'];

  materialList: MaterialModel[];
  materialIdList: number[];

  constructor(
    private store: Store,
    private dialog: MatDialog,
    private snackBar: MatSnackBar
  ) { }

  ngOnInit(): void {
    this.getUserMaterialList();
  }

  getUserMaterialList(): void {
    this.store.dispatch(new MaterialAction.GetUserMaterialList("kazuki.okahashi"));
  }

  openCreateUserMaterialDialog() {
    const dialogRef = this.dialog.open(CreateUserMaterialDialogComponent,
      {
        width: '250',
        data: {
          userId: "kazuki.okahashi"
        }
      }
    );

    dialogRef.afterClosed().subscribe(result => 
      {
        if(result != null)
        {
          this.snackBar.open(result, 'Close', {
            duration: 5000,
            verticalPosition: "bottom",
            horizontalPosition: "start"
          });
        }
      }
    )
  }
}
