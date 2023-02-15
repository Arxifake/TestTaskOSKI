import { AnswerDTO } from './AnswerDTO';

export class QuestionDTO{
  constructor(
    public id?: number,
    public title?: string,
    public description?: string,
    public questionNumber?: number,
    public answers?: AnswerDTO[]
  ) { }
}
