using System;
using System.Collections.Generic;
using System.Text;

namespace FormApp.Classes
{
    public interface FormComponent
    {
        bool IsValid();
        string GetValue();
        void SetValue(string value);
    }
}

//public bool IsValid()
//{
//    return false;
//}
//public string GetKey()
//{
//    return "";
//}
//public void SetKey(string key)
//{

//}
//public string GetValue()
//{
//    return "";
//}
//public void SetValue(string value)
//{

//}




















