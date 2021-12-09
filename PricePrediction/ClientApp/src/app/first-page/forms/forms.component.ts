import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, FormControl, Validators} from '@angular/forms';
import {Router} from '@angular/router';
import {HttpClient} from '@angular/common/http';
import {House} from 'src/app/models/house';


@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css']
})
export class FormsComponent implements OnInit {
  form: FormGroup = new FormGroup({});
  control = new FormControl('', Validators.required);
  invalidForm = false;

  houseModel: House = {
    id: 1,
    bedrooms: '',
    bathrooms: '',
    squareFeet: '',
    floors: '',
    zipcode: '',
    yearbuilt: '',
    price: '',
  };

  constructor(private router: Router, fb: FormBuilder, private httpClient: HttpClient) {
    this.form = fb.group({
      grade: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(1)]],
      zipcode: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.minLength(5), Validators.maxLength(5)]],
      year: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(1800), Validators.max((new Date()).getFullYear())]],
      bedrooms: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(1)]],
      bathrooms: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(1)]],
      sqftliving: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(100)]],
      sqftlot: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(100)]],
      floors: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(1)]]
    });
  }

  get f() {
    return this.form.controls;
  }

  submit() {
    if (!this.form.invalid) {
      console.log(this.form.value);
    }
  }

  setInvalidForm() {
    this.invalidForm = false;
  }

  ngOnInit() {
    console.log('ngOnInit');
  }

  computePrice(house: House) {
    if (!this.form.invalid) {
      this.httpClient.post<number>('/api/1.0/PricePrediction', this.houseModel).subscribe(result => {
        console.log(result);
        this.invalidForm = false;
        this.router.navigateByUrl('waitingPage/' + result);
      });
    } else {
      this.invalidForm = true;
    }

  }
}

