# Tusk.Model.Address

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Contact person at this address. | [optional] 
**Company** | **string** | Company name for this address. Required if Is_Residential is false. | [optional] 
**IsResidential** | **bool** | Flag indicating whether the address is residential. If omitted, it is assumed to be true. | [optional] 
**Street1** | **string** | First line of the street address. | 
**Street2** | **string** | Second line of the street address. May not be needed. | [optional] 
**City** | **string** | Name of the city. | 
**State** | **string** | 2-letter abbreviation of the state. | 
**Country** | **string** | 2-letter country code. Tusk currently only supports US addresses. | [optional] 
**PostalCode** | **string** | Postal code. | 
**Phone** | **string** | Phone number of the contact person at this address. | [optional] 
**Email** | **string** | Email of the contact person at this address. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

