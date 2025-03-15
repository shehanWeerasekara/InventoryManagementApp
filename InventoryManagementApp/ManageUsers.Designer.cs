namespace InventoryManagementApp
{
    partial class ManageUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Unametb = new MaskedTextBox();
            Passwordtb = new MaskedTextBox();
            Fnametb = new MaskedTextBox();
            Teletb = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            UsersGV = new DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 125);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(929, 9);
            label3.Name = "label3";
            label3.Size = new Size(29, 31);
            label3.TabIndex = 3;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 9);
            label2.Name = "label2";
            label2.Size = new Size(610, 46);
            label2.TabIndex = 2;
            label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(395, 70);
            label1.Name = "label1";
            label1.Size = new Size(164, 31);
            label1.TabIndex = 1;
            label1.Text = "Manage Users";
            // 
            // Unametb
            // 
            Unametb.Location = new Point(33, 209);
            Unametb.Name = "Unametb";
            Unametb.Size = new Size(294, 27);
            Unametb.TabIndex = 1;
            Unametb.Text = "UserName";
            // 
            // Passwordtb
            // 
            Passwordtb.Location = new Point(33, 329);
            Passwordtb.Name = "Passwordtb";
            Passwordtb.Size = new Size(294, 27);
            Passwordtb.TabIndex = 2;
            Passwordtb.Text = "Password";
            // 
            // Fnametb
            // 
            Fnametb.Location = new Point(33, 267);
            Fnametb.Name = "Fnametb";
            Fnametb.Size = new Size(294, 27);
            Fnametb.TabIndex = 3;
            Fnametb.Text = "FullName";
            // 
            // Teletb
            // 
            Teletb.Location = new Point(33, 387);
            Teletb.Name = "Teletb";
            Teletb.Size = new Size(294, 27);
            Teletb.TabIndex = 4;
            Teletb.Text = "Telephone";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(33, 463);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(133, 463);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(233, 463);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(133, 525);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            // 
            // UsersGV
            // 
            UsersGV.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGV.Location = new Point(431, 209);
            UsersGV.Name = "UsersGV";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UsersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UsersGV.RowHeadersWidth = 51;
            UsersGV.Size = new Size(444, 345);
            UsersGV.TabIndex = 9;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 592);
            panel2.Name = "panel2";
            panel2.Size = new Size(966, 33);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(593, 152);
            label4.Name = "label4";
            label4.Size = new Size(122, 31);
            label4.TabIndex = 11;
            label4.Text = "USER LIST";
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 625);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(UsersGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Teletb);
            Controls.Add(Fnametb);
            Controls.Add(Passwordtb);
            Controls.Add(Unametb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private MaskedTextBox Unametb;
        private MaskedTextBox Passwordtb;
        private MaskedTextBox Fnametb;
        private MaskedTextBox Teletb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView UsersGV;
        private Panel panel2;
        private Label label3;
        private Label label4;
    }
}