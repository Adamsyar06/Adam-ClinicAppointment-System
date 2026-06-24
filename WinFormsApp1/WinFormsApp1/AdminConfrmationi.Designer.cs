namespace WinFormsApp1
{
    partial class AdminConfrmationi
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
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            Passwordtxt = new TextBox();
            Verifybtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(243, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter Password to Confirm Admin:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Passwordtxt
            // 
            Passwordtxt.Location = new Point(12, 64);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(330, 27);
            Passwordtxt.TabIndex = 5;
            Passwordtxt.UseSystemPasswordChar = true;
            // 
            // Verifybtn
            // 
            Verifybtn.BackColor = Color.MidnightBlue;
            Verifybtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Verifybtn.ForeColor = SystemColors.ButtonHighlight;
            Verifybtn.Location = new Point(184, 137);
            Verifybtn.Name = "Verifybtn";
            Verifybtn.Size = new Size(110, 31);
            Verifybtn.TabIndex = 25;
            Verifybtn.Text = "VERIFY";
            Verifybtn.UseVisualStyleBackColor = false;
            Verifybtn.Click += Verifybtn_Click;
            // 
            // AdminConfrmationi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 180);
            Controls.Add(Verifybtn);
            Controls.Add(Passwordtxt);
            Controls.Add(label2);
            Name = "AdminConfrmationi";
            Text = "AdminConfrmationi";
            Load += AdminConfrmationi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox Passwordtxt;
        private Button Verifybtn;
    }
}