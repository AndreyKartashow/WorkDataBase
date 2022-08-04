namespace DataBase
{
    class Student
    {
        public void ScriptStudent(int count)
        {
            string text = "";
            
            string[] fName = { "Олег", "Владимир", "Петр", "Андрей", "Семен", "Геннадий", "Владислав", "Сергей", "Павел", "Анатолий", "Дмитрий", "Александр"};
            string[] lName = { "Сидоров", "Иванов", "Петров", "Дроздов", "Коршунов", "Зудин", "Семенов", "Власкин", "Казаков", "Дроздов"};
            string[] mName = { "Александрович", "Дмитриевич", "Геннадиевич", "Олегович", "Андреевич", "Анатольевич", "Владимирович", "Петрович"};
            
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int idStudent = random.Next(80000, 90000);
                string fNameStudent = fName[random.Next(fName.Length)];
                string lNameStudent = lName[random.Next(lName.Length)];
                string mNameStudent = mName[random.Next(mName.Length)];
                int idClass = random.Next(40000, 50000);
                int idRepresantive = random.Next(60000, 70000);

                text += $"{idStudent};{lNameStudent};{fNameStudent};{mNameStudent};{idClass};{idRepresantive}\n";
            }

            File.WriteAllText("Student.csv", text);
        }
    }
}