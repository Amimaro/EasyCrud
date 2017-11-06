import { Component, OnInit } from '@angular/core';
import { ProgrammerService } from '../../services/programmer.service';
import { Router } from '@angular/router';

import { Programmer } from '../../models/programmer';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  programmer: Programmer = new Programmer();
  programmers: Programmer[];

  constructor(private programmerService: ProgrammerService,
    private router: Router) { }

  ngOnInit() {
    this.programmerService
      .getProgrammers()
      .then(p => { this.programmers = p; console.log(this.programmers) });
  }

  calcMeanPoints(knoledge): string {
    var sumValues = Object.entries(knoledge).slice(1, 26).reduce(function(sum, value) {
      sum[1] = parseInt(sum[1]) + parseInt(value[1]) + '';
      return sum;
    });
    var mean = parseInt(sumValues[1]) / 25.0;
    var stars = "";
    for (var i = 0; i < 5; i++) {
      if (mean <= i)
        stars += '<i class="fa fa-star-o" aria-hidden="true"></i> ';
      else
        stars += '<i class="fa fa-star" aria-hidden="true"></i> ';
    }
    return stars;
  }

  go2Form(): void {
    this.programmerService.setCurrentProgrammer(this.programmer);
    this.router.navigate(['/programmer/form1']);
  }

  edit(id: number): void {
      this.programmerService.editProgrammer(id);
  }

  remove(id: number): void {
    this.programmerService.deleteProgrammer(id);
  }

}
