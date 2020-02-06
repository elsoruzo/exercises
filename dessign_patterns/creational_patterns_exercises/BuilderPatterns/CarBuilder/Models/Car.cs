namespace CarBuilder.Models
{
    public class Car : ICar
    {
        public string Engine { get; set; }
        public int Seats { get; set; }
        public bool IsHasGps { get; set; }
        public bool IsHasTripComputer { get; set; }

        public override string ToString()
        {
            return $" \n New car is created with params: " +
                $" \n seats amonth: {Seats} " +
                $" \n engine type: {Engine} " +
                $" \n gps is included: {IsHasGps} " +
                $" \n trip computer is included: {IsHasTripComputer} " +
                $" \n ";
        }
    }
}