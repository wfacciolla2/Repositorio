package first_project;

public class TestaDuasContas {

	public static void main(String[] args) {
		// Testando mais de uma conta
		
		Conta minhaConta;
		minhaConta = new Conta();
		minhaConta.saldo = 1000;
		
		Conta meuSonho;
		meuSonho = new Conta();
		meuSonho.saldo = 150000.00;
		
		System.out.println(minhaConta.saldo);
		System.out.println(meuSonho.saldo);
	}

}
