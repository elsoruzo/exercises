using System;


namespace DesignPatterns.Memento.Practical
{
    public class MementoPractical
    {
    private string _state;
    public MementoPractical(string state)
    {
        _state = state;
    }

    public string GetSavedState()
    {
      return _state;
    }
  }
}