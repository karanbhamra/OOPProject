import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model: any = {};  // will store username and password


  constructor() { }

  ngOnInit() {
  }

  login() {
    console.log(this.model);
  }

}
