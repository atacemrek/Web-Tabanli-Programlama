﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MorningCoffee.Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data,false,message)
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
    }
}
