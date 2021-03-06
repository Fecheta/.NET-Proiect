import { HttpClient } from '@angular/common/http';
import { House } from './../models/house';
import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'houses-dashboard',
    templateUrl: './housesDashboard.component.html',
    styleUrls: ['./housesDashboard.component.css'],
  })

  export class HousesDashboardComponent{
    houses:House[];
    totalHouses:number;
    page:number=1;

    constructor(
      private router: Router,
      private httpClient: HttpClient,
    ) {
      this.httpClient.get<House[]>('/api/1.0/Houses').subscribe(result =>{
        console.log(result);
        this.houses = result;
        this.totalHouses= result.length;
      });
    }
    redirectId(id:number){
      this.router.navigateByUrl('details/' + id);
    }
  }
