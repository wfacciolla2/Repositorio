/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hashtableexample;

/**
 *
 * @author julio
 */
import java.util.Hashtable;
import java.util.Enumeration;

public class HashtableExample {
 
 public static void main(String[] args) {
 
   Enumeration names;
   String key;
 
   // Cria a Tabela Hash
   Hashtable<String, String> hashtable = new Hashtable<String, String>();
 
   // Adiciona o par chave/valor na Tabela Hash
   hashtable.put("Chave1","UNIVESP");
   hashtable.put("Chave2","USP");
   hashtable.put("Chave3","UNICAMP");
   hashtable.put("Chave4","UNESP");
 
   names = hashtable.keys();
   while(names.hasMoreElements()) {
      key = (String) names.nextElement();
      System.out.println("Chave: " +key+ " & Valor: " +
      hashtable.get(key));
   }
 }
}
