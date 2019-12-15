using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures.SLinkedListModel
{
    class SLinkedListItem<T>
    {
        private T data = default(T);

        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }
        public SLinkedListItem<T> Next { get; set; }


        public SLinkedListItem(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
