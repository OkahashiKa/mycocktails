import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagementUserMaterialsComponent } from './management-user-materials.component';

describe('ManagementUserMaterialsComponent', () => {
  let component: ManagementUserMaterialsComponent;
  let fixture: ComponentFixture<ManagementUserMaterialsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManagementUserMaterialsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManagementUserMaterialsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
