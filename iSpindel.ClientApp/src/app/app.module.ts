import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { MqttModule, IMqttServiceOptions } from 'ngx-mqtt';

import { AppComponent } from './app.component';
import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';
import { CustomMaterialModule } from './material.module';
import { AppRoutingModule } from './app-routing.module';
import { GraphComponent } from './graph/graph.component';
import { LiveDataComponent } from './live-data/live-data.component';
import { NewMeasureComponent } from './new-measure/new-measure.component';
import { ListMeasuresComponent } from './list-measures/list-measures.component';
import { CurrentMeasureComponent } from './current-measure/current-measure.component';
import { Routes } from '@angular/router';
import { BeerDetailsComponent } from './beer-details/beer-details.component';
import { BrewCalculatorsComponent } from './brew-calculators/brew-calculators.component';
//import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';

//TODO replace with server sided configuration
export const MQTT_SERVICE_OPTIONS: IMqttServiceOptions =
{
  hostname: 'localhost',//environment.mqttBroker.hostname,
  port: 1883,//environment.mqttBroker.port,
  username: 'ispindel',//environment.mqttBroker.username,
  password: 'ispindel123',//environment.mqttBroker.password,
  clientId: 'angular',//environment.mqttBroker.clientId,
  path: '/test',//environment.mqttBroker.path,
};

@NgModule({
  declarations: [
    AppComponent,
    GraphComponent,
    LiveDataComponent,
    NewMeasureComponent,
    ListMeasuresComponent,
    CurrentMeasureComponent,
    BeerDetailsComponent,
    BrewCalculatorsComponent,
  ],
  imports: [
    //BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ApiAuthorizationModule,
    //custom modules start here
    CustomMaterialModule,
    AppRoutingModule,
    //RouterModule.forRoot(routes),
    MqttModule.forRoot(MQTT_SERVICE_OPTIONS),
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }