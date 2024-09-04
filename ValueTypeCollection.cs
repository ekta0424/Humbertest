using System;
using System.Collections.Generic;
using System.Linq;

public class ValueTypeCollection<T> where T : struct
{
    // Private generic collection to hold items
    private List<T> _items = new List<T>();

    // Method to add items to the private collection
    public void AddItem(T item)
    {
        _items.Add(item);
    }

    // Method to return an item from the list by index
    public T GetItem(int index)
    {
        if (index < 0 || index >= _items.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        return _items[index];
    }

    // Method that returns a sorted collection with the items in descending order
    public List<T> GetSortedDescending()
    {
        return _items.OrderByDescending(item => item).ToList();
    }
}
