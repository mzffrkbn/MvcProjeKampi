using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karekter giriniz");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("en fazla 20 katekter giriniz.");

            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");  

        }
    }
}
