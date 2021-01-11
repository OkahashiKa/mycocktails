using System;
using System.Net;
using mycocktails.library.common.Models;

namespace mycocktails.library.common.Logics
{
    public class LogicCommonMethods
    {
        /// <summary>
        /// Common error response creation class with exception.
        /// </summary>
        /// <param name="ex">exception</param>
        /// <returns>error response</returns>
        public static ErrorResponse<CommonMessageModel> GenerateErrorResponse(Exception ex)
        {
            CommonMessageModel error;
            string errMsg = (ex.InnerException == null) ?
                $" : {ex.Message}" :
                $" : {ex.Message} {Environment.NewLine} {ex.InnerException.Message}";

            error = new CommonMessageModel
            {
                Msg = $"{errMsg}"
            };

            return new ErrorResponse<CommonMessageModel>(HttpStatusCode.InternalServerError, error, ex.InnerException?.Message ?? ex.Message);
        }

        /// <summary>
        /// Common error response creation class.
        /// </summary>
        /// <param name="statusCode">response status code</param>
        /// <param name="msg">error message</param>
        /// <returns>error response</returns>
        public static ErrorResponse<CommonMessageModel> GenerateErrorResponse(HttpStatusCode statusCode, string msg)
        {
            CommonMessageModel error = new CommonMessageModel
            {
                Msg = msg
            };

            return new ErrorResponse<CommonMessageModel>(statusCode, error);
        }
    }
}
