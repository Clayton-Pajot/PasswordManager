using System;
using System.Collections.Generic;
using System.Text;
using FormApp.Classes;

namespace FormApp.FormComponents
{
    public class realname : FormComponent
    {
        string value;
        public realname(string name)
        {
            value = name;
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
