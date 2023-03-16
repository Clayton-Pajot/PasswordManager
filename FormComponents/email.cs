using System;
using System.Collections.Generic;
using System.Text;
using FormApp.Classes;

namespace FormApp.FormComponents
{
    public class email : FormComponent
    {
        string value;
        public email(string email)
        {
            value = email;
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
