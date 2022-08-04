namespace DataBase
{
    class Contact
    {
        public void ScriptContact(int count)
        {
            string text = "";
            string[] telephoneComment = { "Сотовый", "Рабочий", "Бабушка", "Мама", "Папа", "Звонить только на этот", "Никогда не отвечают", "Домашний"};
            string[] address = { "Лермонтова", "Пушкина", "Колхозная", "Музыкальная", "Ленина", "Центральная", "Большая", "Южная"};
            
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int idContactData = random.Next(50000, 60000);
                int telephone = random.Next(8000, 9000);
                string comment = telephoneComment[random.Next(telephoneComment.Length)];
                string addressPerson = address[random.Next(address.Length)];
                int numberHome = random.Next(1, 65);

                text += $"{idContactData};{telephone};{comment};{addressPerson};{numberHome}\n";
            }

            File.WriteAllText("Contact.csv", text);
        }
    }
}