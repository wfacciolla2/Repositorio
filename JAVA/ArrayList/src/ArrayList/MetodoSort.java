package ArrayList;

import java.util.Arrays;
import java.util.List;
import java.util.Collections;

public class MetodoSort {

	public class Sort1{
		private final String suits[] = {"Hearts","Diamonds","Clubs","Spades"};
		//exibe elementos do array
		public void printElements(){
			List<String> list = Arrays.asList(suits);
					System.out.printf("Unsorted array elements:\n%s\n", list);
		//Classifica os elementos do array
			Collections.sort(list);
			System.out.printf("Sorted array elements:\n%s\n", list);
		}
}
}