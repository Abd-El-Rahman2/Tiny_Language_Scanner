namespace TinyLanguageScanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.gridTokens = new System.Windows.Forms.DataGridView();
            this.TokenType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiny Code Input";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(99, 51);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(209, 223);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(342, 275);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(66, 23);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // gridTokens
            // 
            this.gridTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TokenType,
            this.Lexeme});
            this.gridTokens.Location = new System.Drawing.Point(456, 51);
            this.gridTokens.Name = "gridTokens";
            this.gridTokens.RowHeadersWidth = 51;
            this.gridTokens.RowTemplate.Height = 24;
            this.gridTokens.Size = new System.Drawing.Size(283, 212);
            this.gridTokens.TabIndex = 3;
            // 
            // TokenType
            // 
            this.TokenType.HeaderText = "TokenType";
            this.TokenType.MinimumWidth = 6;
            this.TokenType.Name = "TokenType";
            this.TokenType.Width = 125;
            // 
            // Lexeme
            // 
            this.Lexeme.HeaderText = "Lexeme";
            this.Lexeme.MinimumWidth = 6;
            this.Lexeme.Name = "Lexeme";
            this.Lexeme.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 462);
            this.Controls.Add(this.gridTokens);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.DataGridView gridTokens;
        private System.Windows.Forms.DataGridViewTextBoxColumn TokenType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexeme;
    }
}

