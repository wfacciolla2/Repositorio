package ArrayList;
import java.util.*;


public class Stack2 {

	public static void main(String[] args) {
		// Passando objetos Stack genéricos para métodos genéricos
		Double [] doubleElements = { 1.1,        2.2,3.3,4.4,5.5};
		@SuppressWarnings("unused")
		Integer [] integerElements = {1,2,3,4,5,6,7,8};
		
		Stack<Double> doubleStack = new Stack<Double>();
		Stack<Integer>integerStack = new Stack<Integer>();
		
		testPush("doubleStack", doubleStack, doubleElements);
		testPop("doubleStack", doubleStack);
		
		testPush("integerStack", doubleStack, doubleElements);
		testPop("integerStack", integerStack);
	}
	
	public static<T> void testPush(String name, Stack<T>stack,T[]elements){
		System.out.printf("Pushing elements onto %s", name);
		
		//insere elementos na Stack
		for(T element : elements){
			System.out.printf("%s", element);
			} //fim do metodo for
}// fim do metodo testPush
	
	public static <T> void testPop(String name, Stack<T>stack){
		try{
			System.out.printf("Popping elements from %s", name);
			T popValue;
			while(true){
				popValue = stack.pop();
				System.out.printf("%s", popValue);
				}
		}
		catch(EmptyStackException emptyStackException){
			System.out.println();
			emptyStackException.printStackTrace();
		}
	}

}





