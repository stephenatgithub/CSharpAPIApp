using CSharpBlazorApp.Models;
using Refit;

namespace CSharpBlazorApp.DataAccess
{
    public interface IGuestData
    {
        // data source URL
        // https://localhost:5001/api/Guests

        [Get("/Guests")]
        Task<List<GuestModel>> GetGuests();

        [Get("/Guests/{id}")]
        Task<GuestModel> GetGuest(int id);

        [Post("/Guests")]
        Task CreateGuest([Body] GuestModel guest);

        [Put("/Guests/{id}")]
        Task UpdateGuest(int id, GuestModel guest);

        [Delete("/Guests/{id}")]
        Task DeleteGuest(int id);

    }
}
