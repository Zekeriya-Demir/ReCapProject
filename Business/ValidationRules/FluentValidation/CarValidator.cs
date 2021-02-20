using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    // Doğrulama kuralları.
    public class CarValidator : AbstractValidator<Car>
    {
        // kira ücreti, marka id, renk id boş geçilemez.
        // kira ücreti 0'dan büyük olmalı.
        // marka id 1 olan aracın kiralama ücreti minumum 10 olmalı.
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.ModelYear).Equal(2005);
            RuleFor(c => c.DailyPrice).GreaterThan(500);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(30).When(c => c.BrandId == 1);            
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
        }
    }
}
