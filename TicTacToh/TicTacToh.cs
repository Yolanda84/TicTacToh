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
        
        public TicTacToh() {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e) {

            Button sendr = sender as Button;

            sendr.Text = _currentPLayer;
            sendr.Enabled = false;

            if (_currentPLayer == "X") {
                _currentPLayer = "O";
            }
            else if (_currentPLayer == "O") {
                _currentPLayer = "X";
            }
            

            //string[] ticTacTohh = { "X", "O"};
            //int i = Array.IndexOf(ticTacTohh, sendr.Text);
            //if (i >= 0 && i < 2) {
            //    sendr.Text = ticTacTohh[1];
            //}
            //else {
            //    sendr.Text = ticTacTohh[0];
            //}


        }


    }
}
