namespace Example
{
    using System;
    using StarWarsApiCSharp;

    public class MyPerson : Person
    {
        public override string ToString()
        {
            return this.Name + Environment.NewLine +
                "Ano de Nascimento: " + this.BirthYear + Environment.NewLine +
                "Filmes: " + this.Films.Count; 
        }
    }
}
