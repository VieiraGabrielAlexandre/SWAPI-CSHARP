namespace Example
{
    using System;
    using StarWarsApiCSharp;

    public class PeopleExample2 : IExecutor
    {
        public void Execute()
        {
            
            int pagina = 1;
            int tamanho = 87;
            var peoples = new Repository<Person>();

            var lista = peoples.GetEntities(pagina, tamanho);

            if (lista == null)
            {
                Console.WriteLine("Tem que exibir personagens !");
            }

            foreach (var exibir in lista)
            {
                Console.WriteLine("Nome: " + exibir.Name);
                Console.WriteLine("Quantidade de Filmes: " + exibir.Films.Count);
            }

           
        }
    }
}
