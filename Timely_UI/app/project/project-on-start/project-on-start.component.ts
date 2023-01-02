import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-project-on-start',
  templateUrl: './project-on-start.component.html',
  styleUrls: ['./project-on-start.component.css'],
})
export class ProjectOnStartComponent implements OnInit {
  constructor(private service: SharedService) {}
  projectList: any = [];
  ngOnInit(): void {
    this.refreshProjectList();
  }

  refreshProjectList() {
    this.service.addProject(new Date());
    this.service.getProjectList().subscribe((data) => {
      this.projectList = data;
    });
  }
}
