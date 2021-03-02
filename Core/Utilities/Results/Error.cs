﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Error: Result
    {
        public Error(string message) : base(false, message)
        {

        }

        public Error() : base(false)
        {

        }
    }
}
