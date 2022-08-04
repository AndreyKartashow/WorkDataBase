namespace DataBase
{
    class DisTeach
    {
        public void ScriptDisTeach(int count)
        {
            string text = "";
            
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int idDisTeach = random.Next(70000, 80000);
                int idDiscipline = random.Next(10000, 20000);
                int idTeacher = random.Next(20000, 30000);

                text += $"{idDisTeach};{idDiscipline};{idTeacher}\n";
            }

            File.WriteAllText("DisTeach.csv", text);
        }
    }
}