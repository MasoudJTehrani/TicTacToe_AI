namespace TicTacToe_AI
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gameStateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LearningRate = new System.Windows.Forms.NumericUpDown();
            this.DiscountFactor = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.EpsilonGreedy = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Iterations = new System.Windows.Forms.NumericUpDown();
            this.TrainBTN = new System.Windows.Forms.Button();
            this.RetryBTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Win = new System.Windows.Forms.NumericUpDown();
            this.Lose = new System.Windows.Forms.NumericUpDown();
            this.Draw = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textboxstate = new System.Windows.Forms.RichTextBox();
            this.panelQ = new System.Windows.Forms.Panel();
            this.QLearningBTN = new System.Windows.Forms.Button();
            this.FapproxBTN = new System.Windows.Forms.Button();
            this.panelA = new System.Windows.Forms.Panel();
            this.W0checkBox = new System.Windows.Forms.CheckBox();
            this.OptimalMoveradio = new System.Windows.Forms.RadioButton();
            this.randomMoveradio = new System.Windows.Forms.RadioButton();
            this.Wlabel10 = new System.Windows.Forms.Label();
            this.Wlabel9 = new System.Windows.Forms.Label();
            this.Wlabel8 = new System.Windows.Forms.Label();
            this.Wlabel7 = new System.Windows.Forms.Label();
            this.Wlabel6 = new System.Windows.Forms.Label();
            this.Wlabel5 = new System.Windows.Forms.Label();
            this.Wlabel4 = new System.Windows.Forms.Label();
            this.Wlabel3 = new System.Windows.Forms.Label();
            this.Wlabel2 = new System.Windows.Forms.Label();
            this.Wlabel1 = new System.Windows.Forms.Label();
            this.Wlabel0 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.DrawA = new System.Windows.Forms.NumericUpDown();
            this.LoseA = new System.Windows.Forms.NumericUpDown();
            this.WinA = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TrainA = new System.Windows.Forms.Button();
            this.iterateA = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.LearningRateA = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.playfirstRadioBTN = new System.Windows.Forms.RadioButton();
            this.pcplaysfirstRadioBTN = new System.Windows.Forms.RadioButton();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpsilonGreedy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Draw)).BeginInit();
            this.panelQ.SuspendLayout();
            this.panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoseA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterateA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(590, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 614);
            this.panel1.TabIndex = 1;
            // 
            // table
            // 
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.table.Controls.Add(this.button9, 2, 2);
            this.table.Controls.Add(this.button8, 1, 2);
            this.table.Controls.Add(this.button7, 0, 2);
            this.table.Controls.Add(this.button6, 2, 1);
            this.table.Controls.Add(this.button5, 1, 1);
            this.table.Controls.Add(this.button4, 0, 1);
            this.table.Controls.Add(this.button3, 2, 0);
            this.table.Controls.Add(this.button2, 1, 0);
            this.table.Controls.Add(this.button1, 0, 0);
            this.table.Enabled = false;
            this.table.Location = new System.Drawing.Point(656, 57);
            this.table.Name = "table";
            this.table.RowCount = 3;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.Size = new System.Drawing.Size(446, 346);
            this.table.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.BorderSize = 3;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(299, 233);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 109);
            this.button9.TabIndex = 8;
            this.button9.Text = "_";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(151, 233);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(142, 109);
            this.button8.TabIndex = 7;
            this.button8.Text = "_";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 233);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(142, 109);
            this.button7.TabIndex = 6;
            this.button7.Text = "_";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(299, 118);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 109);
            this.button6.TabIndex = 5;
            this.button6.Text = "_";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(151, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 109);
            this.button5.TabIndex = 4;
            this.button5.Text = "_";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 109);
            this.button4.TabIndex = 3;
            this.button4.Text = "_";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(299, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 109);
            this.button3.TabIndex = 2;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(151, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 109);
            this.button2.TabIndex = 1;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 109);
            this.button1.TabIndex = 0;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameStateLabel
            // 
            this.gameStateLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStateLabel.ForeColor = System.Drawing.Color.Yellow;
            this.gameStateLabel.Location = new System.Drawing.Point(661, 425);
            this.gameStateLabel.Name = "gameStateLabel";
            this.gameStateLabel.Size = new System.Drawing.Size(441, 59);
            this.gameStateLabel.TabIndex = 3;
            this.gameStateLabel.Text = "Let\'s play some tic tac toe";
            this.gameStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 59);
            this.label2.TabIndex = 4;
            this.label2.Text = "Q(S,A) = Q(S,A) + α ∗ ( R + γ ∗ maxQ(S′,a) − Q(S,A) )";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(129, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Learning rate α = ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LearningRate
            // 
            this.LearningRate.BackColor = System.Drawing.Color.Gainsboro;
            this.LearningRate.DecimalPlaces = 1;
            this.LearningRate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningRate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LearningRate.Location = new System.Drawing.Point(331, 83);
            this.LearningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LearningRate.Name = "LearningRate";
            this.LearningRate.Size = new System.Drawing.Size(66, 26);
            this.LearningRate.TabIndex = 6;
            this.LearningRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LearningRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.LearningRate.ValueChanged += new System.EventHandler(this.Draw_ValueChanged);
            // 
            // DiscountFactor
            // 
            this.DiscountFactor.BackColor = System.Drawing.Color.Gainsboro;
            this.DiscountFactor.DecimalPlaces = 1;
            this.DiscountFactor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountFactor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.DiscountFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DiscountFactor.Location = new System.Drawing.Point(331, 135);
            this.DiscountFactor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiscountFactor.Name = "DiscountFactor";
            this.DiscountFactor.Size = new System.Drawing.Size(66, 26);
            this.DiscountFactor.TabIndex = 8;
            this.DiscountFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiscountFactor.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.DiscountFactor.ValueChanged += new System.EventHandler(this.Draw_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Beige;
            this.label4.Location = new System.Drawing.Point(108, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discount Factor γ = ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EpsilonGreedy
            // 
            this.EpsilonGreedy.BackColor = System.Drawing.Color.Gainsboro;
            this.EpsilonGreedy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpsilonGreedy.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.EpsilonGreedy.Location = new System.Drawing.Point(331, 196);
            this.EpsilonGreedy.Name = "EpsilonGreedy";
            this.EpsilonGreedy.Size = new System.Drawing.Size(66, 26);
            this.EpsilonGreedy.TabIndex = 10;
            this.EpsilonGreedy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EpsilonGreedy.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.EpsilonGreedy.ValueChanged += new System.EventHandler(this.Draw_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Beige;
            this.label5.Location = new System.Drawing.Point(129, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Epsilon-Greedy = ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Beige;
            this.label6.Location = new System.Drawing.Point(403, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Beige;
            this.label7.Location = new System.Drawing.Point(129, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Train iterations = ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Iterations
            // 
            this.Iterations.BackColor = System.Drawing.Color.Gainsboro;
            this.Iterations.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iterations.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Iterations.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Iterations.Location = new System.Drawing.Point(331, 254);
            this.Iterations.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Iterations.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(86, 26);
            this.Iterations.TabIndex = 13;
            this.Iterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Iterations.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Iterations.ValueChanged += new System.EventHandler(this.Draw_ValueChanged);
            // 
            // TrainBTN
            // 
            this.TrainBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrainBTN.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.TrainBTN.FlatAppearance.BorderSize = 2;
            this.TrainBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainBTN.ForeColor = System.Drawing.Color.Gold;
            this.TrainBTN.Location = new System.Drawing.Point(207, 353);
            this.TrainBTN.Name = "TrainBTN";
            this.TrainBTN.Size = new System.Drawing.Size(139, 41);
            this.TrainBTN.TabIndex = 14;
            this.TrainBTN.Text = "Train";
            this.TrainBTN.UseVisualStyleBackColor = true;
            this.TrainBTN.Click += new System.EventHandler(this.TrainBTN_Click);
            // 
            // RetryBTN
            // 
            this.RetryBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RetryBTN.Enabled = false;
            this.RetryBTN.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.RetryBTN.FlatAppearance.BorderSize = 2;
            this.RetryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetryBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryBTN.ForeColor = System.Drawing.Color.Gold;
            this.RetryBTN.Location = new System.Drawing.Point(812, 498);
            this.RetryBTN.Name = "RetryBTN";
            this.RetryBTN.Size = new System.Drawing.Size(139, 41);
            this.RetryBTN.TabIndex = 15;
            this.RetryBTN.Text = "Retry";
            this.RetryBTN.UseVisualStyleBackColor = true;
            this.RetryBTN.Click += new System.EventHandler(this.RetryBTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Beige;
            this.label8.Location = new System.Drawing.Point(2, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Score for:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(121, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Win:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(268, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Lose:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(413, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Draw:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Win
            // 
            this.Win.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Win.DecimalPlaces = 1;
            this.Win.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Win.ForeColor = System.Drawing.Color.Lime;
            this.Win.Location = new System.Drawing.Point(186, 308);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(76, 26);
            this.Win.TabIndex = 20;
            this.Win.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Win.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Win.ValueChanged += new System.EventHandler(this.Draw_ValueChanged);
            // 
            // Lose
            // 
            this.Lose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lose.DecimalPlaces = 1;
            this.Lose.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lose.ForeColor = System.Drawing.Color.Red;
            this.Lose.Location = new System.Drawing.Point(331, 307);
            this.Lose.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Lose.Name = "Lose";
            this.Lose.Size = new System.Drawing.Size(76, 26);
            this.Lose.TabIndex = 21;
            this.Lose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lose.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Lose.ValueChanged += new System.EventHandler(this.Draw_ValueChanged);
            // 
            // Draw
            // 
            this.Draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Draw.DecimalPlaces = 1;
            this.Draw.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Draw.Location = new System.Drawing.Point(492, 308);
            this.Draw.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(76, 26);
            this.Draw.TabIndex = 22;
            this.Draw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Draw.ValueChanged += new System.EventHandler(this.Draw_ValueChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(2, 400);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(572, 12);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 23;
            // 
            // textboxstate
            // 
            this.textboxstate.Location = new System.Drawing.Point(2, 418);
            this.textboxstate.Name = "textboxstate";
            this.textboxstate.Size = new System.Drawing.Size(572, 124);
            this.textboxstate.TabIndex = 24;
            this.textboxstate.Text = "";
            // 
            // panelQ
            // 
            this.panelQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelQ.Controls.Add(this.textboxstate);
            this.panelQ.Controls.Add(this.progressBar1);
            this.panelQ.Controls.Add(this.Draw);
            this.panelQ.Controls.Add(this.Lose);
            this.panelQ.Controls.Add(this.Win);
            this.panelQ.Controls.Add(this.label11);
            this.panelQ.Controls.Add(this.label10);
            this.panelQ.Controls.Add(this.label9);
            this.panelQ.Controls.Add(this.label8);
            this.panelQ.Controls.Add(this.TrainBTN);
            this.panelQ.Controls.Add(this.Iterations);
            this.panelQ.Controls.Add(this.label7);
            this.panelQ.Controls.Add(this.label6);
            this.panelQ.Controls.Add(this.EpsilonGreedy);
            this.panelQ.Controls.Add(this.label5);
            this.panelQ.Controls.Add(this.DiscountFactor);
            this.panelQ.Controls.Add(this.label4);
            this.panelQ.Controls.Add(this.LearningRate);
            this.panelQ.Controls.Add(this.label3);
            this.panelQ.Controls.Add(this.label2);
            this.panelQ.Location = new System.Drawing.Point(4, 69);
            this.panelQ.Name = "panelQ";
            this.panelQ.Size = new System.Drawing.Size(580, 550);
            this.panelQ.TabIndex = 25;
            // 
            // QLearningBTN
            // 
            this.QLearningBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QLearningBTN.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.QLearningBTN.FlatAppearance.BorderSize = 2;
            this.QLearningBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QLearningBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLearningBTN.ForeColor = System.Drawing.Color.Gold;
            this.QLearningBTN.Location = new System.Drawing.Point(12, 12);
            this.QLearningBTN.Name = "QLearningBTN";
            this.QLearningBTN.Size = new System.Drawing.Size(264, 41);
            this.QLearningBTN.TabIndex = 26;
            this.QLearningBTN.Text = "Q-Learning";
            this.QLearningBTN.UseVisualStyleBackColor = true;
            this.QLearningBTN.Click += new System.EventHandler(this.button10_Click);
            // 
            // FapproxBTN
            // 
            this.FapproxBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FapproxBTN.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.FapproxBTN.FlatAppearance.BorderSize = 2;
            this.FapproxBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FapproxBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FapproxBTN.ForeColor = System.Drawing.Color.Gold;
            this.FapproxBTN.Location = new System.Drawing.Point(295, 12);
            this.FapproxBTN.Name = "FapproxBTN";
            this.FapproxBTN.Size = new System.Drawing.Size(289, 41);
            this.FapproxBTN.TabIndex = 27;
            this.FapproxBTN.Text = "Function approximation";
            this.FapproxBTN.UseVisualStyleBackColor = true;
            this.FapproxBTN.Click += new System.EventHandler(this.button11_Click);
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelA.Controls.Add(this.W0checkBox);
            this.panelA.Controls.Add(this.OptimalMoveradio);
            this.panelA.Controls.Add(this.randomMoveradio);
            this.panelA.Controls.Add(this.Wlabel10);
            this.panelA.Controls.Add(this.Wlabel9);
            this.panelA.Controls.Add(this.Wlabel8);
            this.panelA.Controls.Add(this.Wlabel7);
            this.panelA.Controls.Add(this.Wlabel6);
            this.panelA.Controls.Add(this.Wlabel5);
            this.panelA.Controls.Add(this.Wlabel4);
            this.panelA.Controls.Add(this.Wlabel3);
            this.panelA.Controls.Add(this.Wlabel2);
            this.panelA.Controls.Add(this.Wlabel1);
            this.panelA.Controls.Add(this.Wlabel0);
            this.panelA.Controls.Add(this.checkBox9);
            this.panelA.Controls.Add(this.checkBox8);
            this.panelA.Controls.Add(this.checkBox7);
            this.panelA.Controls.Add(this.checkBox6);
            this.panelA.Controls.Add(this.checkBox5);
            this.panelA.Controls.Add(this.checkBox4);
            this.panelA.Controls.Add(this.checkBox3);
            this.panelA.Controls.Add(this.checkBox2);
            this.panelA.Controls.Add(this.checkBox1);
            this.panelA.Controls.Add(this.label21);
            this.panelA.Controls.Add(this.checkBox0);
            this.panelA.Controls.Add(this.DrawA);
            this.panelA.Controls.Add(this.LoseA);
            this.panelA.Controls.Add(this.WinA);
            this.panelA.Controls.Add(this.label12);
            this.panelA.Controls.Add(this.label13);
            this.panelA.Controls.Add(this.label14);
            this.panelA.Controls.Add(this.label15);
            this.panelA.Controls.Add(this.TrainA);
            this.panelA.Controls.Add(this.iterateA);
            this.panelA.Controls.Add(this.label16);
            this.panelA.Controls.Add(this.LearningRateA);
            this.panelA.Controls.Add(this.label20);
            this.panelA.Location = new System.Drawing.Point(7, 61);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(577, 565);
            this.panelA.TabIndex = 28;
            // 
            // W0checkBox
            // 
            this.W0checkBox.AutoSize = true;
            this.W0checkBox.Checked = true;
            this.W0checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.W0checkBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W0checkBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.W0checkBox.Location = new System.Drawing.Point(21, 31);
            this.W0checkBox.Name = "W0checkBox";
            this.W0checkBox.Size = new System.Drawing.Size(59, 24);
            this.W0checkBox.TabIndex = 69;
            this.W0checkBox.Text = "W0";
            this.W0checkBox.UseVisualStyleBackColor = true;
            this.W0checkBox.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // OptimalMoveradio
            // 
            this.OptimalMoveradio.AutoSize = true;
            this.OptimalMoveradio.Checked = true;
            this.OptimalMoveradio.ForeColor = System.Drawing.Color.Yellow;
            this.OptimalMoveradio.Location = new System.Drawing.Point(392, 515);
            this.OptimalMoveradio.Name = "OptimalMoveradio";
            this.OptimalMoveradio.Size = new System.Drawing.Size(125, 21);
            this.OptimalMoveradio.TabIndex = 68;
            this.OptimalMoveradio.TabStop = true;
            this.OptimalMoveradio.Text = "Optimal move";
            this.OptimalMoveradio.UseVisualStyleBackColor = true;
            this.OptimalMoveradio.CheckedChanged += new System.EventHandler(this.bestMoveradio_CheckedChanged);
            // 
            // randomMoveradio
            // 
            this.randomMoveradio.AutoSize = true;
            this.randomMoveradio.ForeColor = System.Drawing.Color.Yellow;
            this.randomMoveradio.Location = new System.Drawing.Point(392, 494);
            this.randomMoveradio.Name = "randomMoveradio";
            this.randomMoveradio.Size = new System.Drawing.Size(130, 21);
            this.randomMoveradio.TabIndex = 67;
            this.randomMoveradio.Text = "Random move";
            this.randomMoveradio.UseVisualStyleBackColor = true;
            this.randomMoveradio.CheckedChanged += new System.EventHandler(this.bestMoveradio_CheckedChanged);
            // 
            // Wlabel10
            // 
            this.Wlabel10.AutoSize = true;
            this.Wlabel10.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel10.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel10.Location = new System.Drawing.Point(451, 466);
            this.Wlabel10.Name = "Wlabel10";
            this.Wlabel10.Size = new System.Drawing.Size(42, 12);
            this.Wlabel10.TabIndex = 66;
            this.Wlabel10.Text = "W10: _";
            this.Wlabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wlabel9
            // 
            this.Wlabel9.AutoSize = true;
            this.Wlabel9.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel9.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel9.Location = new System.Drawing.Point(344, 466);
            this.Wlabel9.Name = "Wlabel9";
            this.Wlabel9.Size = new System.Drawing.Size(36, 12);
            this.Wlabel9.TabIndex = 65;
            this.Wlabel9.Text = "W9: _";
            this.Wlabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wlabel8
            // 
            this.Wlabel8.AutoSize = true;
            this.Wlabel8.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel8.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel8.Location = new System.Drawing.Point(240, 466);
            this.Wlabel8.Name = "Wlabel8";
            this.Wlabel8.Size = new System.Drawing.Size(36, 12);
            this.Wlabel8.TabIndex = 64;
            this.Wlabel8.Text = "W8: _";
            this.Wlabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wlabel7
            // 
            this.Wlabel7.AutoSize = true;
            this.Wlabel7.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel7.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel7.Location = new System.Drawing.Point(121, 466);
            this.Wlabel7.Name = "Wlabel7";
            this.Wlabel7.Size = new System.Drawing.Size(36, 12);
            this.Wlabel7.TabIndex = 63;
            this.Wlabel7.Text = "W7: _";
            this.Wlabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wlabel6
            // 
            this.Wlabel6.AutoSize = true;
            this.Wlabel6.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel6.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel6.Location = new System.Drawing.Point(8, 466);
            this.Wlabel6.Name = "Wlabel6";
            this.Wlabel6.Size = new System.Drawing.Size(36, 12);
            this.Wlabel6.TabIndex = 62;
            this.Wlabel6.Text = "W6: _";
            this.Wlabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wlabel5
            // 
            this.Wlabel5.AutoSize = true;
            this.Wlabel5.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel5.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel5.Location = new System.Drawing.Point(451, 437);
            this.Wlabel5.Name = "Wlabel5";
            this.Wlabel5.Size = new System.Drawing.Size(36, 12);
            this.Wlabel5.TabIndex = 61;
            this.Wlabel5.Text = "W5: _";
            this.Wlabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wlabel4
            // 
            this.Wlabel4.AutoSize = true;
            this.Wlabel4.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel4.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel4.Location = new System.Drawing.Point(344, 437);
            this.Wlabel4.Name = "Wlabel4";
            this.Wlabel4.Size = new System.Drawing.Size(36, 12);
            this.Wlabel4.TabIndex = 60;
            this.Wlabel4.Text = "W4: _";
            this.Wlabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wlabel3
            // 
            this.Wlabel3.AutoSize = true;
            this.Wlabel3.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel3.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel3.Location = new System.Drawing.Point(240, 437);
            this.Wlabel3.Name = "Wlabel3";
            this.Wlabel3.Size = new System.Drawing.Size(36, 12);
            this.Wlabel3.TabIndex = 59;
            this.Wlabel3.Text = "W3: _";
            this.Wlabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wlabel2
            // 
            this.Wlabel2.AutoSize = true;
            this.Wlabel2.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel2.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel2.Location = new System.Drawing.Point(121, 437);
            this.Wlabel2.Name = "Wlabel2";
            this.Wlabel2.Size = new System.Drawing.Size(36, 12);
            this.Wlabel2.TabIndex = 58;
            this.Wlabel2.Text = "W2: _";
            this.Wlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wlabel1
            // 
            this.Wlabel1.AutoSize = true;
            this.Wlabel1.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel1.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel1.Location = new System.Drawing.Point(8, 437);
            this.Wlabel1.Name = "Wlabel1";
            this.Wlabel1.Size = new System.Drawing.Size(36, 12);
            this.Wlabel1.TabIndex = 57;
            this.Wlabel1.Text = "W1: _";
            this.Wlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wlabel0
            // 
            this.Wlabel0.AutoSize = true;
            this.Wlabel0.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlabel0.ForeColor = System.Drawing.Color.Yellow;
            this.Wlabel0.Location = new System.Drawing.Point(8, 515);
            this.Wlabel0.Name = "Wlabel0";
            this.Wlabel0.Size = new System.Drawing.Size(36, 12);
            this.Wlabel0.TabIndex = 56;
            this.Wlabel0.Text = "W0: _";
            this.Wlabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBox9.Location = new System.Drawing.Point(21, 334);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(501, 24);
            this.checkBox9.TabIndex = 55;
            this.checkBox9.Text = "x10 : The number of 3 X near each other on the board\r\n";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBox8.Location = new System.Drawing.Point(21, 307);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(491, 24);
            this.checkBox8.TabIndex = 54;
            this.checkBox8.Text = "x9 : The number of 3 O near each other on the board";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBox7.Location = new System.Drawing.Point(21, 277);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(380, 24);
            this.checkBox7.TabIndex = 53;
            this.checkBox7.Text = "x8 : The number of 2 free spaces near X";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBox6.Location = new System.Drawing.Point(21, 247);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(527, 24);
            this.checkBox6.TabIndex = 52;
            this.checkBox6.Text = "x7 : The number of 2 X near each other but blocked by O";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBox5.Location = new System.Drawing.Point(21, 217);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(527, 24);
            this.checkBox5.TabIndex = 51;
            this.checkBox5.Text = "x6 : The number of 2 O near each other but blocked by X";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBox4.Location = new System.Drawing.Point(21, 187);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(490, 24);
            this.checkBox4.TabIndex = 50;
            this.checkBox4.Text = "x5 : The number of 2 X near each other on the board";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBox3.Location = new System.Drawing.Point(21, 154);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(491, 24);
            this.checkBox3.TabIndex = 49;
            this.checkBox3.Text = "x4 : The number of 2 O near each other on the board";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBox2.Location = new System.Drawing.Point(21, 124);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(381, 24);
            this.checkBox2.TabIndex = 48;
            this.checkBox2.Text = "x3 : The number of 2 free spaces near O";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBox1.Location = new System.Drawing.Point(21, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(332, 24);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "x2 : The number of X on the board";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Yellow;
            this.label21.Location = new System.Drawing.Point(2, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(572, 50);
            this.label21.TabIndex = 46;
            this.label21.Text = "Select features:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Checked = true;
            this.checkBox0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox0.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox0.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkBox0.Location = new System.Drawing.Point(21, 61);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(333, 24);
            this.checkBox0.TabIndex = 45;
            this.checkBox0.Text = "x1 : The number of O on the board";
            this.checkBox0.UseVisualStyleBackColor = true;
            this.checkBox0.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // DrawA
            // 
            this.DrawA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DrawA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DrawA.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DrawA.Location = new System.Drawing.Point(495, 397);
            this.DrawA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DrawA.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.DrawA.Name = "DrawA";
            this.DrawA.Size = new System.Drawing.Size(76, 26);
            this.DrawA.TabIndex = 42;
            this.DrawA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoseA
            // 
            this.LoseA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoseA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoseA.ForeColor = System.Drawing.Color.Red;
            this.LoseA.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LoseA.Location = new System.Drawing.Point(334, 396);
            this.LoseA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LoseA.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.LoseA.Name = "LoseA";
            this.LoseA.Size = new System.Drawing.Size(76, 26);
            this.LoseA.TabIndex = 41;
            this.LoseA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoseA.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            // 
            // WinA
            // 
            this.WinA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WinA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinA.ForeColor = System.Drawing.Color.Lime;
            this.WinA.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WinA.Location = new System.Drawing.Point(189, 397);
            this.WinA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WinA.Name = "WinA";
            this.WinA.Size = new System.Drawing.Size(76, 26);
            this.WinA.TabIndex = 40;
            this.WinA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WinA.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(416, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 25);
            this.label12.TabIndex = 39;
            this.label12.Text = "Draw:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(271, 397);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "Lose:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(124, 397);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 25);
            this.label14.TabIndex = 37;
            this.label14.Text = "Win:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Beige;
            this.label15.Location = new System.Drawing.Point(5, 396);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "Score for:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrainA
            // 
            this.TrainA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrainA.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.TrainA.FlatAppearance.BorderSize = 2;
            this.TrainA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainA.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainA.ForeColor = System.Drawing.Color.Gold;
            this.TrainA.Location = new System.Drawing.Point(201, 503);
            this.TrainA.Name = "TrainA";
            this.TrainA.Size = new System.Drawing.Size(139, 41);
            this.TrainA.TabIndex = 35;
            this.TrainA.Text = "Train";
            this.TrainA.UseVisualStyleBackColor = true;
            this.TrainA.Click += new System.EventHandler(this.TrainA_Click);
            // 
            // iterateA
            // 
            this.iterateA.BackColor = System.Drawing.Color.Gainsboro;
            this.iterateA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterateA.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.iterateA.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.iterateA.Location = new System.Drawing.Point(485, 364);
            this.iterateA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.iterateA.Name = "iterateA";
            this.iterateA.Size = new System.Drawing.Size(86, 26);
            this.iterateA.TabIndex = 34;
            this.iterateA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iterateA.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Beige;
            this.label16.Location = new System.Drawing.Point(283, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(194, 25);
            this.label16.TabIndex = 33;
            this.label16.Text = "Train iterations = ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LearningRateA
            // 
            this.LearningRateA.BackColor = System.Drawing.Color.Gainsboro;
            this.LearningRateA.DecimalPlaces = 3;
            this.LearningRateA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningRateA.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LearningRateA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.LearningRateA.Location = new System.Drawing.Point(189, 364);
            this.LearningRateA.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LearningRateA.Name = "LearningRateA";
            this.LearningRateA.Size = new System.Drawing.Size(88, 26);
            this.LearningRateA.TabIndex = 27;
            this.LearningRateA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LearningRateA.Value = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Beige;
            this.label20.Location = new System.Drawing.Point(5, 364);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(196, 25);
            this.label20.TabIndex = 26;
            this.label20.Text = "Learning rate α = ";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playfirstRadioBTN
            // 
            this.playfirstRadioBTN.AutoSize = true;
            this.playfirstRadioBTN.Enabled = false;
            this.playfirstRadioBTN.ForeColor = System.Drawing.Color.Yellow;
            this.playfirstRadioBTN.Location = new System.Drawing.Point(669, 555);
            this.playfirstRadioBTN.Name = "playfirstRadioBTN";
            this.playfirstRadioBTN.Size = new System.Drawing.Size(121, 21);
            this.playfirstRadioBTN.TabIndex = 29;
            this.playfirstRadioBTN.Text = "You play first";
            this.playfirstRadioBTN.UseVisualStyleBackColor = true;
            this.playfirstRadioBTN.CheckedChanged += new System.EventHandler(this.playfirstRadioBTN_CheckedChanged);
            // 
            // pcplaysfirstRadioBTN
            // 
            this.pcplaysfirstRadioBTN.AutoSize = true;
            this.pcplaysfirstRadioBTN.Checked = true;
            this.pcplaysfirstRadioBTN.Enabled = false;
            this.pcplaysfirstRadioBTN.ForeColor = System.Drawing.Color.Yellow;
            this.pcplaysfirstRadioBTN.Location = new System.Drawing.Point(669, 576);
            this.pcplaysfirstRadioBTN.Name = "pcplaysfirstRadioBTN";
            this.pcplaysfirstRadioBTN.Size = new System.Drawing.Size(121, 21);
            this.pcplaysfirstRadioBTN.TabIndex = 30;
            this.pcplaysfirstRadioBTN.TabStop = true;
            this.pcplaysfirstRadioBTN.Text = "PC plays first";
            this.pcplaysfirstRadioBTN.UseVisualStyleBackColor = true;
            this.pcplaysfirstRadioBTN.CheckedChanged += new System.EventHandler(this.playfirstRadioBTN_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1163, 631);
            this.Controls.Add(this.pcplaysfirstRadioBTN);
            this.Controls.Add(this.playfirstRadioBTN);
            this.Controls.Add(this.FapproxBTN);
            this.Controls.Add(this.QLearningBTN);
            this.Controls.Add(this.RetryBTN);
            this.Controls.Add(this.gameStateLabel);
            this.Controls.Add(this.table);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panelQ);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LearningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpsilonGreedy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Draw)).EndInit();
            this.panelQ.ResumeLayout(false);
            this.panelQ.PerformLayout();
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoseA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterateA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label gameStateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown LearningRate;
        private System.Windows.Forms.NumericUpDown DiscountFactor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown EpsilonGreedy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Iterations;
        private System.Windows.Forms.Button TrainBTN;
        private System.Windows.Forms.Button RetryBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Win;
        private System.Windows.Forms.NumericUpDown Lose;
        private System.Windows.Forms.NumericUpDown Draw;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox textboxstate;
        private System.Windows.Forms.Panel panelQ;
        private System.Windows.Forms.Button QLearningBTN;
        private System.Windows.Forms.Button FapproxBTN;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.NumericUpDown DrawA;
        private System.Windows.Forms.NumericUpDown LoseA;
        private System.Windows.Forms.NumericUpDown WinA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button TrainA;
        private System.Windows.Forms.NumericUpDown iterateA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown LearningRateA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label Wlabel10;
        private System.Windows.Forms.Label Wlabel9;
        private System.Windows.Forms.Label Wlabel8;
        private System.Windows.Forms.Label Wlabel7;
        private System.Windows.Forms.Label Wlabel6;
        private System.Windows.Forms.Label Wlabel5;
        private System.Windows.Forms.Label Wlabel4;
        private System.Windows.Forms.Label Wlabel3;
        private System.Windows.Forms.Label Wlabel2;
        private System.Windows.Forms.Label Wlabel1;
        private System.Windows.Forms.Label Wlabel0;
        private System.Windows.Forms.RadioButton OptimalMoveradio;
        private System.Windows.Forms.RadioButton randomMoveradio;
        private System.Windows.Forms.RadioButton playfirstRadioBTN;
        private System.Windows.Forms.RadioButton pcplaysfirstRadioBTN;
        private System.Windows.Forms.CheckBox W0checkBox;
    }
}

