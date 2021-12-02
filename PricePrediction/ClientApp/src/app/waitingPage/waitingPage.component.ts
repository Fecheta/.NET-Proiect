import {Component} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';


@Component({
  selector: 'app-waiting-page',
  templateUrl: './waitingPage.component.html',
  styleUrls: ['./waitingPage.component.css'],

})

export class WaitingPageComponent {
  private price;
  private router: Router;


  constructor(private activatedRoute: ActivatedRoute, router: Router) {
    this.router = router;
    this.activatedRoute.paramMap.subscribe( async params => {
      this.price = params.get('price');
      console.log(this.price);

      await delay(4000);

      this.router.navigateByUrl('result/' + this.price);

    });

    function delay(ms: number) {
      return new Promise( resolve => setTimeout(resolve, ms) );
    }
  }
}
