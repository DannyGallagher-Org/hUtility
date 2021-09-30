using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace hUtility.ScriptableVariables.Strings
{
    [Serializable]
    [CreateAssetMenu(fileName = "NewStringVar", menuName = "DataVariables/String")]
    public class StringVariable : ScriptableObject, INotifyPropertyChanged
    {
        private string _value;

        public string Value
        {
            set
            {
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