using System;
using System.Collections.Generic;
using System.Text;
using FormApp.Classes;

namespace FormApp.ValidatorClasses
{
    public class NumberValidator : FormComponent
    {
        public NumberValidator(FormComponent component)
        {

        }

        public bool IsValid()
        {
            
            return true;
        }
        public string GetKey()
        {
            string key = "";

            return key;
        }
        public void SetKey(string key)
        {

        }
        public string GetValue()
        {
            string value = "";

            return value;
        }
        public void SetValue(string value)
        {

        }

    }
}
