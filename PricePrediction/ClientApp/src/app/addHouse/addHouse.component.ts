import { HttpClient } from '@angular/common/http';
import { Component, Inject, Input } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { House } from '../models/house';

@Component({
    selector: 'add-house',
    templateUrl: './addHouse.component.html',
    styleUrls: ['./addHouse.component.css'],

  })

  export class AddHouseComponent{

    houseModel:House = {
      id: 1,
      bedrooms: "string",
      squareFeet: "string",
      floors: "string",
      zipcode: "string",
      yearbuilt: "string",
      price:"string",
    }

    constructor(
        private router: Router,
        private httpClient: HttpClient,
      ) {
        httpClient.post<number>('/api/1.0/Houses', this.houseModel).subscribe(result =>{
          console.log(result);
        }
          )
      }

      // add(house: House):Observable<number> {
      //   console.log('aci');

      //   var result = this.httpClient.post<number>("/api/1.0/Houses", house)


      //   return result;
      // }
  }