import { HttpClient } from '@angular/common/http';
import { Component, Inject, Input } from '@angular/core';
import { Router } from '@angular/router';
import { House } from '../models/house';
import {FormBuilder, FormGroup, FormControl, Validators} from '@angular/forms';


@Component({
    selector: 'add-house',
    templateUrl: './addHouse.component.html',
    styleUrls: ['./addHouse.component.css'],

  })

  export class AddHouseComponent{
    inputForm: FormGroup = new FormGroup({});
    control = new FormControl('', Validators.required);
    invalidForm = false;

    houseModel:House = {
      id: 1,
      bedrooms: "",
      bathrooms: "",
      squareFeet: "",
      floors: "",
      zipcode: "",
      yearbuilt: "",
      price:"",
    }

    constructor(
        private router: Router,
        private httpClient: HttpClient,
        formBuilder: FormBuilder
      ) {
        this.inputForm = formBuilder.group({
          price: ['', [Validators.required, Validators.pattern('^[0-9]*$'), ]],
          zipcode: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.minLength(5), Validators.maxLength(5)]],
          yearbuilt: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(1800), Validators.max((new Date()).getFullYear())]],
          bedrooms: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(1)]],
          bathrooms: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(1)]],
          squarefeet: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(20)]],
          floors: ['', [Validators.required, Validators.pattern('^[0-9]*$'), Validators.min(1)]],
        });
      }
      get f() {
        return this.inputForm.controls;
      }
    
      submit() {
        if (!this.inputForm.invalid) {
          console.log(this.inputForm.value);
        }
      }
    
      compute() {
        if (!this.inputForm.invalid) {
          this.invalidForm = false;
          this.router.navigateByUrl('waitingPage');
        } else {
          this.invalidForm = true;
        }
      }
    
      setInvalidForm() {
        this.invalidForm = false;
      }

      add(house: House) {
        var result = this.httpClient.post<number>('/api/1.0/Houses', this.houseModel).subscribe(result =>{
          console.log(result);
        });

      }
  }