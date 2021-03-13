using System;
using System.Collections.Generic;

namespace DesignPatterns.Memento.Practical
{
    public class CaretakerPractical
    {
    private List<MementoPractical> _mementos;
    public CaretakerPractical(List<MementoPractical> mementos)
    {
        _mementos = mementos;
    }
    public void AddMemento(MementoPractical memento) 
    {
        _mementos.Add(memento);
    }

    public MementoPractical GetMenento(int index)
    {
        return _mementos[index];
    }
  }
}