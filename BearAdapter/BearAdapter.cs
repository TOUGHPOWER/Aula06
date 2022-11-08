using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearAdapter
{
    public class BearAdapter:IDog
    {
        private IBear bear;
        public void Bark()
        {
            bear.Roar();
        }
        public void Fetch(object objectToFetch)
        {
            bear.GoTowards(objectToFetch);
            bear.TryEat(objectToFetch);
        }

        public BearAdapter(IBear theBear)
        {
            bear = theBear;
        }
    }
}