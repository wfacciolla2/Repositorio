package banco2;

public class Account {

	private String name;
	public String getName;
	private double balance;
	
	public Account(String name, double balance){
		this.name = name;
		
		if(balance > 0.0)
			this.balance = balance;
	}
	
	public void deposit(double depositAmount){
		if(depositAmount > 0.0)
			balance = balance + depositAmount;
	}
	
	public void setName(String name){
		this.name = name;
	}
	public String getName() {
		return name;
	}

	public double getBalance() {
		return balance;
	}

	public void setBalance(double balance) {
		this.balance = balance;
	}

}
