import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagementCocktailsComponent } from './management-cocktails.component';

describe('ManagementCocktailsComponent', () => {
  let component: ManagementCocktailsComponent;
  let fixture: ComponentFixture<ManagementCocktailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManagementCocktailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManagementCocktailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
