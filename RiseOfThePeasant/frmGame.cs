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
        private double xpMax = 100;
        private double suspicion = 0;
        private bool isWorkingIllegally = false;

        // Game constants
        private double baseMoneyPerClick = 1;
        private double moneyMultiplierPerLevel = 0.5;
        private double xpPerClick = 5;
        private double suspicionIncreaseRate = 1;

        public frmGame()
        {
            InitializeComponent();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            double moneyGain = baseMoneyPerClick * (1 + level * moneyMultiplierPerLevel);
            money += moneyGain;
            xp += xpPerClick;
            suspicion += suspicionIncreaseRate * level;

            AddFloatingText($"+${Math.Round(moneyGain, 2)}", Color.Gold, new PointF(btnWork.Left + 50, btnWork.Top - 20));
            AddFloatingText($"+{xpPerClick} XP", Color.LightGreen, new PointF(btnWork.Left + 50, btnWork.Top - 40));

            CheckLevelUp();
            CheckCaught();
        }
    }
}
