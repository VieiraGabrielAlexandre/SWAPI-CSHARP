﻿namespace Example
{
    using System;
    using StarWarsApiCSharp;

    public class FilmsExample : IExecutor
    {
        public void Execute()
        {
            IRepository<Film> filmsRepo = new Repository<Film>();
            var films = filmsRepo.GetEntities(size: int.MaxValue);

            if (films == null)
            {
                Console.WriteLine("No films!");
                return;
            }

            foreach (var film in films)
            {
                Console.WriteLine(new string('#', 25));
                Console.WriteLine("Title: " + film.Title);
                Console.WriteLine("Opening crawl: " + film.OpeningCrawl);
                Console.WriteLine("Director: " + film.Director);
                Console.WriteLine("Release date: " + film.ReleaseDate);
                Console.WriteLine("Episode:  " + film.EpisodeId);
                Console.WriteLine("Producer: " + film.Producer);
                Console.WriteLine("Characters: " + film.Characters.Count);
                Console.WriteLine("Planets: " + film.Planets.Count + " :");

                foreach (var item in film.Planets)
                {
                    Console.WriteLine(new string('-', 3) + ">" + item);
                }

                Console.WriteLine("URL: " + film.Url);
                Console.WriteLine("Date edited: " + film.Edited);
                Console.WriteLine("Date created: " + film.Created);
            }
        }
    }
}
