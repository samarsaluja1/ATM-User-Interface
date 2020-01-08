namespace WindowsFormsApplication2
{
    partial class ATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM));
            this.button1 = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.MaskedTextBox();
            this.PIN = new System.Windows.Forms.MaskedTextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PINLabel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.NumKey1 = new System.Windows.Forms.Button();
            this.NumKey2 = new System.Windows.Forms.Button();
            this.NumKey3 = new System.Windows.Forms.Button();
            this.NumKey6 = new System.Windows.Forms.Button();
            this.NumKey5 = new System.Windows.Forms.Button();
            this.NumKey4 = new System.Windows.Forms.Button();
            this.NumKey9 = new System.Windows.Forms.Button();
            this.NumKey8 = new System.Windows.Forms.Button();
            this.NumKey7 = new System.Windows.Forms.Button();
            this.ClearKey = new System.Windows.Forms.Button();
            this.NumEnterKey = new System.Windows.Forms.Button();
            this.NumKey0 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(316, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1451, 810);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Continue
            // 
            this.Continue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Continue.BackColor = System.Drawing.Color.Transparent;
            this.Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Continue.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.White;
            this.Continue.Location = new System.Drawing.Point(0, 147);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(1370, 749);
            this.Continue.TabIndex = 1;
            this.Continue.Text = "Press Anywhere to Begin";
            this.Continue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Continue.Click += new System.EventHandler(this.label1_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Title.BackgroundImage")));
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Title.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Title.Location = new System.Drawing.Point(304, 34);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1218, 172);
            this.Title.TabIndex = 3;
            this.Title.TabStop = false;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(558, 307);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(400, 32);
            this.Username.TabIndex = 4;
            this.Username.Visible = false;
            // 
            // PIN
            // 
            this.PIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PIN.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN.Location = new System.Drawing.Point(558, 353);
            this.PIN.Name = "PIN";
            this.PIN.PasswordChar = '*';
            this.PIN.Size = new System.Drawing.Size(400, 32);
            this.PIN.TabIndex = 5;
            this.PIN.Visible = false;
            this.PIN.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PIN_MaskInputRejected);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(401, 296);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(172, 54);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UsernameLabel.Visible = false;
            // 
            // PINLabel
            // 
            this.PINLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PINLabel.BackColor = System.Drawing.Color.Transparent;
            this.PINLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PINLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINLabel.ForeColor = System.Drawing.Color.White;
            this.PINLabel.Location = new System.Drawing.Point(436, 340);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(172, 54);
            this.PINLabel.TabIndex = 7;
            this.PINLabel.Text = "PIN:";
            this.PINLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PINLabel.Visible = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(-36, -131);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(534, 574);
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // NumKey1
            // 
            this.NumKey1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumKey1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumKey1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKey1.ForeColor = System.Drawing.Color.White;
            this.NumKey1.Location = new System.Drawing.Point(589, 414);
            this.NumKey1.Name = "NumKey1";
            this.NumKey1.Size = new System.Drawing.Size(106, 80);
            this.NumKey1.TabIndex = 9;
            this.NumKey1.Text = "1";
            this.NumKey1.UseVisualStyleBackColor = false;
            this.NumKey1.Visible = false;
            this.NumKey1.Click += new System.EventHandler(this.NumKey1_Click);
            // 
            // NumKey2
            // 
            this.NumKey2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumKey2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumKey2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKey2.ForeColor = System.Drawing.Color.White;
            this.NumKey2.Location = new System.Drawing.Point(701, 414);
            this.NumKey2.Name = "NumKey2";
            this.NumKey2.Size = new System.Drawing.Size(100, 80);
            this.NumKey2.TabIndex = 10;
            this.NumKey2.Text = "2";
            this.NumKey2.UseVisualStyleBackColor = false;
            this.NumKey2.Visible = false;
            this.NumKey2.Click += new System.EventHandler(this.NumKey2_Click);
            // 
            // NumKey3
            // 
            this.NumKey3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumKey3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumKey3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKey3.ForeColor = System.Drawing.Color.White;
            this.NumKey3.Location = new System.Drawing.Point(806, 414);
            this.NumKey3.Name = "NumKey3";
            this.NumKey3.Size = new System.Drawing.Size(106, 80);
            this.NumKey3.TabIndex = 11;
            this.NumKey3.Text = "3";
            this.NumKey3.UseVisualStyleBackColor = false;
            this.NumKey3.Visible = false;
            this.NumKey3.Click += new System.EventHandler(this.NumKey3_Click);
            // 
            // NumKey6
            // 
            this.NumKey6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumKey6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumKey6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKey6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKey6.ForeColor = System.Drawing.Color.White;
            this.NumKey6.Location = new System.Drawing.Point(806, 500);
            this.NumKey6.Name = "NumKey6";
            this.NumKey6.Size = new System.Drawing.Size(106, 80);
            this.NumKey6.TabIndex = 14;
            this.NumKey6.Text = "6";
            this.NumKey6.UseVisualStyleBackColor = false;
            this.NumKey6.Visible = false;
            this.NumKey6.Click += new System.EventHandler(this.NumKey6_Click);
            // 
            // NumKey5
            // 
            this.NumKey5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumKey5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumKey5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKey5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKey5.ForeColor = System.Drawing.Color.White;
            this.NumKey5.Location = new System.Drawing.Point(701, 500);
            this.NumKey5.Name = "NumKey5";
            this.NumKey5.Size = new System.Drawing.Size(100, 80);
            this.NumKey5.TabIndex = 13;
            this.NumKey5.Text = "5";
            this.NumKey5.UseVisualStyleBackColor = false;
            this.NumKey5.Visible = false;
            this.NumKey5.Click += new System.EventHandler(this.NumKey5_Click);
            // 
            // NumKey4
            // 
            this.NumKey4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumKey4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumKey4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKey4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKey4.ForeColor = System.Drawing.Color.White;
            this.NumKey4.Location = new System.Drawing.Point(589, 500);
            this.NumKey4.Name = "NumKey4";
            this.NumKey4.Size = new System.Drawing.Size(106, 80);
            this.NumKey4.TabIndex = 12;
            this.NumKey4.Text = "4";
            this.NumKey4.UseVisualStyleBackColor = false;
            this.NumKey4.Visible = false;
            this.NumKey4.Click += new System.EventHandler(this.NumKey4_Click);
            // 
            // NumKey9
            // 
            this.NumKey9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumKey9.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumKey9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKey9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKey9.ForeColor = System.Drawing.Color.White;
            this.NumKey9.Location = new System.Drawing.Point(806, 586);
            this.NumKey9.Name = "NumKey9";
            this.NumKey9.Size = new System.Drawing.Size(106, 80);
            this.NumKey9.TabIndex = 17;
            this.NumKey9.Text = "9";
            this.NumKey9.UseVisualStyleBackColor = false;
            this.NumKey9.Visible = false;
            this.NumKey9.Click += new System.EventHandler(this.NumKey9_Click);
            // 
            // NumKey8
            // 
            this.NumKey8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumKey8.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumKey8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKey8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKey8.ForeColor = System.Drawing.Color.White;
            this.NumKey8.Location = new System.Drawing.Point(701, 586);
            this.NumKey8.Name = "NumKey8";
            this.NumKey8.Size = new System.Drawing.Size(100, 80);
            this.NumKey8.TabIndex = 16;
            this.NumKey8.Text = "8";
            this.NumKey8.UseVisualStyleBackColor = false;
            this.NumKey8.Visible = false;
            this.NumKey8.Click += new System.EventHandler(this.NumKey8_Click);
            // 
            // NumKey7
            // 
            this.NumKey7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumKey7.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumKey7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKey7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKey7.ForeColor = System.Drawing.Color.White;
            this.NumKey7.Location = new System.Drawing.Point(589, 586);
            this.NumKey7.Name = "NumKey7";
            this.NumKey7.Size = new System.Drawing.Size(106, 80);
            this.NumKey7.TabIndex = 15;
            this.NumKey7.Text = "7";
            this.NumKey7.UseVisualStyleBackColor = false;
            this.NumKey7.Visible = false;
            this.NumKey7.Click += new System.EventHandler(this.NumKey7_Click);
            // 
            // ClearKey
            // 
            this.ClearKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClearKey.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClearKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearKey.ForeColor = System.Drawing.Color.White;
            this.ClearKey.Location = new System.Drawing.Point(589, 672);
            this.ClearKey.Name = "ClearKey";
            this.ClearKey.Size = new System.Drawing.Size(106, 80);
            this.ClearKey.TabIndex = 18;
            this.ClearKey.Text = "Clear";
            this.ClearKey.UseVisualStyleBackColor = false;
            this.ClearKey.Visible = false;
            this.ClearKey.Click += new System.EventHandler(this.ClearKey_Click);
            // 
            // NumEnterKey
            // 
            this.NumEnterKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumEnterKey.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumEnterKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumEnterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumEnterKey.ForeColor = System.Drawing.Color.White;
            this.NumEnterKey.Location = new System.Drawing.Point(806, 672);
            this.NumEnterKey.Name = "NumEnterKey";
            this.NumEnterKey.Size = new System.Drawing.Size(106, 80);
            this.NumEnterKey.TabIndex = 19;
            this.NumEnterKey.Text = "Enter";
            this.NumEnterKey.UseVisualStyleBackColor = false;
            this.NumEnterKey.Visible = false;
            this.NumEnterKey.Click += new System.EventHandler(this.NumEnterKey_Click);
            // 
            // NumKey0
            // 
            this.NumKey0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumKey0.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.NumKey0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumKey0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumKey0.ForeColor = System.Drawing.Color.White;
            this.NumKey0.Location = new System.Drawing.Point(701, 672);
            this.NumKey0.Name = "NumKey0";
            this.NumKey0.Size = new System.Drawing.Size(100, 80);
            this.NumKey0.TabIndex = 20;
            this.NumKey0.Text = "0";
            this.NumKey0.UseVisualStyleBackColor = false;
            this.NumKey0.Visible = false;
            this.NumKey0.Click += new System.EventHandler(this.NumKey0_Click);
            // 
            // ATM
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PIN);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.NumKey0);
            this.Controls.Add(this.NumEnterKey);
            this.Controls.Add(this.ClearKey);
            this.Controls.Add(this.NumKey9);
            this.Controls.Add(this.NumKey8);
            this.Controls.Add(this.NumKey7);
            this.Controls.Add(this.NumKey6);
            this.Controls.Add(this.NumKey5);
            this.Controls.Add(this.NumKey4);
            this.Controls.Add(this.NumKey3);
            this.Controls.Add(this.NumKey2);
            this.Controls.Add(this.NumKey1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.PINLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ATM";
            this.Text = "Alpha Centauri ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Continue;
        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.MaskedTextBox Username;
        private System.Windows.Forms.MaskedTextBox PIN;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button NumKey1;
        private System.Windows.Forms.Button NumKey2;
        private System.Windows.Forms.Button NumKey3;
        private System.Windows.Forms.Button NumKey6;
        private System.Windows.Forms.Button NumKey5;
        private System.Windows.Forms.Button NumKey4;
        private System.Windows.Forms.Button NumKey9;
        private System.Windows.Forms.Button NumKey8;
        private System.Windows.Forms.Button NumKey7;
        private System.Windows.Forms.Button ClearKey;
        private System.Windows.Forms.Button NumEnterKey;
        private System.Windows.Forms.Button NumKey0;
    }
}

