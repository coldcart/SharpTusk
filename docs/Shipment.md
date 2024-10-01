# Tusk.Model.Shipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the Shipment. | [optional] 
**ExternalReference** | **string** | Optional field for providing an identifier of the shipment. This can help identify shipments faster in case of a support issue. This field is limited to 50 characters and no validation of any data is performed on this. | [optional] 
**Confirmation** | **string** | Confirmation requested for this shipment. Options are: NONE, SIGNATURE, ADULT_SIGNATURE. Defaults to NONE if not specified. A surcharge might apply. | [optional] 
**AddressTo** | [**Address**](Address.md) |  | [optional] 
**AddressFrom** | [**Address**](Address.md) |  | [optional] 
**Parcels** | [**List&lt;Parcel&gt;**](Parcel.md) | Parcels sent as part of this Shipment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

