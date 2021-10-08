﻿/*
 * Cocktail API
 *
 * API to manage cocktail info.
 *
 * The version of the OpenAPI document: 0.1.3
 * Contact: okarians.302.dev@gmail.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace mycocktails.library.common.Models
{
    /// <summary>
    /// 共通応答電文
    /// </summary>
    [DataContract]
    public partial class CommonMessageModel : IEquatable<CommonMessageModel>
    {
        /// <summary>
        /// Gets or Sets Msg
        /// </summary>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonMessageModel {\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CommonMessageModel)obj);
        }

        /// <summary>
        /// Returns true if CommonMessageModel instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonMessageModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonMessageModel other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Msg == other.Msg ||
                    Msg != null &&
                    Msg.Equals(other.Msg)
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
                if (Msg != null)
                    hashCode = hashCode * 59 + Msg.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(CommonMessageModel left, CommonMessageModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CommonMessageModel left, CommonMessageModel right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}