namespace WinFormsProekt
{
    partial class LoginForm
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
            this.buttonVhod = new System.Windows.Forms.Button();
            this.buttonRegist = new System.Windows.Forms.Button();
            this.textBoxParol = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelParol = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVhod
            // 
            this.buttonVhod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVhod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVhod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVhod.Location = new System.Drawing.Point(64, 191);
            this.buttonVhod.Name = "buttonVhod";
            this.buttonVhod.Size = new System.Drawing.Size(98, 32);
            this.buttonVhod.TabIndex = 11;
            this.buttonVhod.Text = "Войти";
            this.buttonVhod.UseVisualStyleBackColor = false;
            this.buttonVhod.Click += new System.EventHandler(this.buttonVhod_Click);
            this.buttonVhod.MouseEnter += new System.EventHandler(this.buttonVhod_MouseEnter);
            this.buttonVhod.MouseLeave += new System.EventHandler(this.buttonVhod_MouseLeave);
            // 
            // buttonRegist
            // 
            this.buttonRegist.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegist.Location = new System.Drawing.Point(186, 191);
            this.buttonRegist.Name = "buttonRegist";
            this.buttonRegist.Size = new System.Drawing.Size(123, 32);
            this.buttonRegist.TabIndex = 10;
            this.buttonRegist.Text = "Регистрация";
            this.buttonRegist.UseVisualStyleBackColor = false;
            this.buttonRegist.Click += new System.EventHandler(this.buttonRegist_Click);
            this.buttonRegist.MouseEnter += new System.EventHandler(this.buttonRegist_MouseEnter);
            this.buttonRegist.MouseLeave += new System.EventHandler(this.buttonRegist_MouseLeave);
            // 
            // textBoxParol
            // 
            this.textBoxParol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxParol.Location = new System.Drawing.Point(64, 140);
            this.textBoxParol.Name = "textBoxParol";
            this.textBoxParol.Size = new System.Drawing.Size(245, 29);
            this.textBoxParol.TabIndex = 9;
            this.textBoxParol.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLogin.Location = new System.Drawing.Point(64, 66);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(245, 29);
            this.textBoxLogin.TabIndex = 8;
            // 
            // labelParol
            // 
            this.labelParol.AutoSize = true;
            this.labelParol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelParol.Location = new System.Drawing.Point(64, 105);
            this.labelParol.Name = "labelParol";
            this.labelParol.Size = new System.Drawing.Size(126, 21);
            this.labelParol.TabIndex = 7;
            this.labelParol.Text = "Введите пароль:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(64, 33);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(116, 21);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Введите логин:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsProekt.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(28, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsProekt.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(28, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinFormsProekt.Properties.Resources.eye;
            this.pictureBox3.Location = new System.Drawing.Point(324, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(369, 266);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVhod);
            this.Controls.Add(this.buttonRegist);
            this.Controls.Add(this.textBoxParol);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelParol);
            this.Controls.Add(this.labelLogin);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно входа/регистрации";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonVhod;
        private Button buttonRegist;
        private TextBox textBoxParol;
        private TextBox textBoxLogin;
        private Label labelParol;
        private Label labelLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}