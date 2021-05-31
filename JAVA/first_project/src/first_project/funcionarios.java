package first_project;

public class funcionarios {

	private int codigo;
	private String nome;
	
	public void Funcionarios(int codigo,  String nome){
		this.codigo = codigo;
		this.nome = nome;
	}
	
	public int getCodigo(){
		return codigo;
	}
	
	public String getNome(){
		return nome;
	}
}
