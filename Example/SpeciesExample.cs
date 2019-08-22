namespace Example
{
    using System;
    using StarWarsApiCSharp;

    public class SpeciesExample : IExecutor
    {
        public void Execute()
        {
            Repository<Specie> specieRepository = new Repository<Specie>();
            IRepository<Person> person = new Repository<Person>();
            int pagina = 1;
            int tamanho = 37;
            var peoples = new Repository<Person>();

            var lista = peoples.GetEntities(pagina, tamanho);
            
            Specie specie = specieRepository.GetById(1);
            
            const string UnknownValue = "unknown";
            const int SpecialSpan = 2;

            if (specie != null && specie.AverageLifespan != UnknownValue)
            {
                string name = specie.Name;
                
                Console.WriteLine("Name: " + name);
                if (specie != null && specie.People.Count > 0)
                {
                    Console.WriteLine("Personagens: ");
                    foreach (var people in lista)
                    {
                        Console.WriteLine(people.Name);
                    }
                }
                Console.WriteLine("Peso médio :" + specie.AverageHeight);
            }

            int lifeSpanAverage = 0;
            if (int.TryParse(specie.AverageLifespan, out lifeSpanAverage))
            {
                
            }
        }
    }
}
