namespace Aleksbtz.Autofac.RegistrationsValidation.Models.Errors;

public class DiValidationException : Exception
{
    public DiValidationException(string? message) : base(message)
    {
    }
}