using System;
using System.Collections.Generic;
using System.Text;

namespace FormApp.Classes
{
    public class DoneState : IState
    {
        Form form;
        string input;
        FormComponent component;
        bool done = false;
        public DoneState(Form form)
        {
            this.form = form;
        }
        public string HandleInput()
        {
            Console.Write(">");
            input = Console.ReadLine();
            return input;
        }

        public bool isDone()
        {
            return done;
        }

        public void Run()
        {
            Console.WriteLine("You're done! To confirm, here's what you wrote:\n");

            form.PrintForm();

            Console.WriteLine("\nTo re-enter info, type 'Reset' or type 'Exit' to end the program");

            input = Console.ReadLine();
            input = input.ToLower();
            if(input == "reset")
            {
                form.SetState(new InputState(form));
                StateContext state = new StateContext();
                state.Run(form);
                
            }
            else if(input == "exit")
            {
                Environment.Exit(0);
            }

        }

    }
}
