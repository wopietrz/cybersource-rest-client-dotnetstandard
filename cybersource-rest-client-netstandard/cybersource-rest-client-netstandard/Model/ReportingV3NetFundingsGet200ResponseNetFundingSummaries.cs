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
    /// ReportingV3NetFundingsGet200ResponseNetFundingSummaries
    /// </summary>
    [DataContract]
    public partial class ReportingV3NetFundingsGet200ResponseNetFundingSummaries :  IEquatable<ReportingV3NetFundingsGet200ResponseNetFundingSummaries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3NetFundingsGet200ResponseNetFundingSummaries" /> class.
        /// </summary>
        /// <param name="Type">Valid values: - PURCHASES - REFUNDS - FEES - CHARGEBACKS .</param>
        /// <param name="PaymentSubType">PaymentSubType.</param>
        /// <param name="ConveyedCount">ConveyedCount.</param>
        /// <param name="ConveyedAmount">ConveyedAmount.</param>
        /// <param name="SettledCount">SettledCount.</param>
        /// <param name="FundedCount">FundedCount.</param>
        /// <param name="FundedAmount">FundedAmount.</param>
        /// <param name="CurrencyCode">Valid ISO 4217 ALPHA-3 currency code.</param>
        public ReportingV3NetFundingsGet200ResponseNetFundingSummaries(string Type = default(string), string PaymentSubType = default(string), int? ConveyedCount = default(int?), string ConveyedAmount = default(string), int? SettledCount = default(int?), int? FundedCount = default(int?), string FundedAmount = default(string), string CurrencyCode = default(string))
        {
            this.Type = Type;
            this.PaymentSubType = PaymentSubType;
            this.ConveyedCount = ConveyedCount;
            this.ConveyedAmount = ConveyedAmount;
            this.SettledCount = SettledCount;
            this.FundedCount = FundedCount;
            this.FundedAmount = FundedAmount;
            this.CurrencyCode = CurrencyCode;
        }
        
        /// <summary>
        /// Valid values: - PURCHASES - REFUNDS - FEES - CHARGEBACKS 
        /// </summary>
        /// <value>Valid values: - PURCHASES - REFUNDS - FEES - CHARGEBACKS </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets PaymentSubType
        /// </summary>
        [DataMember(Name="paymentSubType", EmitDefaultValue=false)]
        public string PaymentSubType { get; set; }

        /// <summary>
        /// Gets or Sets ConveyedCount
        /// </summary>
        [DataMember(Name="conveyedCount", EmitDefaultValue=false)]
        public int? ConveyedCount { get; set; }

        /// <summary>
        /// Gets or Sets ConveyedAmount
        /// </summary>
        [DataMember(Name="conveyedAmount", EmitDefaultValue=false)]
        public string ConveyedAmount { get; set; }

        /// <summary>
        /// Gets or Sets SettledCount
        /// </summary>
        [DataMember(Name="settledCount", EmitDefaultValue=false)]
        public int? SettledCount { get; set; }

        /// <summary>
        /// Gets or Sets FundedCount
        /// </summary>
        [DataMember(Name="fundedCount", EmitDefaultValue=false)]
        public int? FundedCount { get; set; }

        /// <summary>
        /// Gets or Sets FundedAmount
        /// </summary>
        [DataMember(Name="fundedAmount", EmitDefaultValue=false)]
        public string FundedAmount { get; set; }

        /// <summary>
        /// Valid ISO 4217 ALPHA-3 currency code
        /// </summary>
        /// <value>Valid ISO 4217 ALPHA-3 currency code</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3NetFundingsGet200ResponseNetFundingSummaries {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PaymentSubType: ").Append(PaymentSubType).Append("\n");
            sb.Append("  ConveyedCount: ").Append(ConveyedCount).Append("\n");
            sb.Append("  ConveyedAmount: ").Append(ConveyedAmount).Append("\n");
            sb.Append("  SettledCount: ").Append(SettledCount).Append("\n");
            sb.Append("  FundedCount: ").Append(FundedCount).Append("\n");
            sb.Append("  FundedAmount: ").Append(FundedAmount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
            return this.Equals(obj as ReportingV3NetFundingsGet200ResponseNetFundingSummaries);
        }

        /// <summary>
        /// Returns true if ReportingV3NetFundingsGet200ResponseNetFundingSummaries instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3NetFundingsGet200ResponseNetFundingSummaries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3NetFundingsGet200ResponseNetFundingSummaries other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.PaymentSubType == other.PaymentSubType ||
                    this.PaymentSubType != null &&
                    this.PaymentSubType.Equals(other.PaymentSubType)
                ) && 
                (
                    this.ConveyedCount == other.ConveyedCount ||
                    this.ConveyedCount != null &&
                    this.ConveyedCount.Equals(other.ConveyedCount)
                ) && 
                (
                    this.ConveyedAmount == other.ConveyedAmount ||
                    this.ConveyedAmount != null &&
                    this.ConveyedAmount.Equals(other.ConveyedAmount)
                ) && 
                (
                    this.SettledCount == other.SettledCount ||
                    this.SettledCount != null &&
                    this.SettledCount.Equals(other.SettledCount)
                ) && 
                (
                    this.FundedCount == other.FundedCount ||
                    this.FundedCount != null &&
                    this.FundedCount.Equals(other.FundedCount)
                ) && 
                (
                    this.FundedAmount == other.FundedAmount ||
                    this.FundedAmount != null &&
                    this.FundedAmount.Equals(other.FundedAmount)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.PaymentSubType != null)
                    hash = hash * 59 + this.PaymentSubType.GetHashCode();
                if (this.ConveyedCount != null)
                    hash = hash * 59 + this.ConveyedCount.GetHashCode();
                if (this.ConveyedAmount != null)
                    hash = hash * 59 + this.ConveyedAmount.GetHashCode();
                if (this.SettledCount != null)
                    hash = hash * 59 + this.SettledCount.GetHashCode();
                if (this.FundedCount != null)
                    hash = hash * 59 + this.FundedCount.GetHashCode();
                if (this.FundedAmount != null)
                    hash = hash * 59 + this.FundedAmount.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
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
