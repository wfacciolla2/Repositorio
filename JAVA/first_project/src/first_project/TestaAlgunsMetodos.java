package first_project;

public class TestaAlgunsMetodos {

	public static void main(String[] args) {
		
		// criando a conta
		Conta minhaConta;
		minhaConta = new Conta();
		
		
		//alterando os valores da minhaConta
		minhaConta.titular = "Joao Felipe";
		minhaConta.saldo = 1000;
		boolean consegui = minhaConta.saca(200);
				if (consegui){
					System.out.println("Consegui sacar");
				} else {
					System.out.println("N�o consegui sacar");
				}
		//========================================================================
		//saca 200 reais
		//minhaConta.saca(200);
		
		//deposita 500 reais
		//minhaConta.deposita(500);
		
		System.out.println("Saldo atual: " + minhaConta.saldo);
		
		
	}

}
