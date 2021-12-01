import {Component, OnInit} from '@angular/core';
import {FormBuilder, FormGroup, FormControl, Validators} from '@angular/forms';
import {Router} from '@angular/router';


@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css']
})
export class FormsComponent implements OnInit {
  form: FormGroup = new FormGroup({});
  control = new FormControl('', Validators.required);
  invalidForm = false;

  constructor(private router: Router, fb: FormBuilder) {
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

  compute() {
    if (!this.form.invalid) {
      this.invalidForm = false;
      this.router.navigateByUrl('waitingPage');
    } else {
      this.invalidForm = true;
    }
  }

  setInvalidForm() {
    this.invalidForm = false;
  }

  ngOnInit() {
  }

}
