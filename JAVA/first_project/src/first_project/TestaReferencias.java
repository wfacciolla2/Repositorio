package first_project;

public class TestaReferencias {

	public static void main(String[] args) {
		// Aprendendo a trabalhar com referencias
		
		Conta c1 = new Conta();
		c1.titular = "Jo?o Felipe";
		c1.saldo = 227;
		
		Conta c2 = new Conta();
		c2.titular = "Wellington";
		c2.saldo = 325;
		
		c1.transferePara(c2, 228);
		
		System.out.println(c1.titular + " saldo: " + c1.saldo);
		System.out.println(c2.titular + " saldo: " + c2.saldo);
		
	}

}
