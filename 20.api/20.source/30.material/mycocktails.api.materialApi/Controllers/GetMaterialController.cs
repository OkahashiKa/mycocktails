/*
 * Materials API
 *
 * API to manage material info.
 *
 * The version of the OpenAPI document: 0.1.1
 * Contact: okarians.302.dev@gmail.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using mycocktails.api.materialApi.Attributes;
using mycocktails.library.materialApi.Models;
using mycocktails.api.materialApi.Logics.interfaces;
using mycocktails.library.materialApi.Controllers;
using Microsoft.Extensions.Logging;
using mycocktails.library.common.Models;
using CommonMessageModel = mycocktails.library.common.Models.CommonMessageModel;
using System.Net;

namespace mycocktails.api.materialApi.Controllers
{
    /// <summary>
    /// Get material api controller.
    /// </summary>
    [ApiController]
    public class GetMaterialController : GetMaterialsApiController
    {
        private readonly IGetMaterialLogic logic;
        private readonly ILogger<GetMaterialController> logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logic">logic</param>
        /// <param name="logger">logger</param>
        public GetMaterialController(
            IGetMaterialLogic logic,
            ILogger<GetMaterialController> logger)
        {
            this.logic = logic;
            this.logger = logger;
        }

        #region Get material.

        /// <summary>
        /// Get material info by id.
        /// </summary>
        /// <param name="id">Material id.</param>
        /// <response code="200">Get material info response.</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="409">Conflict</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("/api/v1/materials/{id}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(MaterialDetailModel))]
        [ProducesResponseType(statusCode: 400, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 401, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 409, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 500, type: typeof(CommonMessageModel))]
        public override IActionResult IdGet([FromRoute][Required] int id)
        {
            ApiResponse result;

            try
            {
                result = logic.GetMaterial(id);
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
                ApiResponse<MaterialDetailModel> successResponse = (ApiResponse<MaterialDetailModel>)result;
                return StatusCode((int)successResponse.StatusCode, successResponse.ResponseModel);
            }
            else
            {
                ApiResponse<CommonMessageModel> failureResponse = (ApiResponse<CommonMessageModel>)result;
                return StatusCode((int)failureResponse.StatusCode, failureResponse.ResponseModel);
            }
        }

        #endregion

        #region Get material list.

        /// <summary>
        /// Get material info list.
        /// </summary>
        /// <response code="200">Get material info list response.</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="409">Conflict</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("/api/v1/materials")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<MaterialModel>))]
        [ProducesResponseType(statusCode: 400, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 401, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 409, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 500, type: typeof(CommonMessageModel))]
        public override IActionResult RootGet()
        {
            ApiResponse result;

            try
            {
                result = logic.GetMaterialList();
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
                ApiResponse<List<MaterialModel>> successResponse = (ApiResponse<List<MaterialModel>>)result;
                return StatusCode((int)successResponse.StatusCode, successResponse.ResponseModel);
            }
            else
            {
                ApiResponse<CommonMessageModel> failureResponse = (ApiResponse<CommonMessageModel>)result;
                return StatusCode((int)failureResponse.StatusCode, failureResponse.ResponseModel);
            }
        }

        #endregion

        #region Get user material.

        /// <summary>
        /// Get user mterial info by user id.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <response code="200">Get user material info list response.</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="409">Conflict</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [Route("/api/v1/materials/user_material/{userId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<MaterialModel>))]
        [ProducesResponseType(statusCode: 400, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 401, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 409, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 500, type: typeof(CommonMessageModel))]
        public override IActionResult UserMaterialUserIdGet([FromRoute (Name = "userId")][Required]string userId)
        { 
            ApiResponse result;

            try
            {
                result = logic.GetUserMaterialList(userId);
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
                ApiResponse<List<MaterialModel>> successResponse = (ApiResponse<List<MaterialModel>>)result;
                return StatusCode((int)successResponse.StatusCode, successResponse.ResponseModel);
            }
            else
            {
                ApiResponse<CommonMessageModel> failureResponse = (ApiResponse<CommonMessageModel>)result;
                return StatusCode((int)failureResponse.StatusCode, failureResponse.ResponseModel);
            }
        }

        #endregion
    }
}
