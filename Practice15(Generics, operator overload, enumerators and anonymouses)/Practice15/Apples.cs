using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice15
{
    class Apples : IEnumerable
    {
        private List<Apple> appleList = new List<Apple>();

        public Apples(List<Apple> list)
        {
            appleList = list;
        }

        public Apples()
        {
            
        }

        public Apple this[int index]
        {
            get { return (Apple)appleList[index]; }
            set { appleList.Insert(index, value); }           
        }

        public void Add(Apple item)
        {
            appleList.Add(item);
        }

        public int Count
        {
            get
            {
                return appleList.Count;
            }
        }

        public IEnumerable<TResult> Select<TResult>(Func<Apple, TResult> selector)
        {
            foreach (var item in appleList)
            {
                yield return selector(item);
            }
        }

        public IEnumerable<Apple> OrderBy<TKey>(Func<Apple, TKey> keySelector)
        {
            return appleList.OrderBy(keySelector);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return appleList.GetEnumerator();
        }
    }
}