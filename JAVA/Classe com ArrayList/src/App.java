import java.util.ArrayList;

import jdk.javadoc.internal.doclets.formats.html.SourceToHTMLConverter;

public class App {
    public static void main(String[] args) throws Exception {
        ArrayList<Integer> x = new ArrayList();

        int i;

        for(i = 0; i<10; i++){
            x.add(i);
        }

        mostrar(x);
        x.remove(1);
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
}
