using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Pong9.Services.Helpers
{
    public class ApiResult<T>
    {
        public T Value { get; set; }

        public bool IsSuccess { get; set; }

        public ApiResult(T value)
        {
            Value = value;
            IsSuccess = true;
        }

        public ApiResult(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
    }
}
