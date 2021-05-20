package pacoteAves;

import java.util.ArrayList;

public class TestaAves {

	public static void main(String[] args) {
		ArrayList<Ave> aves = new ArrayList<Ave>();
		aves.add(new Pinguim("Pinguim real", "Filtrador", Ave.FEMEA));
		aves.add(new Pinguim("Pinguim do mato", "Longo", Ave.MACHO));
		aves.add(new Pato("Pato real", "Filtrador", Ave.FEMEA));
		
		for(Ave aveAtual : aves){
			System.out.println("Espécie: " + aveAtual.getEspecie());
			if(aveAtual instanceof Pato){
				System.out.println("Voar: ");
				((Pato)aveAtual).voar();
				System.out.println("Nadar: ");
				((Pato)aveAtual).nadar();
			}else if(aveAtual instanceof Pinguim){
				System.out.println("Nadar: ");
				((Pinguim)aveAtual).nadar();
			}
			System.out.println("Bico: " + aveAtual.getBico());
			System.out.println("Por ovos: ");
			aveAtual.porOvos();
			System.out.println();
			
		}
	}

}
