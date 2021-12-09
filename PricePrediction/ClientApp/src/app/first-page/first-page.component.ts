import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-first-page',
  templateUrl: './first-page.component.html'
})
export class FirstPageComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
    console.log("ngOnInit");
  }

}
