package Escola;

import java.sql.Date;

public class Funcionario extends Pessoa{

	
	double salario;
	Date admissao;
	String cargo;
	
	public Funcionario(String nome, String CPF, int nasc) {
		super(nome, CPF, nasc);
		
		
		// TODO Auto-generated constructor stub
	}

	public double getSalario() {
		return salario;
	}

	public void setSalario(double salario) {
		this.salario = salario;
	}

}
