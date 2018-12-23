namespace group28
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stuzone = new System.Windows.Forms.Button();
            this.manzone = new System.Windows.Forms.Button();
            this.leczone = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Login_button);
            this.groupBox1.Controls.Add(this.username_text);
            this.groupBox1.Controls.Add(this.password_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(122, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(406, 161);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(294, 105);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(100, 40);
            this.Login_button.TabIndex = 12;
            this.Login_button.Text = "LOGIN";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(100, 32);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(171, 20);
            this.username_text.TabIndex = 9;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(100, 60);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '•';
            this.password_text.Size = new System.Drawing.Size(171, 20);
            this.password_text.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stuzone
            // 
            this.stuzone.BackColor = System.Drawing.Color.Ivory;
            this.stuzone.Font = new System.Drawing.Font("Baskerville Old Face", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuzone.ForeColor = System.Drawing.Color.Green;
            this.stuzone.ImageKey = "(none)";
            this.stuzone.Location = new System.Drawing.Point(244, 10);
            this.stuzone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stuzone.Name = "stuzone";
            this.stuzone.Size = new System.Drawing.Size(103, 30);
            this.stuzone.TabIndex = 17;
            this.stuzone.Text = "Student Zone";
            this.stuzone.UseVisualStyleBackColor = false;
            this.stuzone.Click += new System.EventHandler(this.stuzone_Click);
            // 
            // manzone
            // 
            this.manzone.BackColor = System.Drawing.Color.Ivory;
            this.manzone.Font = new System.Drawing.Font("Baskerville Old Face", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manzone.ForeColor = System.Drawing.Color.Green;
            this.manzone.ImageKey = "(none)";
            this.manzone.Location = new System.Drawing.Point(459, 10);
            this.manzone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manzone.Name = "manzone";
            this.manzone.Size = new System.Drawing.Size(103, 30);
            this.manzone.TabIndex = 16;
            this.manzone.Text = "Manager Zone";
            this.manzone.UseVisualStyleBackColor = false;
            this.manzone.Click += new System.EventHandler(this.manzone_Click);
            // 
            // leczone
            // 
            this.leczone.BackColor = System.Drawing.Color.Ivory;
            this.leczone.Font = new System.Drawing.Font("Baskerville Old Face", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leczone.ForeColor = System.Drawing.Color.Green;
            this.leczone.ImageKey = "(none)";
            this.leczone.Location = new System.Drawing.Point(352, 10);
            this.leczone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leczone.Name = "leczone";
            this.leczone.Size = new System.Drawing.Size(103, 30);
            this.leczone.TabIndex = 15;
            this.leczone.Text = "Lecturer Zone";
            this.leczone.UseVisualStyleBackColor = false;
            this.leczone.Click += new System.EventHandler(this.leczone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stuzone);
            this.Controls.Add(this.manzone);
            this.Controls.Add(this.leczone);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stuzone;
        private System.Windows.Forms.Button manzone;
        private System.Windows.Forms.Button leczone;
    }
}

