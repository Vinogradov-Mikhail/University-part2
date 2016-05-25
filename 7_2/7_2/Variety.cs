using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2
{
    /// <summary>
    /// class variety with functio add, delete, Intersection and association
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Variety<T>
    {
        private List<T> list;

        public Variety()
        {
            list = new List<T>();
        }

        /// <summary>
        /// add element on variety
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value) => list.Push(value);

        /// <summary>
        /// delete elment from variety
        /// </summary>
        /// <param name="value"></param>
        public void Pop(T value) => list.Pop(value);

        /// <summary>
        /// cheking including element 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Include(T value) => list.Find(value);

        /// <summary>
        /// show all elements of variety
        /// </summary>
        public void Show() => list.Print();

        /// <summary>
        /// return list which element of variety
        /// </summary>
        /// <returns></returns>
        public List<T> Getlist() => list;

        /// <summary>
        /// return emount of elements
        /// </summary>
        /// <returns></returns>
        public int GetEmount() => list.Length();

        /// <summary>
        /// Association of two variety
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public Variety<T> Association(Variety<T> first, Variety<T> second)
        {
            Variety<T> temp = first;
            List<T> tempList = second.Getlist();
            if (second.list != null)
            {
                for (int i = 0; i < tempList.Length(); ++i)
                {
                    if (!temp.Include(tempList.GetElement(i)))
                    {
                        temp.Add(tempList.GetElement(i));
                    }
                }
            }
            return temp;
        }

        /// <summary>
        /// Intersection of two variety
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public Variety<T> Intersection(Variety<T> first, Variety<T> second)
        {
            Variety<T> temp = new Variety<T>();
            List<T> tempList = first.Getlist();
            for (int i = 0; i < tempList.Length(); ++i)
            {
                if (second.Include(tempList.GetElement(i)))
                {
                    temp.Add(tempList.GetElement(i));
                }
            }
            return temp;
        }
    }
}
