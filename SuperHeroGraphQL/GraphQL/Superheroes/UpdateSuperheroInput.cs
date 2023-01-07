namespace SuperHeroGraphQL.GraphQL.Superheroes
{
    public class UpdateSuperheroInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Height { get; set; }
        public string PictureUrl { get; set; }
    }
}
