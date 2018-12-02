import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators'

@Injectable()
export class DataService {
  private readonly launchesUrl = "/api/launch";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getNextFiveLaunches() {
    return this.http.get(`${this.baseUrl + this.launchesUrl}/getlaunches`)
      .pipe(map((result : LaunchList) => result));
  }

  getFiveRockets() {
    return this.http.get(`${this.baseUrl + this.launchesUrl}/getrockets`)
      .pipe(map((result: RocketList) => result));
  }
}
