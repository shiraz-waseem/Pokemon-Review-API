using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);

        // cat ka owner kon ha?
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);

        // shiraz ka konsa pokemon ha?
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int ownerId);

    }
}
