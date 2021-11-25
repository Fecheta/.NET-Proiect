import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'add-house',
    templateUrl: './addHouse.component.html',
    styleUrls: ['./addHouse.component.css'],

  })

  export class AddHouseComponent{
    constructor(
        private router: Router,

      ) {}
  }