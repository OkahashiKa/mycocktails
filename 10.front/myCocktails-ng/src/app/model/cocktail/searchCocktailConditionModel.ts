/**
 * Cocktails API
 * API to manage cocktail info.
 *
 * The version of the OpenAPI document: 0.2.8
 * Contact: okarians.302.dev@gmail.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


/**
 * Search cocktail info condition model.
 */
export interface SearchCocktailConditionModel { 
    searchString?: string;
    /**
     * Material id list.
     */
    materialIdList?: Array<number>;
    /**
     * cocktail search type. (AND, OR)
     */
    materialSearchType?: string;
}

