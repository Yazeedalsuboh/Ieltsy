import { Component, inject, NgModule, OnInit, signal } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { interval, map, Observable, Subscription } from 'rxjs';
import { TestService } from '../../shared/services/test.service';
import { AsyncPipe, CommonModule, NgClass, NgStyle } from '@angular/common';
import {
  FormBuilder,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';

@Component({
  selector: 'app-test',
  imports: [AsyncPipe, ReactiveFormsModule, CommonModule, NgClass],
  templateUrl: './test.component.html',
  styleUrl: './test.component.css',
})
export class TestComponent implements OnInit {
  id!: string | null;
  test$!: Observable<any>;
  answerForm: FormGroup;
  minutes: number = 0;
  seconds: number = 0;
  isTimeExceeded: boolean = false;
  private timerSubscription: Subscription | undefined;
  wordCount: number = 0;

  countWords() {
    let text = this.answerForm.get('userAnswer')?.value;
    const words = text.trim().split(/\s+/);
    this.wordCount = text.trim() === '' ? 0 : words.length;
  }

  private _activatedRoute = inject(ActivatedRoute);
  private _testService = inject(TestService);

  constructor(private _fb: FormBuilder) {
    this.answerForm = this._fb.group({
      total: [''],
      enhancedAnswer: [''],
      userAnswer: ['', Validators.required],
    });
  }

  ngOnInit(): void {
    this.timerSubscription = interval(1000).subscribe(() => {
      this.seconds++;
      if (this.seconds === 60) {
        this.minutes++;
        this.seconds = 0;
      }
      if (this.minutes >= 20) {
        this.isTimeExceeded = true;
      }
    });

    this.id = this._activatedRoute.snapshot.paramMap.get('id');
    this.getTest();
  }

  ngOnDestroy() {
    if (this.timerSubscription) {
      this.timerSubscription.unsubscribe();
    }
  }

  getTest() {
    this.test$ = this._testService.getTest(this.id || '0');
  }

  async onSubmit(question: string): Promise<void> {
    const useranswer = this.answerForm.get('userAnswer')?.value;

    try {
      const AiResponse = await this._testService.aiAnswer(question, useranswer);
      this.answerForm.patchValue({
        total: AiResponse.total,
        enhancedAnswer: AiResponse.enhancedAnswer,
      });
    } catch (error) {
      console.error('Failed to get AI answer:', error);
    }

    if (this.answerForm.valid && this.id) {
      this._testService.submitAnswer(this.id, this.answerForm.value).subscribe({
        next: (response) => {
          this.answerForm.reset();
          this.getTest();
        },
        error: (error) => {
          console.error('Error:', error);
        },
      });
    }
  }
}
