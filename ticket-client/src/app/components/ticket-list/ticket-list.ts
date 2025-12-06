import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TicketService, Ticket } from '../../services/ticket';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-ticket-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './ticket-list.html',
  styleUrls: ['./ticket-list.css']
})
export class TicketList implements OnInit {
  tickets: Ticket[] = [];
  loading = true;
  error: string | null = null;

  constructor(private ticketService: TicketService) {}

  ngOnInit(): void {
    this.ticketService.getTickets().subscribe({
      next: data => {
        this.tickets = data;
        this.loading = false;
      },
      error: err => {
        this.error = 'Failed to load tickets';
        this.loading = false;
        console.error(err);
      }
    });
  }
}
