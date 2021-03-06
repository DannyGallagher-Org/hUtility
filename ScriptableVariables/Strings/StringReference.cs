﻿using System;

namespace hUtility.ScriptableVariables.Strings
{
    [Serializable]
    public class StringReference
    {
        public bool UseConstant = true;
        public string ConstantValue;
        public StringVariable Variable;

        public string Value => UseConstant ? ConstantValue : Variable.Value;
    }
}