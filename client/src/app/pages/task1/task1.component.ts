import { Component } from '@angular/core';
import { TestsListComponent } from '../../components/tests-list/tests-list.component';

@Component({
  selector: 'app-task1',
  imports: [TestsListComponent],
  templateUrl: './task1.component.html',
  styleUrl: './task1.component.css',
})
export class Task1Component {}
