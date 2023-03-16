using System;
using System.Collections.Generic;
using System.Text;
using FormApp.Classes;

namespace FormApp.ValidatorClasses
{
    public class LengthValidator : ValidatorDecorator
    {
        //FormComponent component;
        string input;
        int maxLength = 50;
        int minLength = 2;

        public LengthValidator(FormComponent comp) : base(comp)  {
            input = comp.GetValue();
        }
        /*
        public LengthValidator(string comp, int max, int min) : base()
        {
            input = comp;
            maxLength = max;
            minLength = min;
        }
*/
        public override bool IsValid()
        {
            if (input == null)
            {
                Console.WriteLine("Input is empty");
                return false;
            }

            if (input.Length > maxLength)
            {
                Console.WriteLine("Input is too long");
                return false;
            }

            if (input.Length < minLength)
            {
                Console.WriteLine("Input is too short");
                return false;
            }
            return true;
        }
        public override string GetValue()
        {
            return input;
        }
        public override void SetValue(string value)
        {
            input = value;
        }
        public void setLengths(int max, int min)
        {
            maxLength = max;
            minLength = min;
        }

    }
}
