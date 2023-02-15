import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { TestDTO } from '../DTO/TestDTO';
import { HomeDataService } from './homedataservice';

@Component({
  selector: 'app-home',
  templateUrl: 'home.component.html',
  providers: [HomeDataService]
})
export class HomeComponent implements OnInit {
  tests: TestDTO[] = [];
  userId: any;
  constructor(private route: ActivatedRoute,
    private router: Router, private testDataService: HomeDataService) { }

  ngOnInit() {
    this.userId = sessionStorage.getItem('userId');
    this.getTests();
  }
  getTests() {
    console.log(this.userId);
    this.testDataService.GetTests(this.userId).subscribe((data: TestDTO[]) => console.log(this.tests = data))
  }
}
