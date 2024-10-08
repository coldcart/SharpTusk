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
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Tusk.Model
{
    /// <summary>
    /// Parcel
    /// </summary>
    [DataContract(Name = "Parcel")]
    public partial class Parcel : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Parcel" /> class.
        /// </summary>
        [JsonConstructor]
        public Parcel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Parcel" /> class.
        /// </summary>
        /// <param name="dimensions">dimensions (required).</param>
        /// <param name="weight">weight (required).</param>
        public Parcel(ParcelDimensions dimensions = default(ParcelDimensions), ParcelWeight weight = default(ParcelWeight))
        {
            // to ensure "dimensions" is required (not null)
            if (dimensions == null)
            {
                throw new ArgumentNullException("dimensions is a required property for Parcel and cannot be null");
            }
            this.Dimensions = dimensions;
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new ArgumentNullException("weight is a required property for Parcel and cannot be null");
            }
            this.Weight = weight;
        }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", EmitDefaultValue = true)]
        [JsonPropertyName("dimensions")]
        public ParcelDimensions? Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = true)]
        [JsonPropertyName("weight")]
        public ParcelWeight? Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Parcel {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
