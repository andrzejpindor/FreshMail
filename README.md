# FreshMail
##Prerequisities
Because the API client uses the HttpClient class whole solution is targeted to .NET Framework 4.5.
All API client methods are asynchronous.

## Installation
FreshMail API Client is available as [nuget package](https://www.nuget.org/packages/FreshMail/).
Simply install it using Package Manager from Visual Studio:
```
Install-Package FreshMail
```

## Usage example

First create configuration class:

```
var configuration = new FreshMailConfiguration(new Uri("https://api.freshmail.com/rest/"), "API_KEY", "API_SIGN");
```

Next create FreshMailApiClient instance:

```
FreshMailApiClient client = new FreshMailApiClient(configuration);
```

And use as simple as:

```
Task<EmptyApiResponse> response = client.Sms.Send(new SmsRequest("48123456789", "Visit our page", "example.com", SingleSettings.On));

AddSubscriberRequest request = new AddSubscriberRequest("abcdefgh", "some@example.com", SubscriberStatus.PendingActivation);
request.AddCustomField("extra_field", "some value");
Task<EmptyApiResponse> response = client.Subscribers.Add(request);
```

##Missing methods implementation
* [Spam tests](http://freshmail.pl/developer-api/spamtesty/)
* [Manage users](http://freshmail.pl/developer-api/tworzenie-kont/)
* [Multiple subscribers operations](http://freshmail.pl/developer-api/subskrybenci-zarzadzanie-wieloma-subskrybentami-w-pojedynczym-zadaniu/)