using System;

namespace DesignPatterns.Mediator.Concrete
{
    public class PassengerTrain : ITrain
    {
      private ITrainMediator _mediator;
      public PassengerTrain(ITrainMediator mediator)
      {
        this._mediator = mediator; 
      }

      public void Arrive()
      {
          if (!this._mediator.CanArrive(this))
           {
              Console.WriteLine("PassengerTrain: Arrival blocked, waiting");
              return;
            }

          Console.WriteLine("PassengerTrain: Arrived");
      }

       public void Depart()
        {
            Console.WriteLine("PassengerTrain: Leaving");
            this._mediator.NotifyAboutDeparture();
        }

      public void PermitArrival()
      {
            Console.WriteLine("PassengerTrain: Arrival permitted, arriving");
            this.Arrive();
      }
    }
}