using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyLanguageScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            gridTokens.Rows.Clear();

            var tokens = Scanner.Scan(txtCode.Text);

            foreach (var token in tokens)
            {
                gridTokens.Rows.Add(token.Type, token.Lexeme);
            }
        }
    }
}
