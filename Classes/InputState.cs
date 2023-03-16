using System;
using System.Collections.Generic;
using System.Text;
using FormApp.ValidatorClasses;

namespace FormApp.Classes
{

    public class InputState : IState
    {
        string input;
        string component;
        Form form = new Form();
        public InputState(Form form){
            this.form = form;

            //Console.WriteLine("Entered Input State");
        }

        public string HandleInput()
        {
            Console.Write(">");
            input = Console.ReadLine();

            return input;
        }

        public void Run()
        {
            HandleInput();
        }

        public bool isDone()
        {
            return false;
        }
    }
}
