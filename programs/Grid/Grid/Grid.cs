using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Grid
{
    public class Grid<T>
    {
        private T[,] data;

        public int Width { get; private set; }
        public int Height { get; private set; }

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
            data = new T[width, height];
        }

        public Grid(int width, int height, T value) : this(width, height)
        {
            SetAll(value);
        }

        public Grid(int width, int height, List<T> items) : this(width, height)
        {
            int copySize = Math.Min(width*height, items.Count);
            for (int i = 0; i < copySize; i++)
            {
                int x = i%width;
                int y = i/width;
                data[x, y] = items[i];
            }
        }

        public T Get(int x, int y)
        {
            return data[x, y];
        }

        public void Set(int x, int y, T value)
        {
            data[x, y] = value;
        }

        public List<T> GetItemsInRect(int x1, int y1, int x2, int y2)
        {
            List<T> list = new List<T>();
            for (int x = x1; x <= x2; x++)
            {
                for (int y = y1; y <= y2; y++)
                {
                    list.Add(data[x, y]);
                }
            }
            return list;
        }

        public void SetItemsInRect(int x1, int y1, int x2, int y2, T value)
        {
            for (int x = x1; x <= x2; x++)
            {
                for (int y = y1; y <= y2; y++)
                {
                    data[x, y] = value;
                }
            }
        }

        public List<T> ToList()
        {
            return GetItemsInRect(0, 0, Width - 1, Height - 1);
        }

        public void SetAll(T value)
        {
            SetItemsInRect(0, 0, Width - 1, Height - 1, value);
        }
    }
}