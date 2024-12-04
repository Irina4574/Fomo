using System.Diagnostics.Eventing.Reader;

namespace TicTacToeGameArchitecture.Models
{
    internal class Logics
    {
        private Conditions[] field = new Conditions[9];
        Random random = new Random();

        public void UserClick(int index)
        {
            field[index] = Conditions.X;
        }

        public int PCStep()
        {
            int index = 0;
            while (true)
            {
                index = random.Next(0, field.Length);
                if (field[index] == Conditions.Empty)
                {
                    field[index] = Conditions.O;
                    break;
                }
            }
            return index;
        }

        public int HardPCStep()
        {
            int index = 0;
            if (field[4] == Conditions.Empty)
            {
                field[4] = Conditions.O;
                index = 4;
            }

            #region horizont
            else if (field[0] == Conditions.Empty && field[1] == field[2] && field[1] != Conditions.Empty)
            {
                field[0] = Conditions.O;
                index = 0;
            }
            else if (field[1] == Conditions.Empty && field[0] == field[2] && field[2] != Conditions.Empty)
            {
                field[1] = Conditions.O;
                index = 1;
            }
            else if (field[2] == Conditions.Empty && field[0] == field[1] && field[1] != Conditions.Empty)
            {
                field[2] = Conditions.O;
                index = 2;
            }

            else if (field[3] == Conditions.Empty && field[4] == field[5] && field[5] != Conditions.Empty)
            {
                field[3] = Conditions.O;
                index = 3;
            }
            else if (field[4] == Conditions.Empty && field[3] == field[5] && field[5] != Conditions.Empty)
            {
                field[4] = Conditions.O;
                index = 4;
            }
            else if (field[5] == Conditions.Empty && field[3] == field[4] && field[4] != Conditions.Empty)
            {
                field[5] = Conditions.O;
                index = 5;
            }

            else if (field[6] == Conditions.Empty && field[7] == field[8] && field[8] != Conditions.Empty)
            {
                field[6] = Conditions.O;
                index = 6;
            }
            else if (field[7] == Conditions.Empty && field[6] == field[8] && field[8] != Conditions.Empty)
            {
                field[7] = Conditions.O;
                index = 7;
            }
            else if (field[8] == Conditions.Empty && field[6] == field[7] && field[7] != Conditions.Empty)
            {
                field[8] = Conditions.O;
                index = 8;
            }
            #endregion

            #region vertical
            else if (field[0] == Conditions.Empty && field[3] == field[6] && field[6] != Conditions.Empty)
            {
                field[0] = Conditions.O;
                index = 0;
            }
            else if (field[3] == Conditions.Empty && field[0] == field[6] && field[6] != Conditions.Empty)
            {
                field[3] = Conditions.O;
                index = 3;
            }
            else if (field[6] == Conditions.Empty && field[0] == field[3] && field[3] != Conditions.Empty)
            {
                field[6] = Conditions.O;
                index = 6;
            }

            else if (field[1] == Conditions.Empty && field[4] == field[7] && field[7] != Conditions.Empty)
            {
                field[1] = Conditions.O;
                index = 1;
            }
            else if (field[4] == Conditions.Empty && field[1] == field[7] && field[7] != Conditions.Empty)
            {
                field[4] = Conditions.O;
                index = 4;
            }
            else if (field[7] == Conditions.Empty && field[1] == field[4] && field[4] != Conditions.Empty)
            {
                field[7] = Conditions.O;
                index = 7;
            }

            else if (field[2] == Conditions.Empty && field[5] == field[8] && field[8] != Conditions.Empty)
            {
                field[2] = Conditions.O;
                index = 2;
            }
            else if (field[5] == Conditions.Empty && field[2] == field[8] && field[8] != Conditions.Empty)
            {
                field[5] = Conditions.O;
                index = 5;
            }
            else if (field[8] == Conditions.Empty && field[2] == field[5] && field[5] != Conditions.Empty)
            {
                field[8] = Conditions.O;
                index = 8;
            }
            #endregion

            #region diahonal
            else if (field[0] == Conditions.Empty && field[4] == field[8] && field[8] != Conditions.Empty)
            {
                field[0] = Conditions.O;
                index = 0;
            }
            else if (field[4] == Conditions.Empty && field[0] == field[8] && field[8] != Conditions.Empty)
            {
                field[4] = Conditions.O;
                index = 4;
            }
            else if (field[8] == Conditions.Empty && field[0] == field[4] && field[4] != Conditions.Empty)
            {
                field[8] = Conditions.O;
                index = 8;
            }

            else if (field[2] == Conditions.Empty && field[4] == field[6] && field[6] != Conditions.Empty)
            {
                field[2] = Conditions.O;
                index = 2;
            }
            else if (field[4] == Conditions.Empty && field[2] == field[6] && field[6] != Conditions.Empty)
            {
                field[4] = Conditions.O;
                index = 4;
            }
            else if (field[6] == Conditions.Empty && field[2] == field[4] && field[4] != Conditions.Empty)
            {
                field[6] = Conditions.O;
                index = 6;
            }
            #endregion

            else if ((field[0] == field[8] && field[0] == Conditions.X) || (field[2] == field[6] && field[2] == Conditions.X))
            {
                if (field[1] == Conditions.Empty)
                {
                    field[1] = Conditions.O;
                    index = 1;
                }
                else if (field[3] == Conditions.Empty)
                {
                    field[3] = Conditions.O;
                    index = 3;
                }
                else if (field[5] == Conditions.Empty)
                {
                    field[5] = Conditions.O;
                    index = 5;
                }
                else if (field[7] == Conditions.Empty)
                {
                    field[7] = Conditions.O;
                    index = 7;
                }
            }

            else if (field[0] == Conditions.Empty)
            {
                field[0] = Conditions.O;
                index = 0;
            }
            else if (field[2] == Conditions.Empty)
            {
                field[2] = Conditions.O;
                index = 2;
            }
            else if (field[6] == Conditions.Empty)
            {
                field[6] = Conditions.O;
                index = 6;
            }
            else if (field[8] == Conditions.Empty)
            {
                field[8] = Conditions.O;
                index = 8;
            }
            return index;
        }

        public bool IsWin(Conditions condition)
        {
            bool result = false;
            if (field[0] == field[1] && field[1] == field[2] && field[0] == condition)
            {
                result = true;
            }
            else if (field[3] == field[4] && field[4] == field[5] && field[3] == condition)
            {
                result = true;
            }
            else if (field[6] == field[7] && field[7] == field[8] && field[6] == condition)
            {
                result = true;
            }
            else if (field[0] == field[3] && field[3] == field[6] && field[0] == condition)
            {
                result = true;
            }
            else if (field[1] == field[4] && field[4] == field[7] && field[1] == condition)
            {
                result = true;
            }
            else if (field[2] == field[5] && field[5] == field[8] && field[2] == condition)
            {
                result = true;
            }
            else if (field[0] == field[4] && field[4] == field[8] && field[0] == condition)
            {
                result = true;
            }
            else if (field[2] == field[4] && field[4] == field[6] && field[2] == condition)
            {
                result = true;
            }
            return result;
        }

        public void Restart()
        {
            field = new Conditions[9];
        }

        public bool IsFullField()
        {
            return !field.Any(s => s == Conditions.Empty);
        }
    }
}


