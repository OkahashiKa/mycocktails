import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchUserMaterialComponent } from './search-user-material.component';

describe('SearchUserMaterialComponent', () => {
  let component: SearchUserMaterialComponent;
  let fixture: ComponentFixture<SearchUserMaterialComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearchUserMaterialComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchUserMaterialComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
