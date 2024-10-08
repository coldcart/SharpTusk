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
    /// ShipmentLabel
    /// </summary>
    [DataContract(Name = "ShipmentLabel")]
    public partial class ShipmentLabel : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentLabel" /> class.
        /// </summary>
        /// <param name="id">The identifier of this Label..</param>
        /// <param name="cost">Purchase price of the Label..</param>
        /// <param name="trackingNumber">The Tusk tracking number used to track this Label specifically, instead of the full Shipment it is a part of..</param>
        /// <param name="trackingUrl">URL to a tracking page for this Label..</param>
        /// <param name="labelUrl">URL to a label PDF for this Label..</param>
        public ShipmentLabel(int id = default(int), decimal cost = default(decimal), string trackingNumber = default(string), string trackingUrl = default(string), string labelUrl = default(string))
        {
            this.Id = id;
            this.Cost = cost;
            this.TrackingNumber = trackingNumber;
            this.TrackingUrl = trackingUrl;
            this.LabelUrl = labelUrl;
        }

        /// <summary>
        /// The identifier of this Label.
        /// </summary>
        /// <value>The identifier of this Label.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Purchase price of the Label.
        /// </summary>
        /// <value>Purchase price of the Label.</value>
        [DataMember(Name = "cost", EmitDefaultValue = false)]
        [JsonPropertyName("cost")]
        public decimal Cost { get; set; }

        /// <summary>
        /// The Tusk tracking number used to track this Label specifically, instead of the full Shipment it is a part of.
        /// </summary>
        /// <value>The Tusk tracking number used to track this Label specifically, instead of the full Shipment it is a part of.</value>
        [DataMember(Name = "tracking_number", EmitDefaultValue = false)]
        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// URL to a tracking page for this Label.
        /// </summary>
        /// <value>URL to a tracking page for this Label.</value>
        [DataMember(Name = "tracking_url", EmitDefaultValue = false)]
        [JsonPropertyName("tracking_url")]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// URL to a label PDF for this Label.
        /// </summary>
        /// <value>URL to a label PDF for this Label.</value>
        [DataMember(Name = "label_url", EmitDefaultValue = false)]
        [JsonPropertyName("label_url")]
        public string LabelUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentLabel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
            sb.Append("  LabelUrl: ").Append(LabelUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
