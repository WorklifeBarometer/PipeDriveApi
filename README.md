# PipeDriveApi

[![NuGet](https://img.shields.io/nuget/v/PipeDriveApi.svg?style=flat-square)](https://www.nuget.org/packages/PipeDriveApi/)

> .Net API for interacting with the PipeDrive API. Fully Async, support for custom fields and API Rate limiting.

## Example - Basics

```cs
var myKey = "MY_PIPEDRIVE_API_KEY";
var client = new PipeDriveClient(myKey);

var emails = await client.Activities.GetAllByType("email");
var deals = await client.Deals.GetAllAsync();
var persons = await client.Persons.GetAllAsync();
```

## Example - Custom Fields

```cs
var myKey = "MY_PIPEDRIVE_API_KEY";
var client = new PipeDriveClient<Person, MyCustomOrganization,Deal,Product>(myKey);

var orgs = await client.Organizations.GetAsync();

public class MyCustomOrganization : Organization
{
   [CustomField("5d65d158579525f6d46b7d381fad397d74778553")]
   public string FavoriteShoeSize { get; set; }
}
```

