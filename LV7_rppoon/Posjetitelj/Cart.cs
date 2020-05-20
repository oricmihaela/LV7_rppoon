using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_rppoon.Posjetitelj
{
    class Cart : IVisitor
    {
        private List<IItem> collection;
      
        public Cart(List<IItem> itemsList)
        {
            collection = new List<IItem>(itemsList);
        }
        public void AddItem(IItem newItem)
        {
            collection.Add(newItem);
        }
        public void RemoveItem(IItem oldItem)
        {
            for (int i = 0; i < collection.Count(); i++)
            {
                if (collection[i] == oldItem)
                {
                    collection.RemoveAt(i);
                }
            }
        }

        //u prošlom zadatku sam za posjetitelja napravila novu klasu, tako da sada nije potrebno mijenjati ju
        //da bi cijene bile jednake prodajnoj, nego samo koristim BuyVisitor

        public double Accept(BuyVisitor visitor)
        {
            double sum = 0;
            for(int i = 0; i < collection.Count; i++)
            {
                collection[i].Accept(visitor);
                sum += visitor.Visit(collection[i]);
            }
            return sum;
        }
    }
}
