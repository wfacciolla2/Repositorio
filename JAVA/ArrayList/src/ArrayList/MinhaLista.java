package ArrayList;

import java.util.Arrays;

public class MinhaLista<T>{
	private Object[] elementos = new Object[0];
	public T get(int indice){
		return (T) elementos[indice];
	}
	public void adiciona(T elemento){
		int posicao = elementos.length +1;
		elementos = Arrays.copyOf(elementos,  posicao);
		elementos[posicao] = elemento;
	}
}
