using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovProcess
{
    public class StrategyStepList
    {
        public int StepCount { get; set; }
        public int StateCount { get; set; }
        public int StrategyCount { get; set; }
        public int[,] D { get; set; }
        public double[,] V { get; set; }

        private int startX;
        private int startY;
        private int stepLength;
        private int circleRadius;
        private int strategyDistance;

        public StrategyStepList()
        {
            StepCount = 0;
            D = new int[0, 0];
            V = new double[0, 0];
        }

        public StrategyStepList(int stepCount, int[,] d, double[,] v, int stateCount = 3, int strategyCount = 3)
        {
            StepCount = stepCount;
            D = d;
            V = v;

            StateCount = stateCount;
            StrategyCount = strategyCount;
        }

        private Color GetColor(int i)
        {
            if (i % 3 == 0)
                return Color.Red;
            if (i % 2 == 1)
                return Color.Green;
            return Color.Blue;
        }

        public void DrawStrategies(Graphics g, int initState, int windowWidth = 830, int windowHeight = 440)
        {
            circleRadius = GetCircleRadius(windowWidth, windowHeight);
            stepLength = GetStepLength(windowWidth, windowHeight);
            strategyDistance = GetStrategyDistance(windowHeight);

            startX = GetCircleRadius(windowWidth, windowHeight) / 2;
            startY = GetCircleRadius(windowWidth, windowHeight) / 2;

            int initX = startX + circleRadius / 2;
            int initY = startY + initState * 2 * strategyDistance + circleRadius / 2;

            for (int j = 0; j < StateCount; j++)
            {
                int X2 = startX + 2 * (stepLength + circleRadius) + circleRadius / 2;
                int Y2 = startY + j * 2 * strategyDistance + circleRadius / 2;

                DrawSection(g, D[initState, 1], new Point(initX, initY), new Point(X2, Y2));
            }

            for (int n = 1; n < StepCount; n++)
            {
                for (int i = 0; i < StateCount; i++)
                {
                    int X1 = startX + n * 2 * (stepLength + circleRadius) + circleRadius / 2;
                    int Y1 = startY + i * 2 * strategyDistance + circleRadius / 2;

                    for (int j = 0; j < StateCount; j++)
                    {
                        int X2 = startX + (n + 1) * 2 * (stepLength + circleRadius) + circleRadius / 2;
                        int Y2 = startY + j * 2 * strategyDistance + circleRadius / 2;

                        DrawSection(g, D[i, n + 1], new Point(X1, Y1), new Point(X2, Y2));
                    }
                }
            }
        }

        /// <summary>
        /// Прорисовка отрезка 
        /// </summary>
        /// <param name="i">Номер оптимальной стратегии</param>
        /// <param name="p1">Начальное состояние (точка)</param>
        /// <param name="p2">Конечное состояние (точка)</param>
        private void DrawSection(Graphics g, int i, Point p1, Point p2)
        {
            SolidBrush brush = new SolidBrush(GetColor(i));
            Pen pen = new Pen(brush, 2);

            g.DrawLine(pen, p1, p2);
        }

        private int GetCircleRadius(int windowWidth, int windowHeight)
        {
            int value1 = windowHeight / (2 * StrategyCount);
            int value2 = windowWidth / (2 * StepCount);
            return Math.Min(value1, value2);
        }

        private int GetStepLength(int windowWidth, int windowHeight)
        {
            return windowWidth / (2 * GetCircleRadius(windowWidth, windowHeight) * StepCount);
        }

        private int GetStrategyDistance(int windowHeight)
        {
            return windowHeight / (2 * StrategyCount);
        }
    }
}
