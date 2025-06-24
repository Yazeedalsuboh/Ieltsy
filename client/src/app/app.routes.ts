import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { TestComponent } from './pages/test/test.component';
import { Task1Component } from './pages/task1/task1.component';
import { Task2Component } from './pages/task2/task2.component';

export const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    pathMatch: 'full',
  },
  {
    path: 'task1',
    component: Task1Component,
    pathMatch: 'full',
  },
  {
    path: 'task2',
    component: Task2Component,
    pathMatch: 'full',
  },
  {
    path: 'test/:id',
    component: TestComponent,
    pathMatch: 'full',
  },
];
