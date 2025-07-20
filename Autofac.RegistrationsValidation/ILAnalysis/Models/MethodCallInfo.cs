using System.Reflection;

namespace Aleksbtz.Autofac.RegistrationsValidation.ILAnalysis.Models;

internal record MethodCallInfo(MethodBase MethodBase, object? Target);