using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
    public class ObjectPool<T>
    {
        private Stack<T> _Available;
        private HashSet<T> _Leased;

        private Func<T> _Create;
        private Action<T> _Lease;
        private Action<T> _Return;

        private void CreateNewObject()
        {
            _Available.Push(_Create());
        }

        public T Get()
        {
            if (_Available.Count == 0)
            {
                CreateNewObject();
            }
            var obj = _Available.Pop();
            _Leased.Add(obj);
            _Lease(obj);
            return obj;
        }

        public void Return(T obj)
        {
            if (!_Leased.Remove(obj))
            {
                Debug.LogWarning("Attempted to return object that was not leased by pool.");
                return;
            }
            _Return(obj);
            _Available.Push(obj);
        }
        
        public ObjectPool(int initialCapacity, Func<T> create, Action<T> lease, Action<T> release)
        {
            _Create = create;
            _Lease = lease;
            _Return = release;
            _Available = new Stack<T>(initialCapacity);
            _Leased = new HashSet<T>();
            for (var i = 0; i < initialCapacity; i++)
            {
                CreateNewObject();
            }
        }
    }
}
