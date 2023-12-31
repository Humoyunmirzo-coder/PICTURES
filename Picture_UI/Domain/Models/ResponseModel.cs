﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ResponsModels<T>
    {
        public ResponsModels(T resilt, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            Result = resilt;
            StatusCode = statusCode;

        }
        public ResponsModels(string error, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            Error = error;
            StatusCode = statusCode;

        }
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public string Error { get; set; }
        public T Result { get; set; }
    }

}
