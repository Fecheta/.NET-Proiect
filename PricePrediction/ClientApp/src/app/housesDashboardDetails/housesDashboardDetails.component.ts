import { HttpClient } from '@angular/common/http';
import { House } from '../models/house';
import { Component } from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
    selector: 'houses-dashboard-details',
    templateUrl: './housesDashboardDetails.component.html',
    styleUrls: ['./housesDashboardDetails.component.css'],
  })

  export class HousesDashboardDetailsComponent{
    house:House = new House();
    private houseId;

    ngOnInit() {
      this.httpClient.get<House>(`/api/1.0/Houses/${this.houseId}`).subscribe(result =>{
        console.log(result);
        this.house = result;
      });
    }

    constructor(
      private router: Router,
      private httpClient: HttpClient,
      private activatedRoute: ActivatedRoute
    ) {
      this.activatedRoute.paramMap.subscribe( async params => {
        this.houseId = params.get('houseId');
        console.log(this.houseId);
      });
    }
  }