﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ChatApplication
{
    public class MessageStack<T>
    {
        private int count;
        private int size;
        private T[] arr;

        public MessageStack()
        {
            size = 10;
            count = 0;
            arr = new T[size];
        }

        public int Length()
        {
            return count;
        }

        public void Push(T val)
        {
            if (count == size)
                Expand();
            arr[count] = val;
            count++;
        }

        public void Pop()
        {
            Debug.Assert(!Empty());
            count--;
        }

        public T Top()
        {
            Debug.Assert(!Empty());
            return arr[count - 1];
        }

        public Boolean Empty()
        {
            return (count == 0);
        }

        public void Expand()
        {
            size += 5;
            T[] tmp = new T[size];
            for (int i = 0; i < count; i++)
                tmp[i] = arr[i];

            arr = tmp;
        }

       
        public void Undo()
        {
            for (int i = count - 1; i < Length(); i++)
            {

            }
        }
        //Message STack add this function
        public T[] ViewAll()
        {
            return arr;
        }

       
    }
}
