using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGames
{
    public class CardFace : Card, IPrintable
    {
        public string CardName { get; set; }
        public CardFace(string cardName)
        {
            this.CardName = cardName;
            this.IsVisible = false;
        }
        public override void DrowSelf(int row, int col)
        {
            if (IsVisible)
            {
                CardPosition position = CardPosition.GeneratePosition(row, col);
                Print(position);
            }
        }

        public void Print(CardPosition topLeft)
        {
            if (this.CardName == "One")
            {

                PrintCardOne(topLeft);
            }
            else if  (this.CardName == "Two")
            {

                PrintCardTwo(topLeft);
            }
            else if (this.CardName == "Three")
            {

                PrintCardThree(topLeft);
            }
            else if (this.CardName == "Four")
            {

                PrintCardFour(topLeft);
            }
            else if (this.CardName == "Five")
            {

                PrintCardFive(topLeft);
            }
            else if (this.CardName == "Six")
            {

                PrintCardSix(topLeft);
            }
            else if (this.CardName == "Seven")
            {

                PrintCardSeven(topLeft);
            }
            else
            {
                PrintCardEight(topLeft);
            }
        }

        public static bool operator ==(CardFace firstCardFace, CardFace secondCardFace)
        {
            if (firstCardFace.CardName == secondCardFace.CardName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(CardFace firstCardFace, CardFace secondCardFace)
        {
            return !(firstCardFace == secondCardFace);
        }
        #region CardOne
        public static void PrintCardOne(CardPosition topleft)
        {
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.Write("  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.Write("  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.ResetColor();
        }
        #endregion
        #region CardTwo
        public static void PrintCardTwo(CardPosition topleft)
        {
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/!!\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/!!!!\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/!!!!!!\\");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\!!!!!!/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\_!!_/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.ResetColor();
        }
        #endregion
        #region CardThree
        public static void PrintCardThree(CardPosition topleft)
        {
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("o_");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\//");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("_0");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("0__");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("__o");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("o_");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\//");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("_0");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("0__");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("__o");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("o_");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\//");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("_0");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("0__");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("__o");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");

            Console.ResetColor();
        }
        #endregion
        #region CardFour
        public static void PrintCardFour(CardPosition topleft)
        {
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("|~~~~~~|");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("|  ##  |");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("|  ##  |");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("|  ##  |");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("|  ##  |");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("|~~~~~~|");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.ResetColor();
        }
        #endregion
        #region CardFive
        public static void PrintCardFive(CardPosition topleft)
        {
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("/ \\/ \\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\    /");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\  /");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%%");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%%%%%%%");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");

            Console.ResetColor();
        }
        #endregion
        #region CardSix
        public static void PrintCardSix(CardPosition topleft)
        {
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.Write("  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.Write("  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.ResetColor();
        }
        #endregion
        #region CardSeven
        public static void PrintCardSeven(CardPosition topleft)
        {
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("(((");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(")))");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("(((");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(")))");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("(((");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(")))");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");

            Console.ResetColor();
        }
        #endregion
        #region CardEight
        public static void PrintCardEight(CardPosition topleft)
        {
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|\\/|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|/\\|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|\\/|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|/\\|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|\\/|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|/\\|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topleft.X, topleft.Y);
            topleft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§§§");
            Console.ResetColor();
        }
        #endregion
    }
}
