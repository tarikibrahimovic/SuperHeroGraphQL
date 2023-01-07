using SuperHeroGraphQL.Data;
using SuperHeroGraphQL.GraphQL.Superheroes;
using SuperHeroGraphQL.GraphQL.Superpowers;
using SuperHeroGraphQL.Models;

namespace SuperHeroGraphQL.GraphQL
{
    public class Mutation
    {

        //ADD SUPERHERO
        [UseDbContext(typeof(ApplicationDbContext))]
        public Superhero AddSuperhero(AddSuperheroInput input, [ScopedService] ApplicationDbContext context)
        {
            if (context.Superheroes.Any(s => s.Name == input.Name))
                throw new Exception("Superpower already exists!");
            var hero = new Superhero()
            {
                Name = input.Name,
                Description = input.Description,
                Height = input.Height,
                PictureUrl = input.PictureUrl
            };
            context.Superheroes.Add(hero);
            context.SaveChanges();

            return hero;
        }

        //ADD SUPERPOWER
        [UseDbContext(typeof(ApplicationDbContext))]

        public Superpower AddSuperpower(AddSuperpowerInput input, [ScopedService] ApplicationDbContext context)
        {
            if (context.Superpowers.Any(s => s.SuperPower == input.SuperPower))
                throw new Exception("Superpower already exists!");
            var power = new Superpower()
            {
                SuperPower = input.SuperPower,
                Description = input.Description,
                SuperheroId = input.SuperheroId,
            };

            context.Superpowers.Add(power);
            context.SaveChanges();

            return power;
        }
        //UPDATE SUPERHERO
        [UseDbContext(typeof(ApplicationDbContext))]

        public Superhero UpdateSuperhero(UpdateSuperheroInput input, [ScopedService] ApplicationDbContext context)
        {
            var superhero = context.Superheroes.FirstOrDefault(s => s.Id == input.Id);
            if (superhero == null) throw new Exception("Superhero not found!");
            superhero.Height = input.Height;
            superhero.Description = input.Description;
            superhero.Name = input.Name;
            superhero.PictureUrl = input.PictureUrl;
            context.SaveChanges();
            return superhero;
        }

        //UPDATE SUPERPOWER
        [UseDbContext(typeof(ApplicationDbContext))]

        public Superpower UpdateSuperpower(UpdateSuperpowerInput input, [ScopedService] ApplicationDbContext context)
        {
            var superpower = context.Superpowers.FirstOrDefault(s => s.Id == input.Id);
            if (superpower == null) throw new Exception("Superpower not found!");
            superpower.SuperPower = input.SuperPower;
            superpower.Description = input.Description;
            superpower.SuperheroId = input.SuperheroId;
            context.SaveChanges();
            return superpower;
        }


        //DELETE SUPERHERO
        [UseDbContext(typeof(ApplicationDbContext))]

        public Superhero DeleteSuperhero(RemoveInput input, [ScopedService] ApplicationDbContext context)
        {
            var superhero = context.Superheroes.FirstOrDefault(s => s.Id == input.Id);
            if (superhero == null) throw new Exception("Superhero not found!");
            context.Remove(superhero);
            context.SaveChanges();
            return superhero;
        }

        //DELETE SUPERPOWER
        [UseDbContext(typeof(ApplicationDbContext))]

        public Superpower DeleteSuperpower(RemoveInput input, [ScopedService] ApplicationDbContext context)
        {
            var superpower = context.Superpowers.FirstOrDefault(s => s.Id == input.Id);
            if (superpower == null) throw new Exception("superpower not found!");
            context.Remove(superpower);
            context.SaveChanges();
            return superpower;
        }
    }
}
