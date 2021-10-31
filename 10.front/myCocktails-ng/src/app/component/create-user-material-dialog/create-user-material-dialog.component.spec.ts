import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateUserMaterialDialogComponent } from './create-user-material-dialog.component';

describe('CreateUserCocktailsComponent', () => {
  let component: CreateUserMaterialDialogComponent;
  let fixture: ComponentFixture<CreateUserMaterialDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateUserMaterialDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateUserMaterialDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
