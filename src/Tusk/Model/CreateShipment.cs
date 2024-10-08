/*
 * Tusk Logistics API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Contact: devsupport@tusklogistics.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Tusk.Model
{
    /// <summary>
    /// CreateShipment
    /// </summary>
    [DataContract(Name = "CreateShipment")]
    public partial class CreateShipment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShipment" /> class.
        /// </summary>
        [JsonConstructor]
        public CreateShipment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShipment" /> class.
        /// </summary>
        /// <param name="externalReference">Optional field for providing an identifier of the shipment. This can help identify shipments faster in case of a support issue. This field is limited to 50 characters and no validation of any data is performed on this..</param>
        /// <param name="confirmation">Request confirmation for this shipment. Options are: NONE, SIGNATURE, ADULT_SIGNATURE. Defaults to NONE if not specified. A surcharge might apply..</param>
        /// <param name="addressTo">addressTo (required).</param>
        /// <param name="addressFrom">addressFrom (required).</param>
        /// <param name="parcels">Parcels sent as part of this Shipment. (required).</param>
        public CreateShipment(string externalReference = default(string), string confirmation = default(string), Address addressTo = default(Address), Address addressFrom = default(Address), List<Parcel> parcels = default(List<Parcel>))
        {
            // to ensure "addressTo" is required (not null)
            if (addressTo == null)
            {
                throw new ArgumentNullException("addressTo is a required property for CreateShipment and cannot be null");
            }
            this.AddressTo = addressTo;
            // to ensure "addressFrom" is required (not null)
            if (addressFrom == null)
            {
                throw new ArgumentNullException("addressFrom is a required property for CreateShipment and cannot be null");
            }
            this.AddressFrom = addressFrom;
            // to ensure "parcels" is required (not null)
            if (parcels == null)
            {
                throw new ArgumentNullException("parcels is a required property for CreateShipment and cannot be null");
            }
            this.Parcels = parcels;
            this.ExternalReference = externalReference;
            this.Confirmation = confirmation;
        }

        /// <summary>
        /// Optional field for providing an identifier of the shipment. This can help identify shipments faster in case of a support issue. This field is limited to 50 characters and no validation of any data is performed on this.
        /// </summary>
        /// <value>Optional field for providing an identifier of the shipment. This can help identify shipments faster in case of a support issue. This field is limited to 50 characters and no validation of any data is performed on this.</value>
        [DataMember(Name = "external_reference", EmitDefaultValue = false)]
        public string? ExternalReference { get; set; }

        /// <summary>
        /// Request confirmation for this shipment. Options are: NONE, SIGNATURE, ADULT_SIGNATURE. Defaults to NONE if not specified. A surcharge might apply.
        /// </summary>
        /// <value>Request confirmation for this shipment. Options are: NONE, SIGNATURE, ADULT_SIGNATURE. Defaults to NONE if not specified. A surcharge might apply.</value>
        [DataMember(Name = "confirmation", EmitDefaultValue = false)]
        public string? Confirmation { get; set; }

        /// <summary>
        /// Gets or Sets AddressTo
        /// </summary>
        [DataMember(Name = "address_to", IsRequired = true, EmitDefaultValue = true)]
        public Address? AddressTo { get; set; }

        /// <summary>
        /// Gets or Sets AddressFrom
        /// </summary>
        [DataMember(Name = "address_from", IsRequired = true, EmitDefaultValue = true)]
        public Address? AddressFrom { get; set; }

        /// <summary>
        /// Parcels sent as part of this Shipment.
        /// </summary>
        /// <value>Parcels sent as part of this Shipment.</value>
        [DataMember(Name = "parcels", IsRequired = true, EmitDefaultValue = true)]
        public List<Parcel> Parcels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateShipment {\n");
            sb.Append("  ExternalReference: ").Append(ExternalReference).Append("\n");
            sb.Append("  Confirmation: ").Append(Confirmation).Append("\n");
            sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
            sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
            sb.Append("  Parcels: ").Append(Parcels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
