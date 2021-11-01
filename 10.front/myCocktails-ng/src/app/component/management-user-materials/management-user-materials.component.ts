import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Select, Store } from '@ngxs/store';
import { Observable, of } from 'rxjs';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { MaterialAction } from 'src/app/store/materials/materials.action';
import { MaterialSelector } from 'src/app/store/materials/materials.selector';
import { CreateUserMaterialDialogComponent } from 'src/app/component/create-user-material-dialog/create-user-material-dialog.component';
import { MaterialsService } from 'src/app/service/api/materials/materials.service';
import { catchError, tap } from 'rxjs/operators';

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
    private materialService: MaterialsService,
    private dialog: MatDialog,
    private snackBar: MatSnackBar
  ) { }

  ngOnInit(): void {
    this.getUserMaterialList();
  }

  // get user material list.
  getUserMaterialList(): void {
    this.store.dispatch(new MaterialAction.GetUserMaterialList("kazuki.okahashi"));
  }

  // Open create user material dialog.
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
        // Display when a message is returned.
        if(result != null)
        {
          // open snack bar.
          this.snackBar.open(result, 'Close', {
            duration: 5000,
            verticalPosition: "bottom",
            horizontalPosition: "start"
          });

          // Get user material again. 
          this.getUserMaterialList();
        }
      }
    )
  }

  // delete user material
  deleteUserMaterial(materialId: number) {
    // call delete user material api.
    this.materialService.deleteUserMaterial("kazuki.okahashi", materialId).pipe(
      tap(result => {
        // open sucssece snack bar.
        this.snackBar.open(result.msg, 'Close', {
          duration: 5000,
          verticalPosition: "bottom",
          horizontalPosition: "start"
        });

        // Get user material again. 
        this.getUserMaterialList();
      }),
      catchError(error =>{
        // open error snack bar.
        this.snackBar.open(error, 'Close', {
          duration: 5000,
          verticalPosition: "bottom",
          horizontalPosition: "start"
        });
        return of(error);
      })
    ).subscribe();
  }
}
