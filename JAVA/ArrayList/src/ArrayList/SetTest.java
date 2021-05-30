package ArrayList;

import java.util.Collection;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

public class SetTest {

	private static final String colors[] = {"vermelho","branco","azul","verde","laranja","branco","cinza"};
	
	//cria conjuto de array para elimitar duplicatas
	private void printNonDuplicates(Collection<String>collection){
		//cria um HashSet
		Set<String>set = new HashSet<String>(collection);
		
		System.out.println("\nNonduplicates are: ");
		
		for (String s : set)
			System.out.printf("%s",s);
		
		System.out.println();

	}

	public SetTest(){
		List<String>list = Array.asList(colors);
		System.out.printf("ArrayList: %s\n", list);
		printNonDuplicates(list);
	}
	
	public static void main(String args[]){
		new SetTest();
	}
}





