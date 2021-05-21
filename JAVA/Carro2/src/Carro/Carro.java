package Carro;

public class Carro {

	
	private static int velocidade;
	public Carro(int velocidadeInicial) {
		velocidade = velocidadeInicial;
	}
	public void acelera(){
		velocidade++;
	}
	public void freia(){
		velocidade--;
	}

	public static int getVelocidade() {
		return velocidade;
	}

	public static void setVelocidade(int velocidade) {
		Carro.velocidade = velocidade;
	}
	

}
