using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfManyEncounters
{
    public partial class InputForm: Form
    {
        public string UserInput1 { get; set; }
        public string UserInput2 { get; set; }
        public string UserInput3 { get; set; }
        public InputForm()
        {
            InitializeComponent();
        }

        private void saveAndCloseInput_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            UserInput1 = comboBox1.Text;
            UserInput2 = comboBox2.Text;
            UserInput3 = comboBox3.Text;
            this.Close();
        }
    }
}
