namespace SuperHeroGraphQL.Models
{
    public class Superpower
    {
        public int Id { get; set; }
        public string SuperPower { get; set; }
        public string Description { get; set; }
        public int SuperheroId { get; set; }
        public Superhero Superhero { get; set; }
    }
}