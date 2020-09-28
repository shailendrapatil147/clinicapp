using System;

namespace Clinic.Common.StaticMethods
{
    public static class ExecuteUsingTryCatch
    {
        public static Result UserTryCatchAndSkipException<Result>(Func<Result> function)
        {
            try
            {
                return function.Invoke();
            }
            catch
            {
                return default(Result);
            }
        }

        public static string UserTryCatchAndReturnErrorMessage<Result>(Func<Result> function)
        {
            string errorMessage = string.Empty;
            try
            {
                function.Invoke();
            }
            catch(Exception ex)
            {
                errorMessage = ex.Message;
            }
            return errorMessage;
        }
    }
}
