namespace DataBase
{
    class Places
    {
        public void ScriptPlaces(int count)
        {
            string text = "";

            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int idCabinet = random.Next(30000, 40000);
                int idOccupation = random.Next(0, 10000);
                int idStudent = random.Next(80000, 90000);
                int row = random.Next(1, 5);
                int idTable = random.Next(1, 10);
                int idVariante = random.Next(1, 3);
                                
                text += $"{idCabinet};{idOccupation};{idStudent};{row};{idTable};{idVariante}\n";
            }

            File.WriteAllText("Places.csv", text);
        }
    }
}