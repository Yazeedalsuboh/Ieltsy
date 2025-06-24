import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { catchError, map, Observable, of } from 'rxjs';
import { environment } from '../../../environments/environment.development';
import { CohereClientV2 } from 'cohere-ai';
import { Router } from '@angular/router';
import { task1prompt } from '../../utils/prompts';

@Injectable({
  providedIn: 'root',
})
export class TestService {
  private _http = inject(HttpClient);
  private _baseUrl = environment.serverUrl;
  private readonly _aiAPIKey: string = environment.AiAPIKey;
  private _router = inject(Router);

  getTests(taskType: string): Observable<any[]> {
    return this._http.get<any[]>(`${this._baseUrl}?type=${taskType}`).pipe(
      map((res: any) => res.load),
      catchError((err: any) => {
        return of([] as any[]);
      }),
      map((tests) => {
        return tests;
      })
    );
  }

  getTest(id: string): Observable<any> {
    return this._http.get<any>(`${this._baseUrl}/${id}`).pipe(
      map((res: any) => res.load),
      catchError((err: any) => {
        this._router.navigate(['']);
        return of({});
      }),
      map((test) => {
        return test;
      })
    );
  }

  retakeTest(id: string) {
    return this._http.post<any>(`${this._baseUrl}/retake/${id}`, {});
  }

  submitAnswer(id: string, answerForm: any) {
    return this._http.post<any>(`${this._baseUrl}/${id}`, answerForm);
  }

  async aiAnswer(question: string, userAnswer: string): Promise<any> {
    try {
      const cohere = new CohereClientV2({ token: this._aiAPIKey });
      const response = await cohere.chat({
        model: 'command-a-03-2025',
        messages: [
          {
            role: 'user',
            content:
              task1prompt +
              `


              Description of the chart in the question: ${question}
              User Answer: ${userAnswer},
              `,
          },
        ],
      });

      if (response.finishReason === 'COMPLETE' && response.message.content) {
        const airesponse = response.message.content[0].text;

        const result: {
          total: string;
          enhancedAnswer: string;
        } = {
          total: '',
          enhancedAnswer: '',
        };

        const total = airesponse.match(/Final Grade:\s*(.*?)(\r?\n|$)/);
        if (total && total[1].trim()) {
          result.total = total[1].trim(); // This should now be '88%'
        }
        const enhancedMatch = airesponse.match(/Enhanced Answer:\s*([\s\S]*)/);
        if (enhancedMatch && enhancedMatch[1].trim()) {
          result.enhancedAnswer = enhancedMatch[1].trim();
        }
        return result;
      }
      throw new Error('Invalid response from Cohere API');
    } catch (error) {
      console.error('Title enhancement failed:', error);
      throw error;
    }
  }
}
