using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace hUtility.ScriptableVariables.Bools
{
    [CreateAssetMenu(fileName = "NewBoolVar", menuName = "DataVariables/Bool")]
    public class BoolVariable : ScriptableObject, INotifyPropertyChanged
    {
        [SerializeField] private bool value;
        private bool _value;

        public bool Value
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