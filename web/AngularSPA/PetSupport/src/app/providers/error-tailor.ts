import {ErrorTailorModule} from '@ngneat/error-tailor';
import {NgModule} from '@angular/core';
import {ReactiveFormsModule} from '@angular/forms';

@NgModule({
  declarations: [],
  imports: [
    ReactiveFormsModule,
    ErrorTailorModule.forRoot({
      errors: {
        useValue: {
          required: 'This field is required',
          minlength: ({requiredLength, actualLength}) =>
            `Expect minimum ${requiredLength} chars, but got ${actualLength} chars`,
          maxlength: ({requiredLength, actualLength}) =>
            `Expect maximum ${requiredLength} chars, but got ${actualLength} chars`,
          email: `Provided value is not valid email`,
        }
      }
    })
  ],
})
export class CustomErrorTailorModule {
}
