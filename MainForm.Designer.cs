
namespace Practic6
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.modelingB = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nNumeric = new System.Windows.Forms.NumericUpDown();
            this.kNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mNumeric = new System.Windows.Forms.NumericUpDown();
            this.vNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bNumeric = new System.Windows.Forms.NumericUpDown();
            this.dNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumeric)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modelingB
            // 
            this.modelingB.Location = new System.Drawing.Point(6, 412);
            this.modelingB.Name = "modelingB";
            this.modelingB.Size = new System.Drawing.Size(120, 23);
            this.modelingB.TabIndex = 1;
            this.modelingB.Text = "Моделироавание";
            this.modelingB.UseVisualStyleBackColor = true;
            this.modelingB.Click += new System.EventHandler(this.modelingB_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(6, 19);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(300, 381);
            this.listBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество задач(N):";
            // 
            // nNumeric
            // 
            this.nNumeric.Location = new System.Drawing.Point(132, 12);
            this.nNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nNumeric.Name = "nNumeric";
            this.nNumeric.Size = new System.Drawing.Size(64, 20);
            this.nNumeric.TabIndex = 5;
            this.nNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // kNumeric
            // 
            this.kNumeric.Location = new System.Drawing.Point(176, 14);
            this.kNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kNumeric.Name = "kNumeric";
            this.kNumeric.Size = new System.Drawing.Size(64, 20);
            this.kNumeric.TabIndex = 7;
            this.kNumeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время обработки (k):";
            // 
            // lNumeric
            // 
            this.lNumeric.Location = new System.Drawing.Point(176, 40);
            this.lNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lNumeric.Name = "lNumeric";
            this.lNumeric.Size = new System.Drawing.Size(64, 20);
            this.lNumeric.TabIndex = 9;
            this.lNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Погрешность времени (l):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kNumeric);
            this.groupBox1.Controls.Add(this.lNumeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 64);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры CPU:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mNumeric);
            this.groupBox2.Controls.Add(this.vNumeric);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(266, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 64);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры HDD:";
            // 
            // mNumeric
            // 
            this.mNumeric.Location = new System.Drawing.Point(176, 14);
            this.mNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mNumeric.Name = "mNumeric";
            this.mNumeric.Size = new System.Drawing.Size(64, 20);
            this.mNumeric.TabIndex = 7;
            this.mNumeric.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // vNumeric
            // 
            this.vNumeric.Location = new System.Drawing.Point(176, 40);
            this.vNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.vNumeric.Name = "vNumeric";
            this.vNumeric.Size = new System.Drawing.Size(64, 20);
            this.vNumeric.TabIndex = 9;
            this.vNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Погрешность времени (v):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Время обработки (m):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bNumeric);
            this.groupBox3.Controls.Add(this.dNumeric);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(518, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 64);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры NET:";
            // 
            // bNumeric
            // 
            this.bNumeric.Location = new System.Drawing.Point(176, 14);
            this.bNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bNumeric.Name = "bNumeric";
            this.bNumeric.Size = new System.Drawing.Size(64, 20);
            this.bNumeric.TabIndex = 7;
            this.bNumeric.Value = new decimal(new int[] {
            140,
            0,
            0,
            0});
            // 
            // dNumeric
            // 
            this.dNumeric.Location = new System.Drawing.Point(176, 40);
            this.dNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.dNumeric.Name = "dNumeric";
            this.dNumeric.Size = new System.Drawing.Size(64, 20);
            this.dNumeric.TabIndex = 9;
            this.dNumeric.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Погрешность времени (d):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Время обработки (b):";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox);
            this.groupBox4.Controls.Add(this.modelingB);
            this.groupBox4.Location = new System.Drawing.Point(14, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 441);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ход обработки задач:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView);
            this.groupBox5.Location = new System.Drawing.Point(333, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(431, 440);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Созданные задачи:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CCPU,
            this.CHDD,
            this.CNET});
            this.dataGridView.Location = new System.Drawing.Point(7, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(418, 414);
            this.dataGridView.TabIndex = 0;
            // 
            // CName
            // 
            this.CName.Frozen = true;
            this.CName.HeaderText = "Имя";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 75;
            // 
            // CCPU
            // 
            this.CCPU.Frozen = true;
            this.CCPU.HeaderText = "Время(CPU)";
            this.CCPU.Name = "CCPU";
            this.CCPU.ReadOnly = true;
            // 
            // CHDD
            // 
            this.CHDD.Frozen = true;
            this.CHDD.HeaderText = "Время(HDD)";
            this.CHDD.Name = "CHDD";
            this.CHDD.ReadOnly = true;
            // 
            // CNET
            // 
            this.CNET.Frozen = true;
            this.CNET.HeaderText = "Время(NET)";
            this.CNET.Name = "CNET";
            this.CNET.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nNumeric);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Моделирование системы пакетной обработки данных";
            ((System.ComponentModel.ISupportInitialize)(this.nNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNumeric)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button modelingB;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nNumeric;
        private System.Windows.Forms.NumericUpDown kNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown mNumeric;
        private System.Windows.Forms.NumericUpDown vNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown bNumeric;
        private System.Windows.Forms.NumericUpDown dNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNET;
    }
}

