package ArrayList;

import java.util.EmptyStackException;
import java.util.Stack;

public class RawType extends Stack2 {

	public static void main(String[] args) {
		// working rawTypes
		Double [] doubleElements = {1.1,2.2,3.3,4.4,5.5};
		Integer [] integerElements = {1,2,3,4,5,6,7,8,9,10};
		
		//Pilha de tipos brutos atribuidos a classe Stack
		Stack<Double> rawTypeStack1 = new Stack<Double>();
		
		//Stack<Double> atribuido a Stack de tipos brutos
		Stack<Double> rawTypeStack2 = new Stack<Double>();
		
		//Pilha de tipos crus atribuidos a variavel Stack<Integer>
		Stack<Integer>integerStack = new Stack<Integer>();
		
		testPush("rawTypeStack1", rawTypeStack1, doubleElements);
		testPop("rawTypeStack1", rawTypeStack1);
		testPush("rawTypeStack2", rawTypeStack2, doubleElements);
		testPop("rawTypeStack2", rawTypeStack2);
		testPush("integerStack", integerStack, integerElements);
		testPop("integerStack",integerStack);
		
		//metodo genérico, insere elementos na pilha
		public static <T> void testPush(String name,Stack<T>stack,T[] elements){
			System.out.printf("Pushing elements onto", name);
			for (T element : elements){
				System.out.printf("%s", element);
				stack.push(element);
			}
		}
		
		//metodo genérico, temove elementos da pilha
		public static<T>void testPop(String name, Stack<T>stack){
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

}
