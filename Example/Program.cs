﻿namespace Example
{
    using System;
    using System.Linq;
    using ServiceDemo;
    using StarWarsApiCSharp;

    public class Program
    {
        public static void Main(string[] args)
        {
            IRepository<Planet> planetsRepo = new Repository<Planet>();
            IRepository<Vehicle> vehicleRepo = new Repository<Vehicle>();
            IRepository<Specie> speciesRepo = new Repository<Specie>();

            ConsoleColor backgroundColor = ConsoleColor.DarkBlue;
            string template = "Pressione [Enter] para processar {0}";

            //Não apagar os campos abaixo pois deu um trabalhoooo ...

            //ProcessExecuteCommand(new FilmsFromFileDemo(), template, "Another service", backgroundColor);
            //ProcessExecuteCommand(new FilmsExample(), template, "Films", backgroundColor);
            //ProcessExecuteCommand(new StarshipsExample(), template, "Starhips", backgroundColor);
            ProcessExecuteCommand(new PeopleExample2(),template, "Lista dos Personagens", backgroundColor);
            Console.WriteLine("---------------\n--Pressione enter para avançar !--\n");
            Console.ReadLine();
            ProcessExecuteCommand(new PeopleExample(), template, "Pesquisa por ID", backgroundColor);
            Console.WriteLine("---------------\n--Pressione enter para avançar !--\n");
            Console.ReadLine();
            //ProcessExecuteCommand(new PlanetsExample(), template, "Planets", backgroundColor);
            ProcessExecuteCommand(new SpeciesExample(), template, "Humanos", backgroundColor);
            Console.WriteLine("---------------\n--Pressione enter para avançar !--\n");
            Console.ReadLine();
            //ProcessExecuteCommand(new VehiclesExample(), template, "Vehicles", backgroundColor);
        }

        private static void ProcessExecuteCommand(
            IExecutor executor,
            string template, 
            string typeName,
            ConsoleColor backgroundColor)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(template, typeName);
            Console.BackgroundColor = defaultColor;
            Console.ReadLine();

            executor.Execute();
        }
    }
}
