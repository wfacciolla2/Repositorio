package first_project;

import java.util.HashSet;
import java.util.LinkedHashSet;
import java.util.Set;
import java.util.TreeSet;


public class EstruturaDeDados extends funcionarios {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Set<funcionario> funcionarios = new LinkedHashSet<>();
		funcionarios.add(new funcionario(codigo 1, nome "Ester");
		funcionarios.add("Wellington");
		funcionarios.add("João");
		funcionarios.add("Isabel");
		
		System.out.println(funcionarios);
		System.out.println(funcionarios.size());
	}

}