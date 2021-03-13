using System;

namespace DesignPatterns.Mediator.Concrete
{
    public interface ITrain
    {
      void Arrive();
      void Depart();
      void PermitArrival();
    }
}