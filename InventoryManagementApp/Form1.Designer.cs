namespace InventoryManagementApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            clearbtn = new Button();
            ShowPassword = new CheckBox();
            button1 = new Button();
            passwordtb = new MaskedTextBox();
            usernametb = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(clearbtn);
            panel1.Controls.Add(ShowPassword);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(passwordtb);
            panel1.Controls.Add(usernametb);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(89, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 230);
            panel1.TabIndex = 0;
            // 
            // clearbtn
            // 
            clearbtn.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearbtn.Location = new Point(76, 137);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(55, 20);
            clearbtn.TabIndex = 6;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowPassword.Location = new Point(180, 142);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(96, 17);
            ShowPassword.TabIndex = 5;
            ShowPassword.Text = "ShowPassword";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(91, 172);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // passwordtb
            // 
            passwordtb.ForeColor = Color.Black;
            passwordtb.Location = new Point(76, 109);
            passwordtb.Name = "passwordtb";
            passwordtb.Size = new Size(200, 27);
            passwordtb.TabIndex = 3;
            passwordtb.Text = "Password";
            passwordtb.UseSystemPasswordChar = true;
            passwordtb.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // usernametb
            // 
            usernametb.ForeColor = Color.Black;
            usernametb.Location = new Point(76, 60);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(200, 27);
            usernametb.TabIndex = 2;
            usernametb.Text = "Username";
            usernametb.MaskInputRejected += usernametb_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(137, 12);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(89, 9);
            label2.Name = "label2";
            label2.Size = new Size(359, 28);
            label2.TabIndex = 1;
            label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(512, 463);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private MaskedTextBox usernametb;
        private Button button1;
        private MaskedTextBox passwordtb;
        private CheckBox ShowPassword;
        private Button clearbtn;
    }
}
