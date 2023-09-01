namespace Repository.Class
{
    public class GeneralResponse
    {
        public GeneralResponse()
        {

        }
        public GeneralResponse(bool IsSuccess = false, string Message = "", string ErrorMessage = "")
        {
            this.IsSuccess = IsSuccess;
            this.Message = Message;
            this.ErrorMessage = ErrorMessage;
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class GeneralResponse<T>
    {
        public GeneralResponse(T obj, bool IsSuccess = false, string Message = "", string ErrorMessage = "")
        {
            this.IsSuccess = IsSuccess;
            this.Message = Message;
            this.ErrorMessage = ErrorMessage;
            this.obj = obj;
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
        public T obj { get; set; }
    }
}
