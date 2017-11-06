import { Component, OnInit } from '@angular/core';
import { ProgrammerService } from '../../services/programmer.service';
import { Router } from '@angular/router';

import { Programmer } from '../../models/programmer';

@Component({
  selector: 'app-form-email',
  templateUrl: './form-email.component.html',
  styleUrls: ['./form-email.component.css']
})
export class FormEmailComponent implements OnInit {

  programmer: Programmer = new Programmer();

  constructor(private programmerService: ProgrammerService,
    private router: Router) { }

  ngOnInit() {
    this.programmer = this.programmerService.getCurrentProgrammer();
    console.log(this.programmer);
  }

  next() {
    this.programmerService.setCurrentProgrammer(this.programmer);
    this.router.navigate(['/programmer/form2']);
  }

}
