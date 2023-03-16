using System;
using System.Collections.Generic;

namespace FormApp.Classes {
    public class Form {

        private IState state;
        string status = "input";
        FormComponent userName;
        FormComponent email;
        FormComponent realName;
        FormComponent password;
        FormComponent confirmPassword;
        FormComponent age;

        public Form() {
           
        }
        public void AddComponent(FormComponent component, string comName)
        {
            string switchParam = comName.ToLower();
            switch(switchParam)
            {
                case "username":
                    userName = component;
                    break;

                case "email":
                    email = component;
                    break;

                case "realname":
                    realName = component;
                    break;

                case "password":
                    password = component;
                    break;

                case "confirmpassword":
                    confirmPassword = component;
                    break;

                case "age":
                    age = component;
                    break;

                default:
                    Console.WriteLine("Error: Invalid parameter name");
                    break;
            }
        }

        public bool HandleInput(string input)
        {
            return false;
        }

        public void ChangeState(string input)
        {
            if (input == "input")
            {
                state = new InputState(this);
                status = input;
            }
            else if(input == "done")
            {
                state = new DoneState(this);
                state.Run();
                status = input;
            }
        }

        public void SetState(IState _state)
        {
            this.state = _state;

        }

        public IState GetState()
        {
            if (status == "input")
            {
                //Console.WriteLine("Input State");
                return state;
            }
            else if (status == "done")
            {
                //Console.WriteLine("Done State");
                return state;
            }
            else 
            { 
                Console.WriteLine("Error: State is null"); 
                return null; 
            }
        }

        public bool isDone()
        {
            return false;
        }

        public void PrintForm()
        {
            Console.WriteLine("Username: " + userName.GetValue() +
                                "\nEmail: " + email.GetValue() +
                                "\nReal Name: " + realName.GetValue() +
                                "\nPassword: " + password.GetValue() +
                                "\nConfirm Password: " + confirmPassword.GetValue() +
                                "\nAge: " + age.GetValue());
        }
    }
}
