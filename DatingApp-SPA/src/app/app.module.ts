import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ValuesComponent } from './values/values.component';

import { HttpClientModule } from 'node_modules/@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    ValuesComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule /* For HTTP Request */
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
