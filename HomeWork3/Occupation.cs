namespace DataBase
{
    class Occupation
    {
        public void ScriptOccupation(int count)
        {
            string text = "";
            
            DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25); 

            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int idOccupation = random.Next(0, 10000);
                int idDiscipline = random.Next(10000, 20000);
                int idTeacher = random.Next(20000, 30000);
                int idCabinet = random.Next(30000, 40000);
                int idClass = random.Next(40000, 50000); 
                                
                text += $"{idOccupation};{idDiscipline};{idTeacher};{idCabinet};{idClass};{date1.AddDays(i)};{date1.AddHours(i)}\n";
            }

            File.WriteAllText("ScriptOccupation.csv", text);
        }
    }
}