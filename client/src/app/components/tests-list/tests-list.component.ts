import { Component, inject, Input } from '@angular/core';
import { Observable } from 'rxjs';
import { TestService } from '../../shared/services/test.service';
import { Router, RouterLink } from '@angular/router';
import { AsyncPipe, CommonModule } from '@angular/common';

@Component({
  selector: 'app-tests-list',
  imports: [AsyncPipe, RouterLink, CommonModule],

  templateUrl: './tests-list.component.html',
  styleUrl: './tests-list.component.css',
})
export class TestsListComponent {
  @Input({ required: true }) taskType!: string;
  tests$!: Observable<any[]>;

  private _testService = inject(TestService);
  private _router = inject(Router);

  ngOnInit() {
    this.tests$ = this._testService.getTests(this.taskType);
  }

  handleTestAction(id: string, solved: boolean) {
    if (solved) {
      this._testService.retakeTest(id).subscribe({
        next: (response) => {
          this._router.navigate(['/test', id]);
        },
        error: (err) => {
          console.error('Submission failed:', err);
        },
      });
    } else {
      this._router.navigate(['/test', id]);
    }
  }
}
