using System;
using System.Collections.Generic;
using System.Text;
using FormApp.Classes;

namespace FormApp.FormComponents
{
    public class age : FormComponent
    {
        string value;

        public age(string value)
        {
            this.value = value;
        }


        public bool IsValid()
        {
            return false;
        }
        public string GetValue()
        {
            return value;
        }
        public void SetValue(string valueIn)
        {
            value = valueIn;
        }
        public void AddObserver()
        {

        }
    }
}
