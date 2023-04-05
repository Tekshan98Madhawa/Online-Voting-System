
namespace Online_Voting_system
{
    partial class Register
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelNic = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelConfirmPasswrd = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNic = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxCpass = new System.Windows.Forms.TextBox();
            this.labelPasswrd = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(114, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name :";
            // 
            // labelNic
            // 
            this.labelNic.AutoSize = true;
            this.labelNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNic.Location = new System.Drawing.Point(105, 142);
            this.labelNic.Name = "labelNic";
            this.labelNic.Size = new System.Drawing.Size(68, 20);
            this.labelNic.TabIndex = 2;
            this.labelNic.Text = "NIC No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // labelConfirmPasswrd
            // 
            this.labelConfirmPasswrd.AutoSize = true;
            this.labelConfirmPasswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPasswrd.Location = new System.Drawing.Point(30, 260);
            this.labelConfirmPasswrd.Name = "labelConfirmPasswrd";
            this.labelConfirmPasswrd.Size = new System.Drawing.Size(145, 20);
            this.labelConfirmPasswrd.TabIndex = 4;
            this.labelConfirmPasswrd.Text = "Confirm Password :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(198, 90);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(258, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxNic
            // 
            this.textBoxNic.Location = new System.Drawing.Point(198, 144);
            this.textBoxNic.Name = "textBoxNic";
            this.textBoxNic.Size = new System.Drawing.Size(258, 20);
            this.textBoxNic.TabIndex = 6;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(198, 201);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(258, 20);
            this.textBoxPass.TabIndex = 7;
            // 
            // textBoxCpass
            // 
            this.textBoxCpass.Location = new System.Drawing.Point(198, 260);
            this.textBoxCpass.Name = "textBoxCpass";
            this.textBoxCpass.PasswordChar = '*';
            this.textBoxCpass.Size = new System.Drawing.Size(258, 20);
            this.textBoxCpass.TabIndex = 8;
            // 
            // labelPasswrd
            // 
            this.labelPasswrd.AutoSize = true;
            this.labelPasswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswrd.Location = new System.Drawing.Point(87, 204);
            this.labelPasswrd.Name = "labelPasswrd";
            this.labelPasswrd.Size = new System.Drawing.Size(86, 20);
            this.labelPasswrd.TabIndex = 9;
            this.labelPasswrd.Text = "Password :";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistration.Location = new System.Drawing.Point(464, 292);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(158, 44);
            this.buttonRegistration.TabIndex = 10;
            this.buttonRegistration.Text = "Register";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.labelPasswrd);
            this.Controls.Add(this.textBoxCpass);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxNic);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelConfirmPasswrd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRATION ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConfirmPasswrd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNic;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxCpass;
        private System.Windows.Forms.Label labelPasswrd;
        private System.Windows.Forms.Button buttonRegistration;
    }
}