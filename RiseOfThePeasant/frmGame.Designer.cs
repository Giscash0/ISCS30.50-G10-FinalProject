namespace RiseOfThePeasant
{
    partial class frmGame
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
            components = new System.ComponentModel.Container();
            pBarXP = new ProgressBar();
            pBarSus = new ProgressBar();
            lblMoney = new Label();
            btnWork = new Button();
            optNormal = new RadioButton();
            optIllegal = new RadioButton();
            tabControl1 = new TabControl();
            tabPolice = new TabPage();
            lblUpgrade5Description = new Label();
            lblUpgrade5Title = new Label();
            lblUpgrade5Lvl = new Label();
            lblUpgrade5Cost = new Label();
            btnUpgrade5 = new Button();
            lblUpgrade6Description = new Label();
            lblUpgrade6Title = new Label();
            lblUpgrade6Lvl = new Label();
            lblUpgrade6Cost = new Label();
            btnUpgrade6 = new Button();
            lblPoliceBribeAmount = new Label();
            lblPoliceBribeCost = new Label();
            btnBribe1 = new Button();
            tabNews = new TabPage();
            lblUpgrade7Description = new Label();
            lblUpgrade7Title = new Label();
            lblUpgrade7Lvl = new Label();
            lblUpgrade7Cost = new Label();
            btnUpgrade7 = new Button();
            lblUpgrade8Description = new Label();
            lblUpgrade8Title = new Label();
            lblUpgrade8Lvl = new Label();
            lblUpgrade8Cost = new Label();
            btnUpgrade8 = new Button();
            lblNewsBribeAmount = new Label();
            lblNewsBribeCost = new Label();
            btnBribe2 = new Button();
            tabTrolls = new TabPage();
            lblUpgrade10Description = new Label();
            lblUpgrade10Title = new Label();
            lblUpgrade10Lvl = new Label();
            lblUpgrade10Cost = new Label();
            btnUpgrade10 = new Button();
            lblUpgrade9Description = new Label();
            lblUpgrade9Title = new Label();
            lblUpgrade9Lvl = new Label();
            lblUpgrade9Cost = new Label();
            btnUpgrade9 = new Button();
            tabControl2 = new TabControl();
            tabWork = new TabPage();
            lblUpgrade2Description = new Label();
            lblUpgrade2Title = new Label();
            lblUpgrade2Lvl = new Label();
            lblUpgrade2Cost = new Label();
            btnUpgrade2 = new Button();
            lblUpgrade1Description = new Label();
            lblUpgrade1Title = new Label();
            lblUpgrade1Lvl = new Label();
            lblUpgrade1Cost = new Label();
            btnUpgrade1 = new Button();
            tabHelper = new TabPage();
            lblUpgrade4Description = new Label();
            lblUpgrade4Title = new Label();
            lblUpgrade4Lvl = new Label();
            lblUpgrade4Cost = new Label();
            btnUpgrade4 = new Button();
            lblUpgrade3Description = new Label();
            lblUpgrade3Title = new Label();
            lblUpgrade3Lvl = new Label();
            lblUpgrade3Cost = new Label();
            btnUpgrade3 = new Button();
            btnSave = new Button();
            lblXPLvl = new Label();
            lblSusLvl = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLoad = new Button();
            tmrProcess = new System.Windows.Forms.Timer(components);
            lblXPAmount = new Label();
            lblSusAmount = new Label();
            tabControl1.SuspendLayout();
            tabPolice.SuspendLayout();
            tabNews.SuspendLayout();
            tabTrolls.SuspendLayout();
            tabControl2.SuspendLayout();
            tabWork.SuspendLayout();
            tabHelper.SuspendLayout();
            SuspendLayout();
            // 
            // pBarXP
            // 
            pBarXP.Location = new Point(101, 55);
            pBarXP.Name = "pBarXP";
            pBarXP.Size = new Size(659, 25);
            pBarXP.TabIndex = 0;
            // 
            // pBarSus
            // 
            pBarSus.Location = new Point(101, 127);
            pBarSus.Name = "pBarSus";
            pBarSus.Size = new Size(659, 25);
            pBarSus.TabIndex = 1;
            // 
            // lblMoney
            // 
            lblMoney.Font = new Font("Segoe UI", 25F);
            lblMoney.Location = new Point(288, 186);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(216, 76);
            lblMoney.TabIndex = 2;
            lblMoney.Text = "$10000";
            lblMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnWork
            // 
            btnWork.Location = new Point(314, 349);
            btnWork.Name = "btnWork";
            btnWork.Size = new Size(156, 84);
            btnWork.TabIndex = 3;
            btnWork.Text = "WORK";
            btnWork.UseVisualStyleBackColor = true;
            btnWork.Click += btnWork_Click;
            // 
            // optNormal
            // 
            optNormal.AutoSize = true;
            optNormal.Checked = true;
            optNormal.Location = new Point(304, 309);
            optNormal.Name = "optNormal";
            optNormal.Size = new Size(65, 19);
            optNormal.TabIndex = 4;
            optNormal.TabStop = true;
            optNormal.Text = "Normal";
            optNormal.UseVisualStyleBackColor = true;
            optNormal.CheckedChanged += optNormal_CheckedChanged;
            // 
            // optIllegal
            // 
            optIllegal.AutoSize = true;
            optIllegal.Location = new Point(430, 309);
            optIllegal.Name = "optIllegal";
            optIllegal.Size = new Size(56, 19);
            optIllegal.TabIndex = 5;
            optIllegal.Text = "Illegal";
            optIllegal.UseVisualStyleBackColor = true;
            optIllegal.CheckedChanged += optIllegal_CheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPolice);
            tabControl1.Controls.Add(tabNews);
            tabControl1.Controls.Add(tabTrolls);
            tabControl1.Location = new Point(510, 206);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(262, 331);
            tabControl1.TabIndex = 7;
            // 
            // tabPolice
            // 
            tabPolice.Controls.Add(lblUpgrade5Description);
            tabPolice.Controls.Add(lblUpgrade5Title);
            tabPolice.Controls.Add(lblUpgrade5Lvl);
            tabPolice.Controls.Add(lblUpgrade5Cost);
            tabPolice.Controls.Add(btnUpgrade5);
            tabPolice.Controls.Add(lblUpgrade6Description);
            tabPolice.Controls.Add(lblUpgrade6Title);
            tabPolice.Controls.Add(lblUpgrade6Lvl);
            tabPolice.Controls.Add(lblUpgrade6Cost);
            tabPolice.Controls.Add(btnUpgrade6);
            tabPolice.Controls.Add(lblPoliceBribeAmount);
            tabPolice.Controls.Add(lblPoliceBribeCost);
            tabPolice.Controls.Add(btnBribe1);
            tabPolice.Location = new Point(4, 24);
            tabPolice.Name = "tabPolice";
            tabPolice.Padding = new Padding(3);
            tabPolice.Size = new Size(254, 303);
            tabPolice.TabIndex = 0;
            tabPolice.Text = "Police";
            tabPolice.UseVisualStyleBackColor = true;
            // 
            // lblUpgrade5Description
            // 
            lblUpgrade5Description.AutoSize = true;
            lblUpgrade5Description.Location = new Point(33, 178);
            lblUpgrade5Description.Name = "lblUpgrade5Description";
            lblUpgrade5Description.Size = new Size(143, 15);
            lblUpgrade5Description.TabIndex = 24;
            lblUpgrade5Description.Text = "Higher Amount per BRIBE";
            // 
            // lblUpgrade5Title
            // 
            lblUpgrade5Title.AutoSize = true;
            lblUpgrade5Title.Font = new Font("Segoe UI", 11F);
            lblUpgrade5Title.Location = new Point(33, 119);
            lblUpgrade5Title.Name = "lblUpgrade5Title";
            lblUpgrade5Title.Size = new Size(66, 20);
            lblUpgrade5Title.TabIndex = 23;
            lblUpgrade5Title.Text = "Stronger";
            // 
            // lblUpgrade5Lvl
            // 
            lblUpgrade5Lvl.AutoSize = true;
            lblUpgrade5Lvl.Location = new Point(33, 145);
            lblUpgrade5Lvl.Name = "lblUpgrade5Lvl";
            lblUpgrade5Lvl.Size = new Size(24, 15);
            lblUpgrade5Lvl.TabIndex = 22;
            lblUpgrade5Lvl.Text = "Lvl:";
            // 
            // lblUpgrade5Cost
            // 
            lblUpgrade5Cost.AutoSize = true;
            lblUpgrade5Cost.Location = new Point(33, 160);
            lblUpgrade5Cost.Name = "lblUpgrade5Cost";
            lblUpgrade5Cost.Size = new Size(34, 15);
            lblUpgrade5Cost.TabIndex = 21;
            lblUpgrade5Cost.Text = "Cost:";
            // 
            // btnUpgrade5
            // 
            btnUpgrade5.Location = new Point(135, 119);
            btnUpgrade5.Name = "btnUpgrade5";
            btnUpgrade5.Size = new Size(92, 56);
            btnUpgrade5.TabIndex = 20;
            btnUpgrade5.Text = "Upgrade";
            btnUpgrade5.UseVisualStyleBackColor = true;
            btnUpgrade5.Click += btnUpgrade5_Click;
            // 
            // lblUpgrade6Description
            // 
            lblUpgrade6Description.AutoSize = true;
            lblUpgrade6Description.Location = new Point(33, 274);
            lblUpgrade6Description.Name = "lblUpgrade6Description";
            lblUpgrade6Description.Size = new Size(119, 15);
            lblUpgrade6Description.TabIndex = 19;
            lblUpgrade6Description.Text = "Lower Cost per BRIBE";
            // 
            // lblUpgrade6Title
            // 
            lblUpgrade6Title.AutoSize = true;
            lblUpgrade6Title.Font = new Font("Segoe UI", 11F);
            lblUpgrade6Title.Location = new Point(33, 215);
            lblUpgrade6Title.Name = "lblUpgrade6Title";
            lblUpgrade6Title.Size = new Size(67, 20);
            lblUpgrade6Title.TabIndex = 18;
            lblUpgrade6Title.Text = "Discount";
            // 
            // lblUpgrade6Lvl
            // 
            lblUpgrade6Lvl.AutoSize = true;
            lblUpgrade6Lvl.Location = new Point(33, 241);
            lblUpgrade6Lvl.Name = "lblUpgrade6Lvl";
            lblUpgrade6Lvl.Size = new Size(24, 15);
            lblUpgrade6Lvl.TabIndex = 17;
            lblUpgrade6Lvl.Text = "Lvl:";
            // 
            // lblUpgrade6Cost
            // 
            lblUpgrade6Cost.AutoSize = true;
            lblUpgrade6Cost.Location = new Point(33, 256);
            lblUpgrade6Cost.Name = "lblUpgrade6Cost";
            lblUpgrade6Cost.Size = new Size(34, 15);
            lblUpgrade6Cost.TabIndex = 16;
            lblUpgrade6Cost.Text = "Cost:";
            // 
            // btnUpgrade6
            // 
            btnUpgrade6.Location = new Point(135, 215);
            btnUpgrade6.Name = "btnUpgrade6";
            btnUpgrade6.Size = new Size(92, 56);
            btnUpgrade6.TabIndex = 15;
            btnUpgrade6.Text = "Upgrade";
            btnUpgrade6.UseVisualStyleBackColor = true;
            btnUpgrade6.Click += btnUpgrade6_Click;
            // 
            // lblPoliceBribeAmount
            // 
            lblPoliceBribeAmount.AutoSize = true;
            lblPoliceBribeAmount.Location = new Point(73, 73);
            lblPoliceBribeAmount.Name = "lblPoliceBribeAmount";
            lblPoliceBribeAmount.Size = new Size(54, 15);
            lblPoliceBribeAmount.TabIndex = 12;
            lblPoliceBribeAmount.Text = "Amount:";
            // 
            // lblPoliceBribeCost
            // 
            lblPoliceBribeCost.AutoSize = true;
            lblPoliceBribeCost.Location = new Point(73, 88);
            lblPoliceBribeCost.Name = "lblPoliceBribeCost";
            lblPoliceBribeCost.Size = new Size(34, 15);
            lblPoliceBribeCost.TabIndex = 11;
            lblPoliceBribeCost.Text = "Cost:";
            // 
            // btnBribe1
            // 
            btnBribe1.Location = new Point(73, 18);
            btnBribe1.Name = "btnBribe1";
            btnBribe1.Size = new Size(112, 51);
            btnBribe1.TabIndex = 10;
            btnBribe1.Text = "BRIBE";
            btnBribe1.UseVisualStyleBackColor = true;
            btnBribe1.Click += btnBribe1_Click;
            // 
            // tabNews
            // 
            tabNews.Controls.Add(lblUpgrade7Description);
            tabNews.Controls.Add(lblUpgrade7Title);
            tabNews.Controls.Add(lblUpgrade7Lvl);
            tabNews.Controls.Add(lblUpgrade7Cost);
            tabNews.Controls.Add(btnUpgrade7);
            tabNews.Controls.Add(lblUpgrade8Description);
            tabNews.Controls.Add(lblUpgrade8Title);
            tabNews.Controls.Add(lblUpgrade8Lvl);
            tabNews.Controls.Add(lblUpgrade8Cost);
            tabNews.Controls.Add(btnUpgrade8);
            tabNews.Controls.Add(lblNewsBribeAmount);
            tabNews.Controls.Add(lblNewsBribeCost);
            tabNews.Controls.Add(btnBribe2);
            tabNews.Location = new Point(4, 24);
            tabNews.Name = "tabNews";
            tabNews.Padding = new Padding(3);
            tabNews.Size = new Size(254, 303);
            tabNews.TabIndex = 1;
            tabNews.Text = "News";
            tabNews.UseVisualStyleBackColor = true;
            // 
            // lblUpgrade7Description
            // 
            lblUpgrade7Description.AutoSize = true;
            lblUpgrade7Description.Location = new Point(30, 176);
            lblUpgrade7Description.Name = "lblUpgrade7Description";
            lblUpgrade7Description.Size = new Size(143, 15);
            lblUpgrade7Description.TabIndex = 37;
            lblUpgrade7Description.Text = "Higher Amount per BRIBE";
            // 
            // lblUpgrade7Title
            // 
            lblUpgrade7Title.AutoSize = true;
            lblUpgrade7Title.Font = new Font("Segoe UI", 11F);
            lblUpgrade7Title.Location = new Point(30, 117);
            lblUpgrade7Title.Name = "lblUpgrade7Title";
            lblUpgrade7Title.Size = new Size(66, 20);
            lblUpgrade7Title.TabIndex = 36;
            lblUpgrade7Title.Text = "Stronger";
            // 
            // lblUpgrade7Lvl
            // 
            lblUpgrade7Lvl.AutoSize = true;
            lblUpgrade7Lvl.Location = new Point(30, 143);
            lblUpgrade7Lvl.Name = "lblUpgrade7Lvl";
            lblUpgrade7Lvl.Size = new Size(24, 15);
            lblUpgrade7Lvl.TabIndex = 35;
            lblUpgrade7Lvl.Text = "Lvl:";
            // 
            // lblUpgrade7Cost
            // 
            lblUpgrade7Cost.AutoSize = true;
            lblUpgrade7Cost.Location = new Point(30, 158);
            lblUpgrade7Cost.Name = "lblUpgrade7Cost";
            lblUpgrade7Cost.Size = new Size(34, 15);
            lblUpgrade7Cost.TabIndex = 34;
            lblUpgrade7Cost.Text = "Cost:";
            // 
            // btnUpgrade7
            // 
            btnUpgrade7.Location = new Point(132, 117);
            btnUpgrade7.Name = "btnUpgrade7";
            btnUpgrade7.Size = new Size(92, 56);
            btnUpgrade7.TabIndex = 33;
            btnUpgrade7.Text = "Upgrade";
            btnUpgrade7.UseVisualStyleBackColor = true;
            btnUpgrade7.Click += btnUpgrade7_Click;
            // 
            // lblUpgrade8Description
            // 
            lblUpgrade8Description.AutoSize = true;
            lblUpgrade8Description.Location = new Point(30, 272);
            lblUpgrade8Description.Name = "lblUpgrade8Description";
            lblUpgrade8Description.Size = new Size(119, 15);
            lblUpgrade8Description.TabIndex = 32;
            lblUpgrade8Description.Text = "Lower Cost per BRIBE";
            // 
            // lblUpgrade8Title
            // 
            lblUpgrade8Title.AutoSize = true;
            lblUpgrade8Title.Font = new Font("Segoe UI", 11F);
            lblUpgrade8Title.Location = new Point(30, 213);
            lblUpgrade8Title.Name = "lblUpgrade8Title";
            lblUpgrade8Title.Size = new Size(67, 20);
            lblUpgrade8Title.TabIndex = 31;
            lblUpgrade8Title.Text = "Discount";
            // 
            // lblUpgrade8Lvl
            // 
            lblUpgrade8Lvl.AutoSize = true;
            lblUpgrade8Lvl.Location = new Point(30, 239);
            lblUpgrade8Lvl.Name = "lblUpgrade8Lvl";
            lblUpgrade8Lvl.Size = new Size(24, 15);
            lblUpgrade8Lvl.TabIndex = 30;
            lblUpgrade8Lvl.Text = "Lvl:";
            // 
            // lblUpgrade8Cost
            // 
            lblUpgrade8Cost.AutoSize = true;
            lblUpgrade8Cost.Location = new Point(30, 254);
            lblUpgrade8Cost.Name = "lblUpgrade8Cost";
            lblUpgrade8Cost.Size = new Size(34, 15);
            lblUpgrade8Cost.TabIndex = 29;
            lblUpgrade8Cost.Text = "Cost:";
            // 
            // btnUpgrade8
            // 
            btnUpgrade8.Location = new Point(132, 213);
            btnUpgrade8.Name = "btnUpgrade8";
            btnUpgrade8.Size = new Size(92, 56);
            btnUpgrade8.TabIndex = 28;
            btnUpgrade8.Text = "Upgrade";
            btnUpgrade8.UseVisualStyleBackColor = true;
            btnUpgrade8.Click += btnUpgrade8_Click;
            // 
            // lblNewsBribeAmount
            // 
            lblNewsBribeAmount.AutoSize = true;
            lblNewsBribeAmount.Location = new Point(70, 71);
            lblNewsBribeAmount.Name = "lblNewsBribeAmount";
            lblNewsBribeAmount.Size = new Size(54, 15);
            lblNewsBribeAmount.TabIndex = 27;
            lblNewsBribeAmount.Text = "Amount:";
            // 
            // lblNewsBribeCost
            // 
            lblNewsBribeCost.AutoSize = true;
            lblNewsBribeCost.Location = new Point(70, 86);
            lblNewsBribeCost.Name = "lblNewsBribeCost";
            lblNewsBribeCost.Size = new Size(34, 15);
            lblNewsBribeCost.TabIndex = 26;
            lblNewsBribeCost.Text = "Cost:";
            // 
            // btnBribe2
            // 
            btnBribe2.Location = new Point(70, 16);
            btnBribe2.Name = "btnBribe2";
            btnBribe2.Size = new Size(112, 51);
            btnBribe2.TabIndex = 25;
            btnBribe2.Text = "BRIBE";
            btnBribe2.UseVisualStyleBackColor = true;
            btnBribe2.Click += btnBribe2_Click;
            // 
            // tabTrolls
            // 
            tabTrolls.Controls.Add(lblUpgrade10Description);
            tabTrolls.Controls.Add(lblUpgrade10Title);
            tabTrolls.Controls.Add(lblUpgrade10Lvl);
            tabTrolls.Controls.Add(lblUpgrade10Cost);
            tabTrolls.Controls.Add(btnUpgrade10);
            tabTrolls.Controls.Add(lblUpgrade9Description);
            tabTrolls.Controls.Add(lblUpgrade9Title);
            tabTrolls.Controls.Add(lblUpgrade9Lvl);
            tabTrolls.Controls.Add(lblUpgrade9Cost);
            tabTrolls.Controls.Add(btnUpgrade9);
            tabTrolls.Location = new Point(4, 24);
            tabTrolls.Name = "tabTrolls";
            tabTrolls.Size = new Size(254, 303);
            tabTrolls.TabIndex = 2;
            tabTrolls.Text = "Trolls";
            tabTrolls.UseVisualStyleBackColor = true;
            // 
            // lblUpgrade10Description
            // 
            lblUpgrade10Description.AutoSize = true;
            lblUpgrade10Description.Location = new Point(15, 252);
            lblUpgrade10Description.Name = "lblUpgrade10Description";
            lblUpgrade10Description.Size = new Size(147, 15);
            lblUpgrade10Description.TabIndex = 24;
            lblUpgrade10Description.Text = "Each troll lowers more SUS";
            // 
            // lblUpgrade10Title
            // 
            lblUpgrade10Title.AutoSize = true;
            lblUpgrade10Title.Font = new Font("Segoe UI", 11F);
            lblUpgrade10Title.Location = new Point(21, 174);
            lblUpgrade10Title.Name = "lblUpgrade10Title";
            lblUpgrade10Title.Size = new Size(80, 20);
            lblUpgrade10Title.TabIndex = 23;
            lblUpgrade10Title.Text = "Train Trolls";
            // 
            // lblUpgrade10Lvl
            // 
            lblUpgrade10Lvl.AutoSize = true;
            lblUpgrade10Lvl.Location = new Point(21, 200);
            lblUpgrade10Lvl.Name = "lblUpgrade10Lvl";
            lblUpgrade10Lvl.Size = new Size(24, 15);
            lblUpgrade10Lvl.TabIndex = 22;
            lblUpgrade10Lvl.Text = "Lvl:";
            // 
            // lblUpgrade10Cost
            // 
            lblUpgrade10Cost.AutoSize = true;
            lblUpgrade10Cost.Location = new Point(21, 215);
            lblUpgrade10Cost.Name = "lblUpgrade10Cost";
            lblUpgrade10Cost.Size = new Size(34, 15);
            lblUpgrade10Cost.TabIndex = 21;
            lblUpgrade10Cost.Text = "Cost:";
            // 
            // btnUpgrade10
            // 
            btnUpgrade10.Location = new Point(123, 174);
            btnUpgrade10.Name = "btnUpgrade10";
            btnUpgrade10.Size = new Size(114, 66);
            btnUpgrade10.TabIndex = 20;
            btnUpgrade10.Text = "Upgrade";
            btnUpgrade10.UseVisualStyleBackColor = true;
            btnUpgrade10.Click += btnUpgrade10_Click;
            // 
            // lblUpgrade9Description
            // 
            lblUpgrade9Description.AutoSize = true;
            lblUpgrade9Description.Location = new Point(15, 113);
            lblUpgrade9Description.Name = "lblUpgrade9Description";
            lblUpgrade9Description.Size = new Size(195, 15);
            lblUpgrade9Description.TabIndex = 19;
            lblUpgrade9Description.Text = "Add troll that decreases SUS for you";
            // 
            // lblUpgrade9Title
            // 
            lblUpgrade9Title.AutoSize = true;
            lblUpgrade9Title.Font = new Font("Segoe UI", 11F);
            lblUpgrade9Title.Location = new Point(21, 35);
            lblUpgrade9Title.Name = "lblUpgrade9Title";
            lblUpgrade9Title.Size = new Size(76, 20);
            lblUpgrade9Title.TabIndex = 18;
            lblUpgrade9Title.Text = "Hire Trolls";
            // 
            // lblUpgrade9Lvl
            // 
            lblUpgrade9Lvl.AutoSize = true;
            lblUpgrade9Lvl.Location = new Point(21, 61);
            lblUpgrade9Lvl.Name = "lblUpgrade9Lvl";
            lblUpgrade9Lvl.Size = new Size(24, 15);
            lblUpgrade9Lvl.TabIndex = 17;
            lblUpgrade9Lvl.Text = "Lvl:";
            // 
            // lblUpgrade9Cost
            // 
            lblUpgrade9Cost.AutoSize = true;
            lblUpgrade9Cost.Location = new Point(21, 76);
            lblUpgrade9Cost.Name = "lblUpgrade9Cost";
            lblUpgrade9Cost.Size = new Size(34, 15);
            lblUpgrade9Cost.TabIndex = 16;
            lblUpgrade9Cost.Text = "Cost:";
            // 
            // btnUpgrade9
            // 
            btnUpgrade9.Location = new Point(123, 35);
            btnUpgrade9.Name = "btnUpgrade9";
            btnUpgrade9.Size = new Size(114, 66);
            btnUpgrade9.TabIndex = 15;
            btnUpgrade9.Text = "Upgrade";
            btnUpgrade9.UseVisualStyleBackColor = true;
            btnUpgrade9.Click += btnUpgrade9_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabWork);
            tabControl2.Controls.Add(tabHelper);
            tabControl2.Location = new Point(20, 206);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(262, 331);
            tabControl2.TabIndex = 8;
            // 
            // tabWork
            // 
            tabWork.Controls.Add(lblUpgrade2Description);
            tabWork.Controls.Add(lblUpgrade2Title);
            tabWork.Controls.Add(lblUpgrade2Lvl);
            tabWork.Controls.Add(lblUpgrade2Cost);
            tabWork.Controls.Add(btnUpgrade2);
            tabWork.Controls.Add(lblUpgrade1Description);
            tabWork.Controls.Add(lblUpgrade1Title);
            tabWork.Controls.Add(lblUpgrade1Lvl);
            tabWork.Controls.Add(lblUpgrade1Cost);
            tabWork.Controls.Add(btnUpgrade1);
            tabWork.Location = new Point(4, 24);
            tabWork.Name = "tabWork";
            tabWork.Padding = new Padding(3);
            tabWork.Size = new Size(254, 303);
            tabWork.TabIndex = 0;
            tabWork.Text = "Work Upgrades";
            tabWork.UseVisualStyleBackColor = true;
            // 
            // lblUpgrade2Description
            // 
            lblUpgrade2Description.AutoSize = true;
            lblUpgrade2Description.Location = new Point(10, 251);
            lblUpgrade2Description.Name = "lblUpgrade2Description";
            lblUpgrade2Description.Size = new Size(229, 15);
            lblUpgrade2Description.TabIndex = 9;
            lblUpgrade2Description.Text = "Lower SUS increase when working illegally";
            // 
            // lblUpgrade2Title
            // 
            lblUpgrade2Title.AutoSize = true;
            lblUpgrade2Title.Font = new Font("Segoe UI", 11F);
            lblUpgrade2Title.Location = new Point(16, 173);
            lblUpgrade2Title.Name = "lblUpgrade2Title";
            lblUpgrade2Title.Size = new Size(101, 20);
            lblUpgrade2Title.TabIndex = 8;
            lblUpgrade2Title.Text = "Work Discreet";
            // 
            // lblUpgrade2Lvl
            // 
            lblUpgrade2Lvl.AutoSize = true;
            lblUpgrade2Lvl.Location = new Point(16, 199);
            lblUpgrade2Lvl.Name = "lblUpgrade2Lvl";
            lblUpgrade2Lvl.Size = new Size(24, 15);
            lblUpgrade2Lvl.TabIndex = 7;
            lblUpgrade2Lvl.Text = "Lvl:";
            // 
            // lblUpgrade2Cost
            // 
            lblUpgrade2Cost.AutoSize = true;
            lblUpgrade2Cost.Location = new Point(16, 214);
            lblUpgrade2Cost.Name = "lblUpgrade2Cost";
            lblUpgrade2Cost.Size = new Size(34, 15);
            lblUpgrade2Cost.TabIndex = 6;
            lblUpgrade2Cost.Text = "Cost:";
            // 
            // btnUpgrade2
            // 
            btnUpgrade2.Location = new Point(118, 173);
            btnUpgrade2.Name = "btnUpgrade2";
            btnUpgrade2.Size = new Size(114, 66);
            btnUpgrade2.TabIndex = 5;
            btnUpgrade2.Text = "Upgrade";
            btnUpgrade2.UseVisualStyleBackColor = true;
            btnUpgrade2.Click += btnUpgrade2_Click;
            // 
            // lblUpgrade1Description
            // 
            lblUpgrade1Description.AutoSize = true;
            lblUpgrade1Description.Location = new Point(10, 106);
            lblUpgrade1Description.Name = "lblUpgrade1Description";
            lblUpgrade1Description.Size = new Size(150, 15);
            lblUpgrade1Description.TabIndex = 4;
            lblUpgrade1Description.Text = "More money gain per work";
            // 
            // lblUpgrade1Title
            // 
            lblUpgrade1Title.AutoSize = true;
            lblUpgrade1Title.Font = new Font("Segoe UI", 11F);
            lblUpgrade1Title.Location = new Point(16, 28);
            lblUpgrade1Title.Name = "lblUpgrade1Title";
            lblUpgrade1Title.Size = new Size(93, 20);
            lblUpgrade1Title.TabIndex = 3;
            lblUpgrade1Title.Text = "Work Harder";
            // 
            // lblUpgrade1Lvl
            // 
            lblUpgrade1Lvl.AutoSize = true;
            lblUpgrade1Lvl.Location = new Point(16, 54);
            lblUpgrade1Lvl.Name = "lblUpgrade1Lvl";
            lblUpgrade1Lvl.Size = new Size(24, 15);
            lblUpgrade1Lvl.TabIndex = 2;
            lblUpgrade1Lvl.Text = "Lvl:";
            // 
            // lblUpgrade1Cost
            // 
            lblUpgrade1Cost.AutoSize = true;
            lblUpgrade1Cost.Location = new Point(16, 69);
            lblUpgrade1Cost.Name = "lblUpgrade1Cost";
            lblUpgrade1Cost.Size = new Size(34, 15);
            lblUpgrade1Cost.TabIndex = 1;
            lblUpgrade1Cost.Text = "Cost:";
            // 
            // btnUpgrade1
            // 
            btnUpgrade1.Location = new Point(118, 28);
            btnUpgrade1.Name = "btnUpgrade1";
            btnUpgrade1.Size = new Size(114, 66);
            btnUpgrade1.TabIndex = 0;
            btnUpgrade1.Text = "Upgrade";
            btnUpgrade1.UseVisualStyleBackColor = true;
            btnUpgrade1.Click += btnUpgrade1_Click;
            // 
            // tabHelper
            // 
            tabHelper.Controls.Add(lblUpgrade4Description);
            tabHelper.Controls.Add(lblUpgrade4Title);
            tabHelper.Controls.Add(lblUpgrade4Lvl);
            tabHelper.Controls.Add(lblUpgrade4Cost);
            tabHelper.Controls.Add(btnUpgrade4);
            tabHelper.Controls.Add(lblUpgrade3Description);
            tabHelper.Controls.Add(lblUpgrade3Title);
            tabHelper.Controls.Add(lblUpgrade3Lvl);
            tabHelper.Controls.Add(lblUpgrade3Cost);
            tabHelper.Controls.Add(btnUpgrade3);
            tabHelper.Location = new Point(4, 24);
            tabHelper.Name = "tabHelper";
            tabHelper.Padding = new Padding(3);
            tabHelper.Size = new Size(254, 303);
            tabHelper.TabIndex = 1;
            tabHelper.Text = "Helper";
            tabHelper.UseVisualStyleBackColor = true;
            // 
            // lblUpgrade4Description
            // 
            lblUpgrade4Description.AutoSize = true;
            lblUpgrade4Description.Location = new Point(9, 249);
            lblUpgrade4Description.Name = "lblUpgrade4Description";
            lblUpgrade4Description.Size = new Size(172, 15);
            lblUpgrade4Description.TabIndex = 14;
            lblUpgrade4Description.Text = "Each worker gives more money";
            // 
            // lblUpgrade4Title
            // 
            lblUpgrade4Title.AutoSize = true;
            lblUpgrade4Title.Font = new Font("Segoe UI", 11F);
            lblUpgrade4Title.Location = new Point(15, 171);
            lblUpgrade4Title.Name = "lblUpgrade4Title";
            lblUpgrade4Title.Size = new Size(90, 20);
            lblUpgrade4Title.TabIndex = 13;
            lblUpgrade4Title.Text = "Train Helper";
            // 
            // lblUpgrade4Lvl
            // 
            lblUpgrade4Lvl.AutoSize = true;
            lblUpgrade4Lvl.Location = new Point(15, 197);
            lblUpgrade4Lvl.Name = "lblUpgrade4Lvl";
            lblUpgrade4Lvl.Size = new Size(24, 15);
            lblUpgrade4Lvl.TabIndex = 12;
            lblUpgrade4Lvl.Text = "Lvl:";
            // 
            // lblUpgrade4Cost
            // 
            lblUpgrade4Cost.AutoSize = true;
            lblUpgrade4Cost.Location = new Point(15, 212);
            lblUpgrade4Cost.Name = "lblUpgrade4Cost";
            lblUpgrade4Cost.Size = new Size(34, 15);
            lblUpgrade4Cost.TabIndex = 11;
            lblUpgrade4Cost.Text = "Cost:";
            // 
            // btnUpgrade4
            // 
            btnUpgrade4.Location = new Point(117, 171);
            btnUpgrade4.Name = "btnUpgrade4";
            btnUpgrade4.Size = new Size(114, 66);
            btnUpgrade4.TabIndex = 10;
            btnUpgrade4.Text = "Upgrade";
            btnUpgrade4.UseVisualStyleBackColor = true;
            btnUpgrade4.Click += btnUpgrade4_Click;
            // 
            // lblUpgrade3Description
            // 
            lblUpgrade3Description.AutoSize = true;
            lblUpgrade3Description.Location = new Point(9, 110);
            lblUpgrade3Description.Name = "lblUpgrade3Description";
            lblUpgrade3Description.Size = new Size(224, 15);
            lblUpgrade3Description.TabIndex = 9;
            lblUpgrade3Description.Text = "Add helper that generates money for you";
            // 
            // lblUpgrade3Title
            // 
            lblUpgrade3Title.AutoSize = true;
            lblUpgrade3Title.Font = new Font("Segoe UI", 11F);
            lblUpgrade3Title.Location = new Point(15, 32);
            lblUpgrade3Title.Name = "lblUpgrade3Title";
            lblUpgrade3Title.Size = new Size(86, 20);
            lblUpgrade3Title.TabIndex = 8;
            lblUpgrade3Title.Text = "Hire Helper";
            // 
            // lblUpgrade3Lvl
            // 
            lblUpgrade3Lvl.AutoSize = true;
            lblUpgrade3Lvl.Location = new Point(15, 58);
            lblUpgrade3Lvl.Name = "lblUpgrade3Lvl";
            lblUpgrade3Lvl.Size = new Size(24, 15);
            lblUpgrade3Lvl.TabIndex = 7;
            lblUpgrade3Lvl.Text = "Lvl:";
            // 
            // lblUpgrade3Cost
            // 
            lblUpgrade3Cost.AutoSize = true;
            lblUpgrade3Cost.Location = new Point(15, 73);
            lblUpgrade3Cost.Name = "lblUpgrade3Cost";
            lblUpgrade3Cost.Size = new Size(34, 15);
            lblUpgrade3Cost.TabIndex = 6;
            lblUpgrade3Cost.Text = "Cost:";
            // 
            // btnUpgrade3
            // 
            btnUpgrade3.Location = new Point(117, 32);
            btnUpgrade3.Name = "btnUpgrade3";
            btnUpgrade3.Size = new Size(114, 66);
            btnUpgrade3.TabIndex = 5;
            btnUpgrade3.Text = "Upgrade";
            btnUpgrade3.UseVisualStyleBackColor = true;
            btnUpgrade3.Click += btnUpgrade3_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(344, 457);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 32);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblXPLvl
            // 
            lblXPLvl.AutoSize = true;
            lblXPLvl.Font = new Font("Segoe UI", 15F);
            lblXPLvl.Location = new Point(24, 52);
            lblXPLvl.Name = "lblXPLvl";
            lblXPLvl.Size = new Size(51, 28);
            lblXPLvl.TabIndex = 10;
            lblXPLvl.Text = "Lvl 0";
            // 
            // lblSusLvl
            // 
            lblSusLvl.AutoSize = true;
            lblSusLvl.Font = new Font("Segoe UI", 15F);
            lblSusLvl.Location = new Point(24, 124);
            lblSusLvl.Name = "lblSusLvl";
            lblSusLvl.Size = new Size(51, 28);
            lblSusLvl.TabIndex = 11;
            lblSusLvl.Text = "Lvl 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 80);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 12;
            label3.Text = "XP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 152);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 13;
            label4.Text = "SUS";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(344, 501);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 32);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // tmrProcess
            // 
            tmrProcess.Enabled = true;
            tmrProcess.Interval = 10;
            tmrProcess.Tick += tmrProcess_Tick;
            // 
            // lblXPAmount
            // 
            lblXPAmount.Location = new Point(101, 83);
            lblXPAmount.Name = "lblXPAmount";
            lblXPAmount.Size = new Size(659, 23);
            lblXPAmount.TabIndex = 15;
            lblXPAmount.Text = "0/10";
            lblXPAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSusAmount
            // 
            lblSusAmount.Location = new Point(101, 148);
            lblSusAmount.Name = "lblSusAmount";
            lblSusAmount.Size = new Size(659, 23);
            lblSusAmount.TabIndex = 16;
            lblSusAmount.Text = "0/10";
            lblSusAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            Controls.Add(lblSusAmount);
            Controls.Add(lblXPAmount);
            Controls.Add(btnLoad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblSusLvl);
            Controls.Add(lblXPLvl);
            Controls.Add(btnSave);
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            Controls.Add(optIllegal);
            Controls.Add(optNormal);
            Controls.Add(btnWork);
            Controls.Add(lblMoney);
            Controls.Add(pBarSus);
            Controls.Add(pBarXP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmGame";
            Text = "Rise of The Peasant";
            tabControl1.ResumeLayout(false);
            tabPolice.ResumeLayout(false);
            tabPolice.PerformLayout();
            tabNews.ResumeLayout(false);
            tabNews.PerformLayout();
            tabTrolls.ResumeLayout(false);
            tabTrolls.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabWork.ResumeLayout(false);
            tabWork.PerformLayout();
            tabHelper.ResumeLayout(false);
            tabHelper.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pBarXP;
        private ProgressBar pBarSus;
        private Label lblMoney;
        private Button btnWork;
        private RadioButton optNormal;
        private RadioButton optIllegal;
        private TabControl tabControl1;
        private TabPage tabPolice;
        private TabPage tabNews;
        private TabControl tabControl2;
        private TabPage tabWork;
        private TabPage tabHelper;
        private Button btnSave;
        private TabPage tabTrolls;
        private Label lblXPLvl;
        private Label lblSusLvl;
        private Label label3;
        private Label label4;
        private Button btnLoad;
        private Label lblUpgrade1Cost;
        private Button btnUpgrade1;
        private Label lblUpgrade1Title;
        private Label lblUpgrade1Lvl;
        private Label lblUpgrade1Description;
        private Label lblUpgrade4Description;
        private Label lblUpgrade4Title;
        private Label lblUpgrade4Lvl;
        private Label lblUpgrade4Cost;
        private Button btnUpgrade4;
        private Label lblUpgrade3Description;
        private Label lblUpgrade3Title;
        private Label lblUpgrade3Lvl;
        private Label lblUpgrade3Cost;
        private Button btnUpgrade3;
        private Label lblUpgrade2Description;
        private Label lblUpgrade2Title;
        private Label lblUpgrade2Lvl;
        private Label lblUpgrade2Cost;
        private Button btnUpgrade2;
        private Label lblPoliceBribeAmount;
        private Label lblPoliceBribeCost;
        private Button btnBribe1;
        private Label lblUpgrade5Description;
        private Label lblUpgrade5Title;
        private Label lblUpgrade5Lvl;
        private Label lblUpgrade5Cost;
        private Button btnUpgrade5;
        private Label lblUpgrade6Description;
        private Label lblUpgrade6Title;
        private Label lblUpgrade6Lvl;
        private Label lblUpgrade6Cost;
        private Button btnUpgrade6;
        private Label lblUpgrade7Description;
        private Label lblUpgrade7Title;
        private Label lblUpgrade7Lvl;
        private Label lblUpgrade7Cost;
        private Button btnUpgrade7;
        private Label lblUpgrade8Description;
        private Label lblUpgrade8Title;
        private Label lblUpgrade8Lvl;
        private Label lblUpgrade8Cost;
        private Button btnUpgrade8;
        private Label lblNewsBribeAmount;
        private Label lblNewsBribeCost;
        private Button btnBribe2;
        private Label lblUpgrade10Description;
        private Label lblUpgrade10Title;
        private Label lblUpgrade10Lvl;
        private Label lblUpgrade10Cost;
        private Button btnUpgrade10;
        private Label lblUpgrade9Description;
        private Label lblUpgrade9Title;
        private Label lblUpgrade9Lvl;
        private Label lblUpgrade9Cost;
        private Button btnUpgrade9;
        private System.Windows.Forms.Timer tmrProcess;
        private Label lblXPAmount;
        private Label lblSusAmount;
    }
}