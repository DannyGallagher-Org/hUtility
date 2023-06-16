using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using System;

namespace hUtility.ScriptableVariables.Bools
{
    [Serializable]
    public class BoolReference : INotifyPropertyChanged
    {
        public bool UseConstant = true;
        public bool ConstantValue;
        public BoolVariable Variable;

        public bool Value
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