using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MarkovProcess
{
    public partial class PlotWindow : Form
    {
        private int StepCount;
        private StrategyStepList strategyStepList;
        private int startX;
        private int startY;
        private int stepLength;
        private int circleRadius;
        private int strategyDistance;
        private int initState;

        public PlotWindow(int stepCount, StrategyStepList _strategyStepList)
        {
            InitializeComponent();

            StepCount = stepCount;
            strategyStepList = _strategyStepList;
            plotPictureBox.Refresh();
            initState = 0;
            FillDataGrids();
        }

        private void FillDataGrids()
        {
            profitDataGridView.RowCount = strategyStepList.StateCount;
            profitDataGridView.ColumnCount = strategyStepList.StepCount;

            strategyDataGridView.RowCount = strategyStepList.StateCount;
            strategyDataGridView.ColumnCount = strategyStepList.StepCount;

            for (int i = 0; i < strategyStepList.StateCount; i++)
            {
                profitDataGridView.Rows[i].HeaderCell.Value = GetStateName(i);
                strategyDataGridView.Rows[i].HeaderCell.Value = GetStateName(i);
                for (int j = 0; j < strategyStepList.StepCount; j++)
                {
                    profitDataGridView.Rows[i].Cells[j].Value = strategyStepList.V[i, j + 1];
                    strategyDataGridView.Rows[i].Cells[j].Value = strategyStepList.D[i, j + 1] + 1;
                }
            }

            for (int i = 0; i < strategyStepList.StepCount; i++)
            {
                profitDataGridView.Columns[i].HeaderCell.Value = (i + 1).ToString();
                strategyDataGridView.Columns[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private string GetStateName(int i)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int j = 0; j < alphabet.Length; j++)
                if (i % strategyStepList.StateCount == j)
                    return alphabet[j].ToString();

            return "A";
        }

        private void DrawPlot(Graphics g)
        {
            circleRadius = GetCircleRadius();
            stepLength = GetStepLength();
            strategyDistance = GetStrategyDistance();

            startX = GetCircleRadius() / 2;
            startY = GetCircleRadius() / 2;

            //Прорисовка лучших стратегий
            strategyStepList.DrawStrategies(g, initState);

            //Прорисовка состояний на нужное число шагов моделирования
            for (int i = 0; i < StepCount; i++)
            {
                for (int j = 0; j < strategyStepList.StateCount; j++)
                {
                    int currentX = startX + i * 2 * (stepLength + circleRadius);
                    int currentY = startY + j * 2 * strategyDistance;
                    Pen pen = new Pen(Brushes.Black, 1);
                    g.FillEllipse(Brushes.White, currentX, currentY, circleRadius, circleRadius);
                    g.DrawEllipse(pen, currentX, currentY, circleRadius, circleRadius);
                    g.DrawString(GetStateName(j), new Font("Times New Roman", 10), Brushes.DarkBlue, currentX + circleRadius / 2 - 5, currentY + circleRadius / 2 - 5);
                }
            }
        }

        private int GetCircleRadius()
        {
            int value1 = plotPictureBox.Size.Height / (2 * strategyStepList.StateCount);
            int value2 = plotPictureBox.Size.Width / (2 * StepCount);
            return Math.Min(value1, value2);
        }

        private int GetStepLength()
        {
            return plotPictureBox.Size.Width / (2 * GetCircleRadius() * StepCount);
        }

        private int GetStrategyDistance()
        {
            return plotPictureBox.Size.Height / (2 * strategyStepList.StateCount);
        }

        private void plotPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawPlot(g);
        }

        private void stateRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (stateRadioButton1.Checked == true)
            {
                initState = 0;
                plotPictureBox.Refresh();
            }
        }

        private void stateRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (stateRadioButton2.Checked == true)
            {
                initState = 1;
                plotPictureBox.Refresh();
            }
        }

        private void stateRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (stateRadioButton3.Checked == true)
            {
                initState = 2;
                plotPictureBox.Refresh();
            }
        }
    }
}
