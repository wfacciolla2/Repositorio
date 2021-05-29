package ArrayList;

import java.util.ArrayList;
import java.util.List;

import ArrayList.MetodoSort.Sort1;

public class lista {

	public static void main(String[] args) {
		List<String> myList = new ArrayList<String>();
		myList.add("Wellington");
		myList.add("Ester");
		for(String listElements : myList){
			System.out.println(listElements);
		
			
			Sort1 sort1 = new Sort1();
			sort1.printElements();
		}
		


	}

}
