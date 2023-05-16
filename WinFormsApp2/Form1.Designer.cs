namespace WinFormsApp2
{
    partial class frmMass
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtn = new TextBox();
            txtm = new TextBox();
            txtRez = new TextBox();
            dgvMass = new DataGridView();
            cmdStart = new Button();
            cmdClear = new Button();
            cmdExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 0;
            label1.Text = "Количество строк n=";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 21);
            label2.TabIndex = 1;
            label2.Text = "Количество столбцов m=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 256);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 2;
            label3.Text = "Результат:";
            label3.Click += label3_Click;
            // 
            // txtn
            // 
            txtn.Location = new Point(25, 83);
            txtn.Margin = new Padding(4);
            txtn.Name = "txtn";
            txtn.Size = new Size(217, 29);
            txtn.TabIndex = 3;
            txtn.TextChanged += txtn_TextChanged;
            // 
            // txtm
            // 
            txtm.Location = new Point(25, 198);
            txtm.Margin = new Padding(4);
            txtm.Name = "txtm";
            txtm.Size = new Size(217, 29);
            txtm.TabIndex = 4;
            // 
            // txtRez
            // 
            txtRez.Location = new Point(25, 293);
            txtRez.Margin = new Padding(4);
            txtRez.Multiline = true;
            txtRez.Name = "txtRez";
            txtRez.Size = new Size(349, 211);
            txtRez.TabIndex = 5;
            txtRez.TextChanged += txtRez_TextChanged;
            // 
            // dgvMass
            // 
            dgvMass.AllowUserToOrderColumns = true;
            dgvMass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMass.Location = new Point(383, 25);
            dgvMass.Margin = new Padding(4);
            dgvMass.Name = "dgvMass";
            dgvMass.RowTemplate.Height = 25;
            dgvMass.Size = new Size(615, 479);
            dgvMass.TabIndex = 6;
            dgvMass.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmdStart
            // 
            cmdStart.Location = new Point(51, 544);
            cmdStart.Margin = new Padding(4);
            cmdStart.Name = "cmdStart";
            cmdStart.Size = new Size(257, 62);
            cmdStart.TabIndex = 7;
            cmdStart.Text = "Вычислить";
            cmdStart.UseVisualStyleBackColor = true;
            cmdStart.Click += cmdStart_Click;
            // 
            // cmdClear
            // 
            cmdClear.Location = new Point(383, 544);
            cmdClear.Margin = new Padding(4);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(254, 62);
            cmdClear.TabIndex = 8;
            cmdClear.Text = "Очистка полей";
            cmdClear.UseVisualStyleBackColor = true;
            cmdClear.Click += cmdClear_Click;
            // 
            // cmdExit
            // 
            cmdExit.Location = new Point(744, 544);
            cmdExit.Margin = new Padding(4);
            cmdExit.Name = "cmdExit";
            cmdExit.Size = new Size(254, 62);
            cmdExit.TabIndex = 9;
            cmdExit.Text = "Завершить работу";
            cmdExit.UseVisualStyleBackColor = true;
            cmdExit.Click += cmdExit_Click;
            // 
            // frmMass
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(cmdExit);
            Controls.Add(cmdClear);
            Controls.Add(cmdStart);
            Controls.Add(dgvMass);
            Controls.Add(txtRez);
            Controls.Add(txtm);
            Controls.Add(txtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmMass";
            Text = "Двумерные массивы";
            ((System.ComponentModel.ISupportInitialize)dgvMass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtn;
        private TextBox txtm;
        private TextBox txtRez;
        private DataGridView dgvMass;
        private Button cmdStart;
        private Button cmdClear;
        private Button cmdExit;
    }
}