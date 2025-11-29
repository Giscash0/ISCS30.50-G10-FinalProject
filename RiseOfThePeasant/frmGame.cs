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
        private double money = 1000000;
        private int level = 1;
        private double xp = 0;
        private double xpMax = 100;
        private double suspicion = 0;
        private bool isWorkingIllegally = false;

        // Upgrades state
        private int[] upgradeLevel = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private double[] upgradeCost = new double[10] { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20 };
        private Label[] upgradeLvlLabels;
        private Label[] upgradeCostLabels;

        private double[] bribeAmount = new double[2] { 5, 10 };
        private double[] bribeCost = new double[2] { 20, 20 };
        private Label[] bribeAmountLabels;
        private Label[] bribeCostLabels;

        // Game constants
        private double baseMoneyPerClick = 1;
        private double moneyMultiplierPerLevel = 0.5;
        private double xpPerClick = 5;
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
            double moneyGain = baseMoneyPerClick * (1 + level * moneyMultiplierPerLevel);
            money += moneyGain;
            xp += xpPerClick;
            suspicion += suspicionIncreaseRate * level;

            AddFloatingText($"+${Math.Round(moneyGain, 2)}", Color.Gold, new PointF(btnWork.Left + 50, btnWork.Top - 20));
            AddFloatingText($"+{xpPerClick} XP", Color.LightGreen, new PointF(btnWork.Left + 50, btnWork.Top - 40));

            //CheckLevelUp();
            //CheckCaught();
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

        private void btnUpgrade_Click(int index)
        {
            if (money >= upgradeCost[index])
            {
                // update game states
                money -= upgradeCost[index];
                upgradeLevel[index]++;
                upgradeCost[index] *= 1.1;

                // update UI
                lblMoney.Text = $"${Math.Round(money, 2)}";
                upgradeLvlLabels[index].Text = $"Lvl: {upgradeLevel[index]}";
                upgradeCostLabels[index].Text = $"Cost: ${Math.Round(upgradeCost[index], 2)}";
            }
        }
        private void btnUpgrade1_Click(object sender, EventArgs e)
        {
            btnUpgrade_Click(0);
        }
        private void btnUpgrade2_Click(object sender, EventArgs e)
        {
            btnUpgrade_Click(1);
        }
        private void btnUpgrade3_Click(object sender, EventArgs e)
        {
            btnUpgrade_Click(2);
        }
        private void btnUpgrade4_Click(object sender, EventArgs e)
        {
            btnUpgrade_Click(3);
        }
        private void btnUpgrade5_Click(object sender, EventArgs e)
        {
            btnUpgrade_Click(4);
        }
        private void btnUpgrade6_Click(object sender, EventArgs e)
        {
            btnUpgrade_Click(5);
        }
        private void btnUpgrade7_Click(object sender, EventArgs e)
        {
            btnUpgrade_Click(6);
        }
        private void btnUpgrade8_Click(object sender, EventArgs e)
        {
            btnUpgrade_Click(7);
        }
        private void btnUpgrade9_Click(object sender, EventArgs e)
        {
            btnUpgrade_Click(8);
        }
        private void btnUpgrade10_Click(object sender, EventArgs e)
        {
            btnUpgrade_Click(9);
        }

        private void btnBribe_Click(int index)
        {
            if (money >= upgradeCost[index])
            {
                // update game states
                money -= upgradeCost[index];
                upgradeLevel[index]++;
                upgradeCost[index] *= 1.1;

                // update UI
                lblMoney.Text = $"${Math.Round(money, 2)}";
                upgradeLvlLabels[index].Text = $"Lvl: {upgradeLevel[index]}";
                upgradeCostLabels[index].Text = $"Cost: ${Math.Round(upgradeCost[index], 2)}";
            }
        }
        private void btnBribe1_Click(object sender, EventArgs e)
        {

        }
        private void btnBribe2_Click(object sender, EventArgs e)
        {

        }
    }
}
