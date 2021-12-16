import { Component, Input, } from '@angular/core';
import { House } from '../models/house';

@Component({
    selector: 'house-card-details',
    templateUrl: './houseCardDetails.component.html',
    styleUrls: ['./houseCardDetails.component.css'],
  })

  export class HouseCardDetailsComponent{
    @Input() house:House;
  }