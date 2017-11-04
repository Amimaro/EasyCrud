import { Component, OnInit } from '@angular/core';
import { ProgrammerService } from '../../services/programmer.service';

import { Programmer } from '../../models/programmer';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  programmers: Programmer[];

  constructor(private programmerService: ProgrammerService) {

  }

  ngOnInit() {
      this.programmerService
        .getProgrammers()
        .then(p => {this.programmers = p; console.log(this.programmers)});
  }

}
