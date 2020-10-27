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
    /// TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures :  IEquatable<TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures" /> class.
        /// </summary>
        /// <param name="BalanceAmount">Remaining balance on the account.  Returned by authorization service.  #### PIN debit Remaining balance on the prepaid card.  Returned by PIN debit purchase. .</param>
        /// <param name="PreviousBalanceAmount">Remaining balance on the account.  Returned by authorization service.  #### PIN debit Remaining balance on the prepaid card.  Returned by PIN debit purchase. .</param>
        /// <param name="Currency">Currency of the remaining balance on the account. For the possible values, see the [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  Returned by authorization service.  #### PIN debit Currency of the remaining balance on the prepaid card.  Returned by PIN debit purchase. .</param>
        public TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures(string BalanceAmount = default(string), string PreviousBalanceAmount = default(string), string Currency = default(string))
        {
            this.BalanceAmount = BalanceAmount;
            this.PreviousBalanceAmount = PreviousBalanceAmount;
            this.Currency = Currency;
        }
        
        /// <summary>
        /// Remaining balance on the account.  Returned by authorization service.  #### PIN debit Remaining balance on the prepaid card.  Returned by PIN debit purchase. 
        /// </summary>
        /// <value>Remaining balance on the account.  Returned by authorization service.  #### PIN debit Remaining balance on the prepaid card.  Returned by PIN debit purchase. </value>
        [DataMember(Name="balanceAmount", EmitDefaultValue=false)]
        public string BalanceAmount { get; set; }

        /// <summary>
        /// Remaining balance on the account.  Returned by authorization service.  #### PIN debit Remaining balance on the prepaid card.  Returned by PIN debit purchase. 
        /// </summary>
        /// <value>Remaining balance on the account.  Returned by authorization service.  #### PIN debit Remaining balance on the prepaid card.  Returned by PIN debit purchase. </value>
        [DataMember(Name="previousBalanceAmount", EmitDefaultValue=false)]
        public string PreviousBalanceAmount { get; set; }

        /// <summary>
        /// Currency of the remaining balance on the account. For the possible values, see the [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  Returned by authorization service.  #### PIN debit Currency of the remaining balance on the prepaid card.  Returned by PIN debit purchase. 
        /// </summary>
        /// <value>Currency of the remaining balance on the account. For the possible values, see the [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  Returned by authorization service.  #### PIN debit Currency of the remaining balance on the prepaid card.  Returned by PIN debit purchase. </value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures {\n");
            sb.Append("  BalanceAmount: ").Append(BalanceAmount).Append("\n");
            sb.Append("  PreviousBalanceAmount: ").Append(PreviousBalanceAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponsePaymentInformationAccountFeatures other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BalanceAmount == other.BalanceAmount ||
                    this.BalanceAmount != null &&
                    this.BalanceAmount.Equals(other.BalanceAmount)
                ) && 
                (
                    this.PreviousBalanceAmount == other.PreviousBalanceAmount ||
                    this.PreviousBalanceAmount != null &&
                    this.PreviousBalanceAmount.Equals(other.PreviousBalanceAmount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
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
                if (this.BalanceAmount != null)
                    hash = hash * 59 + this.BalanceAmount.GetHashCode();
                if (this.PreviousBalanceAmount != null)
                    hash = hash * 59 + this.PreviousBalanceAmount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
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
            // BalanceAmount (string) maxLength
            if(this.BalanceAmount != null && this.BalanceAmount.Length >= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BalanceAmount, length must be less than or equal to 12.", new [] { "BalanceAmount" });
            }

            // PreviousBalanceAmount (string) maxLength
            if(this.PreviousBalanceAmount != null && this.PreviousBalanceAmount.Length >= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PreviousBalanceAmount, length must be less than or equal to 12.", new [] { "PreviousBalanceAmount" });
            }

            // Currency (string) maxLength
            if(this.Currency != null && this.Currency.Length >= 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than or equal to 5.", new [] { "Currency" });
            }

            yield break;
        }
    }

}
