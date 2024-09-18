using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Common.ErrorOr;

public readonly record struct ErrorOr<TValue>
{
    private readonly TValue? _value { get; }
    private readonly List<Error>? _errors { get; }
    public bool IsError => _errors.Any();
    public TValue Value
    {
        get
        {
            if (IsError)
                throw new InvalidOperationException();
            return _value;
        }
    }
    private ErrorOr(TValue value)
    {
        _value = value;
    }
    private ErrorOr(Error error)
    {
        _errors = [error];
    }
    public static implicit operator ErrorOr<TValue>(TValue value) => new ErrorOr<TValue>(value);
    public static implicit operator ErrorOr<TValue>(Error value) => new ErrorOr<TValue>(value);
}
