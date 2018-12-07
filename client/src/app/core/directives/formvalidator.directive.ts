import {Directive, forwardRef, Input} from '@angular/core';
import {Validator, AbstractControl, NG_VALIDATORS} from '@angular/forms';

@Directive({
  selector: '[formValidator][formControlName],[formValidator][formControl],[formValidator][ngModel]',
  providers: [
    {provide: NG_VALIDATORS, useExisting: forwardRef(() => FormvalidatorDirective), multi: true}
  ]
})
export class FormvalidatorDirective implements Validator {
  @Input() requiredCondition: boolean;

  constructor() {
  }

  validate(control: AbstractControl): any {
    const value = control.value;

    if (this.requiredCondition) {
      if (value === '' || value === undefined || value == null) {
        return {requiredCondition: true};
      }
    }

    return null;
  }

}
