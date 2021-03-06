package banco2;
import java.util.Scanner;


public class AccountTest {

	public static void main(String[] args) {
		
		Account account1 = new Account("Wellington Facciolla", 50.00);
		Account account2 = new Account("Joao Felipe", -50.00);
		
		//exibe saldo inicial de cada objeto
		System.out.println(account1.getName() + " R$" + account1.getBalance());
		System.out.println(account2.getName() + " R$" + account2.getBalance());
		
		// cria um objeto Scanner para obter entrada a partir da janela de comando
		Scanner input = new Scanner(System.in);
		
		System.out.print("Enter deposit amount for account1: ");
		double depositAmount = input.nextDouble();
		System.out.println("sending to account1 balance: " + depositAmount);
		account1.deposit(depositAmount);
		
		System.out.print("Enter deposit amount for account2: ");
		depositAmount = input.nextDouble();
		System.out.println("sending to account2 balance" + depositAmount);
		account2.deposit(depositAmount);
		
		// cria um objeto Account e atribui a Myaccount
		Account myAccount = new Account(null, 0);
		//exive o valor inicial do nome (null)
		System.out.println(myAccount.getName());
		//Solicita e l? o nome
		//System.out.println("Please enter the name: ");
		String theName = input.nextLine();
		myAccount.setName(theName);
		//System.out.println();
		//exibe o nome armazenado no objeto myAccount
		System.out.println(myAccount.getName());
		
		System.out.println(account1.getName() + " " + account1.getBalance());
		System.out.println(account2.getName() + " " + account2.getBalance());
		
		
	}

}
