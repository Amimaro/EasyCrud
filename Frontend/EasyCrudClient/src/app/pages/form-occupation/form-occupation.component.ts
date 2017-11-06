import { Component, OnInit } from '@angular/core';
import { ProgrammerService } from '../../services/programmer.service';
import { Router } from '@angular/router';

import { Programmer } from '../../models/programmer';
import { Availability } from '../../models/availability';
import { BestTime } from '../../models/besttime';

@Component({
  selector: 'app-form-occupation',
  templateUrl: './form-occupation.component.html',
  styleUrls: ['./form-occupation.component.css']
})
export class FormOccupationComponent implements OnInit {

  programmer: Programmer = new Programmer();
  availability: Availability = new Availability();
  bestTime: BestTime = new BestTime();

  constructor(private programmerService: ProgrammerService,
    private router: Router) { }

  ngOnInit() {
    this.programmer = this.programmerService.getCurrentProgrammer();
    console.log(this.programmerService.getCurrentProgrammer());
  }

  next() {
    this.programmer.availability = this.availability;
    this.programmer.bestTime = this.bestTime;
    this.programmerService.setCurrentProgrammer(this.programmer);
    this.router.navigate(['/programmer/form3']);
  }

  back() {
    this.programmer.availability = this.availability;
    this.programmer.bestTime = this.bestTime;
    this.programmerService.setCurrentProgrammer(this.programmer);
    this.router.navigate(['/programmer/form1']);
  }

}
