package pacoteAves;

public abstract class Ave {
	private String especie;
	private String bico;
	private int sexo;
	
	public static final int MACHO = 0, FEMEA = 1;
	
	public Ave(String especie, String bico, int sexo){
		this.setEspecie(especie);
		this.setBico(bico);
		this.setSexo(sexo);
	}

	public String getEspecie() {
		return especie;
	}

	public void setEspecie(String especie) {
		this.especie = especie;
	}

	public String getBico() {
		return bico;
	}

	public void setBico(String bico) {
		this.bico = bico;
	}

	public int getSexo() {
		return sexo;
	}

	public void setSexo(int sexo) {
		this.sexo = sexo;
	}
	
	public void porOvos(){
		if(sexo == FEMEA){
			System.out.println("A ave pôs um ovo");
		}else{
			System.out.println("Machos não poêm ovos");
		}
	}

	public void nadar() {
		
		
	}

	public void voar() {
		// TODO Auto-generated method stub
		
	}
	
}
