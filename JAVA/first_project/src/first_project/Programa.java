package first_project;

public class Programa {
	public static void main(String[] args){
		Conta minhaConta;
		minhaConta = new Conta();
		
		minhaConta.titular = "Wellington";
		minhaConta.saldo = 1000.00;
		
		System.out.println("Saldo atual: " + minhaConta.saldo);
	}
}
