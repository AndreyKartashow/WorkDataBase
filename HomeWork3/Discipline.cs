namespace DataBase
{
    class Discipline
    {
        public void ScriptDiscipline(int count)
        {
            string text = "";
            
            string[] name = { "Математика", "Информатика", "Физика", "Литература", "Русский язый", "Иностранный язык", "История"};
            
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int idDiscipline = random.Next(10000, 20000);
                int plan = random.Next(48, 78);
                int idOccupationDiscipline = random.Next(70000, 80000);
                int idOccupation = random.Next(0, 10000);
                
                text += $"{idDiscipline};{name};{plan};{idOccupationDiscipline};{idOccupation}\n";
            }

            File.WriteAllText("ScriptDiscipline.csv", text);
        }
    }
}