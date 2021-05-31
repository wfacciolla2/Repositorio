/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package details;

/**
 *
 * @author julio
 */
import java.util.TreeMap;
import java.util.Set;
import java.util.Iterator;
import java.util.Map;

public class Details {

   public static void main(String args[]) {

      //Declaração do TreeMap
      TreeMap<Integer, String> tmap;
      tmap = new TreeMap<Integer, String>();

      //Adiciona elementos
      tmap.put(1, "UNIVESP");
      tmap.put(7, "USP");
      tmap.put(6, "UNICAMP");
      tmap.put(4, "UNESP");
      tmap.put(5, "UFMG");

      // Mostra o conteúdo usando o Iterator
      Set set = tmap.entrySet();
      Iterator iterator = set.iterator();
      while(iterator.hasNext()) {
         Map.Entry mentry = (Map.Entry)iterator.next();
         System.out.print("A chave é: "+ mentry.getKey() + " & O valor é: ");
         System.out.println(mentry.getValue());
      }

   }
}