using CSharpBlazorApp.Models;
using Refit;

namespace CSharpBlazorApp.DataAccess
{
    public interface IWeatherData
    {

        [Get("/WeatherForecast")]
        Task<List<WeatherModel>> GetWeather();


    }
}
