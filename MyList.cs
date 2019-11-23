using System;
using System.Collections;
using System.Collections.Generic;

public class List<T> : ICollection<T>, IList<T>, IEnumerable
{
    public T this[int index]
    {
        get {
            return a[index];
            }
        set
        {
            a[index] = value;
        }
    }

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    T[] a;

    public List ()
    {
        a = new T[0];
    }

    public void Add(T item)
    {
        int len = a.Length + 1;
        a = new T[len];
        a[len - 1] = item;
    }

    //public void GetEnumerator()
    //{
    //    throw new NotImplementedException();
    //}

    public void Clear()
    {
        a = new T[0];
    }

    public bool Contains(T item)
    {
       for (int i =0; i<a.Length; i++)
        {
            if (a[i].Equals(item))
                return true;
        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    //public IEnumcerator<T> GetEnumerator()
    //{
     //   return (IEnumcerator)a.GetEnumerator();
    //}

    public int IndexOf(T item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, T item)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((ICollection<T>)a).GetEnumerator();
    }
}