package ArrayList;
import java.util.*;

@SuppressWarnings("unused")
public class Stack1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		class Stack<   T>{
			private ArrayList<T>  elements; // Armazena os elementos da pilha
			
			// construtor sem argumento, cria uma pilha tamanho padrao
			public Stack(){
				this(10); // tamanho padrao da pilha
			}
			
			public Stack(int capacity){
				int initCapacity = capacity > 0 ?        capacity : 10; // valida
				elements = new ArrayList<T>(initCapacity); //Cria a Array
			}
			
			//insere elementos na pilha
			public void push(T pushValue){
				elements.add(pushValue);// insere pushValue na Stack
			}
			
			public T pop(){
				if (elements.isEmpty())//se a pilha estiver vazia
					throw new EmptyStackException();
				return elements.remove(elements.size()-1);
			}
		}
	}

}
