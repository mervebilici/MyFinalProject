using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity); //PRODUCT İÇİN DOGRULAMA YAPACAZ
            //ProductValidator productValidator = new ProductValidator(); //DOGRULAMA YAPMAK İÇİN BUNU KULLANACAM
            var result = validator.Validate(context); //İLGİLİ CONTEXT İÇİN BUNU UYGULA
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors); //KURAL GEÇERLİ DEĞİLSE HATA FIRLAT
            }
        }
    }
}
