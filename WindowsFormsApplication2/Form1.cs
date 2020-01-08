using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication2
{

    public partial class ATM : Form
    {
        //Variables
        string textfilepath = "users.txt";
        Dictionary<string, int> users = new Dictionary<string, int>();
        Dictionary<string, string> names = new Dictionary<string, string>();
        public static string cur_user;
        public static string cur_name;

        //Start Function - Shows Login Page
        void ShowStart()
        {
            Continue.Visible = false;
            button1.Visible = false;
            Username.Visible = true;
            PIN.Visible = true;
            UsernameLabel.Visible = true;
            PINLabel.Visible = true;
            NumKey0.Visible = true;
            NumKey1.Visible = true;
            NumKey2.Visible = true;
            NumKey3.Visible = true;
            NumKey4.Visible = true;
            NumKey5.Visible = true;
            NumKey6.Visible = true;
            NumKey7.Visible = true;
            NumKey8.Visible = true;
            NumKey9.Visible = true;
            ClearKey.Visible = true;
            NumEnterKey.Visible = true;
        }

        //Main Function
        public ATM()
        {
            InitializeComponent();
            //Sets Size and Centres Screen
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width-50, Screen.PrimaryScreen.WorkingArea.Height-50);
            button1.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width + 100, Screen.PrimaryScreen.WorkingArea.Height + 100);
            button1.Top = -100;
            button1.Left = -100;
            this.CenterToScreen();
            //Creates Event Handler of PIN Input
            this.PIN.KeyPress += new KeyPressEventHandler(PIN_KeyPress);
            DoubleBuffered = true;
        }
        
        //Form Load Function
        private void Form1_Load(object sender, EventArgs e)
        {
            //Reads from Database and Saves Information to Dictionary for Fast Use
            foreach (var i in File.ReadAllLines(textfilepath).Where(arg => !string.IsNullOrWhiteSpace(arg)))
            {
                users[i.Split(':')[0].Trim()] = Convert.ToInt32(i.Split(':')[1].Trim());
            }

            foreach (var i in File.ReadAllLines(textfilepath).Where(arg => !string.IsNullOrWhiteSpace(arg)))
            {
                names[i.Split(':')[0].Trim()] = i.Split(':')[2].Trim() + " " + i.Split(':')[3].Trim();
            }
        }

        //Pin Input Function - Restricts Pin Input to Numbers
        private void PIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (PIN.TextLength >= 4) { e.Handled = true; }
        }

        //Click Anywhere to Continue Function START
        private void button1_Click(object sender, EventArgs e)
        {
            ShowStart();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ShowStart();
        }

        private void Title_Click(object sender, EventArgs e)
        {
            ShowStart();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            ShowStart();
        }
        //Click Anywhere to Continue Function END

        //Restricts Length of PIN Input
        private void PIN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (PIN.TextLength > 4)
            {
                PIN.Enabled = false;
            }

            if (PIN.TextLength <= 4)
            {
                PIN.Enabled = true;
            }

        }

        //Keypad Buttons START
        private void NumKey1_Click(object sender, EventArgs e)
        {
            if (PIN.TextLength < 4)
            {
                int number = 1;
                PIN.Text += Convert.ToString(number);
            }

        }

        private void NumKey2_Click(object sender, EventArgs e)
        {
            if (PIN.TextLength < 4)
            {
                int number = 2;
                PIN.Text += Convert.ToString(number);
            }
        }

        private void NumKey3_Click(object sender, EventArgs e)
        {
            if (PIN.TextLength < 4)
            {
                int number = 3;
                PIN.Text += Convert.ToString(number);
            }
        }

        private void NumKey4_Click(object sender, EventArgs e)
        {
            if (PIN.TextLength < 4)
            {
                int number = 4;
                PIN.Text += Convert.ToString(number);
            }
        }

        private void NumKey5_Click(object sender, EventArgs e)
        {
            if (PIN.TextLength < 4)
            {
                int number = 5;
                PIN.Text += Convert.ToString(number);
            }
        }

        private void NumKey6_Click(object sender, EventArgs e)
        {
            if (PIN.TextLength < 4)
            {
                int number = 6;
                PIN.Text += Convert.ToString(number);
            }
        }

        private void NumKey7_Click(object sender, EventArgs e)
        {
            if (PIN.TextLength < 4)
            {
                int number = 7;
                PIN.Text += Convert.ToString(number);
            }
        }

        private void NumKey8_Click(object sender, EventArgs e)
        {
            if (PIN.TextLength < 4)
            {
                int number = 8;
                PIN.Text += Convert.ToString(number);
            }
        }

        private void NumKey9_Click(object sender, EventArgs e)
        {
            if (PIN.TextLength < 4)
            {
                int number = 9;
                PIN.Text += Convert.ToString(number);
            }
        }

        //Clears Pin
        private void ClearKey_Click(object sender, EventArgs e)
        {
            PIN.Text = string.Empty;
        }

        //Enter Function
        private void NumEnterKey_Click(object sender, EventArgs e)
        {
            //Creates new Instance of Main Form
            Main_Menu form2 = new Main_Menu();

            //Checks to See if Login Credentials are Valid
            if (string.IsNullOrWhiteSpace(PIN.Text) || string.IsNullOrWhiteSpace(Username.Text))
            {
                if (string.IsNullOrWhiteSpace(Username.Text))
                {
                    MessageBox.Show("   Please Enter a Username.  ");
                }
                else { MessageBox.Show("   Please Enter a PIN.  "); }
            }
            else
            { 
                if (users.ContainsKey(Username.Text))
                {
                    if (Convert.ToInt32(PIN.Text) == users[Username.Text])
                    {
                        //Variables for Use in Main Form
                        ATM.cur_user = Username.Text;
                        ATM.cur_name = names[cur_user];
                        //Displays Main Form - Hides Current Form
                        form2.Show();
                        this.Hide();
                    }
                    else { MessageBox.Show("   This PIN Was Incorrect.   "); }
                }
                else { MessageBox.Show("   This User Does Not Exist.   "); }
            }
        }

        private void NumKey0_Click(object sender, EventArgs e)
        {
            if (PIN.TextLength < 4)
            {
                int number = 0;
                PIN.Text += Convert.ToString(number);
            }
        }
        //Keypad Buttons End
    }
}
