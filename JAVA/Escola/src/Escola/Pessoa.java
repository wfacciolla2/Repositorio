package Escola;


public class Pessoa {

		// Super Classe
		public String nome;
		public String CPF;
		public int nasc;
		public double salario;
		
		public String getInfo(){
			return "nome: " + this.nome + " com sal�rio: " + this.salario;
		}
		
		public Pessoa(String nome, String CPF, int nasc){
			this.nome = nome;
			this.CPF = CPF;
			this.nasc = nasc;
		}
}


