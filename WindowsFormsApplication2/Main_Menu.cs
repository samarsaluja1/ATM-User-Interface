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
using WindowsFormsApplication2;


namespace WindowsFormsApplication2
{
    public partial class Main_Menu : Form
    {
        //Variables
        float money;
        string textfilepath2 = "users_balance.txt";
        Dictionary<string, float> users_balance = new Dictionary<string, float>();
        List<string> balances = new List<string>();
        bool transaction = false;
        bool deposit = false;
        bool withdraw = false;
        float prev_transact;

        //Main Function
        public Main_Menu()
        {
            InitializeComponent();

            //Sets Size and Centres Windows
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width - 50, Screen.PrimaryScreen.WorkingArea.Height - 50);
            this.CenterToScreen();

            //Reduces Response Time of Input
            DoubleBuffered = true;
            
            //Loads Database Information into Dictionary for Quick Use
            foreach (var i in File.ReadAllLines(textfilepath2).Where(arg => !string.IsNullOrWhiteSpace(arg)))
            {
                users_balance[i.Split(':')[0].Trim()] = float.Parse(i.Split(':')[1].Trim());
            }
        }

        //Load Progran Function
        private void Main_Menu_Load(object sender, EventArgs e)
        {
            User.Text = "Current User: " + ATM.cur_name;
            //Starts Timer for Auto-Logout
            Screen_Timer.Interval = 45000;
            Screen_Timer.Start();
        }

        //Hides Main Menu Buttons
        void hide()
        {
            Deposit.Visible = false;
            Withdraw.Visible = false;
            BalanceEnquiry.Visible = false;
            Exit.Visible = false;
        }

        //Returns to Main Menu
        void back()
        {
            Deposit.Visible = true;
            Withdraw.Visible = true;
            BalanceEnquiry.Visible = true;
            Exit.Visible = true;
            Back.Visible = false;
            Value.Visible = false;
            DepositEnter.Visible = false;
            WithdrawEnter.Visible = false;
            YourCurrentBalance.Visible = false;
            BalanceNumber.Visible = false;
            EnterAmount.Visible = false;
            Print_Receipt.Visible = false;
            Cur_Action.Visible = false;
        }

        //Checks Balance of User
        bool checkBalance()
        {
            if (users_balance[ATM.cur_user] <= 0)
            {
                MessageBox.Show("You Have Insufficient Funds.");
                back();
                return false;
            }
            else { return true; }
        }

        //Deposit Button Function
        private void Deposit_Click(object sender, EventArgs e)
        {
            hide();
            Back.Visible = true;
            Value.Visible = true;
            DepositEnter.Visible = true;
            EnterAmount.Visible = true;
            Print_Receipt.Visible = true;
            Cur_Action.Visible = true;
            Cur_Action.Text = "Deposit";
        }

        //Withdraw Button Function
        private void Withdraw_Click(object sender, EventArgs e)
        {
            hide();
            Back.Visible = true;
            Value.Visible = true;
            WithdrawEnter.Visible = true;
            EnterAmount.Visible = true;
            Print_Receipt.Visible = true;
            Cur_Action.Visible = true;
            Cur_Action.Text = "Withdraw";
        }

        //Balance Enquiry Function
        private void BalanceEnquiry_Click(object sender, EventArgs e)
        {
            hide();
            Back.Visible = true;
            YourCurrentBalance.Visible = true;
            BalanceNumber.Visible = true;
            users_balance[ATM.cur_user] = (float)(Math.Round(Convert.ToDouble(users_balance[ATM.cur_user]), 3));
            BalanceNumber.Text = "$" + Math.Round(users_balance[ATM.cur_user], 3).ToString();
        }

        //Logout Function
        private void Exit_Click(object sender, EventArgs e)
        {
            ATM form1 = new ATM();
            form1.Show();
            this.Close();
        }

        //Return function
        private void Back_Click(object sender, EventArgs e)
        {
            back();
            transaction = false;
            deposit = false;
            withdraw = false;
            prev_transact = 0;
        }

        //Change In Input Function - Checks if Input is Valid
        private void Value_ValueChanged(object sender, EventArgs e)
        {
            //Checks if Value is Valid
            if (float.Parse(Value.Text) > 0)
            {
                money = float.Parse(Value.Text);
            }
            else { Value.Text = "0.00"; }
        }

        //Deposit Enter Function
        private void DepositEnter_Click(object sender, EventArgs e)
        {
            //Reads If Input is Greater than 0
            if (Math.Round(money, 3) > 0)
            {
                //Checks if Input is Less than 10000 - Security Risk if Large Deposits Take Place - Money Laundering
                if (Math.Round(money, 3) <= 10000)
                {
                    //Reads Balance from Dictionary and Changes Balance. User is Informed of Change
                    users_balance[ATM.cur_user] += (float)(Math.Round(Convert.ToDouble(money), 3));
                    MessageBox.Show(String.Format("You have deposited ${0}. Your account balance is now ${1}.", Convert.ToString(Math.Round(money, 3)), Convert.ToString(Math.Round(users_balance[ATM.cur_user], 3))));
                    prev_transact = (float)(Math.Round(Convert.ToDouble(money), 3));
                    money = 0.00F;
                    transaction = true;
                    deposit = true;
                    withdraw = false;
                }
                else { MessageBox.Show(String.Format("Withdrawals of greater than $10000 must be done at the bank. Your account balance is still ${0}.", Convert.ToString(Math.Round(users_balance[ATM.cur_user], 3)))); }
            }
            else { MessageBox.Show(String.Format("Invalid Deposit. Your account balance is still ${0}", Convert.ToString(Math.Round(users_balance[ATM.cur_user], 3)))); }
            Value.Text = "0.00";

            //Dictionary Writes to Actual Database File
            var list = users_balance.Keys.ToList();
            int temp = 0;
            foreach (string i in list)
            {
                balances.Insert(temp, i + " : " + Convert.ToString(users_balance[i]));
                temp += 1;
            }
            File.WriteAllLines(textfilepath2, balances);
            balances.Clear();
        }

        //Withdraw Enter Function
        private void WithdrawEnter_Click(object sender, EventArgs e)
        {
            //Reads If Input is Greater than 0 and Less than User's Balance
            if (Math.Round(money, 3) <= users_balance[ATM.cur_user] && Math.Round(money, 3) > 0)
            {
                //Checks if Input is Less than 10000 - Security Risk if Large Withdrawals Take Place - Possible Theft
                if (Math.Round(money, 3) <= 10000)
                {
                    //Reads Balance from Dictionary and Changes Balance. User is Informed of Change.
                    users_balance[ATM.cur_user] -= (float)(Math.Round(Convert.ToDouble(money), 3));
                    MessageBox.Show(String.Format("You have withdrawn ${0}. Your account balance is now ${1}.", Convert.ToString(Math.Round(money, 3)), Convert.ToString(Math.Round(users_balance[ATM.cur_user], 3))));
                    prev_transact = (float)(Math.Round(Convert.ToDouble(money), 3));
                    money = 0.00F;
                    transaction = true;
                    deposit = false;
                    withdraw = true;
                }
                else { MessageBox.Show(String.Format("Withdrawals of greater than $10000 must be done at the bank. Your account balance is still ${0}.", Convert.ToString(Math.Round(users_balance[ATM.cur_user], 3)))); }
            }
            else { MessageBox.Show(String.Format("Invalid Withdrawal. Your account balance is still ${0}", Convert.ToString(Math.Round(users_balance[ATM.cur_user], 3)))); }
            Value.Text = "0.00";


            //Dictionary Writes to Actual Database File
            var list = users_balance.Keys.ToList();
            int temp = 0;
            foreach (string i in list)
            {
                balances.Insert(temp, i + " : " + Convert.ToString(users_balance[i]));
                temp += 1;
            }
            File.WriteAllLines(textfilepath2, balances);
            balances.Clear();
        }

        //Timer Function
        private void Screen_Timer_Tick(object sender, EventArgs e)
        {
            //Timer Returns User to Login Screen if Certain Period of Inactivity
            Screen_Timer.Stop();
            MessageBox.Show("   You Have Been Logged Out.   ");
            System.Threading.Thread.Sleep(1000);
            ATM form1 = new ATM();
            form1.Show();
            this.Close();
        }

        //inactivity Function - Restarts Timer if Mouse is Clicked
        private void UI_Click(object sender, EventArgs e)
        {
            Screen_Timer.Stop();
            Screen_Timer.Start();
        }

        //inactivity Function - Restarts Timer if Mouse is Moved
        private void Mouse_Active(object sender, MouseEventArgs e)
        {
            Screen_Timer.Stop();
            Screen_Timer.Start();
        }

        //Print Receipt Function
        private void Print_Receipt_Click(object sender, EventArgs e)
        {
            //Checks if Transaction has Taken Place
            if (transaction)
            {
                //Checks Time and Names Receipt
                DateTime now = DateTime.Now;
                string save = @"receipts\" + now + "_Receipt.txt";
                save = save.Replace(" ", "_");
                save = save.Replace(":", ".");
                save = save.Replace("/", ".");
                string textfilepath3 = save;
                //Creates Receipt
                if (deposit) { string[] receipt = new string[6] { "Transaction Receipt", "User: " + ATM.cur_user, "Date and Time: " + now, "Original Balance: $" + Convert.ToString(users_balance[ATM.cur_user] - prev_transact), "Deposited: $" + prev_transact, "Final Balance: $" + Convert.ToString(users_balance[ATM.cur_user]) }; File.WriteAllLines(textfilepath3, receipt); }
                if (withdraw) { string[] receipt = new string[6] { "Transaction Receipt", "User: " + ATM.cur_user, "Date and Time: " + now, "Original Balance: $" + Convert.ToString(users_balance[ATM.cur_user] - prev_transact), "Withdrawn: $" + prev_transact, "Final Balance: $" + Convert.ToString(users_balance[ATM.cur_user]) }; File.WriteAllLines(textfilepath3, receipt); }
                //Notifies User of Receipt Creation
                MessageBox.Show("Your Receipt Has Been Saved in your Local Directory.");
            }
            else { MessageBox.Show("No transaction has taken place. There is no receipt to print."); }
        }
    }
}
