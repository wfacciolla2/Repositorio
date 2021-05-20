package pacoteAves;

import pacoteInterface.AnimalNadador;
import pacoteInterface.AnimalVoador;

public class Pato extends Ave implements AnimalNadador, AnimalVoador{

	public Pato(String especie, String bico, int sexo) {
		super(especie, bico, sexo);
	}
	
	@Override
	public void nadar(){
		System.out.println("Nada com as pernas");
	}
	
	@Override
	public void voar(){
		System.out.println("Bate as asas e voa");
	}
	
}
