namespace Clinic.Contracts.Models
{
    public class Result
    {
        public string Message { get; set; }
        //public string ErrorMessage { get; set; }
        public int RecordInserted { get; set; }

        public string ErrorMessage { get; set; }
    }
}
