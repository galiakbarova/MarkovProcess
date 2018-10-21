namespace MarkovProcess
{
    partial class MainWindow
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
            this.instrumentPanelLabel = new System.Windows.Forms.Label();
            this.probabiltyMatrixLabel = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.probabilityDataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.probabilityDataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.probabilityDataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.profitDataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.profitDataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.profitDataGridView3 = new System.Windows.Forms.DataGridView();
            this.createPlotButton = new System.Windows.Forms.Button();
            this.stepLabel = new System.Windows.Forms.Label();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGridView3)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profitDataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profitDataGridView2)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profitDataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // instrumentPanelLabel
            // 
            this.instrumentPanelLabel.AutoSize = true;
            this.instrumentPanelLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentPanelLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instrumentPanelLabel.Location = new System.Drawing.Point(343, 9);
            this.instrumentPanelLabel.Name = "instrumentPanelLabel";
            this.instrumentPanelLabel.Size = new System.Drawing.Size(181, 29);
            this.instrumentPanelLabel.TabIndex = 0;
            this.instrumentPanelLabel.Text = "Исходные данные";
            // 
            // probabiltyMatrixLabel
            // 
            this.probabiltyMatrixLabel.AutoSize = true;
            this.probabiltyMatrixLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probabiltyMatrixLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.probabiltyMatrixLabel.Location = new System.Drawing.Point(118, 111);
            this.probabiltyMatrixLabel.Name = "probabiltyMatrixLabel";
            this.probabiltyMatrixLabel.Size = new System.Drawing.Size(220, 16);
            this.probabiltyMatrixLabel.TabIndex = 5;
            this.probabiltyMatrixLabel.Text = "Матрица переходных вероятностей";
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profitLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.profitLabel.Location = new System.Drawing.Point(543, 111);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(140, 16);
            this.profitLabel.TabIndex = 8;
            this.profitLabel.Text = "Матрица доходностей";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(43, 146);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 128);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.probabilityDataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 102);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Стратегия 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // probabilityDataGridView1
            // 
            this.probabilityDataGridView1.AllowUserToAddRows = false;
            this.probabilityDataGridView1.AllowUserToDeleteRows = false;
            this.probabilityDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.probabilityDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.probabilityDataGridView1.Name = "probabilityDataGridView1";
            this.probabilityDataGridView1.Size = new System.Drawing.Size(345, 95);
            this.probabilityDataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.probabilityDataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 102);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Стратегия 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // probabilityDataGridView2
            // 
            this.probabilityDataGridView2.AllowUserToAddRows = false;
            this.probabilityDataGridView2.AllowUserToDeleteRows = false;
            this.probabilityDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.probabilityDataGridView2.Location = new System.Drawing.Point(3, 3);
            this.probabilityDataGridView2.Name = "probabilityDataGridView2";
            this.probabilityDataGridView2.Size = new System.Drawing.Size(345, 95);
            this.probabilityDataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.probabilityDataGridView3);
            this.tabPage3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(352, 102);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Стратегия 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // probabilityDataGridView3
            // 
            this.probabilityDataGridView3.AllowUserToAddRows = false;
            this.probabilityDataGridView3.AllowUserToDeleteRows = false;
            this.probabilityDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.probabilityDataGridView3.Location = new System.Drawing.Point(3, 3);
            this.probabilityDataGridView3.Name = "probabilityDataGridView3";
            this.probabilityDataGridView3.Size = new System.Drawing.Size(345, 95);
            this.probabilityDataGridView3.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(427, 146);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(360, 128);
            this.tabControl2.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.profitDataGridView1);
            this.tabPage4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(352, 102);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Стратегия 1";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // profitDataGridView1
            // 
            this.profitDataGridView1.AllowUserToAddRows = false;
            this.profitDataGridView1.AllowUserToDeleteRows = false;
            this.profitDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profitDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.profitDataGridView1.Name = "profitDataGridView1";
            this.profitDataGridView1.Size = new System.Drawing.Size(345, 95);
            this.profitDataGridView1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.profitDataGridView2);
            this.tabPage5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(352, 102);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Стратегия 2";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // profitDataGridView2
            // 
            this.profitDataGridView2.AllowUserToAddRows = false;
            this.profitDataGridView2.AllowUserToDeleteRows = false;
            this.profitDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profitDataGridView2.Location = new System.Drawing.Point(3, 3);
            this.profitDataGridView2.Name = "profitDataGridView2";
            this.profitDataGridView2.Size = new System.Drawing.Size(345, 95);
            this.profitDataGridView2.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.profitDataGridView3);
            this.tabPage6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(352, 102);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Стратегия 3";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // profitDataGridView3
            // 
            this.profitDataGridView3.AllowUserToAddRows = false;
            this.profitDataGridView3.AllowUserToDeleteRows = false;
            this.profitDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profitDataGridView3.Location = new System.Drawing.Point(3, 3);
            this.profitDataGridView3.Name = "profitDataGridView3";
            this.profitDataGridView3.Size = new System.Drawing.Size(345, 95);
            this.profitDataGridView3.TabIndex = 0;
            // 
            // createPlotButton
            // 
            this.createPlotButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createPlotButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.createPlotButton.Location = new System.Drawing.Point(328, 280);
            this.createPlotButton.Name = "createPlotButton";
            this.createPlotButton.Size = new System.Drawing.Size(165, 40);
            this.createPlotButton.TabIndex = 14;
            this.createPlotButton.Text = "Рассчитать";
            this.createPlotButton.UseVisualStyleBackColor = true;
            this.createPlotButton.Click += new System.EventHandler(this.createPlotButton_Click);
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stepLabel.Location = new System.Drawing.Point(40, 74);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(216, 16);
            this.stepLabel.TabIndex = 15;
            this.stepLabel.Text = "Количество шагов моделирования";
            // 
            // stepTextBox
            // 
            this.stepTextBox.Location = new System.Drawing.Point(275, 73);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(69, 20);
            this.stepTextBox.TabIndex = 16;
            this.stepTextBox.Text = "3";
            this.stepTextBox.TextChanged += new System.EventHandler(this.stepTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SaveButton.Location = new System.Drawing.Point(586, 65);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(193, 32);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Сохранить данные";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LoadButton.Location = new System.Drawing.Point(373, 65);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(193, 32);
            this.LoadButton.TabIndex = 18;
            this.LoadButton.Text = "Загрузить данные из файла";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 326);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.stepTextBox);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.createPlotButton);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.profitLabel);
            this.Controls.Add(this.probabiltyMatrixLabel);
            this.Controls.Add(this.instrumentPanelLabel);
            this.Name = "MainWindow";
            this.Text = "Марковские процессы";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.probabilityDataGridView3)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profitDataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profitDataGridView2)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profitDataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instrumentPanelLabel;
        private System.Windows.Forms.Label probabiltyMatrixLabel;
        private System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView probabilityDataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView probabilityDataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView probabilityDataGridView3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView profitDataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView profitDataGridView2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView profitDataGridView3;
        private System.Windows.Forms.Button createPlotButton;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.TextBox stepTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

