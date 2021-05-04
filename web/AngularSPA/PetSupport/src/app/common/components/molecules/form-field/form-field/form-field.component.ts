import {
  AfterViewInit,
  ChangeDetectionStrategy,
  Component,
  ContentChild,
  ElementRef, Renderer2,
  ViewEncapsulation,
} from '@angular/core';
import {InputDirective} from '../input/input.directive';
import {LabelDirective} from '../label/label.directive';
import {FormControl, FormControlDirective, FormControlName, NgModel} from '@angular/forms';
import {partition} from 'rxjs';

@Component({
  selector: 'app-form-field',
  templateUrl: './form-field.component.html',
  styleUrls: ['./form-field.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
  encapsulation: ViewEncapsulation.None,
})
export class FormFieldComponent implements AfterViewInit {
  @ContentChild(InputDirective, {read: ElementRef})
  private input: ElementRef<HTMLInputElement | HTMLTextAreaElement>;
  @ContentChild(LabelDirective, {read: ElementRef})
  public label?: ElementRef<HTMLLabelElement>;
  @ContentChild(NgModel, {static: true})
  public templateInputModel: NgModel;
  @ContentChild(FormControlName)
  reactiveInputModel: FormControlDirective;

  public get inputEl(): HTMLInputElement | HTMLTextAreaElement {
    return this.input.nativeElement;
  }

  public get labelEl(): HTMLLabelElement {
    return this.label.nativeElement;
  }

  public get control(): FormControl {
    let control;
    if (this.reactiveInputModel) {
      control = this.reactiveInputModel.control;
    }
    if (this.templateInputModel) {
      control = this.templateInputModel.control;
    }
    return control;
  }

  constructor(private renderer: Renderer2) {
  }

  public ngAfterViewInit(): void {
    this.setNoValueInputLogic();
    this.setFocusBehaviour();
    this.setCss();
    this.setPlaceholder();
    this.setValidationCss();
  }

  public setCss(): void {
    this.renderer.addClass(this.inputEl, 'app-input-primary');
    this.renderer.addClass(this.labelEl, 'app-label-primary');
  }

  public setPlaceholder(): void {
    const hasPlaceholder = this.input.nativeElement.placeholder !== '';
    if (hasPlaceholder) {
      return;
    }
    this.renderer.setProperty(this.inputEl, 'placeholder', this.labelEl.innerText);
  }

  public setFocusBehaviour(): void {
    this.inputEl.onfocus = event => {
      this.renderer.addClass(this.labelEl, 'focused');
    };
    this.inputEl.onblur = event => {
      this.renderer.removeClass(this.labelEl, 'focused');
    };
  }

  public setNoValueInputLogic(): void {
    const [empty$, notEmpty$] = partition(this.control.valueChanges, (v) => !v);
    notEmpty$.subscribe(() => this.renderer.addClass(this.labelEl, 'small-label'));
    empty$.subscribe(() => this.renderer.removeClass(this.labelEl, 'small-label'));
  }

  public setValidationCss(): void {
    this.control.valueChanges.subscribe(() => {
      if (!this.control.pristine && this.control.invalid) {
        this.renderer.addClass(this.inputEl, 'error');
        this.renderer.addClass(this.labelEl, 'error');
      } else {
        this.renderer.removeClass(this.inputEl, 'error');
        this.renderer.removeClass(this.labelEl, 'error');
      }
    });
  }

}
