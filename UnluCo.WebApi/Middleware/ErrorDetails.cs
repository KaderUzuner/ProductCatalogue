﻿using FluentValidation.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.WebApi.Middleware
{
    public class ErrorDetails
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class ValidationErrorDetails : ErrorDetails
    {
        public IEnumerable<ValidationFailure> Errors { get; set; }
    }
}
