using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RiseOfThePeasant
{
    public partial class frmGame : Form
    {
        // Game state
        private double money = 0;
        private int level = 1;
        private double xp = 0;
        private double xpMax = 10;
        private double suspicion = 0;
        private bool isWorkingIllegally = false;

        // Upgrades state
        private int[] upgradeLevel = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private double[] upgradeCost = new double[10] { 20, 30, 50, 100, 50, 50, 50, 50, 50, 100 };
        private Label[] upgradeLvlLabels;
        private Label[] upgradeCostLabels;

        private double[] bribeAmount = new double[2] { 5, 10 };
        private double[] bribeCost = new double[2] { 25, 25 };
        private Label[] bribeAmountLabels;
        private Label[] bribeCostLabels;

        // Helper
        private int helperCount = 0;
        private double helperMoneyGenerated = 10;

        // Troll
        private int trollCount = 0;
        private double trollSusReduced = 5;

        // Game constants
        private double baseMoneyPerClick = 1;
        private double baseSusPerClick = 2;
        private double moneyMultiplierPerLevel = 0.5;
        private double xpPerClick = 1;
        private double suspicionIncreaseRate = 1;

        // Floating text
        private List<FloatingText> floatingTexts = new List<FloatingText>();

        public frmGame()
        {
            InitializeComponent();

            // update initial money display
            lblMoney.Text = $"${Math.Round(money, 2)}";

            // update values for upgrade labels
            upgradeLvlLabels = new Label[10]
                { lblUpgrade1Lvl, lblUpgrade2Lvl, lblUpgrade3Lvl, lblUpgrade4Lvl, lblUpgrade5Lvl,
                  lblUpgrade6Lvl, lblUpgrade7Lvl, lblUpgrade8Lvl, lblUpgrade9Lvl, lblUpgrade10Lvl };
            upgradeCostLabels = new Label[10]
                { lblUpgrade1Cost, lblUpgrade2Cost, lblUpgrade3Cost, lblUpgrade4Cost, lblUpgrade5Cost,
                  lblUpgrade6Cost, lblUpgrade7Cost, lblUpgrade8Cost, lblUpgrade9Cost, lblUpgrade10Cost };
            for (int i = 0; i < 10; i++)
            {
                upgradeLvlLabels[i].Text = $"Lvl: {upgradeLevel[i]}";
                upgradeCostLabels[i].Text = $"Cost: ${Math.Round(upgradeCost[i], 2)}";
            }

            // update values for bribe labels
            bribeAmountLabels = new Label[2] { lblPoliceBribeAmount, lblNewsBribeAmount };
            bribeCostLabels = new Label[2] { lblPoliceBribeCost, lblNewsBribeCost };
            for (int i = 0; i < 2; i++)
            {
                bribeAmountLabels[i].Text = $"Amount: {Math.Round(bribeAmount[i], 2)}";
                bribeCostLabels[i].Text = $"Cost: ${Math.Round(bribeCost[i], 2)}";
            }
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            double moneyGain = baseMoneyPerClick * level * moneyMultiplierPerLevel;
            if (isWorkingIllegally)
            {
                suspicion += baseSusPerClick;
                moneyGain *= 3;
            }
            money += moneyGain;
            xp += xpPerClick;

            if (xp >= xpMax)
            {
                xp = 0;
                level++;
                xpMax += 10;
                xpBar.Maximum = (int)xpMax;
                AddFloatingText("LEVEL UP!", Color.Cyan, new PointF(btnWork.Left + 50, btnWork.Top - 60));
                UpdateClickButtonColor();
            }

            // update UI
            lblXPAmount.Text = $"{Math.Floor(xp)}/{xpMax}";
            lblXPLvl.Text = $"Lvl {level}";
            xpBar.Value = Math.Min((int)xp, 100);

            AddFloatingText($"+${Math.Round(moneyGain, 2)}", Color.Gold, new PointF(btnWork.Left + 50, btnWork.Top - 20));

            isCaught();
        }

        private void UpdateClickButtonColor()
        {
            if (level >= 20) btnWork.BackColor = Color.Red;
            else if (level >= 10) btnWork.BackColor = Color.Purple;
            else if (level >= 5) btnWork.BackColor = Color.Blue;
            else btnWork.BackColor = Color.Gray;
        }

        private bool isCaught()
        {
            if (suspicion < 100) return false;

            suspicion = 0;
            double penalty = Math.Min(money, 50); // example penalty
            money -= penalty;
            AddFloatingText("CAUGHT!", Color.Red, new PointF(btnWork.Left + 50, btnWork.Top - 60));
            return true;
        }

        private void optIllegal_CheckedChanged(object sender, EventArgs e)
        {
            isWorkingIllegally = true;
        }

        private void optNormal_CheckedChanged(object sender, EventArgs e)
        {
            isWorkingIllegally = false;
        }

        private void tmrProcess_Tick(object sender, EventArgs e)
        {
            money += helperCount * helperMoneyGenerated * tmrProcess.Interval / 1000.0;
            suspicion -= trollCount * trollSusReduced * tmrProcess.Interval / 1000.0;
            if (isWorkingIllegally) {
                suspicion += suspicionIncreaseRate * level * tmrProcess.Interval / 1000.0;
            }
            if (suspicion < 0) suspicion = 0;

            isCaught();

            // update UI
            lblMoney.Text = $"${Math.Round(money, 2)}";
            lblSusAmount.Text = $"{Math.Floor(suspicion)}/100";
            susBar.Value = Math.Min((int)suspicion, 100);

            // Update floating texts
            for (int i = floatingTexts.Count - 1; i >= 0; i--)
            {
                floatingTexts[i].Update();
                if (floatingTexts[i].Opacity <= 0)
                    floatingTexts.RemoveAt(i);
            }

            this.Invalidate(); // triggers Paint
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var ft in floatingTexts)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb((int)(ft.Opacity * 255), ft.Color)))
                {
                    e.Graphics.DrawString(ft.Text, ft.Font, brush, ft.Position);
                }
            }
        }

        private void AddFloatingText(string text, Color color, PointF position)
        {
            floatingTexts.Add(new FloatingText
            {
                Text = text,
                Color = color,
                Position = position,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Opacity = 1.0f
            });
        }

        private bool isUpgradeable(int index)
        {
            if (money < upgradeCost[index])
            {
                return false;
            }

            // update game states
            money -= upgradeCost[index];
            upgradeLevel[index]++;
            upgradeCost[index] *= 1.1;

            // update UI
            lblMoney.Text = $"${Math.Round(money, 2)}";
            upgradeLvlLabels[index].Text = $"Lvl: {upgradeLevel[index]}";
            upgradeCostLabels[index].Text = $"Cost: ${Math.Round(upgradeCost[index], 2)}";
            return true;
        }
        private void btnUpgrade1_Click(object sender, EventArgs e)
        {
            if(isUpgradeable(0))
            {
                baseMoneyPerClick *= 1.2;
            }
        }
        private void btnUpgrade2_Click(object sender, EventArgs e)
        {
            if (isUpgradeable(1))
            {
                baseSusPerClick *= 0.9;
            }
        }
        private void btnUpgrade3_Click(object sender, EventArgs e)
        {
            if (isUpgradeable(2))
            {
                helperCount++;
            }
        }
        private void btnUpgrade4_Click(object sender, EventArgs e)
        {
            if (isUpgradeable(3))
            {
                helperMoneyGenerated *= 1.01;
            }
        }
        private void btnUpgrade5_Click(object sender, EventArgs e)
        {
            if (isUpgradeable(4))
            {
                bribeAmount[0] *= 1.2;
                bribeAmountLabels[0].Text = $"Amount: {Math.Round(bribeAmount[0], 2)}";
            }
        }
        private void btnUpgrade6_Click(object sender, EventArgs e)
        {
            if (isUpgradeable(5))
            {
                bribeCost[0] *= 0.9;
                bribeCostLabels[0].Text = $"Cost: ${Math.Round(bribeCost[0], 2)}";
            }
        }
        private void btnUpgrade7_Click(object sender, EventArgs e)
        {
            if (isUpgradeable(6))
            {
                bribeAmount[1] *= 1.2;
                bribeAmountLabels[1].Text = $"Amount: {Math.Round(bribeAmount[1], 2)}";
            }
        }
        private void btnUpgrade8_Click(object sender, EventArgs e)
        {
            if (isUpgradeable(7))
            {
                bribeCost[1] *= 0.9;
                bribeCostLabels[1].Text = $"Cost: ${Math.Round(bribeCost[1], 2)}";
            }
        }
        private void btnUpgrade9_Click(object sender, EventArgs e)
        {
            if (isUpgradeable(8))
            {
                trollCount++;
            }
        }
        private void btnUpgrade10_Click(object sender, EventArgs e)
        {
            if (isUpgradeable(9))
            {
                trollSusReduced *= 1.01;
            }
        }

        private bool isBribable(int index)
        {
            if (money < bribeCost[index])
            {
                return false;
            }

            // update game states
            money -= bribeCost[index];
            suspicion -= Math.Min(bribeAmount[index], suspicion);

            // update UI
            lblMoney.Text = $"${Math.Round(money, 2)}";
            lblSusAmount.Text = $"{Math.Floor(suspicion)}/1000";

            return true;
        }
        private void btnPoliceBribe_Click(object sender, EventArgs e)
        {
            if (isBribable(0))
            {
                AddFloatingText("Bribed Police", Color.LightBlue, new PointF(btnPoliceBribe.Left + 50, btnPoliceBribe.Top - 20));
            }
        }
        private void btnNewsBribe_Click(object sender, EventArgs e)
        {
            if (isBribable(1))
            {
                AddFloatingText("Bribed News", Color.LightBlue, new PointF(btnNewsBribe.Left + 50, btnNewsBribe.Top - 20));
            }
        }
    }

    [Serializable]
    public class GameData
    {
        public double Money { get; set; }
        public int Level { get; set; }
        public double XP { get; set; }
        public double Suspicion { get; set; }
    }

    public class FloatingText
    {
        public string Text { get; set; }
        public Color Color { get; set; }
        public PointF Position { get; set; }
        public Font Font { get; set; }
        public float Opacity { get; set; }

        public void Update()
        {
            Position = new PointF(Position.X, Position.Y - 0.5f);
            Opacity -= 0.02f;
        }
    }
}
