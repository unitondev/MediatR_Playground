namespace Services
{
    public class ServiceResult
    {
        
    }

    public class ServiceResult<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
    }
}