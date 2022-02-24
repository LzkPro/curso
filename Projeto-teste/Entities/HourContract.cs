using System;
namespace Projeto_teste.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {

        }
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
