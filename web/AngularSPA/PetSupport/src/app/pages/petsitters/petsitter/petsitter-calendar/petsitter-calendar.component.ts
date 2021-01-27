import { Component, OnInit } from '@angular/core';
import { CalendarOptions } from '@fullcalendar/angular'; // useful for typechecking

@Component({
  selector: 'app-petsitter-calendar',
  templateUrl: './petsitter-calendar.component.html',
  styleUrls: ['./petsitter-calendar.component.css']
})
export class PetsitterCalendarComponent implements OnInit {

  calendarOptions: CalendarOptions = {
    initialView: 'dayGridMonth'
  };
  constructor() { }

  ngOnInit(): void {
  }

}
