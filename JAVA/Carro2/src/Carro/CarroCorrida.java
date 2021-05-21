package Carro;

public class CarroCorrida extends Carro{

	public CarroCorrida(int velocidadeInicial) {
		super(velocidadeInicial);
		// TODO Auto-generated constructor stub
	}
	public void acelera(){
		setVelocidade(getVelocidade() + 5);
	}

	Carro x = new CarroCorrida(1);
	
}


