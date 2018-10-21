using System;
using System.Windows.Forms;
using System.IO;

namespace MarkovProcess
{
    public partial class MainWindow : Form
    {
        static int stateCount = 3;
        static int strategyCount = 3;
        static int stepCount;

        double[,,] P = new double[stateCount, stateCount, strategyCount]; // вероятность перехода от состояния i к состоянию j при выборе k стратегии
        double[,,] R = new double[stateCount, stateCount, strategyCount]; // доходность перехода от состояния i к состоянию j при выборе k стратегии
        double[,] myQ; // ожидаемая доходность за один переход
        double[] KS;
        int[,] vi;
        double[,] vir;
        int[,] di;

        public MainWindow()
        {
            InitializeComponent();
            stepCount = 3;
        }

        void FillMatrix()
        {

            int l = 0;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    P[l, i, j] = Convert.ToDouble(probabilityDataGridView1.Rows[i].Cells[j].Value);
            l++;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    P[l, i, j] = Convert.ToDouble(probabilityDataGridView2.Rows[i].Cells[j].Value);
            l++;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    P[l, i, j] = Convert.ToDouble(probabilityDataGridView3.Rows[i].Cells[j].Value);


            l = 0;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    R[l, i, j] = Convert.ToDouble(profitDataGridView1.Rows[i].Cells[j].Value);
            l++;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    R[l, i, j] = Convert.ToDouble(profitDataGridView2.Rows[i].Cells[j].Value);
            l++;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    R[l, i, j] = Convert.ToDouble(profitDataGridView3.Rows[i].Cells[j].Value);
        }


        private void stepTextBox_TextChanged(object sender, EventArgs e)
        {
            if (stepTextBox.Text.Length == 0)
                stepTextBox.Text = 3.ToString();
            else
                stepCount = Convert.ToInt32(stepTextBox.Text);
        }

        /// <summary>
        /// Событие нажатия на кнопку Рассчитать
        /// </summary>
        private void createPlotButton_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                FillMatrix();
                Step1();
                Step2();
                Step3();

                int[,] d = new int[stateCount, stepCount + 1];
                double[,] v = new double[stateCount, stepCount + 1];
                for (int i = 0; i < stateCount; i++)
                    for (int j = 0; j < stepCount + 1; j++)
                    {
                        v[i, j] = vir[j, i];
                        d[i, j] = vi[j, i];
                    }

                StrategyStepList stepList = new StrategyStepList(stepCount, d, v);
                PlotWindow plotWindow = new PlotWindow(stepCount + 1, stepList);
                plotWindow.Show();
            }
            else
                MessageBox.Show("Все поля должны быть заполнены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public void Step1()
        {
            myQ = new double[strategyCount, stateCount];
            for (int k = 0; k < strategyCount; k++)
            {
                for (int i = 0; i < stateCount; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < stateCount; j++)
                    {
                        sum += P[k, i, j] * R[k, i, j];
                    }
                    myQ[k, i] = sum;
                }
            }
        }

        public void Step2()
        {
            vi = new int[stepCount + 1, stateCount];
            vir = new double[stepCount + 1, stateCount];
            for (int j = 0; j < stateCount; j++)
                vir[0, j] = 0;
            for (int n = 1; n <= stepCount; n++)
            {
                for (int i = 0; i < stateCount; i++)
                {
                    KS = new double[strategyCount];
                    for (int k = 0; k < strategyCount; k++)
                    {
                        double sum = 0;
                        for (int j = 0; j < stateCount; j++)
                        {
                            sum += P[k, i, j] * vir[n - 1, j];

                        }
                        KS[k] = myQ[k, i] + sum;
                    }
                    int indmax = -1;
                    double myMax = double.MinValue;
                    String str = "";
                    for (int myk = 0; myk < strategyCount; myk++)
                    {
                        str += KS[myk].ToString() + "  ";
                        if (KS[myk] > myMax)
                        {
                            indmax = myk;
                            myMax = KS[myk];
                        }
                    }
                    vi[n, i] = indmax;
                    vir[n, i] = myMax;

                }
            }

        }

        public void Step3()
        {
            di = new int[stepCount, stateCount];
            for (int n = 1; n <= stepCount; n++)
            {
                for (int i = 0; i < stateCount; i++)
                {
                    int myMax = int.MinValue;
                    for (int myindex = 0; myindex < stateCount; myindex++)
                    {
                        if (vi[n, myindex] > myMax)
                        {
                            myMax = vi[n, myindex];
                        }
                    }
                    di[n - 1, i] = myMax;
                }
            }
        }

        /// <summary>
        /// Проверка на заполненность всех полей
        /// </summary>
        private bool CheckData()
        {

            if (stepCount == 0)
                return false;

            if (probabilityDataGridView1 == null
                || probabilityDataGridView2 == null
                || probabilityDataGridView3 == null)
                return false;

            if (profitDataGridView1 == null
                || profitDataGridView2 == null
                || profitDataGridView3 == null)
                return false;

            return true;
        }

        private void ClearDataGrid()
        {
            probabilityDataGridView1.Rows.Clear();
            probabilityDataGridView1.Columns.Clear();
            probabilityDataGridView2.Rows.Clear();
            probabilityDataGridView2.Columns.Clear();
            probabilityDataGridView3.Rows.Clear();
            probabilityDataGridView3.Columns.Clear();

            profitDataGridView1.Rows.Clear();
            profitDataGridView1.Columns.Clear();
            profitDataGridView2.Rows.Clear();
            profitDataGridView2.Columns.Clear();
            profitDataGridView3.Rows.Clear();
            profitDataGridView3.Columns.Clear();
        }

        private void OverDraw()
        {
            for (int i = 0; i < stateCount; i++)
            {
                probabilityDataGridView1.Columns.Add((i + 1).ToString(), "  " + (i + 1).ToString());
                probabilityDataGridView2.Columns.Add((i + 1).ToString(), "  " + (i + 1).ToString());
                probabilityDataGridView3.Columns.Add((i + 1).ToString(), "  " + (i + 1).ToString());
            }
            for (int i = 0; i < stateCount; i++)
            {
                probabilityDataGridView1.Rows.Add();
                probabilityDataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                probabilityDataGridView2.Rows.Add();
                probabilityDataGridView2.Rows[i].HeaderCell.Value = (i + 1).ToString();
                probabilityDataGridView3.Rows.Add();
                probabilityDataGridView3.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            for (int i = 0; i < stateCount; i++)
            {
                profitDataGridView1.Columns.Add((i + 1).ToString(), "  " + (i + 1).ToString());
                profitDataGridView2.Columns.Add((i + 1).ToString(), "  " + (i + 1).ToString());
                profitDataGridView3.Columns.Add((i + 1).ToString(), "  " + (i + 1).ToString());
            }
            for (int i = 0; i < stateCount; i++)
            {
                profitDataGridView1.Rows.Add();
                profitDataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                profitDataGridView2.Rows.Add();
                profitDataGridView2.Rows[i].HeaderCell.Value = (i + 1).ToString();
                profitDataGridView3.Rows.Add();
                profitDataGridView3.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ClearDataGrid();
            OverDraw();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "тпр|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(openFileDialog1.FileName);
                LoadFile(stream);


                stream.Close();
            }
        }
        public void LoadFile(StreamReader Stream)
        {

            for (int i = 0; i < stateCount; i++)
            {
                for (int j = 0; j < stateCount; j++)
                {
                    for (int l = 0; l < strategyCount; l++)
                    {
                        P[i, j, l] = Convert.ToDouble(Stream.ReadLine());
                    }
                }
            }

            for (int i = 0; i < stateCount; i++)
            {
                for (int j = 0; j < stateCount; j++)
                {
                    for (int l = 0; l < strategyCount; l++)
                    {
                        R[i, j, l] = Convert.ToDouble(Stream.ReadLine());
                    }
                }
            }
            int w = 0;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    probabilityDataGridView1.Rows[i].Cells[j].Value = Convert.ToDouble(P[w, i, j]);
            w++;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    probabilityDataGridView2.Rows[i].Cells[j].Value = Convert.ToDouble(P[w, i, j]);
            w++;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    probabilityDataGridView3.Rows[i].Cells[j].Value = Convert.ToDouble(P[w, i, j]);


            w = 0;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    profitDataGridView1.Rows[i].Cells[j].Value = Convert.ToDouble(R[w, i, j]);
            w++;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    profitDataGridView2.Rows[i].Cells[j].Value = Convert.ToDouble(R[w, i, j]);
            w++;
            for (int i = 0; i < stateCount; i++)
                for (int j = 0; j < stateCount; j++)
                    profitDataGridView3.Rows[i].Cells[j].Value = Convert.ToDouble(R[w, i, j]);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "тпр1|*.txt";
            saveFileDialog1.DefaultExt = "tpr1";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(saveFileDialog1.FileName);
                Save(stream);
                stream.Close();
            }
        }
        public void Save(StreamWriter stream)
        {

            for (int i = 0; i < stateCount; i++)
            {
                for (int j = 0; j < stateCount; j++)
                {
                    for (int l = 0; l < strategyCount; l++)
                    {
                        stream.WriteLine(P[i, j, l].ToString() + " ");
                    }
                }
            }
            for (int i = 0; i < stateCount; i++)
            {
                for (int j = 0; j < stateCount; j++)
                {
                    for (int l = 0; l < strategyCount; l++)
                    {
                        stream.WriteLine(R[i, j, l].ToString() + " ");
                    }
                }
            }
        }
    }
}
