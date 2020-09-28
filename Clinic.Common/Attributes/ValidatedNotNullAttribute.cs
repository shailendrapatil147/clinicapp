using System;

namespace Clinic.Common.Attributes
{
    // Used to indicate to code analysis that a method checks the specified parameter for null references
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = true)]
    public sealed class ValidatedNotNullAttribute : Attribute
    {
    }
}
