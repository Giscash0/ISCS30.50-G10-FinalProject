using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RiseOfThePeasant
{
    public class MainForm : Form
    {
        // Game state
        private double money = 0;
        private int level = 1;
        private double xp = 0;
        private double xpMax = 100;
        private double suspicion = 0;

        // Game constants
        private double baseMoneyPerClick = 1;
        private double moneyMultiplierPerLevel = 0.5;
        private double xpPerClick = 5;
        private double suspicionIncreaseRate = 1;

        // UI elements
        private Button clickButton;
        private ProgressBar xpBar;
        private ProgressBar suspicionBar;
        private Label moneyLabel;
        private Button bribePoliceButton;
        private Button bribeNewsButton;
        private Button bribeTrollsButton;
        private Button saveButton;
        private Button loadButton;
        private Button resetButton;

        // Floating text
        private List<FloatingText> floatingTexts = new List<FloatingText>();
        private Button button1;
        private Button button2;
        private Button button3;

        // Timer
        private System.Windows.Forms.Timer gameTimer;

        public MainForm()
        {
            this.Text = "Rise of the Peasant";
            this.Size = new Size(800, 600);
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            InitializeUI();
            InitializeTimer();
        }

        private void InitializeUI()
        {
            // Money label
            moneyLabel = new Label
            {
                Text = $"Money: {money}",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                AutoSize = true
            };
            this.Controls.Add(moneyLabel);

            // XP bar
            xpBar = new ProgressBar
            {
                Location = new Point(20, 60),
                Size = new Size(740, 25),
                Maximum = 100
            };
            this.Controls.Add(xpBar);

            // Suspicion bar
            suspicionBar = new ProgressBar
            {
                Location = new Point(20, 100),
                Size = new Size(740, 25),
                Maximum = 100,
                ForeColor = Color.Red
            };
            this.Controls.Add(suspicionBar);

            // Click button
            clickButton = new Button
            {
                Text = "CLICK ME",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Size = new Size(200, 80),
                Location = new Point((this.ClientSize.Width - 200) / 2, 150),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            clickButton.FlatAppearance.BorderSize = 0;
            clickButton.Click += ClickButton_Click;
            this.Controls.Add(clickButton);

            // Bribe buttons
            bribePoliceButton = CreateBribeButton("Pay Police", 50, 300, BribePolice_Click);
            bribeNewsButton = CreateBribeButton("Pay News", 250, 300, BribeNews_Click);
            bribeTrollsButton = CreateBribeButton("Pay Trolls", 450, 300, BribeTrolls_Click);

            // Save/Load/Reset buttons
            saveButton = CreateBribeButton("Save", 20, 400, SaveButton_Click);
            loadButton = CreateBribeButton("Load", 120, 400, LoadButton_Click);
            resetButton = CreateBribeButton("Reset", 220, 400, ResetButton_Click);
        }

        private Button CreateBribeButton(string text, int x, int y, EventHandler onClick)
        {
            var btn = new Button
            {
                Text = text,
                Size = new Size(100, 50),
                Location = new Point(x, y),
                BackColor = Color.DarkSlateGray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.MouseEnter += (s, e) => btn.BackColor = Color.Teal;
            btn.MouseLeave += (s, e) => btn.BackColor = Color.DarkSlateGray;
            btn.Click += onClick;
            this.Controls.Add(btn);
            return btn;
        }

        private void InitializeTimer()
        {
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 50; // 20 FPS
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            xpBar.Value = Math.Min((int)xp, xpBar.Maximum);
            suspicionBar.Value = Math.Min((int)suspicion, suspicionBar.Maximum);
            moneyLabel.Text = $"Money: {Math.Round(money, 2)}";

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

        private void ClickButton_Click(object sender, EventArgs e)
        {
            double moneyGain = baseMoneyPerClick * (1 + level * moneyMultiplierPerLevel);
            money += moneyGain;
            xp += xpPerClick;
            suspicion += suspicionIncreaseRate * level;

            AddFloatingText($"+${Math.Round(moneyGain, 2)}", Color.Gold, new PointF(clickButton.Left + 50, clickButton.Top - 20));
            AddFloatingText($"+{xpPerClick} XP", Color.LightGreen, new PointF(clickButton.Left + 50, clickButton.Top - 40));

            CheckLevelUp();
            CheckCaught();
        }

        private void CheckLevelUp()
        {
            if (xp >= xpMax)
            {
                xp -= xpMax;
                level++;
                AddFloatingText("LEVEL UP!", Color.Cyan, new PointF(clickButton.Left + 50, clickButton.Top - 60));
                UpdateClickButtonColor();
            }
        }

        private void UpdateClickButtonColor()
        {
            if (level >= 20) clickButton.BackColor = Color.Red;
            else if (level >= 10) clickButton.BackColor = Color.Purple;
            else if (level >= 5) clickButton.BackColor = Color.Blue;
            else clickButton.BackColor = Color.Gray;
        }

        private void CheckCaught()
        {
            if (suspicion >= 100)
            {
                suspicion = 0;
                double penalty = Math.Min(money, 50); // example penalty
                money -= penalty;
                AddFloatingText("CAUGHT!", Color.Red, new PointF(clickButton.Left + 50, clickButton.Top - 60));
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

        #region Bribe Handlers
        private void BribePolice_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money -= 100;
                suspicion = Math.Max(0, suspicion - 30);
                AddFloatingText("Bribed Police -30 Suspicion", Color.LightBlue, new PointF(20, 250));
            }
        }
        private void BribeNews_Click(object sender, EventArgs e)
        {
            if (money >= 150)
            {
                money -= 150;
                suspicion = Math.Max(0, suspicion - 50);
                AddFloatingText("Bribed News -50 Suspicion", Color.LightBlue, new PointF(250, 250));
            }
        }
        private void BribeTrolls_Click(object sender, EventArgs e)
        {
            if (money >= 50)
            {
                money -= 50;
                suspicion = Math.Max(0, suspicion - 15);
                AddFloatingText("Bribed Trolls -15 Suspicion", Color.LightBlue, new PointF(450, 250));
            }
        }
        #endregion

        #region Save/Load/Reset
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                GameData data = new GameData
                {
                    Money = money,
                    Level = level,
                    XP = xp,
                    Suspicion = suspicion
                };
                XmlSerializer serializer = new XmlSerializer(typeof(GameData));
                using (FileStream fs = new FileStream("save.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, data);
                }
                AddFloatingText("Game Saved!", Color.Green, new PointF(20, 450));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save failed: {ex.Message}");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("save.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(GameData));
                    using (FileStream fs = new FileStream("save.xml", FileMode.Open))
                    {
                        GameData data = (GameData)serializer.Deserialize(fs);
                        money = data.Money;
                        level = data.Level;
                        xp = data.XP;
                        suspicion = data.Suspicion;
                        UpdateClickButtonColor();
                        AddFloatingText("Game Loaded!", Color.Green, new PointF(20, 470));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load failed: {ex.Message}");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            money = 0;
            level = 1;
            xp = 0;
            suspicion = 0;
            UpdateClickButtonColor();
            AddFloatingText("RESET", Color.Orange, new PointF(20, 490));
        }
        #endregion

        private void InitializeComponent()
        {

        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
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
