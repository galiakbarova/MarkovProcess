namespace MarkovProcess
{
    partial class PlotWindow
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
            this.plotPictureBox = new System.Windows.Forms.PictureBox();
            this.plotLabel = new System.Windows.Forms.Label();
            this.legendLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.strategyLabel = new System.Windows.Forms.Label();
            this.stateDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.strategyDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.stateRadioButton3 = new System.Windows.Forms.RadioButton();
            this.stateRadioButton2 = new System.Windows.Forms.RadioButton();
            this.stateRadioButton1 = new System.Windows.Forms.RadioButton();
            this.initialStateLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.profitDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.strategyDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.plotPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profitDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strategyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // plotPictureBox
            // 
            this.plotPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.plotPictureBox.Location = new System.Drawing.Point(12, 53);
            this.plotPictureBox.Name = "plotPictureBox";
            this.plotPictureBox.Size = new System.Drawing.Size(830, 440);
            this.plotPictureBox.TabIndex = 0;
            this.plotPictureBox.TabStop = false;
            this.plotPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.plotPictureBox_Paint);
            // 
            // plotLabel
            // 
            this.plotLabel.AutoSize = true;
            this.plotLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.plotLabel.Location = new System.Drawing.Point(399, 9);
            this.plotLabel.Name = "plotLabel";
            this.plotLabel.Size = new System.Drawing.Size(62, 29);
            this.plotLabel.TabIndex = 1;
            this.plotLabel.Text = "Граф";
            // 
            // legendLabel
            // 
            this.legendLabel.AutoSize = true;
            this.legendLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legendLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.legendLabel.Location = new System.Drawing.Point(986, 9);
            this.legendLabel.Name = "legendLabel";
            this.legendLabel.Size = new System.Drawing.Size(88, 29);
            this.legendLabel.TabIndex = 2;
            this.legendLabel.Text = "Легенда";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stateLabel.Location = new System.Drawing.Point(883, 66);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(104, 22);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "Состояния";
            // 
            // strategyLabel
            // 
            this.strategyLabel.AutoSize = true;
            this.strategyLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strategyLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.strategyLabel.Location = new System.Drawing.Point(883, 184);
            this.strategyLabel.Name = "strategyLabel";
            this.strategyLabel.Size = new System.Drawing.Size(99, 22);
            this.strategyLabel.TabIndex = 4;
            this.strategyLabel.Text = "Стратегии";
            // 
            // stateDescriptionTextBox
            // 
            this.stateDescriptionTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateDescriptionTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stateDescriptionTextBox.Location = new System.Drawing.Point(865, 91);
            this.stateDescriptionTextBox.Multiline = true;
            this.stateDescriptionTextBox.Name = "stateDescriptionTextBox";
            this.stateDescriptionTextBox.ReadOnly = true;
            this.stateDescriptionTextBox.Size = new System.Drawing.Size(338, 72);
            this.stateDescriptionTextBox.TabIndex = 5;
            this.stateDescriptionTextBox.Text = "А - количество скачиваний растет;\r\nБ - количество скачиваний стабильно;\r\nВ - коли" +
    "чество скачиваний падает.";
            // 
            // strategyDescriptionTextBox
            // 
            this.strategyDescriptionTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.strategyDescriptionTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.strategyDescriptionTextBox.Location = new System.Drawing.Point(871, 209);
            this.strategyDescriptionTextBox.Multiline = true;
            this.strategyDescriptionTextBox.Name = "strategyDescriptionTextBox";
            this.strategyDescriptionTextBox.ReadOnly = true;
            this.strategyDescriptionTextBox.Size = new System.Drawing.Size(337, 95);
            this.strategyDescriptionTextBox.TabIndex = 6;
            this.strategyDescriptionTextBox.Text = "1 - перераспределение обязанностей (красный);\r\n2 - набор новых сотрудников (зелен" +
    "ый);\r\n3 - повышение квалификации старых сотрудников (синий).";
            // 
            // stateRadioButton3
            // 
            this.stateRadioButton3.AutoSize = true;
            this.stateRadioButton3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateRadioButton3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stateRadioButton3.Location = new System.Drawing.Point(653, 529);
            this.stateRadioButton3.Name = "stateRadioButton3";
            this.stateRadioButton3.Size = new System.Drawing.Size(106, 24);
            this.stateRadioButton3.TabIndex = 8;
            this.stateRadioButton3.Text = "Состояние В";
            this.stateRadioButton3.UseVisualStyleBackColor = true;
            this.stateRadioButton3.CheckedChanged += new System.EventHandler(this.stateRadioButton3_CheckedChanged);
            // 
            // stateRadioButton2
            // 
            this.stateRadioButton2.AutoSize = true;
            this.stateRadioButton2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateRadioButton2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stateRadioButton2.Location = new System.Drawing.Point(340, 529);
            this.stateRadioButton2.Name = "stateRadioButton2";
            this.stateRadioButton2.Size = new System.Drawing.Size(106, 24);
            this.stateRadioButton2.TabIndex = 1;
            this.stateRadioButton2.Text = "Состояние Б";
            this.stateRadioButton2.UseVisualStyleBackColor = true;
            this.stateRadioButton2.CheckedChanged += new System.EventHandler(this.stateRadioButton2_CheckedChanged);
            // 
            // stateRadioButton1
            // 
            this.stateRadioButton1.AutoSize = true;
            this.stateRadioButton1.Checked = true;
            this.stateRadioButton1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateRadioButton1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stateRadioButton1.Location = new System.Drawing.Point(40, 529);
            this.stateRadioButton1.Name = "stateRadioButton1";
            this.stateRadioButton1.Size = new System.Drawing.Size(106, 24);
            this.stateRadioButton1.TabIndex = 0;
            this.stateRadioButton1.TabStop = true;
            this.stateRadioButton1.Text = "Состояние А";
            this.stateRadioButton1.UseVisualStyleBackColor = true;
            this.stateRadioButton1.CheckedChanged += new System.EventHandler(this.stateRadioButton1_CheckedChanged);
            // 
            // initialStateLabel
            // 
            this.initialStateLabel.AutoSize = true;
            this.initialStateLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialStateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.initialStateLabel.Location = new System.Drawing.Point(325, 496);
            this.initialStateLabel.Name = "initialStateLabel";
            this.initialStateLabel.Size = new System.Drawing.Size(213, 29);
            this.initialStateLabel.TabIndex = 8;
            this.initialStateLabel.Text = "Начальное состояние";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.resultsLabel.Location = new System.Drawing.Point(904, 374);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(270, 29);
            this.resultsLabel.TabIndex = 9;
            this.resultsLabel.Text = "Результаты моделирования";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(858, 416);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 128);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.profitDataGridView);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(357, 102);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Полный ожидаемый доход";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // profitDataGridView
            // 
            this.profitDataGridView.AllowUserToAddRows = false;
            this.profitDataGridView.AllowUserToDeleteRows = false;
            this.profitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profitDataGridView.Location = new System.Drawing.Point(3, 3);
            this.profitDataGridView.Name = "profitDataGridView";
            this.profitDataGridView.Size = new System.Drawing.Size(350, 95);
            this.profitDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.strategyDataGridView);
            this.tabPage2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(357, 102);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оптимальные стратегии";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // strategyDataGridView
            // 
            this.strategyDataGridView.AllowUserToAddRows = false;
            this.strategyDataGridView.AllowUserToDeleteRows = false;
            this.strategyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.strategyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.strategyDataGridView.Name = "strategyDataGridView";
            this.strategyDataGridView.Size = new System.Drawing.Size(350, 95);
            this.strategyDataGridView.TabIndex = 0;
            // 
            // PlotWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1226, 574);
            this.Controls.Add(this.stateRadioButton3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.stateRadioButton2);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.stateRadioButton1);
            this.Controls.Add(this.initialStateLabel);
            this.Controls.Add(this.strategyDescriptionTextBox);
            this.Controls.Add(this.stateDescriptionTextBox);
            this.Controls.Add(this.strategyLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.legendLabel);
            this.Controls.Add(this.plotLabel);
            this.Controls.Add(this.plotPictureBox);
            this.Name = "PlotWindow";
            this.Text = "PlotWindow";
            ((System.ComponentModel.ISupportInitialize)(this.plotPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profitDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.strategyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox plotPictureBox;
        private System.Windows.Forms.Label plotLabel;
        private System.Windows.Forms.Label legendLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label strategyLabel;
        private System.Windows.Forms.TextBox stateDescriptionTextBox;
        private System.Windows.Forms.TextBox strategyDescriptionTextBox;
        private System.Windows.Forms.RadioButton stateRadioButton3;
        private System.Windows.Forms.RadioButton stateRadioButton2;
        private System.Windows.Forms.RadioButton stateRadioButton1;
        private System.Windows.Forms.Label initialStateLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView profitDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView strategyDataGridView;
    }
}