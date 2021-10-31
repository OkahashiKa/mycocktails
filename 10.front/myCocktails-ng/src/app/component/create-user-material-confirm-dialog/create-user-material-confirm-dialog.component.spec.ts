import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateUserMaterialConfirmDialogComponent } from './create-user-material-confirm-dialog.component';

describe('CreateUserMaterialConfirmDialogComponent', () => {
  let component: CreateUserMaterialConfirmDialogComponent;
  let fixture: ComponentFixture<CreateUserMaterialConfirmDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateUserMaterialConfirmDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateUserMaterialConfirmDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
