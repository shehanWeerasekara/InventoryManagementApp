namespace InventoryManagementApp
{
    partial class ManageCustomers
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Custnametb = new MaskedTextBox();
            Custphonetb = new MaskedTextBox();
            Custidtb = new MaskedTextBox();
            label4 = new Label();
            CustomersGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
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
            panel1.TabIndex = 1;
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
            label1.Location = new Point(358, 68);
            label1.Name = "label1";
            label1.Size = new Size(219, 31);
            label1.TabIndex = 1;
            label1.Text = "Manage Customers";
            // 
            // Custnametb
            // 
            Custnametb.Location = new Point(53, 261);
            Custnametb.Name = "Custnametb";
            Custnametb.Size = new Size(294, 27);
            Custnametb.TabIndex = 6;
            Custnametb.Text = "CustomerName";
            // 
            // Custphonetb
            // 
            Custphonetb.Location = new Point(53, 323);
            Custphonetb.Name = "Custphonetb";
            Custphonetb.Size = new Size(294, 27);
            Custphonetb.TabIndex = 5;
            Custphonetb.Text = "CustomerPhone";
            // 
            // Custidtb
            // 
            Custidtb.Location = new Point(53, 201);
            Custidtb.Name = "Custidtb";
            Custidtb.Size = new Size(294, 27);
            Custidtb.TabIndex = 4;
            Custidtb.Text = "Customerid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(567, 144);
            label4.Name = "label4";
            label4.Size = new Size(187, 31);
            label4.TabIndex = 13;
            label4.Text = "CUSTOMER LIST";
            // 
            // CustomersGV
            // 
            CustomersGV.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGV.Location = new Point(435, 201);
            CustomersGV.Name = "CustomersGV";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CustomersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomersGV.RowHeadersWidth = 51;
            CustomersGV.Size = new Size(444, 345);
            CustomersGV.TabIndex = 12;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(155, 490);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 17;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(255, 428);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(155, 428);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(55, 428);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 592);
            panel2.Name = "panel2";
            panel2.Size = new Size(966, 33);
            panel2.TabIndex = 18;
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 625);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(CustomersGV);
            Controls.Add(Custnametb);
            Controls.Add(Custphonetb);
            Controls.Add(Custidtb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomers";
            Load += ManageCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox Custnametb;
        private MaskedTextBox Custphonetb;
        private MaskedTextBox Custidtb;
        private Label label4;
        private DataGridView CustomersGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
    }
}