import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { NextLaunchComponent } from './next-launch/next-launch.component';
import { DataService } from './core/data.service';
import { RocketListComponent } from './rocket-list/rocket-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    NextLaunchComponent,
    RocketListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: NextLaunchComponent, pathMatch: 'full' },
      { path: 'next-launch', component: NextLaunchComponent },
      { path: 'rockets', component: RocketListComponent }
    ])
  ],
  providers: [DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
