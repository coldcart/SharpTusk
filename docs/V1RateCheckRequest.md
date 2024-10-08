# Tusk.Model.V1RateCheckRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Confirmation** | **string** | Request confirmation for this shipment. Options are: NONE, SIGNATURE, ADULT_SIGNATURE. Defaults to NONE if not specified. A surcharge might apply. | [optional] 
**ShipDate** | **string** | Format YYYY-MM-DD. Date the carrier is expected to receive the parcel. Required to get estimated_delivery_date. | [optional] 
**AddressFrom** | [**Address**](Address.md) |  | 
**PostalCodeTo** | **string** | Destination postal code | 
**Parcels** | [**List&lt;Parcel&gt;**](Parcel.md) | Parcels sent as part of this Shipment. | 
**FinalMileCarrier** | **string** | The final mile carrier to be used for this rate check. If not specified service will be determined for you. Options are: `cdl`, `gls-us`, `lso`, `uds`, `courier_express`, `optima`, `groscale`, `speedx`, `uniuni` | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

