namespace Example
{
    using System;
    using StarWarsApiCSharp;

    public class MyPersonAll : PersonAll
    {
        public override string ToString()
        {
            return this.Name + Environment.NewLine +
                "Ano de Nascimento: " + this.BirthYear + Environment.NewLine +
                "Filmes: " + this.Films.Count;
        }
    }
}