import { Component, OnInit } from '@angular/core';
import { ProgrammerService } from '../../services/programmer.service';
import { Router } from '@angular/router';

import { Programmer } from '../../models/programmer';
import { Knoledge } from '../../models/knoledge';

@Component({
  selector: 'app-form-knoledge',
  templateUrl: './form-knoledge.component.html',
  styleUrls: ['./form-knoledge.component.css']
})
export class FormKnoledgeComponent implements OnInit {

  // Skill text - skill name - required - checked
  skills = [
    ['Ionic', 'ionic', 1, [0, 0, 0, 0, 0, 0]],
    ['Android', 'android', 1, [0, 0, 0, 0, 0, 0]],
    ['IOS', 'ios', 1, [0, 0, 0, 0, 0, 0]],
    ['HTML', 'html', 0, [0, 0, 0, 0, 0, 0]],
    ['CSS', 'css', 0, [0, 0, 0, 0, 0, 0]],
    ['Bootstrap', 'bootstrap', 1, [0, 0, 0, 0, 0, 0]],
    ['JQuery', 'jquery', 1, [0, 0, 0, 0, 0, 0]],
    ['AngularJs', 'angular', 1, [0, 0, 0, 0, 0, 0]],
    ['Java', 'java', 1, [0, 0, 0, 0, 0, 0]],
    ['Asp.Net MVC', 'aspnet', 1, [0, 0, 0, 0, 0, 0]],
    ['C', 'c', 0, [0, 0, 0, 0, 0, 0]],
    ['C++', 'cpp', 0, [0, 0, 0, 0, 0, 0]],
    ['Cake', 'cake', 0, [0, 0, 0, 0, 0, 0]],
    ['Django', 'django', 0, [0, 0, 0, 0, 0, 0]],
    ['Majento', 'majento', 0, [0, 0, 0, 0, 0, 0]],
    ['PHP', 'php', 1, [0, 0, 0, 0, 0, 0]],
    ['Wordpress', 'wordpress', 1, [0, 0, 0, 0, 0, 0]],
    ['Python', 'python', 0, [0, 0, 0, 0, 0, 0]],
    ['Ruby', 'ruby', 0, [0, 0, 0, 0, 0, 0]],
    ['MySQL Server', 'sqls', 0, [0, 0, 0, 0, 0, 0]],
    ['MySQL', 'mysql', 0, [0, 0, 0, 0, 0, 0]],
    ['Salesforce', 'salesforce', 0, [0, 0, 0, 0, 0, 0]],
    ['Photoshop', 'photoshop', 0, [0, 0, 0, 0, 0, 0]],
    ['Illustrator', 'illustrator', 0, [0, 0, 0, 0, 0, 0]],
    ['SEO', 'seo', 0, [0, 0, 0, 0, 0, 0]]];

  programmer: Programmer = new Programmer();
  knoledge: Knoledge = new Knoledge();

  constructor(private programmerService: ProgrammerService,
    private router: Router) { }

  ngOnInit() {
    this.programmer = this.programmerService.getCurrentProgrammer();
    if (this.programmer.knoledge != null) {
      this.knoledge = this.programmer.knoledge;
      console.log(this.knoledge['ionic']);
      for (var i in this.skills) {
        this.skills[i][3][this.knoledge[this.skills[i][1] + '']] = 1;
      }
    }
    console.log(this.programmer);
  }

  back() {
    for (var i in this.skills) {
      this.knoledge[("" + this.skills[i][1])] = Object.values(this.skills[i][3]).findIndex(k => k == 1);
    }
    this.programmer.knoledge = this.knoledge;
    this.programmerService.setCurrentProgrammer(this.programmer);
    this.router.navigate(['/programmer/form3']);
  }

  send() {
    for (var i in this.skills) {
      this.knoledge[("" + this.skills[i][1])] = Object.values(this.skills[i][3]).findIndex(k => k == 1);
    }
    this.programmer.knoledge = this.knoledge;
    this.programmerService.setCurrentProgrammer(this.programmer);
    this.programmerService.createOrUpdateProgrammer();
  }

  onSelectionChange(option, skill) {
    for (var i in this.skills) {
      if (this.skills[i][1] === skill[1]) {
        skill[3] = [0, 0, 0, 0, 0, 0]; // Reset options
        skill[3][option] = 1; // Set selected option
        this.skills[i][3] = skill[3];
      }
    }
  }

}
