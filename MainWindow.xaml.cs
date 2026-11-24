using System.Collections.Generic;
using System.Windows;

namespace Kartova_hra
{
    public partial class MainWindow : Window
    {
        const int Goal = 50;

        Random random = new Random();
        List<Card> cards = new List<Card>();
        int packs;
        int score;

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }

        void StartGame()
        {
            cards.Clear();
            packs = 0;
            score = 0;
            lblMessage.Text = "";
            btnOpen.IsEnabled = true;
            Refresh();
        }

        public Card RandomCard()
        {
            int roll = random.Next(100);

            if (roll < 70)
            {
                return new Common();
            }
            else if (roll < 95)
            {
                return new Rare();
            }
            else
            {
                return new SuperRare();
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            packs++;
            Card card = RandomCard();
            cards.Add(card);
            score += card.Points;

            if (score >= Goal)
            {
                lblMessage.Text = "Vyhral si! Stačilo ti " + packs + " balíčkov.";
                btnOpen.IsEnabled = false;
            }

            Refresh();
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        private void Refresh()
        {
            lblScore.Text = "Body: " + score + " / " + Goal;
            lblPacks.Text = "Otvorených balíčkov: " + packs;

            lstCards.Items.Clear();
            foreach (Card card in cards)
            {
                lstCards.Items.Add(card.Icon + " " + card.Name + " (+" + card.Points + ")");
            }
        }
    }
}