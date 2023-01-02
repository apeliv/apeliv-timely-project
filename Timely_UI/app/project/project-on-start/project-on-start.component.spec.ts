import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectOnStartComponent } from './project-on-start.component';

describe('ProjectOnStartComponent', () => {
  let component: ProjectOnStartComponent;
  let fixture: ComponentFixture<ProjectOnStartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProjectOnStartComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProjectOnStartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
