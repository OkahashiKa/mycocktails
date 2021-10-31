import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

export interface ConfirmDialogData {
  confirmTitle: string;
  confirmContent: string[];
}

@Component({
  selector: 'app-create-user-material-confirm-dialog',
  templateUrl: './create-user-material-confirm-dialog.component.html',
  styleUrls: ['./create-user-material-confirm-dialog.component.css']
})
export class CreateUserMaterialConfirmDialogComponent implements OnInit {

  constructor(
    public dialogRef: MatDialogRef<CreateUserMaterialConfirmDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: ConfirmDialogData
  ) { }

  confirmResult: boolean = false;

  ngOnInit(): void {
  }

  // OK
  onClickOk(){
    this.confirmResult = true;
    this.dialogRef.close(this.confirmResult);
  }

  // Cancel
  onClickCancel(){
    this.dialogRef.close();
  }
}
