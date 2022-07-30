namespace DataBase
{
    class Person
    {
        public void ScriptPerson(int count)
        {
            string text = "id Паспорт; Имя; Фамилия; Отчество; Год рождения; Адрес проживания; Должность;\n";
            
            string[] fName = { "Олег", "Владимир", "Петр", "Андрей", "Семен", "Геннадий", "Владислав", "Сергей", "Павел", "Анатолий", "Дмитрий", "Александр"};
            string[] lName = { "Сидоров", "Иванов", "Петров", "Дроздов", "Коршунов", "Зудин", "Семенов", "Власкин", "Казаков", "Дроздов"};
            string[] mName = { "Александрович", "Дмитриевич", "Геннадиевич", "Олегович", "Андреевич", "Анатольевич", "Владимирович", "Петрович",};
            string[] yearBirth = { "10.12.1995", "15.06.1994", "24.06.1990", "16.07.1996", "07.01.1992", "13.04.1998", "04.03.1995", "28.09.1996"};
            string[] address = { "Лермонтова", "Пушкина", "Колхозная", "Музыкальная", "Ленина", "Центральная", "Большая", "Южная"};
            string[] job = { "Водитель", "Кондуктор", "Диспетчер"};

            Random random = new Random();
            for (int i = 1; i <= count; i++)
            {
                int pasportPerson = random.Next(400000, 500000);
                string fNamePerson = fName[random.Next(fName.Length)];
                string lNamePerson = lName[random.Next(lName.Length)];
                string mNamePerson = mName[random.Next(mName.Length)];
                string yearBirthPerson = yearBirth[random.Next(yearBirth.Length)];
                string addressPerson = address[random.Next(address.Length)];
                string jobPerson = job[random.Next(job.Length)];
                text += $"{pasportPerson};{fNamePerson};{lNamePerson};{mNamePerson};{addressPerson};{jobPerson};\n";
            }

            File.WriteAllText("person.csv", text);
        }
    }
}