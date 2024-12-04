using System.Diagnostics;
using TicTacToeGameArchitecture.Models;
using TicTacToeGameArchitecture.Views;

namespace TicTacToeGameArchitecture.Presenters
{
    internal class Form1Presenter
    {
        private readonly Logics logics = new Logics();

        private readonly IForm1 form1;

        public Form1Presenter(IForm1 form)
        {
            form1 = form;
            form1.ClickEvent += UserClick;
            form1.RestartEvent += RestartClick;
        }

        private void UserClick(int index)
        {
            logics.UserClick(index);
            if (logics.IsWin(Conditions.X))
            {
                form1.ShowWin(Conditions.X);
                return;
            }
            int step = logics.HardPCStep();
            form1.ShowPCStep(step);
            if (logics.IsWin(Conditions.O))
            {
                form1.ShowWin(Conditions.O);
            }
            if (logics.IsFullField())
            {
                form1.Draw();
                return;
            }
        }


        private void RestartClick()
        {
            logics.Restart();
        }


    }
}
