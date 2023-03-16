using System;
using System.Collections.Generic;
using System.Text;
using FormApp.Classes;

namespace FormApp.FormComponents
{
    public class password : FormComponent
    {
        string value;
        public password(string password)
        {
            value = password;   
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
