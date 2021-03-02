using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Success: Result
    {
        public Success(string message):base(true,message)
        {

        }

        public Success() : base(true)
        {

        }
    }
}
