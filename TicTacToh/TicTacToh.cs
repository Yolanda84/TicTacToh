using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToh {
    public partial class TicTacToh : Form {

        private string _currentPLayer = "X";
        private int _counter = 0;


        public TicTacToh() {
            InitializeComponent();
        }



        private void ButtonClick(object sender, EventArgs e) {
            Button sendr = sender as Button;
            Random rnd = new Random();
            int buttonNumber = rnd.Next(1, 9);

            if ((sendr.Text == "X") || (sendr.Text == "O")) {
                return;
            }

            if (sendr == btn1) {
                sendr.Text = _currentPLayer;
                if (buttonNumber == 1) {
                    return;
                }
                else if (buttonNumber == 2) {
                    while ((btn2.Text == "X") || (btn2.Text == "O")) {
                        return;
                    }
                    btn2.Text = "O";
                }
                else if (buttonNumber == 3) {
                    while ((btn3.Text == "X") || (btn3.Text == "O")) {
                        return;
                    }
                    btn3.Text = "O";
                }
                else if (buttonNumber == 4) {
                    while ((btn4.Text == "X") || (btn4.Text == "O")) {
                        return;
                    }
                    btn4.Text = "O";
                }
                else if (buttonNumber == 5) {
                    while ((btn5.Text == "X") || (btn5.Text == "O")) {
                        return;
                    }
                    btn5.Text = "O";
                }
                else if (buttonNumber == 6) {
                    while ((btn6.Text == "X") || (btn6.Text == "O")) {
                        return;
                    }
                    btn6.Text = "O";
                }
                else if (buttonNumber == 7) {
                    while ((btn7.Text == "X") || (btn7.Text == "O")) {
                        return;
                    }
                    btn7.Text = "O";
                }
                else if (buttonNumber == 8) {
                    while ((btn8.Text == "X") || (btn8.Text == "O")) {
                        return;
                    }
                    btn8.Text = "O";
                }
                else if (buttonNumber == 9) {
                    while ((btn9.Text == "X") || (btn9.Text == "O")) {
                        return;
                    }
                    btn9.Text = "O";
                }
            }
            else if (sendr == btn2) {
                sendr.Text = _currentPLayer;
                if (buttonNumber == 1) {
                    while ((btn1.Text == "X") || (btn1.Text == "O")) {
                        return;
                    }
                    btn1.Text = "O";
                }
                else if (buttonNumber == 2) {
                    return;
                }
                else if (buttonNumber == 3) {
                    while ((btn3.Text == "X") || (btn3.Text == "O")) {
                        return;
                    }
                    btn3.Text = "O";
                }
                else if (buttonNumber == 4) {
                    while ((btn4.Text == "X") || (btn4.Text == "O")) {
                        return;
                    }
                    btn4.Text = "O";
                }
                else if (buttonNumber == 5) {
                    while ((btn5.Text == "X") || (btn5.Text == "O")) {
                        return;
                    }
                    btn5.Text = "O";
                }
                else if (buttonNumber == 6) {
                    while ((btn6.Text == "X") || (btn6.Text == "O")) {
                        return;
                    }
                    btn6.Text = "O";
                }
                else if (buttonNumber == 7) {
                    while ((btn7.Text == "X") || (btn7.Text == "O")) {
                        return;
                    }
                    btn7.Text = "O";
                }
                else if (buttonNumber == 8) {
                    while ((btn8.Text == "X") || (btn8.Text == "O")) {
                        return;
                    }
                    btn8.Text = "O";
                }
                else if (buttonNumber == 9) {
                    while ((btn9.Text == "X") || (btn9.Text == "O")) {
                        return;
                    }
                    btn9.Text = "O";
                }
            }
            if (sendr == btn3) {
                sendr.Text = _currentPLayer;
                if (buttonNumber == 1) {
                    while ((btn1.Text == "X") || (btn1.Text == "O")) {
                        return;
                    }
                    return;
                }
                else if (buttonNumber == 2) {
                    while ((btn2.Text == "X") || (btn2.Text == "O")) {
                        return;
                    }
                    btn2.Text = "O";
                }
                else if (buttonNumber == 3) {
                    return;
                }
                else if (buttonNumber == 4) {
                    while ((btn4.Text == "X") || (btn4.Text == "O")) {
                        return;
                    }
                    btn4.Text = "O";
                }
                else if (buttonNumber == 5) {
                    while ((btn5.Text == "X") || (btn5.Text == "O")) {
                        return;
                    }
                    btn5.Text = "O";
                }
                else if (buttonNumber == 6) {
                    while ((btn6.Text == "X") || (btn6.Text == "O")) {
                        return;
                    }
                    btn6.Text = "O";
                }
                else if (buttonNumber == 7) {
                    while ((btn7.Text == "X") || (btn7.Text == "O")) {
                        return;
                    }
                    btn7.Text = "O";
                }
                else if (buttonNumber == 8) {
                    while ((btn8.Text == "X") || (btn8.Text == "O")) {
                        return;
                    }
                    btn8.Text = "O";
                }
                else if (buttonNumber == 9) {
                    while ((btn9.Text == "X") || (btn9.Text == "O")) {
                        return;
                    }
                    btn9.Text = "O";
                }
            }
            else if (sendr == btn4) {
                sendr.Text = _currentPLayer;
                if (buttonNumber == 1) {
                    while ((btn1.Text == "X") || (btn1.Text == "O")) {
                        return;
                    }
                    btn1.Text = "O";
                }
                else if (buttonNumber == 2) {
                    while ((btn2.Text == "X") || (btn2.Text == "O")) {
                        return;
                    }
                    btn2.Text = "O";
                }
                else if (buttonNumber == 3) {
                    while ((btn3.Text == "X") || (btn3.Text == "O")) {
                        return;
                    }
                    btn3.Text = "O";
                }
                else if (buttonNumber == 4) {
                    return;
                }
                else if (buttonNumber == 5) {
                    while ((btn5.Text == "X") || (btn5.Text == "O")) {
                        return;
                    }
                    btn5.Text = "O";
                }
                else if (buttonNumber == 6) {
                    while ((btn6.Text == "X") || (btn6.Text == "O")) {
                        return;
                    }
                    btn6.Text = "O";
                }
                else if (buttonNumber == 7) {
                    while ((btn7.Text == "X") || (btn7.Text == "O")) {
                        return;
                    }
                    btn7.Text = "O";
                }
                else if (buttonNumber == 8) {
                    while ((btn8.Text == "X") || (btn8.Text == "O")) {
                        return;
                    }
                    btn8.Text = "O";
                }
                else if (buttonNumber == 9) {
                    while ((btn9.Text == "X") || (btn9.Text == "O")) {
                        return;
                    }
                    btn9.Text = "O";
                }
            }
            else if (sendr == btn5) {
                sendr.Text = _currentPLayer;
                if (buttonNumber == 1) {
                    while ((btn1.Text == "X") || (btn1.Text == "O")) {
                        return;
                    }
                    btn1.Text = "O";
                }
                else if (buttonNumber == 2) {
                    while ((btn2.Text == "X") || (btn2.Text == "O")) {
                        return;
                    }
                    btn2.Text = "O";
                }
                else if (buttonNumber == 3) {
                    while ((btn3.Text == "X") || (btn3.Text == "O")) {
                        return;
                    }
                    btn3.Text = "O";
                }
                else if (buttonNumber == 4) {
                    while ((btn4.Text == "X") || (btn4.Text == "O")) {
                        return;
                    }
                    btn4.Text = "O";
                }
                else if (buttonNumber == 5) {
                    return;
                }
                else if (buttonNumber == 6) {
                    while ((btn6.Text == "X") || (btn6.Text == "O")) {
                        return;
                    }
                    btn6.Text = "O";
                }
                else if (buttonNumber == 7) {
                    while ((btn7.Text == "X") || (btn7.Text == "O")) {
                        return;
                    }
                    btn7.Text = "O";
                }
                else if (buttonNumber == 8) {
                    while ((btn8.Text == "X") || (btn8.Text == "O")) {
                        return;
                    }
                    btn8.Text = "O";
                }
                else if (buttonNumber == 9) {
                    while ((btn9.Text == "X") || (btn9.Text == "O")) {
                        return;
                    }
                    btn9.Text = "O";
                }
            }
            else if (sendr == btn6) {
                sendr.Text = _currentPLayer;
                if (buttonNumber == 1) {
                    while ((btn1.Text == "X") || (btn1.Text == "O")) {
                        return;
                    }
                    btn1.Text = "O";
                }
                else if (buttonNumber == 2) {
                    while ((btn2.Text == "X") || (btn2.Text == "O")) {
                        return;
                    }
                    btn2.Text = "O";
                }
                else if (buttonNumber == 3) {
                    while ((btn3.Text == "X") || (btn3.Text == "O")) {
                        return;
                    }
                    btn3.Text = "O";
                }
                else if (buttonNumber == 4) {
                    while ((btn4.Text == "X") || (btn4.Text == "O")) {
                        return;
                    }
                    btn4.Text = "O";
                }
                else if (buttonNumber == 5) {
                    while ((btn5.Text == "X") || (btn5.Text == "O")) {
                        return;
                    }
                    btn5.Text = "O";
                }
                else if (buttonNumber == 6) {
                    return;
                }
                else if (buttonNumber == 7) {
                    while ((btn7.Text == "X") || (btn7.Text == "O")) {
                        return;
                    }
                    btn7.Text = "O";
                }
                else if (buttonNumber == 8) {
                    while ((btn8.Text == "X") || (btn8.Text == "O")) {
                        return;
                    }
                    btn8.Text = "O";
                }
                else if (buttonNumber == 9) {
                    while ((btn9.Text == "X") || (btn9.Text == "O")) {
                        return;
                    }
                    btn9.Text = "O";
                }
            }
            if (sendr == btn7) {
                sendr.Text = _currentPLayer;
                if (buttonNumber == 1) {
                    while ((btn1.Text == "X") || (btn1.Text == "O")) {
                        return;
                    }
                    return;
                }
                else if (buttonNumber == 2) {
                    while ((btn2.Text == "X") || (btn2.Text == "O")) {
                        return;
                    }
                    btn2.Text = "O";
                }
                else if (buttonNumber == 3) {
                    while ((btn3.Text == "X") || (btn3.Text == "O")) {
                        return;
                    }
                    btn3.Text = "O";
                }
                else if (buttonNumber == 4) {
                    while ((btn4.Text == "X") || (btn4.Text == "O")) {
                        return;
                    }
                    btn4.Text = "O";
                }
                else if (buttonNumber == 5) {
                    while ((btn5.Text == "X") || (btn5.Text == "O")) {
                        return;
                    }
                    btn5.Text = "O";
                }
                else if (buttonNumber == 6) {
                    while ((btn6.Text == "X") || (btn6.Text == "O")) {
                        return;
                    }
                    btn6.Text = "O";
                }
                else if (buttonNumber == 7) {
                    return;
                }
                else if (buttonNumber == 8) {
                    while ((btn8.Text == "X") || (btn8.Text == "O")) {
                        return;
                    }
                    btn8.Text = "O";
                }
                else if (buttonNumber == 9) {
                    while ((btn9.Text == "X") || (btn9.Text == "O")) {
                        return;
                    }
                    btn9.Text = "O";
                }
            }
            else if (sendr == btn8) {
                sendr.Text = _currentPLayer;
                if (buttonNumber == 1) {
                    while ((btn1.Text == "X") || (btn1.Text == "O")) {
                        return;
                    }
                    btn1.Text = "O";
                }
                else if (buttonNumber == 2) {
                    while ((btn2.Text == "X") || (btn2.Text == "O")) {
                        return;
                    }
                    btn2.Text = "O";
                }
                else if (buttonNumber == 3) {
                    while ((btn3.Text == "X") || (btn3.Text == "O")) {
                        return;
                    }
                    btn3.Text = "O";
                }
                else if (buttonNumber == 4) {
                    while ((btn4.Text == "X") || (btn4.Text == "O")) {
                        return;
                    }
                    btn4.Text = "O";
                }
                else if (buttonNumber == 5) {
                    while ((btn5.Text == "X") || (btn5.Text == "O")) {
                        return;
                    }
                    btn5.Text = "O";
                }
                else if (buttonNumber == 6) {
                    while ((btn6.Text == "X") || (btn6.Text == "O")) {
                        return;
                    }
                    btn6.Text = "O";
                }
                else if (buttonNumber == 7) {
                    while ((btn7.Text == "X") || (btn7.Text == "O")) {
                        return;
                    }
                    btn7.Text = "O";
                }
                else if (buttonNumber == 8) {
                    return;
                }
                else if (buttonNumber == 9) {
                    while ((btn9.Text == "X") || (btn9.Text == "O")) {
                        return;
                    }
                    btn9.Text = "O";
                }
            }
            else if (sendr == btn9) {
                sendr.Text = _currentPLayer;
                if (buttonNumber == 1) {
                    while ((btn1.Text == "X") || (btn1.Text == "O")) {
                        return;
                    }
                    btn1.Text = "O";
                }
                else if (buttonNumber == 2) {
                    while ((btn2.Text == "X") || (btn2.Text == "O")) {
                        return;
                    }
                    btn2.Text = "O";
                }
                else if (buttonNumber == 3) {
                    while ((btn3.Text == "X") || (btn3.Text == "O")) {
                        return;
                    }
                    btn3.Text = "O";
                }
                else if (buttonNumber == 4) {
                    while ((btn4.Text == "X") || (btn4.Text == "O")) {
                        return;
                    }
                    btn4.Text = "O";
                }
                else if (buttonNumber == 5) {
                    while ((btn5.Text == "X") || (btn5.Text == "O")) {
                        return;
                    }
                    btn5.Text = "O";
                }
                else if (buttonNumber == 6) {
                    while ((btn6.Text == "X") || (btn6.Text == "O")) {
                        return;
                    }
                    btn6.Text = "O";
                }
                else if (buttonNumber == 7) {
                    while ((btn7.Text == "X") || (btn7.Text == "O")) {
                        return;
                    }
                    btn7.Text = "O";
                }
                else if (buttonNumber == 8) {
                    while ((btn8.Text == "X") || (btn8.Text == "O")) {
                        return;
                    }
                    btn8.Text = "O";
                }
                else if (buttonNumber == 9) {
                    return;
                }
            }


            //else {
            //    _counter++;
            //    sendr.Font = new Font(sendr.Font.Name, 18, sendr.Font.Style & FontStyle.Bold);

            //    sendr.Text = _currentPLayer;
            //    btn1.Text = "O";

            //if (_currentPLayer == "X") {
            //    sendr.ForeColor = Color.Red;
            //}
            //else if (_currentPLayer == "O") {
            //    sendr.ForeColor = Color.Blue;
            //}
            //sendr.ForeColor = _currentPLayer == "X" ? Color.Red : Color.Blue;

            //ValidateTicTaToh();

            //if (_currentPLayer == "X") {
            //    _currentPLayer = "O";
            //    }
            //else if (_currentPLayer == "O") {
            //    _currentPLayer = "X";
            //}

            //DrawMessage();
        }



        public void ValidateTicTaToh() {

            if (btn1.Text == _currentPLayer && btn2.Text == _currentPLayer && btn3.Text == _currentPLayer) {

                Congrats();
            }
            else if (btn4.Text == _currentPLayer && btn5.Text == _currentPLayer && btn6.Text == _currentPLayer) {

                Congrats();

            }
            else if (btn7.Text == _currentPLayer && btn8.Text == _currentPLayer && btn9.Text == _currentPLayer) {

                Congrats();
            }
            else if (btn1.Text == _currentPLayer && btn4.Text == _currentPLayer && btn7.Text == _currentPLayer) {

                Congrats();
            }
            else if (btn2.Text == _currentPLayer && btn5.Text == _currentPLayer && btn8.Text == _currentPLayer) {

                Congrats();
            }
            else if (btn3.Text == _currentPLayer && btn6.Text == _currentPLayer && btn9.Text == _currentPLayer) {

                Congrats();
            }
            else if (btn1.Text == _currentPLayer && btn5.Text == _currentPLayer && btn9.Text == _currentPLayer) {

                Congrats();
            }
            else if (btn3.Text == _currentPLayer && btn5.Text == _currentPLayer && btn7.Text == _currentPLayer) {
                Congrats();
            }
        }

        private void Congrats() {
            MessageBox.Show("Congratulations, " + _currentPLayer + " wins");
            NewGame();

        }

        private void NewGame() {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            _currentPLayer = "X";
            _counter = 0;
        }

        private void DrawMessage() {

            if (_counter == 9) {
                MessageBox.Show("You lost, suckers");
                NewGame();

            }

        }
    }
}
