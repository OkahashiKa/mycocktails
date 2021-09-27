using System.Net;
using Newtonsoft.Json;

namespace mycocktails.library.common.Models
{
    /// <summary>
    /// 　This Class is used when passing data between Controller / Logic.
    /// 　Stores Success, StatusCode, Exception, ResponseModel<T>.
    /// </summary>
    public class ApiResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse"/> class.
        /// </summary>
        /// <param name="success">API success or failure.</param>
        /// <param name="statusCode">API response status code.</param>
        /// <param name="exception">exception.</param>
        public ApiResponse(bool success, HttpStatusCode statusCode, string exception = "")
        {
            this.Success = success;
            this.StatusCode = statusCode;
            this.Exception = exception;
        }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "statusCode")]
        public HttpStatusCode StatusCode { get; set; }

        [JsonProperty(PropertyName = "exception")]
        public string Exception { get; set; }
    }

    public class ApiResponse<T> : ApiResponse
    {
        public ApiResponse(bool success, HttpStatusCode statusCode, T model, string exception = "")
            : base(success, statusCode, exception)
        {
            this.ResponseModel = model;
        }

        [JsonProperty(PropertyName = "responseModel")]
        public T ResponseModel { get; set; }
    }

    public class SuccessResponse : ApiResponse
    {
        public SuccessResponse(HttpStatusCode statusCode)
            : base(true, statusCode)
        {
            this.StatusCode = statusCode;
        }
    }

    public class SuccessResponse<T> : ApiResponse<T>
    {
        public SuccessResponse(HttpStatusCode statusCode, T model)
            : base(true, statusCode, model)
        {
            this.StatusCode = statusCode;
            this.ResponseModel = model;
        }
    }

    public class ErrorResponse : ApiResponse
    {
        public ErrorResponse(HttpStatusCode statusCode, string exception = "")
            : base(false, statusCode, exception)
        {
            this.StatusCode = statusCode;
            this.Exception = exception;
        }
    }

    public class ErrorResponse<T> : ApiResponse<T>
    {
        public ErrorResponse(HttpStatusCode statusCode, T model, string exception = "")
            : base(false, statusCode, model)
        {
            this.StatusCode = statusCode;
            this.ResponseModel = model;
            this.Exception = exception;
        }
    }
}
