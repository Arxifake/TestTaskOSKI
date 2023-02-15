import { QuestionDTO } from "./QuestionDTO";

export class TestDTO{
  constructor(
    public id?: number,
    public name?: string,
    public description?: string,
    public questions?: QuestionDTO[]
  ) { }
}
