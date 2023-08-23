namespace tilmeldingssystemetNY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanser af person klassen:

            Person person1 = new Person(1, "Louise", "Roskilde", "Roskilde patrulje", DateTime.Parse("19/02/1999"), true);

            Console.WriteLine(person1);

            Person person2 = new Person(2, "Mahmoud", "Vanløse", "Vanløse patrulje", DateTime.Parse("10/02/1998"), false);

            Console.WriteLine(person2);

        }
    }
}