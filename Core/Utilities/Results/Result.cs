﻿using System;
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
            message = Message;
        }

        public Result(bool success)
        {
            success = Success;
        }

        public bool Success => throw new NotImplementedException();

        public string Message => throw new NotImplementedException();
    }
}
