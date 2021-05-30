package ArrayList;

import java.util.ArrayList;

public class WildcardTest {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Integer[] integers = {1,2,3,4,5};
		ArrayList<Integer>integerList = new ArrayList<Integer>();
		
		for (Integer element : integers)
			integerList.add(element);
		
		System.out.printf("IntegerList contais> %s\n", integerList);
		System.out.printf("Total of elements in intergerList: %.0f\n\n", sum(integerList));
		
		Double[] doubles = {1.1,3.3,5.5};
		
		public static double sum(ArrayList<? extends Number> list){
			double total = 0;
			for(Number element : list)
				total += element.doubleValue();
			return total;
			
		}
		
	}

}
