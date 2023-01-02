import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectOnStopComponent } from './project-on-stop.component';

describe('ProjectOnStopComponent', () => {
  let component: ProjectOnStopComponent;
  let fixture: ComponentFixture<ProjectOnStopComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProjectOnStopComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProjectOnStopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
