class Account {

    private int id = 0;
    private double balance = 0;
    private double annualInterestRate = 0;
    private DateTime dateCreated;
    private int v1;
    private int v2;

    public Account() {
    }

    public Account(int id, double balance) {
        dateCreated = DateTime.Today;
        this.id = id;
        this.balance = balance;
    }

 

    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }

    public double getBalance() {
        return balance;
    }
    public void setBalance(double balance) {
        this.balance = balance;
    }

    public double getRate() {
        return annualInterestRate;
    }
    public void setRate(double annualInterestRate) {
        this.annualInterestRate = annualInterestRate;
    }

    public DateTime getDateCreated() {
        return dateCreated;
    }


}