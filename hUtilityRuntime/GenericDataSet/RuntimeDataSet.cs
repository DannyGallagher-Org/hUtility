/*
 * Copyright (c) House of Wire 2017 
 * DataSet 
 * by Danny Gallagher on 22/11/2017
 */

using System.Collections.Generic;
using UnityEngine;

namespace hUtilityRuntime.GenericDataSet
{
    [CreateAssetMenu(fileName = "NewRTDataSet", menuName = "RT Data Set")]
    public class RuntimeDataSet<T> : ScriptableObject
    {
        #region Interface

        public List<T> Items { get; } = new List<T>();

        public int Count => Items.Count;

        #endregion

        #region Public Methods

        public void Add(T item)
        {
            Items.Add(item);
        }

        public void Remove(T item)
        {
            Items.Remove(item);
        }

        #endregion
    }
}