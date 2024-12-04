using TicTacToeGameArchitecture.Models;
using TicTacToeGameArchitecture.Properties;
using TicTacToeGameArchitecture.Views;

namespace TicTacToeGameArchitecture
{
    public partial class Form1 : Form, IForm1
    {


        private List<Button> buttons = new List<Button>();


        public Form1()
        {
            InitializeComponent();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
        }

        public event Action<int> ClickEvent;
        public event Action RestartEvent;
        public event Action<int> PlayerWin;
        public event Action<int> PCWin;

        public void ShowPCStep(int index)
        {
            buttons[index].BackgroundImage = Resources.zero;
            buttons[index].Enabled = false;
        }


        private void OnClick(object sender, EventArgs e)
        {


            Button button = (sender as Button);
            button.BackgroundImage = Resources.cross;
            button.Enabled = false;
            ClickEvent?.Invoke(int.Parse(button.Tag.ToString()));
            /*
            button.BackgroundImage = new Bitmap( Resources.cross);
            */
        }

        private void OnRestart(object sender, EventArgs e)
        {
            RestartEvent?.Invoke();
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Enabled = true;
                buttons[i].BackgroundImage = null;
            }
        }

        public void ShowWin(Conditions conditions)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Enabled = false;
            }
            if (conditions == Conditions.X)
            {
                playerWin.Text = (int.Parse(playerWin.Text) + 1).ToString();
                MessageBox.Show("Ви перемогли");

            }
            else if (conditions == Conditions.O)
            {
                pcWin.Text = (int.Parse(pcWin.Text) + 1).ToString();
                MessageBox.Show("Виграв ПК");
            }
        }

        public void Draw()
        {
            MessageBox.Show("Нічия");
        }
    }
}
