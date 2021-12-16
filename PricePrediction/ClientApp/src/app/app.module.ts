import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AddHouseComponent } from './addHouse/addHouse.component';
import { WaitingPageComponent } from './waitingPage/waitingPage.component';
import { FirstPageComponent } from './first-page/first-page.component';
import { FormsComponent } from './first-page/forms/forms.component';
import { HeaderComponent } from './first-page/header/header.component';
import { ResultComponent } from './result/result.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatProgressBarModule} from '@angular/material';
import { HousesDashboardComponent } from './housesDashboard/housesDashboard.component';
import { HousesDashboardDetailsComponent } from './housesDashboardDetails/housesDashboardDetails.component';
import { HouseCardItemComponent } from './houseCardItem/houseCardItem.component';
import { HouseCardDetailsComponent } from './houseCardDetails/houseCardDetails.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AddHouseComponent,
    WaitingPageComponent,
    FirstPageComponent,
    FormsComponent,
    HeaderComponent,
    ResultComponent,
    HousesDashboardComponent,
    HousesDashboardDetailsComponent,
    HouseCardItemComponent,
    HouseCardDetailsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {path: '', component: HomeComponent, pathMatch: 'full'},
      {path: 'counter', component: CounterComponent},
      {path: 'fetch-data', component: FetchDataComponent},
      {path: 'addHouse', component: AddHouseComponent},
      {path: 'waiting', component: WaitingPageComponent},
      {path: 'waiting/:price', component: WaitingPageComponent},
      {path: 'HousePricePrediction', component: FirstPageComponent},
      {path: 'result', component: ResultComponent},
      {path: 'result/:price', component: ResultComponent},
      {path: 'dashboard', component: HousesDashboardComponent},
      {path: 'details', component: HousesDashboardDetailsComponent},
      {path: 'details/:houseId', component: HousesDashboardDetailsComponent},
    ]),
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatProgressBarModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
