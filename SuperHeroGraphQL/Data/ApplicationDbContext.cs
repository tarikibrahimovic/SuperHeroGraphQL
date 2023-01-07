using Microsoft.EntityFrameworkCore;
using SuperHeroGraphQL.Models;

namespace SuperHeroGraphQL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Superhero>()
                .HasData(
                new Superhero
                {
                    Id = 1,
                    Name = "Batman",
                    Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                    Height = "1.93",
                    PictureUrl = "https://cdn.vox-cdn.com/thumbor/IcD8loKIefZlINVp-pVIz_yUEdE=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/23307403/IMG_3722.jpeg"
                },
                new Superhero
                {
                    Id = 2,
                    Name = "Luke Skywalker",
                    Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                    Height = "1.70",
                    PictureUrl = "https://oyster.ignimgs.com/mediawiki/apis.ign.com/star-wars-episode-7/2/2d/Luke.jpg?width=1280"
                },
                new Superhero
                {
                    Id = 3,
                    Name = "Black Widow",
                    Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                    Height = "1.70",
                    PictureUrl = "https://lumiere-a.akamaihd.net/v1/images/image_b97b56f3.jpeg?region=0%2C0%2C540%2C810"
                });

            builder.Entity<Superpower>()
                .HasData(
                new Superpower
                {
                    Id = 1,
                    SuperPower = "Intellect.",
                    Description = "He's always a step ahead.",
                    SuperheroId = 1
                },
                new Superpower
                {
                    Id = 2,
                    SuperPower = "Fighting",
                    Description = "Sublime fighting skills.",
                    SuperheroId = 1
                },
                new Superpower
                {
                    Id = 3,
                    SuperPower = "Wealth.",
                    Description = "He got a lot of money",
                    SuperheroId = 1
                },
                new Superpower
                {
                    Id = 4,
                    SuperPower = "Deflect blaster power.",
                    Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                    SuperheroId = 2
                },
                new Superpower
                {
                    Id = 5,
                    SuperPower = "Espionage",
                    Description = "She's good at spying at people.",
                    SuperheroId = 2
                },
                new Superpower
                {
                    Id = 6,
                    SuperPower = "Infiltration",
                    Description = "She knows how to infiltrate the enemy.",
                    SuperheroId = 3
                },
                new Superpower
                {
                    Id = 7,
                    SuperPower = "Subterfuge",
                    Description = "The knowledge of how to undermine others.",
                    SuperheroId = 3
                });
        }

        // Add the DbSets for each of our models we would like at our database
        public DbSet<Superhero> Superheroes { get; set; }
        public DbSet<Superpower> Superpowers { get; set; }
    }
}