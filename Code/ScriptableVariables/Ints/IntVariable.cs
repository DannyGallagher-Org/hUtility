using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace hUtility.ScriptableVariables.Ints
{
    [CreateAssetMenu(fileName = "NewIntVar", menuName = "DataVariables/Int")]
    public class IntVariable : ScriptableObject, INotifyPropertyChanged
    {
        private int _value;

        public int Value
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