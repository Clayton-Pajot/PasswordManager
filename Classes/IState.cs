using System;
using System.Collections.Generic;
using System.Text;

namespace FormApp.Classes
{
    public interface IState
    {
        void Run();
        string HandleInput();
        bool isDone();
    }
}
