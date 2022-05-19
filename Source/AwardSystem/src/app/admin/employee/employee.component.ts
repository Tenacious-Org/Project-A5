import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { Employee } from 'Models/Employee';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  @Input() empsrc: string ="https://localhost:7275/api/Employee/GetAll";
  totalLength: any;
  page: number = 1;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {  
      this.http
        .get<any>(this.empsrc)
        .subscribe((data) => {
          this.data = data;
          this.totalLength = data.length;
          console.log(data)
         
        });
      }
        public data: Employee[] = [];

}
