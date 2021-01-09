using System;
using mycocktails.library.common.Models;

namespace mycocktails.library.common.Logics
{
    public class LogicCommonMethods
    {
        /// <summary>
        /// エラーレスポンス生成処理
        /// </summary>
        /// <typeparam name="T">ロガークラスのジェネリック型</typeparam>
        /// <param name="logger">ロガー</param>
        /// <param name="ex">発生した例外</param>
        /// <returns>エラーレスポンス</returns>
        public static ErrorResponse<CommonFailureModel> GenerateErrorResponse<T>(ILogger<T> logger, Exception ex)
        {
            CommonFailureModel error;
            string errMsg = (ex.InnerException == null) ?
                $" : {ex.Message}" :
                $" : {ex.Message} {Environment.NewLine} {ex.InnerException.Message}";

            if (DBErrorNamespaceList.Contains(ex.GetType().Namespace))
            {
                error = new CommonFailureModel
                {
                    Reason = CommonFailureModel.ReasonEnum.DBERROREnum,
                    Msg = "DBエラー" + errMsg,
                };
            }
            else
            {
                error = new CommonFailureModel
                {
                    Reason = CommonFailureModel.ReasonEnum.SYSTEMERROREnum,
                    Msg = "システムエラー" + errMsg,
                };
            }

            logger.LogError($"{error.Reason} : {error.Msg} / detail : {ex.Message} / stacktrace : {ex.StackTrace}");
            return new ErrorResponse<CommonFailureModel>(HttpStatusCode.InternalServerError, error, ex.InnerException?.Message ?? ex.Message);
        }
    }
}
