using System;

namespace DesignPatterns.Mediator.Concrete
{
    public interface ITrainMediator
    {
       bool CanArrive(ITrain trian); 
       void NotifyAboutDeparture();
    }
}