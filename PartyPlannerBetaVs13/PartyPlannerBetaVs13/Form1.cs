using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlannerBetaVs13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty(5, true, false);
            updateDinnerDisplay();

            birthdayParty = new BirthdayParty(5, true, "Happy Birthday!");
            updateBirthdayDisplay();
        }

        private void updateBirthdayDisplay()
        {
            throw new NotImplementedException();
        }

        private void updateDinnerDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
