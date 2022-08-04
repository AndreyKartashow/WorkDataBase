namespace DataBase
{
    class Teacher
    {
        public void ScriptTeacher(int count)
        {
            string text = "";
            
            string[] fName = { "Олег", "Владимир", "Петр", "Андрей", "Семен", "Геннадий", "Владислав", "Сергей", "Павел", "Анатолий", "Дмитрий", "Александр"};
            string[] lName = { "Сидоров", "Иванов", "Петров", "Дроздов", "Коршунов", "Зудин", "Семенов", "Власкин", "Казаков", "Дроздов"};
            string[] mName = { "Александрович", "Дмитриевич", "Геннадиевич", "Олегович", "Андреевич", "Анатольевич", "Владимирович", "Петрович"};
            
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int idTeacher = random.Next(20000, 30000);
                string fNameTeacher = fName[random.Next(fName.Length)];
                string lNameTeacher = lName[random.Next(lName.Length)];
                string mNameTeacher = mName[random.Next(mName.Length)];
                int idClass = random.Next(40000, 50000);
                int idDisTeach = random.Next(70000, 80000);
                int idContactData = random.Next(50000, 60000);

                text += $"{idTeacher};{lNameTeacher};{fNameTeacher};{mNameTeacher};{idClass};{idDisTeach};{idContactData}\n";
            }

            File.WriteAllText("Teacher.csv", text);
        }
    }
}