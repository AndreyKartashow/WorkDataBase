namespace DataBase
{
    class Transport
    {
        public void ScriptTransport(int count)
        {
            string text = "id Транспорт; Вид ТС; Гос номер; Всего мест; Номер ТО; id маршрута; id парка;\n";
            
            string[] view = { "Автобус", "Троллейбус"};
            string[] gNumber = { "Сидоров", "Иванов", "Петров", "Дроздов", "Коршунов", "Зудин", "Семенов", "Власкин", "Казаков", "Дроздов"};
            string[] address = { "Лермонтова", "Пушкина", "Колхозная", "Музыкальная", "Ленина", "Центральная", "Большая", "Южная"};
            string[] job = { "Водитель", "Кондуктор", "Диспетчер"};

            Random random = new Random();
            for (int i = 1; i <= count; i++)
            {
                int numberTransport = random.Next(600000, 700000);
                string viewTransport = view[random.Next(view.Length)];
                string gNumberTransport = gNumber[random.Next(gNumber.Length)];

                int place = random.Next(20, 30);
                int numberInspection = random.Next(3000, 4000);
                int route = random.Next(100);
                int park = random.Next(300, 400);
                text += $"{numberTransport};{viewTransport};{gNumberTransport};{place};{numberInspection};{route};{park};\n";
            }

            File.WriteAllText("transport.csv", text);
        }
    }
}