/*
 * Material API
 *
 * API to manage material info.
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: okarians.302.dev@gmail.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using mycocktails.api.materialApi.Converters;

namespace mycocktails.api.materialApi.Models
{ 
    /// <summary>
    /// material info model.
    /// </summary>
    [DataContract]
    public partial class MaterialModel : IEquatable<MaterialModel>
    {
        /// <summary>
        /// Material id
        /// </summary>
        /// <value>Material id</value>
        [DataMember(Name="materialId", EmitDefaultValue=false)]
        public int MaterialId { get; set; }

        /// <summary>
        /// Material name.
        /// </summary>
        /// <value>Material name.</value>
        [DataMember(Name="materialName", EmitDefaultValue=false)]
        public string MaterialName { get; set; }

        /// <summary>
        /// Material category id.
        /// </summary>
        /// <value>Material category id.</value>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public int CategoryId { get; set; }

        /// <summary>
        /// Material category name.
        /// </summary>
        /// <value>Material category name.</value>
        [DataMember(Name="categoryName", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaterialModel {\n");
            sb.Append("  MaterialId: ").Append(MaterialId).Append("\n");
            sb.Append("  MaterialName: ").Append(MaterialName).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((MaterialModel)obj);
        }

        /// <summary>
        /// Returns true if MaterialModel instances are equal
        /// </summary>
        /// <param name="other">Instance of MaterialModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaterialModel other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MaterialId == other.MaterialId ||
                    
                    MaterialId.Equals(other.MaterialId)
                ) && 
                (
                    MaterialName == other.MaterialName ||
                    MaterialName != null &&
                    MaterialName.Equals(other.MaterialName)
                ) && 
                (
                    CategoryId == other.CategoryId ||
                    
                    CategoryId.Equals(other.CategoryId)
                ) && 
                (
                    CategoryName == other.CategoryName ||
                    CategoryName != null &&
                    CategoryName.Equals(other.CategoryName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    
                    hashCode = hashCode * 59 + MaterialId.GetHashCode();
                    if (MaterialName != null)
                    hashCode = hashCode * 59 + MaterialName.GetHashCode();
                    
                    hashCode = hashCode * 59 + CategoryId.GetHashCode();
                    if (CategoryName != null)
                    hashCode = hashCode * 59 + CategoryName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MaterialModel left, MaterialModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MaterialModel left, MaterialModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
