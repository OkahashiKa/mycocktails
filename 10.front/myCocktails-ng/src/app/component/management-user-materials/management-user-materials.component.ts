import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Select, Store } from '@ngxs/store';
import { Observable, of } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { UserMaterialModel } from 'src/app/model/material/userMaterialModel';
import { MaterialsService } from 'src/app/service/api/materials/materials.service';
import { MaterialAction } from 'src/app/store/materials/materials.action';
import { MaterialSelector } from 'src/app/store/materials/materials.selector';
import { CreateUserMaterialsComponent } from '../create-user-materials/create-user-materials.component';

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
    private materialService: MaterialsService
  ) { }

  ngOnInit(): void {
    this.getUserMaterialList();
  }

  getUserMaterialList(): void {
    this.store.dispatch(new MaterialAction.GetUserMaterialList("kazuki.okahashi"));
  }

  openCreateUserMaterialDialog() {
    const dialogRef = this.dialog.open(CreateUserMaterialsComponent, {
      width: '250',
      data: {
        userId: "kazuki.okahashi"
      }
    });

    dialogRef.afterClosed().pipe(
      tap(result => alert('登録が完了しました。')),
      catchError(error =>{
        return of(error);
      })
    ).subscribe();
  }
}
