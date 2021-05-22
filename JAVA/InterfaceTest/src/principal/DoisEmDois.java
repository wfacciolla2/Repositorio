package principal;

public class DoisEmDois implements interfaceTeste {
	// incremento de 2 em 2
	int valor;
	//metodo construtor
	DoisEmDois(){
		valor = 0;
	}
	
	public int proximo() {
		valor += 2;
		return valor;
	}

}
