package first_project;

public class Conta {
	int numero;
	String titular;
	double saldo;
	double salario;
	
	//void saca(double quantidade){
	//	double novoSaldo = this.saldo - quantidade;
	//	this.saldo = novoSaldo;
	//}
	
	//devolve um valor booleano indicando se a opera��o foi bem sucedida.
	
	boolean saca(double valor){
		if(this.saldo < valor){
			return false;
		}
		else{
			this.saldo = this.saldo - valor;
			return true;
		}
	}
	
	boolean transferePara(Conta destino, double valor){
		boolean retirou = this.saca(valor);
			if(retirou == false){
				return false;
			} else {
				destino.deposita(valor);
				return true;
			}
		
	}
	
	void deposita(double quantidade){
		this.saldo += quantidade;
	}
	
}
