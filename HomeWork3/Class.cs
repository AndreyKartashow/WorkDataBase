namespace DataBase
{
    class Class
    {
        public void ScriptClass(int count)
        {
            string text = "";
            string[] numberClass = { "1А", "1Б", "1В", "2А", "2Б", "2В", "3А", "3Б", "3В", "4А", "4Б", "4В", "5А", "5Б", "5В", "6А", "7Б", "7В", "8А", "8Б", "8В", "9А", "9Б", "9В"};
            
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int idClass = random.Next(40000, 50000);
                int idStudent = random.Next(80000, 90000);
                int idTeacher = random.Next(20000, 30000);
                string numClass = numberClass[random.Next(numberClass.Length)];

                text += $"{idClass};{idStudent};{idTeacher};{numClass}\n";
            }

            File.WriteAllText("Class.csv", text);
        }
    }
}