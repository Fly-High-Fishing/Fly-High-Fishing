using System;
using Unity.Collections;

namespace Utility
{
    /// <summary>
    /// Dynamically resizing wrapper around Unity's NativeArray<T>
    /// </summary>
    public class NativeList<T> where T : struct
    {
        private const int _BaseCapacity = 8;
        
        private NativeArray<T> _Data;
        public NativeArray<T> UnderlyingArray => _Data;
        public int Count { get; private set; }
        private int _Capacity;
        public int Capacity
        {
            get => _Capacity;
            set
            {
                Resize(Math.Max(value, _BaseCapacity));
                _Capacity = value;
            }
        }

        private void Resize(int size)
        {
            _Data.Dispose();
            _Data = new NativeArray<T>(size, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
        }

        public void Add(in T value)
        {
            if (Count == _Capacity) Capacity *= 2;
            _Data[Count] = value;
            Count++;
        }

        public void RemoveAt(int index)
        {
            if (Count < index) throw new IndexOutOfRangeException();
            Count--;
            for (var i = index; i < Count - 1; i++)
            {
                _Data[i] = _Data[i + 1];
            }
        }
        
        public T this[int key]
        {
            get
            {
                if (key >= Count) throw new IndexOutOfRangeException();
                return _Data[key];
            }
            set 
            {
                if (key >= Count) throw new IndexOutOfRangeException();
                _Data[key] = value;
            }
        }

        public NativeList()
        {
            _Data = new NativeArray<T>(_BaseCapacity, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
            _Capacity = _BaseCapacity;
        }
        public NativeList(int capacity)
        {
            _Data = new NativeArray<T>(capacity, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
            _Capacity = capacity;
        }

        public void Dispose()
        {
            _Data.Dispose();
        }
    }
}