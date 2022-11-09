using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe_AI
{
    public partial class Form1 : Form
    {
        // 1 = X , 2 = O , 0 = nothing.
        private int iterate = 10000, eg = 17, W = 100, L = -100, D = 0;
        private double alpha = 0.2, discount = 0.8;
        private int[] board = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int[] features = new int[11] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        private double[] weights;
        private bool rndMove = false;
        private double[][] states = new double[19683][];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = Color.Lime;
            btn.Text = "X";
            btn.Enabled = false;
            makeMove((Int32.Parse(btn.Name.Last().ToString())) - 1, 2, board);

            if (isfinished(board) == 2)
            {
                table.Enabled = false;
                gameStateLabel.Text = "You have won the Game!";
                gameStateLabel.ForeColor = Color.Lime;
                return;
            }
            if (isfinished(board) == 3)
            {
                table.Enabled = false;
                gameStateLabel.Text = "The game is Draw!";
                gameStateLabel.ForeColor = Color.FromArgb(128, 128, 255);
                return;
            }
            
            int pcMove = selectMoveA(1, board);
            Button btn2 = table.Controls["button" + (pcMove + 1)] as Button;
            btn2.BackColor = Color.Red;
            btn2.Text = "O";
            btn2.Enabled = false;
            makeMove(pcMove, 1, board);

            if (isfinished(board) == 1)
            {
                table.Enabled = false;
                gameStateLabel.Text = "PC has won the Game!";
                gameStateLabel.ForeColor = Color.Red;
                return;
            }
            if (isfinished(board) == 3)
            {
                table.Enabled = false;
                gameStateLabel.Text = "The game is Draw!";
                gameStateLabel.ForeColor = Color.FromArgb(128, 128, 255);
                return;
            }
            
        }

        private void TrainA_Click(object sender, EventArgs e)
        {
            weights = new double[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < iterateA.Value; i++)
            {
                trainA();
            }
            printWeights();

            table.Enabled = true;
            playfirstRadioBTN.Enabled = true;
            pcplaysfirstRadioBTN.Enabled = true;
            RetryBTN.Enabled = true;
            RetryBTN.PerformClick();
        }

        private void trainA()
        {
            // 1 = O , 2 = X , 0 = nothing.
            board = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            // isfinished = 0 : not finished.
            // isfinished = 1 : O has won.
            // isfinished = 2 : X has won.
            // isfinished = 3 : the game is Draw.
            while (isfinished(board) == 0 && getEmptyBoardIndices(board).Length > 2)
            {
                double Vhat = V(board);

                makeMove(selectMoveA(1, board), 1, board);

                if (rndMove)
                {
                    makeMove(randomMove(board), 2, board);
                }
                else
                {
                    makeMove(selectMoveA(2, board), 2, board);
                }

                double Vtrain = V(board);
                for (int i = 0; i < weights.Length; i++)
                {
                    weights[i] = features[i] * (weights[i] + ((Convert.ToDouble(LearningRateA.Value) * (Vtrain - Vhat)) * callFeatures(i, board)));
                    weights[i] = Math.Round(weights[i], 2);
                }
            }

            int Vtrain2 = 0;
            if (isfinished(board) == 1)
            {
                Vtrain2 = Convert.ToInt32(WinA.Value);
            }
            if (isfinished(board) == 2)
            {
                Vtrain2 = Convert.ToInt32(LoseA.Value);
            }
            if (isfinished(board) == 3)
            {
                Vtrain2 = Convert.ToInt32(DrawA.Value);
            }
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = features[i] * (weights[i] + ((Convert.ToDouble(LearningRateA.Value) * (Vtrain2 - V(board))) * callFeatures(i, board)));
                weights[i] = Math.Round(weights[i], 2);
            }

        }
        private double V(int[] board)
        {
            double Result = 0;
            for (int i = 0; i < features.Length; i++)
            {
                Result += features[i] * weights[i] * callFeatures(i, board);
            }
            return Math.Round(Result, 2);
        }
        private int callFeatures(int n, int[] board)
        {
            switch (n)
            {
                case 0:
                    return 1;
                case 1:
                    return x1(board);
                case 2:
                    return x2(board);
                case 3:
                    return x3(board);
                case 4:
                    return x4(board);
                case 5:
                    return x5(board);
                case 6:
                    return x6(board);
                case 7:
                    return x7(board);
                case 8:
                    return x8(board);
                case 9:
                    return x9(board);
                case 10:
                    return x10(board);
                default:
                    break;
            }
            return 0;
        }
        private int x1(int[] board)
        {
            // Number of Os on the board
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 1)
                    count++;
            }
            return count;
        }
        private int x2(int[] board)
        {
            // Number of Xs on the board
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 2)
                    count++;
            }
            return count;
        }
        private int x3(int[] board)
        {
            // Number of 2 free spaces near O
            int count = 0;
            //satri
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == 1 && board[i + 1] == 0 && board[i + 2] == 0 ||
                    board[i] == 0 && board[i + 1] == 1 && board[i + 2] == 0 ||
                    board[i] == 0 && board[i + 1] == 0 && board[i + 2] == 1)
                    count++;
            }
            //sotuni
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == 1 && board[i + 3] == 0 && board[i + 6] == 0 ||
                    board[i] == 0 && board[i + 3] == 1 && board[i + 6] == 0 ||
                    board[i] == 0 && board[i + 3] == 0 && board[i + 6] == 1)
                    count++;
            }
            //ghotri
            if (board[0] == 1 && board[4] == 0 && board[8] == 0 ||
                board[0] == 0 && board[4] == 1 && board[8] == 0 ||
                board[0] == 0 && board[4] == 0 && board[8] == 1)
                count++;
            if (board[2] == 1 && board[4] == 0 && board[6] == 0 ||
                board[2] == 0 && board[4] == 1 && board[6] == 0 ||
                board[2] == 0 && board[4] == 0 && board[6] == 1)
                count++;

            return count;
        }
        private int x4(int[] board)
        {
            // Number of 2 Os near each other on the board
            int count = 0;
            //satri
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == 1 && board[i + 1] == 1 || board[i + 1] == 1 && board[i + 2] == 1)
                    count++;
            }
            //sotuni
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == 1 && board[i + 3] == 1 || board[i + 3] == 1 && board[i + 6] == 1)
                    count++;
            }
            //ghotri
            if (board[0] == 1 && board[4] == 1 || board[4] == 1 && board[8] == 1)
                count++;
            if (board[2] == 1 && board[4] == 1 || board[4] == 1 && board[6] == 1)
                count++;

            return count;
        }
        private int x5(int[] board)
        {
            // Number of 2 Xs near each other on the board
            int count = 0;
            //satri
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == 2 && board[i + 1] == 2 || board[i + 1] == 2 && board[i + 2] == 2)
                    count++;
            }
            //sotuni
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == 2 && board[i + 3] == 2 || board[i + 3] == 2 && board[i + 6] == 2)
                    count++;
            }
            //ghotri
            if (board[0] == 2 && board[4] == 2 || board[4] == 2 && board[8] == 2)
                count++;
            if (board[2] == 2 && board[4] == 2 || board[4] == 2 && board[6] == 2)
                count++;

            return count;
        }

        private int x6(int[] board)
        {
            // Number of 2 Os near each other but blocked at the end on the board
            int count = 0;
            //satri
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == 1 && board[i + 1] == 1 && board[i + 2] == 2 || board[i] == 2 && board[i + 1] == 1 && board[i + 2] == 1)
                    count++;
            }
            //sotuni
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == 1 && board[i + 3] == 1 && board[i + 6] == 2 || board[i] == 2 && board[i + 3] == 1 && board[i + 6] == 1)
                    count++;
            }
            //ghotri
            if (board[0] == 1 && board[4] == 1 && board[8] == 2 || board[0] == 2 && board[4] == 1 && board[8] == 1)
                count++;
            if (board[2] == 1 && board[4] == 1 && board[6] == 2 || board[2] == 2 && board[4] == 1 && board[6] == 1)
                count++;

            return count;
        }
        private int x7(int[] board)
        {
            // Number of 2 Xs near each other but blocked at the end on the board
            int count = 0;
            //satri
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == 2 && board[i + 1] == 2 && board[i + 2] == 1 || board[i] == 1 && board[i + 1] == 2 && board[i + 2] == 2)
                    count++;
            }
            //sotuni
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == 2 && board[i + 3] == 2 && board[i + 6] == 1 || board[i] == 1 && board[i + 3] == 2 && board[i + 6] == 2)
                    count++;
            }
            //ghotri
            if (board[0] == 2 && board[4] == 2 && board[8] == 1 || board[0] == 1 && board[4] == 2 && board[8] == 2)
                count++;
            if (board[2] == 2 && board[4] == 2 && board[6] == 1 || board[2] == 1 && board[4] == 2 && board[6] == 2)
                count++;

            return count;
        }
        private int x8(int[] board)
        {
            // Number of 2 free spaces near X
            int count = 0;
            //satri
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == 2 && board[i + 1] == 0 && board[i + 2] == 0 ||
                    board[i] == 0 && board[i + 1] == 2 && board[i + 2] == 0 ||
                    board[i] == 0 && board[i + 1] == 0 && board[i + 2] == 2)
                    count++;
            }
            //sotuni
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == 2 && board[i + 3] == 0 && board[i + 6] == 0 ||
                    board[i] == 0 && board[i + 3] == 2 && board[i + 6] == 0 ||
                    board[i] == 0 && board[i + 3] == 0 && board[i + 6] == 2)
                    count++;
            }
            //ghotri
            if (board[0] == 2 && board[4] == 0 && board[8] == 0 ||
                board[0] == 0 && board[4] == 2 && board[8] == 0 ||
                board[0] == 0 && board[4] == 0 && board[8] == 2)
                count++;
            if (board[2] == 2 && board[4] == 0 && board[6] == 0 ||
                board[2] == 0 && board[4] == 2 && board[6] == 0 ||
                board[2] == 0 && board[4] == 0 && board[6] == 2)
                count++;

            return count;
        }
        private int x9(int[] board)
        {
            // Number of 3 O near each other
            int count = 0;
            //check kardane satri
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == board[i + 1] && board[i] == board[i + 2]
                    && board[i] == 1)
                    count++;
            }
            //check kardane sotuni
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6]
                    && board[i] == 1)
                    count++;
            }
            //check kardane ghotri
            if (board[0] == board[4] && board[8] == board[0] && board[4] == 1)
                count++;
            if (board[2] == board[4] && board[6] == board[2] && board[4] == 1)
                count++;

            return count;
        }
        private int x10(int[] board)
        {
            
            // Number of 3 X near each other
            int count = 0;
            //check kardane satri
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == board[i + 1] && board[i] == board[i + 2]
                    && board[i] == 2)
                    count++;
            }
            //check kardane sotuni
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6]
                    && board[i] == 2)
                    count++;
            }
            //check kardane ghotri
            if (board[0] == board[4] && board[8] == board[0] && board[4] == 2)
                count++;
            if (board[2] == board[4] && board[6] == board[2] && board[4] == 2)
                count++;

            return count;
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chbx = (sender as CheckBox);
            if (chbx.Checked == false)
            {
                features[(Int32.Parse(chbx.Name.Last().ToString()) + 1)] = 0;
                panelA.Controls["Wlabel" + (Int32.Parse(chbx.Name.Last().ToString()) + 1)].ForeColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                features[(Int32.Parse(chbx.Name.Last().ToString()) + 1)] = 1;
                panelA.Controls["Wlabel" + (Int32.Parse(chbx.Name.Last().ToString()) + 1)].ForeColor = Color.Yellow;
            }
        }
        private void printWeights()
        {
            for (int i = 0; i < 11; i++)
            {
                if (features[i] != 0)
                    panelA.Controls["Wlabel" + i].Text = "W" + i + " :" + weights[i];
            }
        }
        private int selectMoveA(int n, int[] board)
        {
            int[] emptyplaces = getEmptyBoardIndices(board);
            if (emptyplaces.Length == 0)
                return -1;

            int[] boardCopy = new int[9];
            board.CopyTo(boardCopy, 0);

            boardCopy[emptyplaces[0]] = n;
            double max = V(boardCopy);
            int index = emptyplaces[0];
            boardCopy[emptyplaces[0]] = 0;

            for (int i = 1; i < emptyplaces.Length; i++)
            {
                boardCopy[emptyplaces[i]] = n;
                if (V(boardCopy) > max)
                {
                    max = V(boardCopy);
                    index = emptyplaces[i];
                }
                boardCopy[emptyplaces[i]] = 0;
            }

            return index;
        }
        private void bestMoveradio_CheckedChanged(object sender, EventArgs e)
        {
            if (randomMoveradio.Checked)
            {
                rndMove = true;
            }
            else
            {
                rndMove = false;
            }
        }

        private void playfirstRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (pcplaysfirstRadioBTN.Checked == true)
            {

                board = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                int pcMove = selectMoveA(1, board);
                Button btn2 = table.Controls["button" + (pcMove + 1)] as Button;
                btn2.BackColor = Color.Red;
                btn2.Text = "O";
                btn2.Enabled = false;

                makeMove(pcMove, 1, board);
            }
            else
            {
                RetryBTN.PerformClick();
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (W0checkBox.Checked == true)
            {
                features[0] = 1;
                Wlabel0.ForeColor = Color.Yellow;
            }
            else
            {
                features[0] = 0;
                Wlabel0.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }
        //
        //
        //
        //
        //
        // ------------------------------- QLearning -------------------------
        //
        //
        //
        //
        //
        private void Draw_ValueChanged(object sender, EventArgs e)
        {
            iterate = Convert.ToInt32(Iterations.Value);
            alpha = Convert.ToDouble(LearningRate.Value);
            discount = Convert.ToDouble(1 - DiscountFactor.Value);
            eg = Convert.ToInt32(EpsilonGreedy.Value);
            W = Convert.ToInt32(Win.Value);
            L = Convert.ToInt32(Lose.Value);
            D = Convert.ToInt32(Draw.Value);
            progressBar1.Maximum = iterate;
        }
        private void TrainBTN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 19683; i++)
            {
                states[i] = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void trainQ()
        {
            backgroundWorker1.ReportProgress(0);
            for (int i = 0; i < iterate; i++)
            {
                board = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                int state = getState(board);
                Q(state, 1, board);

                backgroundWorker1.ReportProgress(1);
            }
        }
        private double Q(int state, int player, int[] board)
        {
            int move;
            Random rnd = new Random();
            if (rnd.Next(0, 100) < eg)
            {
                move = selectMove(1, state, board);
                makeMove(move, player, board);
            }
            else
            {
                move = randomMove(board);
                makeMove(move, player, board);
            }
            if (isfinished(board) == player)
            {
                states[state][move] = theFormula(Convert.ToDouble(Win.Value), state, move);
                return states[state][move];
            }
            if (isfinished(board) == 2)
            {
                states[state][move] = theFormula(Convert.ToDouble(Lose.Value), state, move);
                return states[state][move];
            }
            if (isfinished(board) == 3)
            {
                states[state][move] = theFormula(Convert.ToDouble(Draw.Value), state, move);
                return states[state][move];
            }
            else
            {
                
                makeMove(randomMove(board), 2, board);
                if (isfinished(board) == 2)
                {
                    states[state][move] = theFormula(Convert.ToDouble(Lose.Value), state, move);
                    return states[state][move];
                }
                if (isfinished(board) == 3)
                {
                    states[state][move] = theFormula(Convert.ToDouble(Draw.Value), state, move);
                    return states[state][move];
                }

                int nextState = getState(board);
                states[state][move] = theFormula(Q(nextState, player, board), state, move);

                return states[state][move];
            }

        }
        private double theFormula(double n, int state, int move)
        {
            return Math.Round((states[state][move] + (alpha * (n + (discount * states[state].Max()) - states[state][move]))), 2);
        }
        private int toDecimal(int n)
        {
            int result = 0;
            int t = 0;
            while (n > 0)
            {
                result += (n % 10) * Convert.ToInt32(Math.Pow(3, t));
                t++;
                n /= 10;
            }
            return result;
        }

        private void makeMove(int move, int n, int[] board)
        {
            board[move] = n;
        }

        private int[] stateToBoard(int state)
        {
            int[] result = new int[9];
            string base3 = toBase3(state).ToString().PadRight(9, '0');
            for (int i = 0; i < 9; i++)
            {
                result[i] = Int32.Parse(base3[i].ToString());
            }
            return result;
        }

        private int toBase3(int n)
        {
            int result = 0, factor = 1;
            while (n > 0)
            {
                result += n % 3 * factor;
                n /= 3;
                factor *= 10;
            }
            return result;
        }
        private int[] getEmptyBoardIndices(int[] board)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0)
                    result.Add(i);
            }
            return result.ToArray();
        }
        private string getEmptyBoardIndices2(int[] board)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0)
                    result.Append(i + ",");
            }
            return result.ToString();
        }
        private int randomMove(int[] board)
        {
            Random rnd = new Random();

            int[] possibilities = getEmptyBoardIndices(board);

            if (possibilities.Length == 0)
                return -1;

            int rndMove = rnd.Next(0, possibilities.Length);


            return possibilities[rndMove];
        }
        private int selectMove(int n,int state, int[] board)
        {
            // Finding max
            int[] possibilities = getEmptyBoardIndices(board);
            if (possibilities.Length == 0)
                return -1;

            int[] boardCopy = new int[9];
            board.CopyTo(boardCopy, 0);

            boardCopy[possibilities[0]] = n;
            double max = states[getState(boardCopy)].Max();
            int index = states[getState(boardCopy)].ToList().IndexOf(max);
            boardCopy[possibilities[0]] = 0;

            for (int i = 1; i < possibilities.Length; i++)
            {
                boardCopy[possibilities[i]] = n;
                if (states[getState(boardCopy)].Max() > max)
                {
                    max = states[getState(boardCopy)].Max();
                    index = states[getState(boardCopy)].ToList().IndexOf(max);
                }
                boardCopy[possibilities[i]] = 0;
            }

            return index;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MessageBox.Show("start");
            trainQ();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage != 0)
            {
                progressBar1.PerformStep();
            }
            else
            {
                progressBar1.Value = 0;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                printState();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelQ.Visible = true;
            panelA.Visible = false;
            MessageBox.Show("Q-Learning is not ready yet");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelA.Visible = true;
            panelQ.Visible = false;
        }

        private int getState(int[] board)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                str.Append(board[i]);
            }
            return toDecimal(Int32.Parse(str.ToString()));
        }
        private int isfinished(int[] board)
        {
            //check kardane satri
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == board[i + 1] && board[i] == board[i + 2]
                    && board[i] != 0)
                    return board[i];
            }
            //check kardane sotuni
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6]
                    && board[i] != 0)
                    return board[i];
            }
            //check kardane ghotri
            if (board[0] == board[4] && board[8] == board[0] && board[4] != 0)
                return board[4];
            if (board[2] == board[4] && board[6] == board[2] && board[4] != 0)
                return board[4];
            //check kardane tamum nabudane board
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0)
                    //hanuz tamum nashode va Draw nist
                    return 0;
            }
            // board Draw hast va tamum shode 
            return 3;
        }

        private void printState()
        {
            StringBuilder str = new StringBuilder();
            StringBuilder result = new StringBuilder();
            int flag = 0, count = 0;
            for (int i = 0; i < 19683; i++)
            {
                str = new StringBuilder();
                for (int j = 0; j < 9; j++)
                {
                    if (states[i][j] != 0)
                    {
                        flag = 1;
                    }
                    str.Append(states[i][j] + ",");
                }
                if (flag == 1)
                {
                    result.Append(str + "  _" + ++count + "\n");
                    flag = 0;
                }
            }
            textboxstate.Text = result.ToString();
        }

        private string printBoard(int[] board)
        {
            StringBuilder printResult = new StringBuilder();
            for (int i = 0; i < 9; i += 3)
            {
                printResult.Append(board[i] + "," + board[i + 1] + "," + board[i + 2] + "\n");
            }
            return printResult.ToString();
        }
        private void RetryBTN_Click(object sender, EventArgs e)
        {
            board = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            table.Enabled = true;
            gameStateLabel.Text = "Let's play some tic tac toe";
            gameStateLabel.ForeColor = Color.Yellow;

            for (int i = 1; i < 10; i++)
            {
                Button btn = table.Controls["button" + i] as Button;
                btn.BackColor = Color.CornflowerBlue;
                btn.Text = "_";
                btn.Enabled = true;
            }
            
            if (pcplaysfirstRadioBTN.Checked == true)
            {
                int pcMove = selectMoveA(1, board);

                Button btn2 = table.Controls["button" + (pcMove + 1)] as Button;
                btn2.BackColor = Color.Red;
                btn2.Text = "O";
                btn2.Enabled = false;

                makeMove(pcMove, 1, board);
            }
        }
    }
}
