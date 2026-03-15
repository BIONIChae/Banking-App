namespace TheBankingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankaccount = new BankAccount();
            bankaccount.Owner = "Chae Dhlamini";
            bankaccount.AccountNumber = Guid.NewGuid();
            bankaccount.Balance = 120000000;

            BankAccount bankaccount2 = new BankAccount();
            bankaccount2.Owner = "Sabrina Carpenter";
            bankaccount2.AccountNumber = Guid.NewGuid();
            bankaccount2.Balance = 15000000;

            BankAccount bankaccount3 = new BankAccount();
            bankaccount3.Owner = "Zendaya";
            bankaccount3.AccountNumber = Guid.NewGuid();
            bankaccount3.Balance = 61000000;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankaccount);
            bankAccounts.Add(bankaccount2);
            bankAccounts.Add(bankaccount3);

            BankAccountsGrid.DataSource = bankAccounts;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
