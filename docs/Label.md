# Tusk.Model.Label

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the Label. | [optional] 
**ShipmentId** | **int** | The Shipment which is shipped by this Label. | [optional] 
**RateId** | **int** | The Rate which was used to create this Label. | [optional] 
**LabelUrl** | **string** | URL to fetch the Label to print. | [optional] 
**Cost** | **decimal** | Purchase price of the Label. | [optional] 
**TrackingUrl** | **string** | URL to a tracking page for this Label. | [optional] 
**LabelFormat** | **string** | Format of labels to be returned from this purchase. Options are: PDF4X5, ZPL4X5. Defaults to PDF4X5 if not specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

