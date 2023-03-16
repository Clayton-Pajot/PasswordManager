using System;
using System.Collections.Generic;
using System.Text;
using FormApp.ValidatorClasses;
using FormApp.Classes;

namespace FormApp.FormComponents
{
    public class username : FormComponent
    {
        string value;

        public username(string input)
        {
            value = input;
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
