namespace Aleksbtz.Autofac.RegistrationsValidation.Models;

public enum RequiredServicesSearchStatus
{
    Success,
    NoAvailableConstructors,
    NotEnoughRegistrationsToUseAnyConstructors,
    SelectConstructorError
}