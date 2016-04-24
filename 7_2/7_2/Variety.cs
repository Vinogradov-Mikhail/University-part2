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

        public Variety(T value)
        {
            list = new List<T>(value);
        }

        /// <summary>
        /// add element on variety
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value) => list.Push(value);

        /// <summary>
        /// delete element from variety
        /// </summary>
        /// <param name="value"></param>
        public void Delete(T value) => list.Pop(value);

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
        /// Association of two variety
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public Variety<T> Association(Variety<T> first, Variety<T> second)
        {
            Variety<T> temp = first;
            List<T> tempList = second.Getlist();
            foreach(T elem in tempList)
            {
                if(!temp.Include(elem))
                {
                    temp.Add(elem);
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
            Variety<T> temp = first;
            List<T> tempList = temp.Getlist();
            foreach (T elem in tempList)
            {
                if (!second.Include(elem))
                {
                    temp.Delete(elem);
                }
            }
            return temp;
        }
    }
}
