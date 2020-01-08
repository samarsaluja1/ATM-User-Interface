namespace WindowsFormsApplication2
{
    partial class Main_Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.Exit = new System.Windows.Forms.Button();
            this.BalanceEnquiry = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.EnterAmount = new System.Windows.Forms.Label();
            this.WithdrawEnter = new System.Windows.Forms.Button();
            this.DepositEnter = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.BalanceNumber = new System.Windows.Forms.Label();
            this.YourCurrentBalance = new System.Windows.Forms.Label();
            this.Screen_Timer = new System.Windows.Forms.Timer(this.components);
            this.User = new System.Windows.Forms.Label();
            this.Print_Receipt = new System.Windows.Forms.Button();
            this.Cur_Action = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Value = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(535, 723);
            this.Exit.MaximumSize = new System.Drawing.Size(365, 85);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(365, 85);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Log Out";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BalanceEnquiry
            // 
            this.BalanceEnquiry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BalanceEnquiry.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BalanceEnquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalanceEnquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceEnquiry.ForeColor = System.Drawing.Color.White;
            this.BalanceEnquiry.Location = new System.Drawing.Point(535, 560);
            this.BalanceEnquiry.MaximumSize = new System.Drawing.Size(365, 85);
            this.BalanceEnquiry.Name = "BalanceEnquiry";
            this.BalanceEnquiry.Size = new System.Drawing.Size(365, 85);
            this.BalanceEnquiry.TabIndex = 7;
            this.BalanceEnquiry.Text = "Balance Enquiry";
            this.BalanceEnquiry.UseVisualStyleBackColor = false;
            this.BalanceEnquiry.Click += new System.EventHandler(this.BalanceEnquiry_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Withdraw.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw.ForeColor = System.Drawing.Color.White;
            this.Withdraw.Location = new System.Drawing.Point(535, 401);
            this.Withdraw.MaximumSize = new System.Drawing.Size(365, 85);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(365, 84);
            this.Withdraw.TabIndex = 6;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = false;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // Deposit
            // 
            this.Deposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Deposit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit.ForeColor = System.Drawing.Color.White;
            this.Deposit.Location = new System.Drawing.Point(535, 243);
            this.Deposit.MaximumSize = new System.Drawing.Size(365, 85);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(365, 85);
            this.Deposit.TabIndex = 5;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = false;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // EnterAmount
            // 
            this.EnterAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnterAmount.BackColor = System.Drawing.Color.Transparent;
            this.EnterAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterAmount.ForeColor = System.Drawing.Color.White;
            this.EnterAmount.Location = new System.Drawing.Point(554, 503);
            this.EnterAmount.Name = "EnterAmount";
            this.EnterAmount.Size = new System.Drawing.Size(327, 54);
            this.EnterAmount.TabIndex = 16;
            this.EnterAmount.Text = "Please Enter Amount:";
            this.EnterAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EnterAmount.Visible = false;
            // 
            // WithdrawEnter
            // 
            this.WithdrawEnter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WithdrawEnter.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.WithdrawEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithdrawEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawEnter.ForeColor = System.Drawing.Color.White;
            this.WithdrawEnter.Location = new System.Drawing.Point(933, 560);
            this.WithdrawEnter.Name = "WithdrawEnter";
            this.WithdrawEnter.Size = new System.Drawing.Size(224, 52);
            this.WithdrawEnter.TabIndex = 14;
            this.WithdrawEnter.Text = "Enter";
            this.WithdrawEnter.UseVisualStyleBackColor = false;
            this.WithdrawEnter.Visible = false;
            this.WithdrawEnter.Click += new System.EventHandler(this.WithdrawEnter_Click);
            // 
            // DepositEnter
            // 
            this.DepositEnter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DepositEnter.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.DepositEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositEnter.ForeColor = System.Drawing.Color.White;
            this.DepositEnter.Location = new System.Drawing.Point(933, 560);
            this.DepositEnter.Name = "DepositEnter";
            this.DepositEnter.Size = new System.Drawing.Size(224, 52);
            this.DepositEnter.TabIndex = 17;
            this.DepositEnter.Text = "Enter";
            this.DepositEnter.UseVisualStyleBackColor = false;
            this.DepositEnter.Visible = false;
            this.DepositEnter.Click += new System.EventHandler(this.DepositEnter_Click);
            // 
            // Back
            // 
            this.Back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Back.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(-116, 100);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(169, 64);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Visible = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // BalanceNumber
            // 
            this.BalanceNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BalanceNumber.BackColor = System.Drawing.Color.Transparent;
            this.BalanceNumber.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceNumber.ForeColor = System.Drawing.Color.White;
            this.BalanceNumber.Location = new System.Drawing.Point(443, 446);
            this.BalanceNumber.Name = "BalanceNumber";
            this.BalanceNumber.Size = new System.Drawing.Size(517, 111);
            this.BalanceNumber.TabIndex = 20;
            this.BalanceNumber.Text = "0";
            this.BalanceNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BalanceNumber.Visible = false;
            // 
            // YourCurrentBalance
            // 
            this.YourCurrentBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.YourCurrentBalance.BackColor = System.Drawing.Color.Transparent;
            this.YourCurrentBalance.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourCurrentBalance.ForeColor = System.Drawing.Color.White;
            this.YourCurrentBalance.Location = new System.Drawing.Point(455, 401);
            this.YourCurrentBalance.Name = "YourCurrentBalance";
            this.YourCurrentBalance.Size = new System.Drawing.Size(481, 54);
            this.YourCurrentBalance.TabIndex = 19;
            this.YourCurrentBalance.Text = "Your Current Balance Is:";
            this.YourCurrentBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.YourCurrentBalance.Visible = false;
            // 
            // Screen_Timer
            // 
            this.Screen_Timer.Interval = 1;
            this.Screen_Timer.Tick += new System.EventHandler(this.Screen_Timer_Tick);
            // 
            // User
            // 
            this.User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(73, 738);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(236, 44);
            this.User.TabIndex = 22;
            this.User.Text = "Current User";
            // 
            // Print_Receipt
            // 
            this.Print_Receipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_Receipt.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Print_Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Receipt.ForeColor = System.Drawing.Color.White;
            this.Print_Receipt.Location = new System.Drawing.Point(1102, 727);
            this.Print_Receipt.MaximumSize = new System.Drawing.Size(365, 85);
            this.Print_Receipt.Name = "Print_Receipt";
            this.Print_Receipt.Size = new System.Drawing.Size(235, 64);
            this.Print_Receipt.TabIndex = 23;
            this.Print_Receipt.Text = "Print Receipt";
            this.Print_Receipt.UseVisualStyleBackColor = false;
            this.Print_Receipt.Visible = false;
            this.Print_Receipt.Click += new System.EventHandler(this.Print_Receipt_Click);
            // 
            // Cur_Action
            // 
            this.Cur_Action.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cur_Action.AutoSize = true;
            this.Cur_Action.BackColor = System.Drawing.Color.Transparent;
            this.Cur_Action.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cur_Action.ForeColor = System.Drawing.Color.White;
            this.Cur_Action.Location = new System.Drawing.Point(610, 108);
            this.Cur_Action.Name = "Cur_Action";
            this.Cur_Action.Size = new System.Drawing.Size(175, 58);
            this.Cur_Action.TabIndex = 25;
            this.Cur_Action.Text = "Action";
            this.Cur_Action.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cur_Action.Visible = false;
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(1044, 44);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(354, 174);
            this.Logo.TabIndex = 26;
            this.Logo.TabStop = false;
            // 
            // Value
            // 
            this.Value.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Value.DecimalPlaces = 3;
            this.Value.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.Location = new System.Drawing.Point(535, 560);
            this.Value.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(365, 43);
            this.Value.TabIndex = 15;
            this.Value.ThousandsSeparator = true;
            this.Value.Visible = false;
            this.Value.ValueChanged += new System.EventHandler(this.Value_ValueChanged);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1401, 828);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Cur_Action);
            this.Controls.Add(this.Print_Receipt);
            this.Controls.Add(this.User);
            this.Controls.Add(this.BalanceNumber);
            this.Controls.Add(this.YourCurrentBalance);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DepositEnter);
            this.Controls.Add(this.EnterAmount);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.WithdrawEnter);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BalanceEnquiry);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.Deposit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.Click += new System.EventHandler(this.UI_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Active);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button BalanceEnquiry;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Label EnterAmount;
        private System.Windows.Forms.Button WithdrawEnter;
        private System.Windows.Forms.Button DepositEnter;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label BalanceNumber;
        private System.Windows.Forms.Label YourCurrentBalance;
        private System.Windows.Forms.Timer Screen_Timer;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Button Print_Receipt;
        private System.Windows.Forms.Label Cur_Action;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.NumericUpDown Value;
    }
}