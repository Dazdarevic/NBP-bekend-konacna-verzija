﻿using Newtonsoft.Json;

namespace NBP.API.Errors
{
    public class ApiError
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }

        public ApiError(int statusCode, string message, string details)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
