/*
 * Materials API
 *
 * API to manage material info.
 *
 * The version of the OpenAPI document: 0.2.7
 * Contact: okarians.302.dev@gmail.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using mycocktails.api.materialApi.Attributes;
using mycocktails.library.common.Models;
using mycocktails.library.materialApi.Controllers;
using mycocktails.api.materialApi.Logics.interfaces;
using Microsoft.Extensions.Logging;
using CommonMessageModel = mycocktails.library.common.Models.CommonMessageModel;
using System.Net;

namespace mycocktails.api.materialApi.Controllers
{ 
    /// <summary>
    /// Delete material api controller.
    /// </summary>
    [ApiController]
    public class DeleteMaterialController : DeleteMaterialsApiController
    {
        private readonly IDeleteMaterialLogic logic;
        private readonly ILogger<DeleteMaterialController> logger;

        /// <summary>
        /// constructoer.
        /// </summary>
        /// <param name="logic">logic</param>
        /// <param name="logger">logger</param>
        public DeleteMaterialController(
            IDeleteMaterialLogic logic,
            ILogger<DeleteMaterialController> logger)
        {
            this.logic = logic;
            this.logger = logger;
        }

        /// <summary>
        /// Delete user material info.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <param name="materialId">Material id.</param>
        /// <response code="201"></response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="409">Conflict</response>
        /// <response code="500">Internal Server Error</response>
        [HttpDelete]
        [Route("/api/v1/materials/user_material")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 401, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 409, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 500, type: typeof(CommonMessageModel))]
        public override IActionResult UserMaterialDelete([FromQuery (Name = "userId")][Required()]string userId, [FromQuery (Name = "materialId")][Required()]int materialId)
        {
            ApiResponse result;

            try
            {
                result = logic.DeleteUserMaterial(userId, materialId);
            }

            // catch error.
            catch (Exception ex)
            {
                CommonMessageModel error = new CommonMessageModel
                {
                    Msg = "An unknown error has occurred."
                };
                this.logger.LogError($"{error.Msg}");
                result = new ErrorResponse<CommonMessageModel>(HttpStatusCode.InternalServerError, error, ex.InnerException?.Message ?? ex.Message);
            }

            this.logger.LogInformation($"StatusCode: {result.StatusCode}");
            if (result.Success)
            {
                ApiResponse<CommonMessageModel> successResponse = (ApiResponse<CommonMessageModel>)result;
                return StatusCode((int)successResponse.StatusCode, successResponse.ResponseModel);
            }
            else
            {
                ApiResponse<CommonMessageModel> failureResponse = (ApiResponse<CommonMessageModel>)result;
                return StatusCode((int)failureResponse.StatusCode, failureResponse.ResponseModel);
            }
        }
    }
}
