# dear-api-wrapper
[![.NET Core Desktop](https://github.com/mbe14/dear-api-wrapper/actions/workflows/dotnet-desktop.yml/badge.svg?branch=main)](https://github.com/mbe14/dear-api-wrapper/actions/workflows/dotnet-desktop.yml)  
C# wrapper for DEAR API V2

## Installation
Download the `DearInventoryLib` library and add a reference into your C# project.

## Usage
Create an `ApiRequest` instance
```
string AccountId = "YOUR_ACCOUNT_ID";
string ApplicationKey = "YOUR_APPLICATION_KEY";
ApiRequest Api = new ApiRequest(AccountId, ApplicationKey);
```
Get all products using the API
```
var products = Api.Product.GetAllProducts(IncludeSuppliers: true);
```
Get product by `SKU` or `ID`
```
string sku = "101-Gloves-011";
var product = Api.Product.GetProductBySKU(sku);

Guid guid = Guid.Parse("907f3980-059b-4374-be26-42604e553257");
var anotherProduct = Api.Product.GetProductByID(guid);
```
Adding new product
```
Product p = new Product()
{
    Name = "Apple",
    Barcode = "6001001001",
    SKU = "APL",
    AverageCost = 50,
    Type = DearInventoryLib.Model.Product.Type.Stock,
    CostingMethod = DearInventoryLib.Model.Common.CostingMethod.FIFO
}
//The id of the newly created product
string id = Api.Product.AddProduct(p);
```
Edit a product
```
Product p = new Product()
{
    //Id of the product you want to edit. This field is mandatory
    ID = Guid.Parse(""),
    Category = "Fruit"
}
bool isSuccess = Api.Product.EditProduct(p);
```


