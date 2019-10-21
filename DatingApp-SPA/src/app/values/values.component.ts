import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { values } from '../_models/values';

@Component({
  selector: 'app-values',
  templateUrl: './values.component.html',
  styles: []
})
export class ValuesComponent implements OnInit {
  myvalues: values[] = [{
    id: null,
    value: ''
  }];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues();
  }

  getValues()
  {
    this.http.get<values[]>('http://localhost:5000/api/values').subscribe(response => {
      this.myvalues = response;
      console.log(this.myvalues)
    });
  }
}