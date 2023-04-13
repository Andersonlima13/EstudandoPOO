using System;

public class DynamicArray
{
    int size;
    int capacity = 10;
    Object[] array;

    public DynamicArray()
    {
        this.array = new Object[capacity];

    }

    public DynamicArray(int capacity)
    {
        this.capacity = capacity;
        this.array = new Object[capacity];
    }


    public void add(Object data)
    {
        if(size >= capacity){
            grow();                         
        }
        array[size] = data;
        size++;
    }

    public void delete(Object data)
    {

    }
    

    public void insert(int index, Object data)
    {

    }

    public int search(Object data)
    {
        return -1;
    }

    private void grow()
    {

    }

    private void shrink(Object data)
    {

    }

    public bool isEmpty()
    {
        return size == 0;        
    }


}