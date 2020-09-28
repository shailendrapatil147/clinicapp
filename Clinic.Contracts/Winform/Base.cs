using Clinic.Common.StaticMethods;
using System.Collections.Generic;

namespace Clinic.Contracts.Winform
{
    public class Base
    {
        public bool IsChanged { get; set; }
        public Dictionary<string, string> Errors { get; set; } = new Dictionary<string, string>();

        public void AddRequiredError(string propertyName)
        {
            AddError(propertyName, $"{propertyName} required");
        }

        public void AddError(string propertyName, string error)
        {
            Errors.Remove(propertyName);
            Errors.Add(propertyName, error);
        }

        public string GetError(string propertyName)
        {
            return ExecuteUsingTryCatch.UserTryCatchAndSkipException(() =>
            {
                string error = string.Empty;
                Errors.TryGetValue(propertyName, out error);
                return error;
            });
        }

        public void RemoveError(string propertyName)
        {
            Errors.Remove(propertyName);
        }
    }
}
