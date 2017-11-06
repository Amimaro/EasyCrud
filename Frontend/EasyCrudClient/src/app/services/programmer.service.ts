import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
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

  PROGRAMMER: Programmer = new Programmer();
  PROGRAMMERS: Programmer[] = [
  ];

  constructor(private router: Router, private http: Http) { }

  setCurrentProgrammer(p): void {
    this.PROGRAMMER = p;
  }

  getCurrentProgrammer(): Programmer {
    return this.PROGRAMMER;
  }

  editProgrammer(id): void {
    this.getProgrammer(id).then(p => {
      this.PROGRAMMER = p;
      this.router.navigate(['/programmer/form1'])
    });
  }

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

  createOrUpdateProgrammer(): Promise<Programmer> {
    if (this.PROGRAMMER['id'] == null) {
      try {
        if (this.PROGRAMMER.hasOwnProperty('id'))
          delete this.PROGRAMMER['id'];
        if (this.PROGRAMMER.availability && this.PROGRAMMER.availability.hasOwnProperty('id'))
          delete this.PROGRAMMER.availability['id'];
        if (this.PROGRAMMER.bankInfo && this.PROGRAMMER.bankInfo.hasOwnProperty('id'))
          delete this.PROGRAMMER.bankInfo['id'];
        if (this.PROGRAMMER.bestTime && this.PROGRAMMER.bestTime.hasOwnProperty('id'))
          delete this.PROGRAMMER.bestTime['id'];
        if (this.PROGRAMMER.knoledge && this.PROGRAMMER.knoledge.hasOwnProperty('id'))
          delete this.PROGRAMMER.knoledge['id'];
      } catch (e) {
        console.log(e);
      }
      console.log(this.PROGRAMMER);
      return this.http
        .post(this.apiUrl, this.PROGRAMMER, { headers: this.headers })
        .toPromise()
        .then(res => {
          res.json() as Programmer;
          this.router.navigate(['/programmer/home']);
        })
        .catch(this.handleError);
    } else {
        this.updateProgrammer();
    }
  }

  updateProgrammer(): Promise<Programmer> {
    console.log(this.PROGRAMMER);
    return this.http
      .put(this.apiUrl + "/" + this.PROGRAMMER.id, this.PROGRAMMER, { headers: this.headers })
      .toPromise()
      .then(res => { this.router.navigate(['/programmer/home']); })
      .catch(this.handleError);
  }

  deleteProgrammer(id) {
    this.router.navigate(['/programmer/delete']);
    return this.http
      .delete(this.apiUrl + '/' + id, { headers: this.headers })
      .toPromise()
      .then(res => { this.router.navigate(['/programmer/home']); })
      .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error);
    return Promise.reject(error.message || error);
  }

}
