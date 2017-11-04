import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { Programmer } from '../models/programmer';

@Injectable()
export class ProgrammerService {

  private headers = new Headers({
    'Content-Type': 'application/json',
    // 'Content-Type': 'text/plain',
    'Access-Control-Allow-Origin': '*'
  });
  private apiUrl = 'http://localhost:5000/api/programmer';  // URL to web api

  PROGRAMMER: Programmer;
  PROGRAMMERS: Programmer[] = [
  ];

  constructor(private http: Http) { }

  getProgrammers(): Promise<Programmer[]> {
    return this.http.get(this.apiUrl, { headers: this.headers })
      .toPromise()
      .then(response => response.json() as Programmer[])
      .catch(this.handleError);
  }

  getProgrammer(id: number): Promise<Programmer> {
    return this.getProgrammers()
      .then(progs => progs.find(prog => prog.id === id));
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
  }

}
