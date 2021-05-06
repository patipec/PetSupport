import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {PetsitterComponent} from './petsitter/petsitter.component';
import {PetsittersListComponent} from './petsitters-list/petsitters-list.component';
import {PetsitterListTileComponent} from './petsitters-list/petsitter-list-tile/petsitter-list-tile.component';
import {PettsittersComponent} from './pettsiters.component';
import {RangeSliderComponent} from './long-form/slider/slider.component';
import {MapComponent} from './map/map.component';
import {RateComponent} from '../../common/components/molecules/rate/rate.component';
import {PetsitterServicesComponent} from './petsitter/petsitter-services/petsitter-services.component';
import {PetsitterCalendarComponent} from './petsitter/petsitter-calendar/petsitter-calendar.component';
import {PetsitterReviewsComponent} from './petsitter/petsitter-reviews/petsitter-reviews.component';
import {PetsitterCanHostComponent} from './petsitter/petsitter-can-host/petsitter-can-host.component';
import {HttpClientModule} from '@angular/common/http';
import {LongFormComponent} from './long-form/long-form.component';
import {ReactiveFormsModule} from '@angular/forms';
import {NgxSliderModule} from '@angular-slider/ngx-slider';
import {PetsittersRoutingModule} from './petsitters-routing.module';
import {FullCalendarModule} from '@fullcalendar/angular'; // the main connector. must go first
import dayGridPlugin from '@fullcalendar/daygrid'; // a plugin
import interactionPlugin from '@fullcalendar/interaction';
import {IvyCarouselModule} from 'angular-responsive-carousel';


FullCalendarModule.registerPlugins([ // register FullCalendar plugins
  dayGridPlugin,
  interactionPlugin
]);
@NgModule({
  declarations: [
    PetsitterComponent,
    PetsittersListComponent,
    PetsitterListTileComponent,
    PettsittersComponent,
    RangeSliderComponent,
    MapComponent,
    RateComponent,
    PetsitterServicesComponent,
    PetsitterCalendarComponent,
    PetsitterReviewsComponent,
    PetsitterCanHostComponent,
    LongFormComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxSliderModule,
    PetsittersRoutingModule,
    FullCalendarModule,
    IvyCarouselModule,
  ],
  exports: []
})
export class PetsittersModule {
}
