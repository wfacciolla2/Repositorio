package principal;

public class UmEmUm implements interfaceTeste {
	// incremento de 1 em 1
	int valor;
	//metodo construtor
	UmEmUm(){
		valor = 0;
	}
	
	public int proximo() {
		valor += 1;
		return valor;
	}

}
