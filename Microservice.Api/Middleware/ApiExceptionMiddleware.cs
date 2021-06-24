using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Microservice.Api.Middleware
{
    public class ApiExceptionMiddleware
    {
        //private readonly ApiExceptionOptions _options;
        //private readonly RequestDelegate _next;
        //private readonly ILogger<ApiExceptionMiddleware> _logger;

        //public ApiExceptionMiddleware(ApiExceptionOptions options, RequestDelegate next, ILogger<ApiExceptionMiddleware> logger)
        //{
        //    _options = options;
        //    _next = next;
        //    _logger = logger;
        //}

        //public async Task Invoke(HttpContext context)
        //{
        //    try
        //    {
        //        await _next(context);
        //    }
        //    catch (Exception ex)
        //    {
        //        await HandleExceptionAsync(context, ex, _options);
        //    }
        //}

        //private Task HandleExceptionAsync(HttpContext context, Exception ex, ApiExceptionOptions options)
        //{
        //    var error = new ApiError
        //    {
        //        Id = Guid.NewGuid().ToString(),
        //        Status = (short) HttpStatusCode.InternalServerError,
        //        Title = ""
        //    }
        //}
    }
}
