import { Component, OnInit } from '@angular/core';
import { ProgrammerService } from '../../services/programmer.service';
import { Router } from '@angular/router';

import { Programmer } from '../../models/programmer';
import { BankInfo } from '../../models/bankinfo';

@Component({
  selector: 'app-form-bank',
  templateUrl: './form-bank.component.html',
  styleUrls: ['./form-bank.component.css']
})
export class FormBankComponent implements OnInit {

  programmer: Programmer = new Programmer();
  bankInfo: BankInfo = new BankInfo();

  constructor(private programmerService: ProgrammerService,
    private router: Router) { }

  ngOnInit() {
    this.programmer = this.programmerService.getCurrentProgrammer();
    console.log(this.programmerService.getCurrentProgrammer());
  }

  next() {
    this.programmer.bankInfo = this.bankInfo;
    this.programmerService.setCurrentProgrammer(this.programmer);
    this.router.navigate(['/programmer/form4']);
  }

  back() {
    this.programmer.bankInfo = this.bankInfo;
    this.programmerService.setCurrentProgrammer(this.programmer);
    this.router.navigate(['/programmer/form3']);
  }

}
