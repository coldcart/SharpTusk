# Tusk.Model.Delivery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceShipSpeedDays** | **decimal** | Shipping speed, in days, of the service. For example, next-day service will be 1. Two-day service will be 2. | [optional] 
**EstimatedTimeInTransitDays** | **decimal** | Number of calendar days it is expected to take for the parcel to reach its destination, once the carrier has taken possession of it. | [optional] 
**EstimatedDeliveryDate** | **string** | Estimated delivery date, in the timezone of delivery. This will be null if no ship_date provided in the request. | [optional] 
**Notes** | **List&lt;string&gt;** | Notes about the delivery service. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

