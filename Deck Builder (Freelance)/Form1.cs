namespace Deck_Builder__Freelance_
{
    using Microsoft.VisualBasic;
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        int win = 0;
        int loss = 0;

        string deckDir = "Decks/";
        string currentDeck = "";
        string scoreFile = "Score";
        string format = "n: name";
        int cardMax = 9;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            lWin.Text = win.ToString();
            lLoss.Text = loss.ToString();

            load();
        }

        private void load()
        {
            string[] decks = Directory.GetFiles(deckDir);
            foreach (string deck in decks)
            {
                //var x = deck.Substring(0, deck.IndexOf('.'));
                listDecks.Items.Add(deck);
            }

            string[] scores = File.ReadAllLines(scoreFile);
            win = int.Parse(scores[0]);
            loss = int.Parse(scores[1]);
            updateCounters();
        }

        private void save()
        {
            string deckString = "";
            foreach (string card in listDeck.Items)
                deckString += card + "\n";
            if (!Directory.Exists(deckDir))
                Directory.CreateDirectory(deckDir);
            if (currentDeck != "")
                File.WriteAllText(currentDeck, deckString);

            // Score
            string score = lWin.Text + "\n";
            score += lLoss.Text;
            //score += lRatio.Text;
            //lTest.Text = deckString;
            File.WriteAllText(scoreFile, score);
        }

        private void updateCounters()
        {
            lWin.Text = win.ToString();
            lLoss.Text = loss.ToString();
            lRatio.Text = ((double)win / loss).ToString();
        }

        private void bWinInc_Click(object sender, EventArgs e)
        {
            win++;
            updateCounters();
        }

        private void bWinDec_Click(object sender, EventArgs e)
        {
            win--;
            updateCounters();
        }

        private void bLossInc_Click(object sender, EventArgs e)
        {
            loss++;
            updateCounters();
        }

        private void bLossDec_Click(object sender, EventArgs e)
        {
            loss--;
            updateCounters();
        }

        private void bAddCard_Click(object sender, EventArgs e)
        {
            if (inputCard.Text == null)
                return;

            string input = inputCard.Text;

            int n = 1;

            foreach (string card in listDeck.Items)
                if (card.Contains(input))
                {
                    if (card.First() - '0' < cardMax)
                        listDeck.Items[listDeck.Items.IndexOf(card)] = (n + card.First() - '0') + ": " + input;
                    return;
                }

            listDeck.Items.Add(n + ": " + input);
        }

        private void bDecrease_Click(object sender, EventArgs e)
        {
            if (listDeck.SelectedItem != null)
            {
                string selected = listDeck.SelectedItem.ToString();
                if (selected.First() - '0' > 1)
                    listDeck.Items[listDeck.SelectedIndex] = (selected.First() - '0' - 1) + selected.Substring(1);
                else
                    listDeck.Items.Remove(selected);
            }
        }

        private void bIncrease_Click(object sender, EventArgs e)
        {
            if (listDeck.SelectedItem != null)
            {
                string selected = listDeck.SelectedItem.ToString();
                if (selected.First() - '0' < 9)
                    listDeck.Items[listDeck.SelectedIndex] = (selected.First() - '0' + 1) + selected.Substring(1);
            }
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (listDeck.SelectedItem != null)
                listDeck.Items.Remove(listDeck.SelectedItem);
        }

        private void bNewDeck_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Prompt", "Title", "Default");
            input = deckDir + input;
            if (!listDecks.Items.Contains(input))
                listDecks.Items.Add(input);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (listDecks.SelectedItem != null)
                listDecks.Items.Remove(listDecks.SelectedItem);
        }

        private void listDecks_SelectedIndexChanged(object sender, EventArgs e)
        {
            save();
            listDeck.Items.Clear();
            if (listDecks.SelectedItems != null)
                currentDeck = listDecks.SelectedItem.ToString();
            if ((currentDeck != "" || currentDeck != null) && File.Exists(currentDeck))
            {
                string[] cards = File.ReadAllLines(currentDeck);
                foreach (string card in cards)
                    listDeck.Items.Add(card);
            }
        }

        private void bTest_Click(object sender, EventArgs e)
        {
            save();
        }

        private void random(object sender, EventArgs e)
        {
            if (sender == bCoin)
                lDiceResult.Text = "Result: " + (rnd.Next(2) == 0 ? "Tails" : "Heads");
            else if (sender == bD4)
                lDiceResult.Text = "Result: " + (rnd.Next(4) + 1);
            else if (sender == bD6)
                lDiceResult.Text = "Result: " + (rnd.Next(6) + 1);
            else if (sender == bD12)
                lDiceResult.Text = "Result: " + (rnd.Next(12) + 1);
            else if (sender == bD20)
                lDiceResult.Text = "Result: " + (rnd.Next(20) + 1);
            else if (sender == bDX)
                if (inputCustomDice.Text != "")
                    lDiceResult.Text = "Result: " + (rnd.Next(int.Parse(inputCustomDice.Text)) + 1);
        }

        private void customDice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
                e.Handled = false;
        }
    }
}