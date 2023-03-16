using System;
using System.Collections.Generic;
using System.Text;
using FormApp.Classes;

namespace FormApp.ValidatorClasses
{
    public class OnlyNumValidator : ValidatorDecorator
    {
        string value;
        string test;
        public OnlyNumValidator(FormComponent comp) : base(comp)
        {
            value = comp.GetValue();
        }

        public override bool IsValid()
        {

            bool result = false;
            int temp = 0;

            if(!int.TryParse(value, out temp))
            {
                Console.WriteLine("Error: value entered is not a number.");
                result = false;
            }
            else if(temp <0)
            {
                Console.WriteLine("Error: value entered is not a positive number.");
                result = false;
            }
            else { result = true; }



            return result;
        }
        public override string GetValue()
        {
            string value = "";

            return value;
        }
        public override void SetValue(string value)
        {
            test = value;
        }
    }
}
