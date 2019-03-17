/*
 * Copyright (c) House of Wire 2017 
 * DataSet 
 * by Danny Gallagher on 22/11/2017
 */

using System.Collections.Generic;
using UnityEngine;

namespace hUtility.GenericDataSet
{
    [CreateAssetMenu(fileName = "NewDataSet", menuName = "Data Set")]
    public class DataSet : ScriptableObject
    {
        #region Interface

        public List<Object> Items = new List<Object>();

        public int Count => Items.Count;

        #endregion
    }
}