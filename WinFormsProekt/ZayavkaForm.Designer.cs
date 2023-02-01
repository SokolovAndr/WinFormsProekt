namespace WinFormsProekt
{
    partial class ZayavkaForm
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
            this.labelClient = new System.Windows.Forms.Label();
            this.labelPostavchik = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxZapros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOtvet = new System.Windows.Forms.Label();
            this.textBoxOtvet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxKontr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKontr2 = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClient.Location = new System.Drawing.Point(95, 80);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(63, 21);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Клиент:";
            // 
            // labelPostavchik
            // 
            this.labelPostavchik.AutoSize = true;
            this.labelPostavchik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPostavchik.Location = new System.Drawing.Point(547, 80);
            this.labelPostavchik.Name = "labelPostavchik";
            this.labelPostavchik.Size = new System.Drawing.Size(93, 21);
            this.labelPostavchik.TabIndex = 1;
            this.labelPostavchik.Text = "Поставщик:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(680, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 29);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(70, 214);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(60, 21);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Статус:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(203, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 29);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(680, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(195, 29);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 29);
            this.comboBox1.TabIndex = 6;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelData.Location = new System.Drawing.Point(547, 222);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(117, 21);
            this.labelData.TabIndex = 7;
            this.labelData.Text = "Дата создания:";
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(760, 591);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 40);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonSave_MouseEnter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.buttonSave_MouseLeave);
            // 
            // textBoxZapros
            // 
            this.textBoxZapros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxZapros.Location = new System.Drawing.Point(70, 341);
            this.textBoxZapros.Multiline = true;
            this.textBoxZapros.Name = "textBoxZapros";
            this.textBoxZapros.Size = new System.Drawing.Size(328, 231);
            this.textBoxZapros.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Запрос:";
            // 
            // labelOtvet
            // 
            this.labelOtvet.AutoSize = true;
            this.labelOtvet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOtvet.Location = new System.Drawing.Point(547, 292);
            this.labelOtvet.Name = "labelOtvet";
            this.labelOtvet.Size = new System.Drawing.Size(55, 21);
            this.labelOtvet.TabIndex = 13;
            this.labelOtvet.Text = "Ответ:";
            // 
            // textBoxOtvet
            // 
            this.textBoxOtvet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOtvet.Location = new System.Drawing.Point(547, 341);
            this.textBoxOtvet.Multiline = true;
            this.textBoxOtvet.Name = "textBoxOtvet";
            this.textBoxOtvet.Size = new System.Drawing.Size(328, 231);
            this.textBoxOtvet.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(203, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить клиента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(680, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Добавить поставщика";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // comboBoxKontr
            // 
            this.comboBoxKontr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxKontr.FormattingEnabled = true;
            this.comboBoxKontr.Location = new System.Drawing.Point(203, 27);
            this.comboBoxKontr.Name = "comboBoxKontr";
            this.comboBoxKontr.Size = new System.Drawing.Size(195, 29);
            this.comboBoxKontr.TabIndex = 16;
            this.comboBoxKontr.SelectedValueChanged += new System.EventHandler(this.comboBoxKontr_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выберите клиента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(501, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Выберите поставщика:";
            // 
            // comboBoxKontr2
            // 
            this.comboBoxKontr2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxKontr2.FormattingEnabled = true;
            this.comboBoxKontr2.Location = new System.Drawing.Point(680, 27);
            this.comboBoxKontr2.Name = "comboBoxKontr2";
            this.comboBoxKontr2.Size = new System.Drawing.Size(195, 29);
            this.comboBoxKontr2.TabIndex = 18;
            this.comboBoxKontr2.SelectedValueChanged += new System.EventHandler(this.comboBoxKontr2_SelectedValueChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinFormsProekt.Properties.Resources.create;
            this.pictureBox4.Location = new System.Drawing.Point(634, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsProekt.Properties.Resources.create;
            this.pictureBox1.Location = new System.Drawing.Point(157, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsProekt.Properties.Resources.save;
            this.pictureBox2.Location = new System.Drawing.Point(714, 591);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // ZayavkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(918, 656);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxKontr2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxKontr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOtvet);
            this.Controls.Add(this.textBoxOtvet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxZapros);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelPostavchik);
            this.Controls.Add(this.labelClient);
            this.MaximizeBox = false;
            this.Name = "ZayavkaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelClient;
        private Label labelPostavchik;
        public DateTimePicker dateTimePicker1;
        private Label labelStatus;
        public TextBox textBox1;
        public TextBox textBox2;
        public ComboBox comboBox1;
        public Label labelData;
        private Button buttonSave;
        public TextBox textBoxZapros;
        private Label label1;
        private Label labelOtvet;
        public TextBox textBoxOtvet;
        private Button button1;
        private Button button2;
        private ComboBox comboBoxKontr;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxKontr2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}