# Tusk.Model.CreateShipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalReference** | **string** | Optional field for providing an identifier of the shipment. This can help identify shipments faster in case of a support issue. This field is limited to 50 characters and no validation of any data is performed on this. | [optional] 
**Confirmation** | **string** | Request confirmation for this shipment. Options are: NONE, SIGNATURE, ADULT_SIGNATURE. Defaults to NONE if not specified. A surcharge might apply. | [optional] 
**AddressTo** | [**Address**](Address.md) |  | 
**AddressFrom** | [**Address**](Address.md) |  | 
**Parcels** | [**List&lt;Parcel&gt;**](Parcel.md) | Parcels sent as part of this Shipment. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

