import { Routes } from '@angular/router';
import { TicketList } from './components/ticket-list/ticket-list';

export const routes: Routes = [
  { path: 'tickets', component: TicketList },
  { path: '', redirectTo: '/tickets', pathMatch: 'full' }
];
