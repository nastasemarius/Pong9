using System;
using System.Collections.Generic;
using System.Text;

namespace Pong9.Services.Helpers
{
    public class ApiResult<T>
    {
        public T Value { get; set; }

        public bool IsSuccess { get; set; }

        public ApiResult(T value, bool isSuccess)
        {
            Value = value;
            IsSuccess = isSuccess;
        }

    }
}
