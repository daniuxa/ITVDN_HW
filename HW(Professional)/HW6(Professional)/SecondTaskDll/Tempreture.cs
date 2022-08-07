namespace SecondTaskDll
{
    internal class Tempreture
    {
        public double CurrentTempreture { get; set; }
        public Tempreture(double temp)
        {
            CurrentTempreture = temp;
        }

        public double GetTemp()
        {
            return CurrentTempreture;
        }
    }
}