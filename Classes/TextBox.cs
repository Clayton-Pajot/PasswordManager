using System;
using System.Collections.Generic;
using System.Text;

namespace FormApp.Classes
{
    public class TextBox : FormComponent
    {
        String _value = "";

        public TextBox(String input)
        {
            _value = input;
        }

        public bool IsValid()
        {
            return false;
        }
        public string GetKey()
        {
            return "";
        }
        public void SetKey(string key)
        {

        }
        public string GetValue()
        {
            return "";
        }
        public void SetValue(string value)
        {

        }

    }
}
