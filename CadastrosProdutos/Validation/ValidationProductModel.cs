using CadastrosProdutos.Models;
using FluentValidation;

namespace CadastrosProdutos.Validation
{
    public class ValidationProductModel : AbstractValidator<ProductModel>
    {
        public ValidationProductModel()
        {
            RuleFor(p => p.CreatedAt).NotEmpty().NotNull().WithMessage("O campo CreatedAt não pode ser nulo ou vazio");
            RuleFor(p => p.Name).NotEmpty().NotNull().WithMessage("O campo Name não pode ser nulo ou vazio");
            RuleFor(p => p.Name).MinimumLength(3).MaximumLength(30).WithMessage("O campo Name deve conter de 3 a 30 caracteres");
            RuleFor(p => p.Price).NotEmpty().NotNull().WithMessage("O campo Price não pode ser nulo ou vazio");
            RuleFor(p => p).Must(v => v.Price > 0).WithMessage("O campo Price não pode ser zero");
            RuleFor(p => p.Brand).NotEmpty().NotNull().WithMessage("O campo Brand não pode ser nulo ou vazio");
            RuleFor(p => p.Brand).MinimumLength(3).MaximumLength(30).WithMessage("O campo Brand deve conter de 3 a 30 caracteres");
            RuleFor(p => p.UpdateAt).NotEmpty().NotNull().WithMessage("O campo UpdateAt não pode ser nulo ou vazio");
        }
    }
}
