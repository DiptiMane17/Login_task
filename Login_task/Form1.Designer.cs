namespace Login_task
{
    partial class frm_Login
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
            button1 = new Button();
            label1 = new Label();
            lbl_Username = new Label();
            lbl_Password = new Label();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(403, 372);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(200, 59);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(436, 63);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 41);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI", 18F);
            lbl_Username.Location = new Point(123, 159);
            lbl_Username.Margin = new Padding(6, 0, 6, 0);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(152, 41);
            lbl_Username.TabIndex = 2;
            lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI", 18F);
            lbl_Password.Location = new Point(132, 251);
            lbl_Password.Margin = new Padding(6, 0, 6, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(143, 41);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Password";
            lbl_Password.Click += label3_Click;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(604, 159);
            txt_Username.Margin = new Padding(6, 6, 6, 6);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(261, 47);
            txt_Username.TabIndex = 4;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(604, 245);
            txt_Password.Margin = new Padding(6, 6, 6, 6);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(261, 47);
            txt_Password.TabIndex = 5;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 482);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6, 6, 6, 6);
            Name = "frm_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label lbl_Username;
        private Label lbl_Password;
        private TextBox txt_Username;
        private TextBox txt_Password;
    }
}
