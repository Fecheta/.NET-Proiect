import { Component, Input, } from '@angular/core';
import { Router } from '@angular/router';
import { House } from '../models/house';

@Component({
    selector: 'house-card-item',
    templateUrl: './houseCardItem.component.html',
    styleUrls: ['./houseCardItem.component.css'],
  })

  export class HouseCardItemComponent{
    @Input() house:House;
  }