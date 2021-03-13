using System;
using System.Collections.Generic;

namespace DesignPatterns.Memento.Practical
{
    public class OriginatorPractical
    {
    private MementoPractical _state;
    public OriginatorPractical(MementoPractical state)
    {
        _state = state;
    }

    public MementoPractical CreateMemento()
    {
        return new MementoPractical(_state.GetSavedState());
    }

    public void Restorememento(MementoPractical state) 
    {
      _state = state;
    }

    public void SetState(MementoPractical state)
    {
      _state = state;
    }

    public string GetState()
    {
      return _state.GetSavedState();
    }
  }
}