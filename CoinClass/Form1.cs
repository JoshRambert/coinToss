using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //Create a coin object
            Coin myCoin = new Coin();
            //CLear the listBox 
            coinListbox.Items.Clear();

            //Call the toss method fro the coin class then add that to te listBox
            for (int toss = 0; toss < 5; toss++) {
                myCoin.Toss();
                //add the values to the listBox
                coinListbox.Items.Add(myCoin.GetSide());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the program 
            this.Close();
        }
    }
}
