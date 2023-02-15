import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { AnswerDTO } from '../DTO/AnswerDTO';
import { ResultDTO } from '../DTO/ResultDTO';
import { TestDTO } from '../DTO/TestDTO';
import { TestDataService } from './testdataservice';

@Component({
  selector: 'app-test',
  templateUrl: 'test.component.html',
  providers: [TestDataService]
})
export class TestComponent implements OnInit {
  test: TestDTO;
  answers: ResultDTO[];
  checkbox = false;
  idx: number;
  id: any;
  constructor(private route: ActivatedRoute,
    private router: Router, private testDataService: TestDataService) { }

  ngOnInit() {
    this.route.paramMap.subscribe(params => this.id = params.get('id'))
    this.idx = 0;
    this.answers = [];
    this.getTest();
    
  }
  getTest() {
    this.testDataService.GetTest(this.id).subscribe((data: TestDTO) => this.test = data)
  }
  idxPlus() {
    this.idx = this.idx + 1;
  }
  nextQ(qNumber: any, answer: any) {
    this.answers.push(new ResultDTO(qNumber,answer));
    this.idxPlus();
  }
}
