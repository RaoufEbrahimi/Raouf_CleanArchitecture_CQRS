using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Application.Admin.Behaviors;

public sealed class ValidationBehavior<TRequest, TResponse>(IEnumerable<IValidator<TRequest>> validators) : IPipelineBehavior<TRequest, TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators = validators;
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        //pre --> validation

        var context = new ValidationContext<TRequest>(request);
        var failedValidations =await Task.WhenAll(_validators.Select(x => x.ValidateAsync(context)));

        var errors = failedValidations
            .Where(validationResult => !validationResult.IsValid)
            .SelectMany(validationResult => validationResult.Errors)
            // .Select(error => new validationerrors)
            .ToList();

        var response = await next();

        //post

        return response;
    }
}
