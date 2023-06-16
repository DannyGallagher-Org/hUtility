using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using System;

namespace hUtility.ScriptableVariables.Floats
{
    [Serializable]
    public class FloatReference : INotifyPropertyChanged
    {
        public bool UseConstant = true;
        public float ConstantValue;
        public FloatVariable Variable;

        public float Value
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