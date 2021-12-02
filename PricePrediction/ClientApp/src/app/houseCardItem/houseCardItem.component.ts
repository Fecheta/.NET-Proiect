import { Component, Input, } from '@angular/core';
import { House } from '../models/house';

@Component({
    selector: 'house-card-item',
    templateUrl: './houseCardItem.component.html',
    styleUrls: ['./houseCardItem.component.css'],
  })

  export class HouseCardItemComponent{
    @Input() house:House;
  }