namespace Example
{
    using System;
    using StarWarsApiCSharp;

    public class PeopleExample : IExecutor
    {
        public void Execute()
        {
            IRepository<MyPerson> peopleRepo = new Repository<MyPerson>();
            Console.WriteLine("Digite o id para buscar : ");
            int idNum = Convert.ToInt32(Console.ReadLine());
            MyPerson people = peopleRepo.GetById(idNum);

            if (people != null)
            {
                Console.WriteLine(people.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find this person!");
            }
        }
    }
}
