using System;
using System.Net;
using mycocktails.api.cocktailApi.Models;
using mycocktails.library.common.Models;

namespace mycocktails.library.common.Logics
{
    public class LogicCommonMethods
    {
        /// <summary>
        /// Common error response creation class.
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
    }
}
