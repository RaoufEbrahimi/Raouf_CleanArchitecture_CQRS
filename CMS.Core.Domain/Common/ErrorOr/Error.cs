using CMS.Core.Domain.Enums;

namespace CMS.Core.Domain.Common.ErrorOr;

public readonly record struct Error
{
    private Error(string code, string description, int codeNumeric, ErrorType type)
    {
        Code = code;
        Description = description;
        Type = type;
        CodeNumeric = codeNumeric;
    }
    public string Code { get; }
    public string Description { get; }
    public ErrorType Type { get; }
    public int CodeNumeric { get; }

    public static Error Failure(int codeNumeric, string code = "Failure", string description = "Operation Failed") => new(code, description, codeNumeric, ErrorType.Failure);

    public static Error Unexpected(int codeNumeric, string code = "Unexpected", string description = "Unexpected error ocured") => new(code, description, codeNumeric, ErrorType.Unexpected);

    public static Error Validation(int codeNumeric, string code = "Validation", string description = "Validation Failed") => new(code, description, codeNumeric, ErrorType.Validation);

    public static Error Conflict(int codeNumeric, string code = "Conflict", string description = "Operation Conflicted!") => new(code, description, codeNumeric, ErrorType.Conflict);

    public static Error NotFound(int codeNumeric, string code = "NotFound", string description = "The item Not Found!") => new(code, description, codeNumeric, ErrorType.NotFound);

    public static Error Unautorized(int codeNumeric, string code = "Unautorized", string description = "You are not autorized") => new(code, description, codeNumeric, ErrorType.Unautorized);

    public static Error Frobidden(int codeNumeric, string code = "Frobidden", string description = "This Operation is Frobidden for you") => new(code, description, codeNumeric, ErrorType.Frobidden);
}

