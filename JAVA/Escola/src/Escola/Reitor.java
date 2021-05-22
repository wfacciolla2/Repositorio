package Escola;

public class Reitor extends Pessoa{
	public Reitor(String nome, String CPF, int nasc) {
		super(nome, CPF, nasc);
	}

	public String getinfo(){
		return super.getInfo() + "e ele é um reitor";
	}

}
