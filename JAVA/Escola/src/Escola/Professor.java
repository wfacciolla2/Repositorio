package Escola;


public class Professor extends Pessoa{

	private int horasDeAula;
	double salario;
	String disciplina;
	
	public double getGasto(){
		return this.getSalario() + this.horasDeAula * 10;
	}
	
	@Override
	public String getInfo(){
		String informacaoBasica = super.getInfo();
		String informacao = informacaoBasica + "horas de aulas: " + this.horasDeAula;
		return informacao;
		
	}

	public Professor(String nome, String CPF, int nasc) {
		super(nome, CPF, nasc);
	}

	public double getSalario() {
		return salario;
	}

	public void setSalario(double salario) {
		this.salario = salario;
	}

	public String getDisciplina() {
		return disciplina;
	}

	public void setDisciplina(String disciplina) {
		this.disciplina = disciplina;
	}

}
