using System;
using System.Collections.Generic;
using System.Text;
using FormApp.ValidatorClasses;
using FormApp.Classes;
using FormApp.FormComponents;

namespace FormApp.Classes
{
    class StateContext {
        private Form form;
        private IState state;

        public void Run(Form form) {
            this.form = form;
            bool done = false;
            string tempString = null;
            string tempString2 = null;
            FormComponent tempComp = null;
            FormComponent tempComp2 = null;

            // Set your State here & run it
            state = form.GetState();

            //Create Validators
            LengthValidator LengthTest;
            CharacterValidator CharTest;
            CharacterValidator NumTest;
            OnlyNumValidator IsNumTest;

            //Start getting input==================================================================================
            // USERNAME ------------------------------------------- USERNAME -------------
            Console.WriteLine("Username:");
            while (!done)
            {

                tempString = state.HandleInput();
                tempComp = new username(tempString);
                LengthTest = new LengthValidator(tempComp);
                LengthTest.setLengths(20, 5);
                done = LengthTest.IsValid();
            }
            form.AddComponent(tempComp, "username") ;
            done = false;



            // EMAIL ------------------------------------------- EMAIL -------------
            Console.WriteLine("Email:");
            while (!done)
            {

                tempString = state.HandleInput();
                tempComp = new email(tempString);
                LengthTest = new LengthValidator(tempComp);
                LengthTest.setLengths(30, 6);

                CharTest = new CharacterValidator(tempComp);
                CharTest.SetValue("@.");

                if (LengthTest.IsValid() && CharTest.IsValid())// 
                    done = true;
            }
            form.AddComponent(tempComp, "email");
            done = false;



            // REAL NAME ----------------------------------------- REAL NAME -------------
            Console.WriteLine("Real Name:");
            while (!done)
            {

                tempString = state.HandleInput();
                tempComp = new realname(tempString);
                LengthTest = new LengthValidator(tempComp);
                LengthTest.setLengths(20, 1);
                done = LengthTest.IsValid();
            }
            form.AddComponent(tempComp, "realname");
            done = false;


            // PASSWORDS ------------------------------------------- PASSWORDS -------------
            Console.WriteLine("Password:");
            while (!done)
            {

                tempString = state.HandleInput();
                tempComp = new password(tempString);

                LengthTest = new LengthValidator(tempComp);
                LengthTest.setLengths(20, 8);

                CharTest = new CharacterValidator(tempComp);
                CharTest.SetValue("!?@#$%^&*");

                NumTest = new CharacterValidator(tempComp);
                NumTest.SetValue("1234567890");
                if (LengthTest.IsValid() && CharTest.IsValid() && NumTest.IsValid())
                    done = true;
            }
            done = false;

            Console.WriteLine("Confirm Password:");
            while (!done)
            {

                tempString2 = state.HandleInput();
                tempComp2 = new password(tempString2);
                tempComp2 = new confirmPassword(tempString2);

                LengthTest = new LengthValidator(tempComp2);
                LengthTest.setLengths(20, 8);

                CharTest = new CharacterValidator(tempComp2);
                CharTest.SetValue("!?@#$%^&*");

                NumTest = new CharacterValidator(tempComp2);
                NumTest.SetValue("1234567890");


                ValueMatchValidator valMatch = new ValueMatchValidator(tempComp, tempComp2);

                if (valMatch.IsValid() && LengthTest.IsValid() && CharTest.IsValid() && NumTest.IsValid() )
                    done = true;
            }


            form.AddComponent(tempComp, "password");
            form.AddComponent(tempComp2, "confirmpassword");
            done = false;

            // AGE ------------------------------------------------- AGE -------------
            Console.WriteLine("Age:");
            while (!done)
            {

                tempString = state.HandleInput();
                tempComp = new username(tempString);

                LengthTest = new LengthValidator(tempComp);
                LengthTest.setLengths(3, 1);

                IsNumTest = new OnlyNumValidator(tempComp);

                if (LengthTest.IsValid() && IsNumTest.IsValid())
                    done = true;
            }
            form.AddComponent(tempComp, "age");
            form.ChangeState("done");

            
        }

        public Form GetForm()
        {
            return form;
        }
    }

    public class Main
    {
        public Main()
        {
            //Greet User
            Console.WriteLine("Welcome to Clayton's Password Management App.\n");

            //Create form and set state
            Form form = new Form();
            form.SetState(new InputState(form));
            StateContext state = new StateContext();

            

            state.Run(form);

            


            //Create classes that let you execute the following code:
            /*
                        form.AddComponent(
                            new MinLengthValidator(
                                new TextBox("Username"), 6
                            )
                        );
                        form.AddComponent(
                            new CharacterValidator(
                                new CharacterValidator(
                                    new TextBox("Email"), "@"
                                ), "."
                            )
                        );
                        form.AddComponent(
                            new MinLengthValidator(
                                new TextBox("Real Name"), 2
                            )
                        );

                        FormComponent password = new CharacterValidator(
                            new MinLengthValidator(
                                new TextBox("Password"), 8
                            ), "!"
                        );
                        form.AddComponent(password);

                        form.AddComponent(
                            new ValueMatchValidator(
                                new TextBox("Confirm Password"), password
                            )
                        );
                        form.AddComponent(
                            new NumberValidator(
                                new TextBox("Age")
                            )
                        );

                        new StateContext().Run(form);
            */


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Main main = new Main();

            
        }
    }
}
