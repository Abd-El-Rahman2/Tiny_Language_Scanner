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

            if (tokens.Count == 0) return;

            try
            {
                MiniLParser parser = new MiniLParser(tokens);
                parser.ParseProgram();
                MessageBox.Show("Success: Your code is syntactically correct!",
                    "Parse Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Syntax Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridTokens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
