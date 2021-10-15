import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateUserMaterialsComponent } from './create-user-materials.component';

describe('CreateUserCocktailsComponent', () => {
  let component: CreateUserMaterialsComponent;
  let fixture: ComponentFixture<CreateUserMaterialsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateUserMaterialsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateUserMaterialsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
