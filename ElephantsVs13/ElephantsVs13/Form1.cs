using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace ElephantsVs13
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;
        
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant()
            {
                Name = "Lucinda",
                EarSize = 33
            };
            lloyd = new Elephant()
            {
                Name = "Lloyd",
                EarSize = 40
            };
        }

        private void lloydButton_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void lucindaButton_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Objects swapped");
        }

        private void weirdButton_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi", lucinda);
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.TellMe(message.this);
        }
    }
}

class Elephant
{
    public int EarSize;
    public string Name;

    public void WhoAmI()
    {
        MessageBox.Show("My ears are " + EarSize + " inches tall.", Name + " says...");
    }

    public void TellMe(string message, Elephant whoSaidIt)
    {
        MessageBox.Show(whoSaidIt.Name + " says: " + message);
    }
}