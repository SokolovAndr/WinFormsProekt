namespace WinFormsProekt
{
    partial class RegisterForm
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelParol = new System.Windows.Forms.Label();
            this.textBoxLoginRegistr = new System.Windows.Forms.TextBox();
            this.textBoxParolRegist = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(25, 55);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(57, 21);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин:";
            // 
            // labelParol
            // 
            this.labelParol.AutoSize = true;
            this.labelParol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelParol.Location = new System.Drawing.Point(25, 90);
            this.labelParol.Name = "labelParol";
            this.labelParol.Size = new System.Drawing.Size(66, 21);
            this.labelParol.TabIndex = 1;
            this.labelParol.Text = "Пароль:";
            // 
            // textBoxLoginRegistr
            // 
            this.textBoxLoginRegistr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginRegistr.Location = new System.Drawing.Point(99, 47);
            this.textBoxLoginRegistr.Name = "textBoxLoginRegistr";
            this.textBoxLoginRegistr.Size = new System.Drawing.Size(245, 29);
            this.textBoxLoginRegistr.TabIndex = 2;
            // 
            // textBoxParolRegist
            // 
            this.textBoxParolRegist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxParolRegist.Location = new System.Drawing.Point(99, 87);
            this.textBoxParolRegist.Name = "textBoxParolRegist";
            this.textBoxParolRegist.Size = new System.Drawing.Size(245, 29);
            this.textBoxParolRegist.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOk.Location = new System.Drawing.Point(269, 173);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 32);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.MouseEnter += new System.EventHandler(this.buttonOk_MouseEnter);
            this.buttonOk.MouseLeave += new System.EventHandler(this.buttonOk_MouseLeave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(369, 266);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxParolRegist);
            this.Controls.Add(this.textBoxLoginRegistr);
            this.Controls.Add(this.labelParol);
            this.Controls.Add(this.labelLogin);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLogin;
        private Label labelParol;
        public TextBox textBoxLoginRegistr;
        public TextBox textBoxParolRegist;
        private Button buttonOk;
    }
}