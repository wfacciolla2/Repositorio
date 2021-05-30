package ArrayList;

import java.util.ArrayList;
import java.util.List;


public class Array {
    public static void main(String[] args) throws Exception {
        ArrayList<Integer> 	      x = new ArrayList<Integer>();

        int i;

        for(i = 0; i<10; i++){
            x.add(i);
        }

        mostrar(x);
        mostrarII(x);
        
    }

    public static void mostrar(ArrayList<Integer> lista){
        int i, n = lista.size();

        for(i=0; i<n; i++)
        System.out.printf("%d: %d\n", i, lista.get(i));
    }

    public static void mostrarII(ArrayList<Integer> lista){
        System.out.printf("{");
            for(Integer item: lista){
            System.out.printf("%d", item);
        }
        System.out.printf("}");
    }

	public static List<String> asList(String[] colors) {
		// TODO Auto-generated method stub
		return null;
	}
}
