namespace Deck_Builder__Freelance_
{
    partial class Form1
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
            this.bWinInc = new System.Windows.Forms.Button();
            this.bLossInc = new System.Windows.Forms.Button();
            this.inputCard = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bRemove = new System.Windows.Forms.Button();
            this.bIncrease = new System.Windows.Forms.Button();
            this.bDecrease = new System.Windows.Forms.Button();
            this.listDeck = new System.Windows.Forms.ListBox();
            this.bAddCard = new System.Windows.Forms.Button();
            this.bNewDeck = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listDecks = new System.Windows.Forms.ListBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lRatio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bLossDec = new System.Windows.Forms.Button();
            this.bWinDec = new System.Windows.Forms.Button();
            this.lLoss = new System.Windows.Forms.Label();
            this.lWin = new System.Windows.Forms.Label();
            this.bTest = new System.Windows.Forms.Button();
            this.lTest = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.inputCustomDice = new System.Windows.Forms.TextBox();
            this.bD20 = new System.Windows.Forms.Button();
            this.bD12 = new System.Windows.Forms.Button();
            this.bD6 = new System.Windows.Forms.Button();
            this.bDX = new System.Windows.Forms.Button();
            this.bD4 = new System.Windows.Forms.Button();
            this.bCoin = new System.Windows.Forms.Button();
            this.lDiceResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bWinInc
            // 
            this.bWinInc.Location = new System.Drawing.Point(6, 71);
            this.bWinInc.Name = "bWinInc";
            this.bWinInc.Size = new System.Drawing.Size(75, 23);
            this.bWinInc.TabIndex = 0;
            this.bWinInc.Text = "+";
            this.bWinInc.UseVisualStyleBackColor = true;
            this.bWinInc.Click += new System.EventHandler(this.bWinInc_Click);
            // 
            // bLossInc
            // 
            this.bLossInc.Location = new System.Drawing.Point(114, 71);
            this.bLossInc.Name = "bLossInc";
            this.bLossInc.Size = new System.Drawing.Size(75, 23);
            this.bLossInc.TabIndex = 1;
            this.bLossInc.Text = "+";
            this.bLossInc.UseVisualStyleBackColor = true;
            this.bLossInc.Click += new System.EventHandler(this.bLossInc_Click);
            // 
            // inputCard
            // 
            this.inputCard.Location = new System.Drawing.Point(6, 22);
            this.inputCard.Name = "inputCard";
            this.inputCard.Size = new System.Drawing.Size(156, 23);
            this.inputCard.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bRemove);
            this.groupBox1.Controls.Add(this.bIncrease);
            this.groupBox1.Controls.Add(this.bDecrease);
            this.groupBox1.Controls.Add(this.listDeck);
            this.groupBox1.Controls.Add(this.bAddCard);
            this.groupBox1.Controls.Add(this.inputCard);
            this.groupBox1.Location = new System.Drawing.Point(211, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deck";
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(168, 51);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(75, 23);
            this.bRemove.TabIndex = 14;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bIncrease
            // 
            this.bIncrease.Location = new System.Drawing.Point(87, 51);
            this.bIncrease.Name = "bIncrease";
            this.bIncrease.Size = new System.Drawing.Size(75, 23);
            this.bIncrease.TabIndex = 13;
            this.bIncrease.Text = "Increase";
            this.bIncrease.UseVisualStyleBackColor = true;
            this.bIncrease.Click += new System.EventHandler(this.bIncrease_Click);
            // 
            // bDecrease
            // 
            this.bDecrease.Location = new System.Drawing.Point(6, 51);
            this.bDecrease.Name = "bDecrease";
            this.bDecrease.Size = new System.Drawing.Size(75, 23);
            this.bDecrease.TabIndex = 12;
            this.bDecrease.Text = "Decrease";
            this.bDecrease.UseVisualStyleBackColor = true;
            this.bDecrease.Click += new System.EventHandler(this.bDecrease_Click);
            // 
            // listDeck
            // 
            this.listDeck.FormattingEnabled = true;
            this.listDeck.ItemHeight = 15;
            this.listDeck.Location = new System.Drawing.Point(6, 96);
            this.listDeck.Name = "listDeck";
            this.listDeck.Size = new System.Drawing.Size(237, 319);
            this.listDeck.TabIndex = 11;
            // 
            // bAddCard
            // 
            this.bAddCard.Location = new System.Drawing.Point(168, 22);
            this.bAddCard.Name = "bAddCard";
            this.bAddCard.Size = new System.Drawing.Size(75, 23);
            this.bAddCard.TabIndex = 10;
            this.bAddCard.Text = "Add Card";
            this.bAddCard.UseVisualStyleBackColor = true;
            this.bAddCard.Click += new System.EventHandler(this.bAddCard_Click);
            // 
            // bNewDeck
            // 
            this.bNewDeck.Location = new System.Drawing.Point(6, 51);
            this.bNewDeck.Name = "bNewDeck";
            this.bNewDeck.Size = new System.Drawing.Size(75, 23);
            this.bNewDeck.TabIndex = 7;
            this.bNewDeck.Text = "New Deck";
            this.bNewDeck.UseVisualStyleBackColor = true;
            this.bNewDeck.Click += new System.EventHandler(this.bNewDeck_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listDecks);
            this.groupBox2.Controls.Add(this.bDelete);
            this.groupBox2.Controls.Add(this.bNewDeck);
            this.groupBox2.Location = new System.Drawing.Point(467, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 426);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decks";
            // 
            // listDecks
            // 
            this.listDecks.FormattingEnabled = true;
            this.listDecks.ItemHeight = 15;
            this.listDecks.Location = new System.Drawing.Point(6, 96);
            this.listDecks.Name = "listDecks";
            this.listDecks.Size = new System.Drawing.Size(181, 319);
            this.listDecks.TabIndex = 10;
            this.listDecks.SelectedIndexChanged += new System.EventHandler(this.listDecks_SelectedIndexChanged);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(112, 51);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 9;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lRatio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.bLossDec);
            this.groupBox3.Controls.Add(this.bWinDec);
            this.groupBox3.Controls.Add(this.lLoss);
            this.groupBox3.Controls.Add(this.lWin);
            this.groupBox3.Controls.Add(this.bWinInc);
            this.groupBox3.Controls.Add(this.bLossInc);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 139);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "W/L Tracker";
            // 
            // lRatio
            // 
            this.lRatio.AutoSize = true;
            this.lRatio.Location = new System.Drawing.Point(79, 51);
            this.lRatio.Name = "lRatio";
            this.lRatio.Size = new System.Drawing.Size(37, 15);
            this.lRatio.TabIndex = 9;
            this.lRatio.Text = "Ratio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ratio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Losses:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wins:";
            // 
            // bLossDec
            // 
            this.bLossDec.Location = new System.Drawing.Point(114, 100);
            this.bLossDec.Name = "bLossDec";
            this.bLossDec.Size = new System.Drawing.Size(75, 23);
            this.bLossDec.TabIndex = 5;
            this.bLossDec.Text = "-";
            this.bLossDec.UseVisualStyleBackColor = true;
            this.bLossDec.Click += new System.EventHandler(this.bLossDec_Click);
            // 
            // bWinDec
            // 
            this.bWinDec.Location = new System.Drawing.Point(6, 100);
            this.bWinDec.Name = "bWinDec";
            this.bWinDec.Size = new System.Drawing.Size(75, 23);
            this.bWinDec.TabIndex = 4;
            this.bWinDec.Text = "-";
            this.bWinDec.UseVisualStyleBackColor = true;
            this.bWinDec.Click += new System.EventHandler(this.bWinDec_Click);
            // 
            // lLoss
            // 
            this.lLoss.AutoSize = true;
            this.lLoss.Location = new System.Drawing.Point(138, 51);
            this.lLoss.Name = "lLoss";
            this.lLoss.Size = new System.Drawing.Size(38, 15);
            this.lLoss.TabIndex = 3;
            this.lLoss.Text = "label3";
            // 
            // lWin
            // 
            this.lWin.AutoSize = true;
            this.lWin.Location = new System.Drawing.Point(24, 51);
            this.lWin.Name = "lWin";
            this.lWin.Size = new System.Drawing.Size(38, 15);
            this.lWin.TabIndex = 2;
            this.lWin.Text = "label2";
            // 
            // bTest
            // 
            this.bTest.Location = new System.Drawing.Point(803, 63);
            this.bTest.Name = "bTest";
            this.bTest.Size = new System.Drawing.Size(75, 23);
            this.bTest.TabIndex = 6;
            this.bTest.Text = "Test";
            this.bTest.UseVisualStyleBackColor = true;
            this.bTest.Click += new System.EventHandler(this.bTest_Click);
            // 
            // lTest
            // 
            this.lTest.AutoSize = true;
            this.lTest.Location = new System.Drawing.Point(828, 106);
            this.lTest.Name = "lTest";
            this.lTest.Size = new System.Drawing.Size(27, 15);
            this.lTest.TabIndex = 7;
            this.lTest.Text = "Test";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.inputCustomDice);
            this.groupBox4.Controls.Add(this.bD20);
            this.groupBox4.Controls.Add(this.bD12);
            this.groupBox4.Controls.Add(this.bD6);
            this.groupBox4.Controls.Add(this.bDX);
            this.groupBox4.Controls.Add(this.bD4);
            this.groupBox4.Controls.Add(this.bCoin);
            this.groupBox4.Controls.Add(this.lDiceResult);
            this.groupBox4.Location = new System.Drawing.Point(12, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 281);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dice Roll";
            // 
            // inputCustomDice
            // 
            this.inputCustomDice.Location = new System.Drawing.Point(6, 151);
            this.inputCustomDice.Name = "inputCustomDice";
            this.inputCustomDice.Size = new System.Drawing.Size(100, 23);
            this.inputCustomDice.TabIndex = 7;
            this.inputCustomDice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customDice_KeyPress);
            // 
            // bD20
            // 
            this.bD20.Location = new System.Drawing.Point(112, 122);
            this.bD20.Name = "bD20";
            this.bD20.Size = new System.Drawing.Size(75, 23);
            this.bD20.TabIndex = 6;
            this.bD20.Text = "D20";
            this.bD20.UseVisualStyleBackColor = true;
            this.bD20.Click += new System.EventHandler(this.random);
            // 
            // bD12
            // 
            this.bD12.Location = new System.Drawing.Point(6, 122);
            this.bD12.Name = "bD12";
            this.bD12.Size = new System.Drawing.Size(75, 23);
            this.bD12.TabIndex = 5;
            this.bD12.Text = "D12";
            this.bD12.UseVisualStyleBackColor = true;
            this.bD12.Click += new System.EventHandler(this.random);
            // 
            // bD6
            // 
            this.bD6.Location = new System.Drawing.Point(112, 93);
            this.bD6.Name = "bD6";
            this.bD6.Size = new System.Drawing.Size(75, 23);
            this.bD6.TabIndex = 4;
            this.bD6.Text = "D6";
            this.bD6.UseVisualStyleBackColor = true;
            this.bD6.Click += new System.EventHandler(this.random);
            // 
            // bDX
            // 
            this.bDX.Location = new System.Drawing.Point(112, 151);
            this.bDX.Name = "bDX";
            this.bDX.Size = new System.Drawing.Size(75, 23);
            this.bDX.TabIndex = 3;
            this.bDX.Text = "Roll";
            this.bDX.UseVisualStyleBackColor = true;
            this.bDX.Click += new System.EventHandler(this.random);
            // 
            // bD4
            // 
            this.bD4.Location = new System.Drawing.Point(6, 93);
            this.bD4.Name = "bD4";
            this.bD4.Size = new System.Drawing.Size(75, 23);
            this.bD4.TabIndex = 2;
            this.bD4.Text = "D4";
            this.bD4.UseVisualStyleBackColor = true;
            this.bD4.Click += new System.EventHandler(this.random);
            // 
            // bCoin
            // 
            this.bCoin.Location = new System.Drawing.Point(6, 64);
            this.bCoin.Name = "bCoin";
            this.bCoin.Size = new System.Drawing.Size(75, 23);
            this.bCoin.TabIndex = 1;
            this.bCoin.Text = "Coin";
            this.bCoin.UseVisualStyleBackColor = true;
            this.bCoin.Click += new System.EventHandler(this.random);
            // 
            // lDiceResult
            // 
            this.lDiceResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lDiceResult.Location = new System.Drawing.Point(45, 19);
            this.lDiceResult.Name = "lDiceResult";
            this.lDiceResult.Size = new System.Drawing.Size(107, 26);
            this.lDiceResult.TabIndex = 0;
            this.lDiceResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lTest);
            this.Controls.Add(this.bTest);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Card Game Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bWinInc;
        private Button bLossInc;
        private TextBox inputCard;
        private GroupBox groupBox1;
        private Button bNewDeck;
        private GroupBox groupBox2;
        private Button bDelete;
        private GroupBox groupBox3;
        private Button bLossDec;
        private Button bWinDec;
        private Label lLoss;
        private Label lWin;
        private Button bAddCard;
        private Button bTest;
        private Label lTest;
        private ListBox listDeck;
        private ListBox listDecks;
        private Button bRemove;
        private Button bIncrease;
        private Button bDecrease;
        private GroupBox groupBox4;
        private Button bCoin;
        private Label lDiceResult;
        private TextBox inputCustomDice;
        private Button bD20;
        private Button bD12;
        private Button bD6;
        private Button bDX;
        private Button bD4;
        private Label lRatio;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}