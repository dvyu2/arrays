using System;
using System.Collections;
using System.Collections.Generic;

public class List<T> : ICollection<T>, IList<T>, IEnumerable
{
    public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => throw new NotImplementedException();

    T[] a;

    public List ()
    {
        a = new T[1];
    }

    public void Add(T item)
    {
        //int l = a.Length+1;
        /*try
        {
            l = a.Length;
        }
        catch
        {
            l = 0;
        }
        Console.Write("Length of array is " + l);
        //a = new T[l+1];
        a[l] = item;*/
        //a = new T[1];
        a[a.Length-1] = item;
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

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
}