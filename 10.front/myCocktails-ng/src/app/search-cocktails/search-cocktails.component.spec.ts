import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchCocktailsComponent } from './search-cocktails.component';

describe('SearchCocktailsComponent', () => {
  let component: SearchCocktailsComponent;
  let fixture: ComponentFixture<SearchCocktailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearchCocktailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchCocktailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
