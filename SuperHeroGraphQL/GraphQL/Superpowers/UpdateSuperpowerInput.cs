namespace SuperHeroGraphQL.GraphQL.Superpowers
{
    public class UpdateSuperpowerInput
    {
        public int Id { get; set; }
        public string SuperPower { get; set; }
        public string Description { get; set; }
        public int SuperheroId { get; set; }
    }
}
