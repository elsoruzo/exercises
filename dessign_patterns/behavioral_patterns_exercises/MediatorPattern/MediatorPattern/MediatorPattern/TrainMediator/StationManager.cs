using System;
using System.Collections.Generic;

namespace DesignPatterns.Mediator.Concrete
{
    class StationManager : ITrainMediator
    {

      private bool _isPlatformFree = false; 
      private Queue<ITrain> _trainQueue = new Queue<ITrain>();

        public StationManager()
        {
            this._isPlatformFree = true;
        } 

        public bool CanArrive(ITrain train) 
        {
          if(_isPlatformFree)
          {
            _isPlatformFree = false;
            return true;
         }
          this._trainQueue.Enqueue(train);
          return false;
        }

        public void NotifyAboutDeparture()
        {
          if(!this._isPlatformFree) 
          {
              this._isPlatformFree = true;
          }

         if(this._trainQueue.Count > 0)
         {
              var firstTrainInQueue = this._trainQueue.Dequeue();          
              firstTrainInQueue.PermitArrival();
         }
        }
    }
}