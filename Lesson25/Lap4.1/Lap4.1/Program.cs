using System;

public class Account
{

    protected double Balance;

    // Constructor khởi tạo tài khoản với số tiền ban đầu
    public Account(double initialBalance)
    {
        Balance = initialBalance;
    }

    // Phương thức gửi tiền
    public void Deposit(double money)
    {
        if (money > 0)
        {
            Balance += money;
            Console.WriteLine("Đã gửi: " + money + " VND");
        }
        else
        {
            Console.WriteLine("Số tiền gửi không hợp lệ.");
        }
    }

    // Phương thức rút tiền
    public void Withdraw(double money)
    {
        if (money > 0 && money <= Balance)
        {
            Balance -= money;
            Console.WriteLine("Đã rút: " + money + " VND");
        }
        else
        {
            Console.WriteLine("Số tiền rút không hợp lệ.");
        }
    }

    // Phương thức lấy số dư tài khoản
    public double GetBalance()
    {
        return Balance;
    }
};
public class SavingAccount : Account
{
    private double Rate; // Lãi suất

    // Constructor khởi tạo với số dư ban đầu và lãi suất
    public SavingAccount(double initialBalance, double rate) : base(initialBalance)
    {
        Rate = rate;
    }

    // Phương thức tính tiền lãi dựa trên số dư và lãi suất
    public double GetInterest()
    {
        return Balance * Rate;
    }
};

public class CheckAccount : Account
{
    private double FeeTransfer; // Phí giao dịch

    // Constructor khởi tạo với số dư ban đầu và phí giao dịch
    public CheckAccount(double initialBalance, double feeTransfer) : base(initialBalance)
    {
        FeeTransfer = feeTransfer;
    }

    // Phương thức gửi tiền với trừ phí giao dịch
    public new void Deposit(double money)
    {
        if (money > 0)
        {
            Balance += money - FeeTransfer;
            Console.WriteLine("Đã gửi: " + money + " VND, trừ phí: " + FeeTransfer + " VND");
        }
        else
        {
            Console.WriteLine("Số tiền gửi không hợp lệ.");
        }
    }

    // Phương thức rút tiền với trừ phí giao dịch
    public new void Withdraw(double money)
    {
        if (money > 0 && money + FeeTransfer <= Balance)
        {
            Balance -= (money + FeeTransfer);
            Console.WriteLine("Đã rút: " + money + " VND, trừ phí: " + FeeTransfer + " VND");
        }
        else
        {
            Console.WriteLine("Số tiền rút không hợp lệ.");
        }
    }

    // Phương thức lấy số dư tài khoản
    public new double GetBalance()
    {
        return Balance;
    }
};

class Program
{   
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Kiểm tra lớp Account
        Account acc = new Account(1000000); // Tạo tài khoản với 1 triệu VND
        acc.Deposit(500000); // Gửi thêm 500 nghìn VND
        acc.Withdraw(200000); // Rút 200 nghìn VND
        Console.WriteLine("Số dư tài khoản: " + acc.GetBalance() + " VND");

        // Kiểm tra lớp SavingAccount
        SavingAccount savingAcc = new SavingAccount(1000000, 0.05); // 5% lãi suất
        Console.WriteLine("Tiền lãi: " + savingAcc.GetInterest() + " VND");

        // Kiểm tra lớp CheckAccount
        CheckAccount checkAcc = new CheckAccount(1000000, 10000); // Phí giao dịch 10 nghìn VND
        checkAcc.Deposit(500000); // Gửi thêm 500 nghìn VND
        checkAcc.Withdraw(200000); // Rút 200 nghìn VND
        Console.WriteLine("Số dư tài khoản sau phí: " + checkAcc.GetBalance() + " VND");
    }
}




