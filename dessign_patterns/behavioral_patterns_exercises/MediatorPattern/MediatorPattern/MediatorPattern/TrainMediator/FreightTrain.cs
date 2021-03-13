using System;

namespace DesignPatterns.Mediator.Concrete
{
    public class FreightTrain : ITrain
    {
      private ITrainMediator _mediator;
      public FreightTrain(ITrainMediator mediator)
      {
        this._mediator = mediator; 
      }

      public void Arrive()
      {
          if (!this._mediator.CanArrive(this))
           {
              Console.WriteLine("FreightTrain: Arrival blocked, waiting");
              return;
            }

          Console.WriteLine("FreightTrain: Arrived");
      }

       public void Depart()
        {
            Console.WriteLine("FreightTrain: Leaving");
            this._mediator.NotifyAboutDeparture();
        }

      public void PermitArrival()
      {
            Console.WriteLine("FreightTrain: Arrival permitted, arriving");
            this.Arrive();
      }
    }
}