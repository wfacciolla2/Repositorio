package Escola;

import java.sql.Date;

public class Funcionario extends Pessoa{

	
	double salario;
	Date admissao;
	String cargo;
	
	public double getGastos(){
		return this.salario;
	}
	
	public String getInfo(){
		return "nome: " + this.nome + " com sal?rio: " + this.salario;
	}
	
	public Funcionario(String nome, String CPF, int nasc) {
		super(nome, CPF, nasc);
		
		
	}

	public double getSalario() {
		return salario;
	}

	public void setSalario(double salario) {
		this.salario = salario;
	}

}
