# C# Rest API Client Library

- [Refit](https://github.com/reactiveui/refit)
- [RestSharp](https://restsharp.dev)


# Dependency Injection

e.g. web

initialize in program.cs

`builder.Services.AddRefitClient<IGuestData>().ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:5001/api"));`


# Without Dependency Injection

e.g. console, win form

initialize in class

`var weatherData = RestService.For<IWeatherData>("https://localhost:5001");`



