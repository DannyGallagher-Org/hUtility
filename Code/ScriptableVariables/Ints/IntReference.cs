using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using System;

namespace hUtility.ScriptableVariables.Ints
{
    [Serializable]
    public class IntReference : INotifyPropertyChanged
    {
        public bool UseConstant = true;
        public int ConstantValue;
        public IntVariable Variable;

        public int Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
            set
            {
                if (UseConstant)
                    ConstantValue = value;
                else
                    Variable.Value = value;
                
                OnPropertyChanged(ToString());
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}