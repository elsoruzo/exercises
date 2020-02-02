namespace CarBuilder.Models
{
    public class Car : ICar
    {
        public Car()
        {
        }

        private string _engine { get; set; }
        private int _seats { get; set; }
        private bool _isHasGps { get; set; }
        private bool _isHasTripComputer { get; set; }


        public void SetEngine(string type)
        {
            _engine = type;
        }

        public void SetGps()
        {
            _isHasGps = true;
        }

        public void SetSeats(int amounth)
        {
            _seats = amounth;
        }

        public void SetTripComputer()
        {
            _isHasTripComputer = true;
        }

        public string GetResultingComplectation()
        {
            return $" \n New car is created with params: " +
                $" \n seats amonth: {_seats} " +
                $" \n engine type: {_engine} " +
                $" \n gps is included: {_isHasGps} " +
                $" \n trip computer is included: {_isHasTripComputer} " +
                $" \n ";
        }
    }
}