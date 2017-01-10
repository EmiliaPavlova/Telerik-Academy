namespace Generics
{
    using System;
    using System.Linq;
    using Attributes;

    [CurrVersion(2, 11)]
    public class GenericList<T> where T : IComparable
    {
        private const int defaultCapacity = 16;
        private T[] elements;
        private int currIndex = 0;

        public int CurrIndex
        {
            get { return currIndex; }

            set { currIndex = value; }
        }

        public GenericList(int capacity = defaultCapacity)
        {
            elements = new T[capacity];
            currIndex = 0;

        }

        public void Add(T element)
        {
            if (currIndex >= elements.Length)
            {
                Resize();
            }
            elements[currIndex] = element;
            currIndex++;
        }

        public T Min()
        {
            T min = this.elements[0];

            for (int i = 1; i < currIndex; i++)
            {
                T currElement = this.elements[i];
                if (currElement.CompareTo(min) < 0)
                {
                    min = currElement;
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.elements[0];

            for (int i = 1; i < currIndex; i++)
            {
                T currElement = this.elements[i];
                if (currElement.CompareTo(max) > 0)
                {
                    max = currElement;
                }
            }

            return max;
        }

        private void Resize()
        {
            T[] resized = new T[elements.Length * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                resized[i] = elements[i];
            }

            elements = resized;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= currIndex)
            {
                throw new IndexOutOfRangeException(string.Format("Invalid index {0}", index));
            }
        }

        public void Sort()
        {
            bool sort = true;
            while (sort)
            {
                sort = false;
                for (int i = 0; i < currIndex - 1; i++)
                {
                    if (this.elements[i].CompareTo(this.elements[i + 1]) > 0)
                    {
                        T swapper = this.elements[i];
                        this.elements[i] = this.elements[i + 1];
                        this.elements[i + 1] = swapper;
                        sort = true;
                    }
                }
            }
        }

        public int Find(T element)
        {
            for (int i = 0; i < currIndex; i++)
            {
                if (elements[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Reverse()
        {
            var revElemenets = new T[currIndex];
            int index = 0;
            for (int i = currIndex - 1; i >= 0; i--)
            {
                revElemenets[index] = elements[i];
                index++;
            }

            elements = revElemenets;
        }

        public void Remove(T element)
        {
            int emptyIndex = elements.Length;

            for (int i = 0; i < currIndex; i++)
            {
                T currElement = elements[i];
                if (currElement.Equals(element))
                {
                    elements[i] = default(T);
                    emptyIndex = 1;
                }
            }

            if (!emptyIndex.Equals(elements.Length))
            {
                for (int i = emptyIndex; i < currIndex; i++)
                {
                    T tmp = elements[i];
                    elements[i] = elements[i + 1];
                    elements[i + 1] = tmp;
                }
            }
            currIndex++;
        }

        public void Clear()
        {
            for (int i = 0; i < currIndex; i++)
            {
                elements[i] = default(T);
            }
            currIndex = 0;
        }

        public int Count()
        {
            return currIndex;
        }

        public int Capacity()
        {
            return elements.Length;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < currIndex; i++)
            {
                T currElement = this.elements[i];
                if (currElement.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public void Remove(int index)
        {
            ValidateIndex(index);

            elements[index] = default(T);
            for (int i = index; i < currIndex; i++)
            {
                T tmp = elements[i];
                elements[i] = elements[i + 1];
                elements[i + 1] = tmp;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= currIndex)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }

                return elements[index];
            }
            set
            {
                if (index < 0 || index >= currIndex)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                elements[index] = value;
            }
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements.Take(currIndex));
        }
    }
}