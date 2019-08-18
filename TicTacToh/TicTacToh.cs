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

            if ((sendr.Text == "X") || (sendr.Text == "O")) {
                return;
            }
            else {
                _counter++;
                sendr.Font = new Font(sendr.Font.Name, 18, sendr.Font.Style & FontStyle.Bold);

                sendr.Text = _currentPLayer;

                //if (_currentPLayer == "X") {
                //    sendr.ForeColor = Color.Red;
                //}
                //else if (_currentPLayer == "O") {
                //    sendr.ForeColor = Color.Blue;
                //}
                sendr.ForeColor = _currentPLayer == "X" ? Color.Red : Color.Blue;

                ValidateTicTaToh();

                if (_currentPLayer == "X") {
                    _currentPLayer = "O";
                    }
                else if (_currentPLayer == "O") {
                    _currentPLayer = "X";
                }

                DrawMessage();
            }
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
