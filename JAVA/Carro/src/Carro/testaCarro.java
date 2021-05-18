package Carro;

public class testaCarro {

	public static void main(String[] args) {
		// testando as funcionabilidades do carro
		
		Carro meuCarro;
		meuCarro = new Carro();
		meuCarro.cor = "Verde";
		meuCarro.modelo = "Fusca";
		meuCarro.velocidadeAtual = 0;
		meuCarro.velocidadeMaxima = 80;
		
		//liga o carro
		meuCarro.liga();
		//acelera o carro
		meuCarro.acelera(20);
		System.out.println(meuCarro.velocidadeAtual);
		

	}

}
