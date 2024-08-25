﻿namespace QMS_API.Application.Core
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T Value { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
        public Pagination Pagination { get; set; }

        public static Result<T> Success(T value,string message="") => new Result<T> { IsSuccess = true, Value = value,Message=message };
        public static Result<T> Failure(string error) => new Result<T> { IsSuccess = false, Error = error };

    }
}
