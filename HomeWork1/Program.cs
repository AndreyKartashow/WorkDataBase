namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько людей вы хотите сгененировать?");
            int countPerson = InputCountPerson();
            Console.WriteLine("Сколько машин вы хотите сгененировать?");
            int countTransport = InputCountPerson();

            Person person = new Person();
            Transport transport = new Transport();

            person.ScriptPerson(countPerson);
            transport.ScriptTransport(countTransport);
        }

        private static int InputCountPerson()
        {
            try
            {
                int countPerson = int.Parse(Console.ReadLine());
                return countPerson;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Вы ввели неверные данные, попробуйте еще раз");
                return InputCountPerson();
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели неверные данные, попробуйте еще раз");
                return InputCountPerson();
            }
        }
    }
}