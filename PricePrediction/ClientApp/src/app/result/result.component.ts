import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-result',
  templateUrl: './result.component.html',
  styleUrls: ['./result.component.css']
})
export class ResultComponent implements OnInit {

  price: number;
  priceIsPositive: boolean;
  private activatedRoute: ActivatedRoute;

  constructor(private router: Router, activatedRoute: ActivatedRoute) {
    this.activatedRoute = activatedRoute;
    this.activatedRoute.paramMap.subscribe(async params => {
      this.price = +params.get('price');
      if(this.price > -1) {
        this.priceIsPositive = true;
      }
      else 
        this.priceIsPositive = false;
      console.log(this.price);
    });
  }

  ngOnInit() {
    console.log("ngOnInit");

  }

}
