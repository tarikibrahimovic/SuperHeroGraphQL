using System.ComponentModel.DataAnnotations;

namespace SuperHeroGraphQL.Models
{
    public class Superhero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Height { get; set; }
        public string PictureUrl { get; set; }

        [UseSorting]
        public ICollection<Superpower> Superpowers { get; set; }
    }
}