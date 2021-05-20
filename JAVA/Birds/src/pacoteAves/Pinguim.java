package pacoteAves;

import pacoteInterface.AnimalNadador;

public class Pinguim extends Ave implements AnimalNadador{

	public Pinguim(String especie, String bico, int sexo) {
		super(especie, bico, sexo);
			}
	
	@Override
	public void nadar(){
		System.out.println("Mergulha na água e nada com auxilio de asas e pernas");
	}
}
