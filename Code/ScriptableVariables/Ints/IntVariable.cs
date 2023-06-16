using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace hUtility.ScriptableVariables.Ints
{
    [CreateAssetMenu(fileName = "NewIntVar", menuName = "DataVariables/Int")]
    public class IntVariable: ScriptableObject, INotifyPropertyChanged
    {
        [SerializeField] private int value;
        private int _value;
        
        public int Value
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