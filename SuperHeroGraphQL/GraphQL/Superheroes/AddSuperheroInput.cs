using System.ComponentModel.DataAnnotations;

namespace SuperHeroGraphQL.GraphQL.Superheroes
{
    //public record AddSuperheroInput(string Name, string Description, string Height, string PictureUrl);

    public class AddSuperheroInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Height { get; set; }
        public string PictureUrl { get; set; }
    }
}
