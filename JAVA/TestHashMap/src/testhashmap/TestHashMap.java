/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package testhashmap;

/**
 *
 * @author julio
 */
import java.util.HashMap;
import java.util.Map;
import java.util.Iterator;
import java.util.Set;

public class TestHashMap {

   public static void main(String args[]) {

      //Declaração do HashMap 
      HashMap<Integer, String> hm = new HashMap<Integer, String>();

      // Adição de elementos
      hm.put(1, "UNIVESP");
      hm.put(2, "USP");
      hm.put(7, "UNICAMP");
      hm.put(9, "UNESP");
      hm.put(3, "UFMG");

      // Mostra o conteúdo, usando o Iterator
      Set set = hm.entrySet();
      Iterator iterator = set.iterator();
      while(iterator.hasNext()) {
         Map.Entry mentry = (Map.Entry)iterator.next();
         System.out.print("A chave é: "+ mentry.getKey() + " & o Valor é: ");
         System.out.println(mentry.getValue());
      }

      // Obtém valores basedo na chave
      String var= hm.get(2);
      System.out.println("Valor no indice 2 é: "+var);

      // Remove valor baseado na chave
      hm.remove(3);
      System.out.println("Chave e valor do mapa após remoção:");
      Set set2 = hm.entrySet();
      Iterator iterator2 = set2.iterator();
      while(iterator2.hasNext()) {
          Map.Entry mentry2 = (Map.Entry)iterator2.next();
          System.out.print("A chave é: "+mentry2.getKey() + " & O valor é: ");
          System.out.println(mentry2.getValue());
       }
   }
}
