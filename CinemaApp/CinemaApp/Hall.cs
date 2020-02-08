namespace CinemaApp
{
    class Hall
    {
        public string Name { get; set; }
        public Seat[,] seats { get; set; }

        public int[] test { get; set; }

        public Hall(int row,int column)
        {
            seats = new Seat[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    seats[i, j] = new Seat(i + 1, j + 1);
                }
            }
        }

        public void GetAllSeat()
        {
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    System.Console.WriteLine(seats[i, j]);
                }
            }
        }

        public void Reserve(int row,int column)
        {
            if(row>seats.GetLength(0) || column > seats.GetLength(1))
            {
                System.Console.WriteLine("Aaaa normal reqemler sech !!!");
                return;
            }

            if (seats[row-1, column-1].Status == "Empty")
            {
                seats[row-1, column-1].Status = "Reserve";
                System.Console.WriteLine("Sizin uchun Rezerv olundu");
            }
            else
            {
                System.Console.WriteLine("Artiq rezerv olunub");
                GetAllSeat();
            }
        }

    }
}
