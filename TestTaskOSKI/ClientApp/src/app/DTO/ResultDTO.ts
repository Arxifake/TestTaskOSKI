import { AnswerDTO } from "./AnswerDTO";

export class ResultDTO {
  constructor(
    public questionNumber: number,
    public answer: AnswerDTO
  ) { }
}
