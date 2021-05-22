/*
 * Cocktails API
 *
 * API to manage cocktail info.
 *
 * The version of the OpenAPI document: 0.1.4
 * Contact: okarians.302.dev@gmail.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using mycocktails.api.cocktailApi.Attributes;
using mycocktails.api.cocktailApi.Models;
using mycocktails.library.cocktailApi.Controllers;
using mycocktails.library.common.Models;
using mycocktails.library.cocktailApi.Models;
using CommonMessageModel = mycocktails.library.common.Models.CommonMessageModel;

namespace mycocktails.api.cocktailApi.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class UpdateCocktailController : UpdateCocktailsApiController
    { 
        /// <summary>
        /// Update maltiple cocktail info.
        /// </summary>
        /// <param name="cocktailModel">Delete cocktail info request body.</param>
        /// <response code="201">Create cocktail info response.</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="409">Conflict</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("/api/v1/cocktails/bulk_update")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 201, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 400, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 401, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 409, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 500, type: typeof(CommonMessageModel))]
        public override IActionResult CocktailsBulkUpdatePost([FromBody]List<CocktailModel> cocktailModel)
        { 

            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(CommonMessageModel));
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(CommonMessageModel));
            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(CommonMessageModel));
            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409, default(CommonMessageModel));
            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(CommonMessageModel));
            string exampleJson = null;
            exampleJson = "{\n  \"msg\" : \"msg\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CommonMessageModel>(exampleJson)
            : default(CommonMessageModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update cocktail info by id.
        /// </summary>
        /// <param name="id">Cocktail id.</param>
        /// <param name="cocktailDetailModel">Update cocktail info request body.</param>
        /// <response code="201">Update cocktail info response.</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="409">Conflict</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPut]
        [Route("/api/v1/cocktails/{id}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 201, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 400, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 401, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 409, type: typeof(CommonMessageModel))]
        [ProducesResponseType(statusCode: 500, type: typeof(CommonMessageModel))]
        public override IActionResult CocktailsIdPut([FromRoute][Required]int id, [FromBody]CocktailDetailModel cocktailDetailModel)
        { 

            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(CommonMessageModel));
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(CommonMessageModel));
            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(CommonMessageModel));
            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409, default(CommonMessageModel));
            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(CommonMessageModel));
            string exampleJson = null;
            exampleJson = "{\n  \"msg\" : \"msg\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CommonMessageModel>(exampleJson)
            : default(CommonMessageModel);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
