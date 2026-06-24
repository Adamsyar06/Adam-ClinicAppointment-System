namespace WinFormsApp1
{
    partial class ViewDoctor
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
            panel1 = new Panel();
            ViewDoctordgv = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewDoctordgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(ViewDoctordgv);
            panel1.Location = new Point(12, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 291);
            panel1.TabIndex = 0;
            // 
            // ViewDoctordgv
            // 
            ViewDoctordgv.BackgroundColor = Color.MidnightBlue;
            ViewDoctordgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewDoctordgv.Location = new Point(16, 20);
            ViewDoctordgv.Name = "ViewDoctordgv";
            ViewDoctordgv.RowHeadersWidth = 51;
            ViewDoctordgv.Size = new Size(747, 245);
            ViewDoctordgv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 31);
            label1.TabIndex = 1;
            label1.Text = "Doctor Appointment List";
            // 
            // ViewDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ViewDoctor";
            Text = "ViewDoctor";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ViewDoctordgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView ViewDoctordgv;
        private Label label1;
    }
}