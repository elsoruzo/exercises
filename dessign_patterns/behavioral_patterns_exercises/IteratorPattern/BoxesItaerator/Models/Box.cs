using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxesIterator.Models
{
    public class Box : IEnumerable<Item>
    {
        public List<Box> BoxCollection { get; set; }

        public List<Item> ItemCollection { get; set; }
        public IEnumerator<Item> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<Item>)GetEnumerator();
        }
    }
}
