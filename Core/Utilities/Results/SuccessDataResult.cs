namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : Result, IDataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(true, message)
        {
            Data = data;
        }

        public SuccessDataResult(T data) : base(true)
        {
            Data = data;
        }

        public T Data { get; }
    }
}