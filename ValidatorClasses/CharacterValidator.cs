using System;
using System.Collections.Generic;
using System.Text;
using FormApp.Classes;

namespace FormApp.ValidatorClasses
{
    public class CharacterValidator : ValidatorDecorator
    {
        //FormComponent component;
        string value;
        string test;
        public CharacterValidator(FormComponent comp) : base(comp)
        {
            value = comp.GetValue();
        }

        public override bool IsValid()
        {
           
            bool result = false;
            bool done = false;

            int j = 0;
            while ( j < test.Length && !done)
            {
                int i = 0;
                while (i < value.Length)
                {


                    char c = value[i];
                    if (c == test[j])
                    {
                        result = true;
                        done = true;
                        break;
                    }
                    i++;
                    



                }
                j++;
                if (j >= test.Length)
                {
                    Console.WriteLine("Error: None of these characters '" + test + "' were found.");
                    done = true;
                    break;
                }
            }



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
