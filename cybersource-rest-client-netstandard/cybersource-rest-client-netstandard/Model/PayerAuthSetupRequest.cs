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
    /// PayerAuthSetupRequest
    /// </summary>
    [DataContract]
    public partial class PayerAuthSetupRequest :  IEquatable<PayerAuthSetupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayerAuthSetupRequest" /> class.
        /// </summary>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="TokenInformation">TokenInformation.</param>
        public PayerAuthSetupRequest(Riskv1authenticationsetupsClientReferenceInformation ClientReferenceInformation = default(Riskv1authenticationsetupsClientReferenceInformation), Riskv1authenticationsetupsPaymentInformation PaymentInformation = default(Riskv1authenticationsetupsPaymentInformation), Riskv1authenticationsetupsProcessingInformation ProcessingInformation = default(Riskv1authenticationsetupsProcessingInformation), Riskv1authenticationsetupsTokenInformation TokenInformation = default(Riskv1authenticationsetupsTokenInformation))
        {
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.PaymentInformation = PaymentInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.TokenInformation = TokenInformation;
        }
        
        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsetupsClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsetupsPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsetupsProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets TokenInformation
        /// </summary>
        [DataMember(Name="tokenInformation", EmitDefaultValue=false)]
        public Riskv1authenticationsetupsTokenInformation TokenInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayerAuthSetupRequest {\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  TokenInformation: ").Append(TokenInformation).Append("\n");
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
            return this.Equals(obj as PayerAuthSetupRequest);
        }

        /// <summary>
        /// Returns true if PayerAuthSetupRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PayerAuthSetupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayerAuthSetupRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.TokenInformation == other.TokenInformation ||
                    this.TokenInformation != null &&
                    this.TokenInformation.Equals(other.TokenInformation)
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
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.TokenInformation != null)
                    hash = hash * 59 + this.TokenInformation.GetHashCode();
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
            yield break;
        }
    }

}
