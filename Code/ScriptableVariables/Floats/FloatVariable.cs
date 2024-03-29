﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace hUtility.ScriptableVariables.Floats
{
    [CreateAssetMenu(fileName = "NewFloatVar", menuName = "DataVariables/Float")]
    public class FloatVariable : ScriptableObject, INotifyPropertyChanged
    {
        [SerializeField] private float value;
        private float _value;
        
        public float Value
        {
            set
            {
                this.value = value;
                _value = value;
                OnPropertyChanged(ToString());
            }
            get => _value;
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}