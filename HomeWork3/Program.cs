namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Создание каждой сущности можно так же внести в контрольный метод создания сущности для сокращения кода
            Discipline discipline = new Discipline();
            Console.WriteLine("Сколько учебных дисциплин вы хотите зарегистрировать?");
            int countDiscipline = InputCountObject();
            discipline.ScriptDiscipline(countDiscipline);
            
            Occupation occupation = new Occupation();
            Console.WriteLine("Сколько учебных занятий вы хотите зарегистрировать?");
            int countOccupation = InputCountObject();
            occupation.ScriptOccupation(countOccupation);

            Places places = new Places();
            Console.WriteLine("Сколько учебных мест вы хотите зарегистрировать?");
            int countPlaces = InputCountObject();
            places.ScriptPlaces(countPlaces);

            Student student = new Student();
            Console.WriteLine("Сколько учеников вы хотите зарегистрировать?");
            int countStudent = InputCountObject();
            student.ScriptStudent(countStudent);

            Class classStudent = new Class();
            Console.WriteLine("Сколько учебных классов вы хотите зарегистрировать?");
            int countClass = InputCountObject();
            classStudent.ScriptClass(countClass);

            
            Teacher teacher = new Teacher();
            Console.WriteLine("Сколько преподавателей вы хотите зарегистрировать?");
            int countTeacher = InputCountObject();
            teacher.ScriptTeacher(countTeacher);

            DisTeach disciplinTeacher = new DisTeach();
            disciplinTeacher.ScriptDisTeach((countDiscipline + countTeacher) / 2);

            Contact contact = new Contact();
            Console.WriteLine("Сколько контактных данных вы хотите зарегистрировать?");
            int countContact = InputCountObject();
            contact.ScriptContact(countContact);

            Represantive represantive = new Represantive();
            Console.WriteLine("Сколько представителей учеников вы хотите зарегистрировать?");
            int countRepresantive = InputCountObject();
            represantive.ScriptRepresantive(countRepresantive);
            
        }

        private static int InputCountObject()
        {
            try
            {
                int countPerson = int.Parse(Console.ReadLine());
                return countPerson;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Вы ввели неверные данные, попробуйте еще раз");
                return InputCountObject();
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели неверные данные, попробуйте еще раз");
                return InputCountObject();
            }
        }
    }
}


