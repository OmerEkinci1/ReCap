using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // this koyarak birinc,l constructor oluşturuyoruz. İçine koyduğumuz parametreyle
        // ikincil constructor ı çağırma imkanımız oluyor.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
