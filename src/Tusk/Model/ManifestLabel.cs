/*
 * Tusk Logistics API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Contact: devsupport@tusklogistics.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Tusk.Model
{
    /// <summary>
    /// ManifestLabel
    /// </summary>
    [DataContract(Name = "ManifestLabel")]
    public partial class ManifestLabel : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestLabel" /> class.
        /// </summary>
        /// <param name="labelId">Id of the label in the manifest..</param>
        /// <param name="shipmentTrackingNumber">The unique tracking number used for tracking this Shipment..</param>
        public ManifestLabel(int labelId = default(int), string shipmentTrackingNumber = default(string))
        {
            this.LabelId = labelId;
            this.ShipmentTrackingNumber = shipmentTrackingNumber;
        }

        /// <summary>
        /// Id of the label in the manifest.
        /// </summary>
        /// <value>Id of the label in the manifest.</value>
        [DataMember(Name = "label_id", EmitDefaultValue = false)]
        [JsonPropertyName("label_id")]
        public int LabelId { get; set; }

        /// <summary>
        /// The unique tracking number used for tracking this Shipment.
        /// </summary>
        /// <value>The unique tracking number used for tracking this Shipment.</value>
        [DataMember(Name = "shipment_tracking_number", EmitDefaultValue = false)]
        [JsonPropertyName("shipment_tracking_number")]
        public string ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ManifestLabel {\n");
            sb.Append("  LabelId: ").Append(LabelId).Append("\n");
            sb.Append("  ShipmentTrackingNumber: ").Append(ShipmentTrackingNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
