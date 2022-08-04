namespace DataBase
{
    class Represantive
    {
        public void ScriptRepresantive(int count)
        {
            string text = "";
            
            string[] fName = { "Олег", "Владимир", "Петр", "Андрей", "Семен", "Геннадий", "Владислав", "Сергей", "Павел", "Анатолий", "Дмитрий", "Александр"};
            string[] lName = { "Сидоров", "Иванов", "Петров", "Дроздов", "Коршунов", "Зудин", "Семенов", "Власкин", "Казаков", "Дроздов"};
            string[] mName = { "Александрович", "Дмитриевич", "Геннадиевич", "Олегович", "Андреевич", "Анатольевич", "Владимирович", "Петрович"};
            
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int idRepresantive = random.Next(60000, 70000);
                string fNameRepresantive = fName[random.Next(fName.Length)];
                string lNameRepresantive = lName[random.Next(lName.Length)];
                string mNameRepresantive = mName[random.Next(mName.Length)];
                int idContactData = random.Next(50000, 60000);

                text += $"{idRepresantive};{lNameRepresantive};{fNameRepresantive};{mNameRepresantive};{idContactData}\n";
            }

            File.WriteAllText("Represantive.csv", text);
        }
    }
}