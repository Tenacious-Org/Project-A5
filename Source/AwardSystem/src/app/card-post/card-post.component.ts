import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-card-post',
  templateUrl: './card-post.component.html',
  styleUrls: ['./card-post.component.css']
})
export class CardPostComponent implements OnInit {

  data: any;
  totalLength: any;
  page: number = 1;

  constructor() { }

  ngOnInit(): void {
    // this.http
    //   .get<any>('https://jsonplaceholder.typicode.com/comments')
    //   .subscribe((data) => {
    //     this.data = data;
    //     this.totalLength = data.length;
    //     console.log(this.totalLength);
    //   });
  }

}
