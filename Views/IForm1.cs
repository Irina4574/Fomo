using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGameArchitecture.Models;

namespace TicTacToeGameArchitecture.Views
{
    public interface IForm1
    {
        event Action<int> ClickEvent;

        event Action RestartEvent;

        event Action<int> PlayerWin;

        event Action<int> PCWin;



        void ShowPCStep(int index);

        void ShowWin(Conditions player);

        void Draw();
    }
}
