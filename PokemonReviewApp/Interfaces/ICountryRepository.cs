using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);       // Owner ki Id ke through Country nikaalna

        ICollection<Owner> GetOwnersFromACountry(int countryId);        // Kisi country id py kitna owners ha

        bool CountryExists(int id);
        bool CreateCountry(Country country);
        bool Save();


    }
}
