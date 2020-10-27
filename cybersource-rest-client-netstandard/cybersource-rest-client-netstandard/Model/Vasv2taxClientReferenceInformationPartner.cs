/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Vasv2taxClientReferenceInformationPartner
    /// </summary>
    [DataContract]
    public partial class Vasv2taxClientReferenceInformationPartner :  IEquatable<Vasv2taxClientReferenceInformationPartner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vasv2taxClientReferenceInformationPartner" /> class.
        /// </summary>
        /// <param name="DeveloperId">Identifier for the developer that helped integrate a partner solution to CyberSource.  Send this value in all requests that are sent through the partner solutions built by that developer. CyberSource assigns the ID to the developer.  **Note** When you see a developer ID of 999 in reports, the developer ID that was submitted is incorrect. .</param>
        /// <param name="SolutionId">Identifier for the partner that is integrated to CyberSource.  Send this value in all requests that are sent through the partner solution. CyberSource assigns the ID to the partner.  **Note** When you see a solutionId of 999 in reports, the solutionId that was submitted is incorrect. .</param>
        public Vasv2taxClientReferenceInformationPartner(string DeveloperId = default(string), string SolutionId = default(string))
        {
            this.DeveloperId = DeveloperId;
            this.SolutionId = SolutionId;
        }
        
        /// <summary>
        /// Identifier for the developer that helped integrate a partner solution to CyberSource.  Send this value in all requests that are sent through the partner solutions built by that developer. CyberSource assigns the ID to the developer.  **Note** When you see a developer ID of 999 in reports, the developer ID that was submitted is incorrect. 
        /// </summary>
        /// <value>Identifier for the developer that helped integrate a partner solution to CyberSource.  Send this value in all requests that are sent through the partner solutions built by that developer. CyberSource assigns the ID to the developer.  **Note** When you see a developer ID of 999 in reports, the developer ID that was submitted is incorrect. </value>
        [DataMember(Name="developerId", EmitDefaultValue=false)]
        public string DeveloperId { get; set; }

        /// <summary>
        /// Identifier for the partner that is integrated to CyberSource.  Send this value in all requests that are sent through the partner solution. CyberSource assigns the ID to the partner.  **Note** When you see a solutionId of 999 in reports, the solutionId that was submitted is incorrect. 
        /// </summary>
        /// <value>Identifier for the partner that is integrated to CyberSource.  Send this value in all requests that are sent through the partner solution. CyberSource assigns the ID to the partner.  **Note** When you see a solutionId of 999 in reports, the solutionId that was submitted is incorrect. </value>
        [DataMember(Name="solutionId", EmitDefaultValue=false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vasv2taxClientReferenceInformationPartner {\n");
            sb.Append("  DeveloperId: ").Append(DeveloperId).Append("\n");
            sb.Append("  SolutionId: ").Append(SolutionId).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Vasv2taxClientReferenceInformationPartner);
        }

        /// <summary>
        /// Returns true if Vasv2taxClientReferenceInformationPartner instances are equal
        /// </summary>
        /// <param name="other">Instance of Vasv2taxClientReferenceInformationPartner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vasv2taxClientReferenceInformationPartner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeveloperId == other.DeveloperId ||
                    this.DeveloperId != null &&
                    this.DeveloperId.Equals(other.DeveloperId)
                ) && 
                (
                    this.SolutionId == other.SolutionId ||
                    this.SolutionId != null &&
                    this.SolutionId.Equals(other.SolutionId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.DeveloperId != null)
                    hash = hash * 59 + this.DeveloperId.GetHashCode();
                if (this.SolutionId != null)
                    hash = hash * 59 + this.SolutionId.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // DeveloperId (string) maxLength
            if(this.DeveloperId != null && this.DeveloperId.Length >= 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeveloperId, length must be less than or equal to 8.", new [] { "DeveloperId" });
            }

            // SolutionId (string) maxLength
            if(this.SolutionId != null && this.SolutionId.Length >= 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolutionId, length must be less than or equal to 8.", new [] { "SolutionId" });
            }

            yield break;
        }
    }

}
