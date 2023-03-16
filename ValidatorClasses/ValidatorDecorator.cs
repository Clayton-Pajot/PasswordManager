using System;
using System.Collections.Generic;
using System.Text;
using FormApp.Classes;

namespace FormApp.ValidatorClasses
{
    public abstract class ValidatorDecorator : FormComponent
    {
        protected FormComponent component; 
        public ValidatorDecorator(FormComponent decorated)
        {
            component = decorated;
        }
        public abstract bool IsValid();
        public abstract string GetValue();
        public abstract void SetValue(string value);
    }
}
