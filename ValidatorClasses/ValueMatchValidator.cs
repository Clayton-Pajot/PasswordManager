using System;
using System.Collections.Generic;
using System.Text;
using FormApp.Classes;

namespace FormApp.ValidatorClasses
{
    public class ValueMatchValidator : ValidatorDecorator
    {

        string pass1;
        string pass2;
        FormComponent component;

        public ValueMatchValidator(FormComponent comp, FormComponent comp2) : base(comp)
        {
            pass1 = comp.GetValue();
            pass2 = comp2.GetValue();
        }

        public override bool IsValid()
        {
            if (pass1 == pass2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error: Passwords do not match");
                return false;
            }
        }
        public override string GetValue()
        {
            return "";
        }
        public override void SetValue(string value)
        {

        }
    }
}
