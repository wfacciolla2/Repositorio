/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package mapexample;

/**
 *
 * @author julio
 */
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Set;
 
public class MapExample {
 
    public static void main(String[] args) {
 
        Map<Object,String> mp=new HashMap<Object, String>();
 
        // adicionar ou define elementos no mapa com o métod put (chave e valor)
        mp.put(new Integer(2), "Dois");
        mp.put(new Integer(1), "Um");
        mp.put(new Integer(3), "Três");
        mp.put(new Integer(4), "Quatro");
 
        // Utiliza a interface Map em Set para obter a chave e o valor
        Set s=mp.entrySet();
 
        // Move a próxima chave e valor no mapa utilizando o iterador
        Iterator it=s.iterator();
 
        while(it.hasNext())
        {
            // obter chave e valor com o Map.Entry
            Map.Entry m =(Map.Entry)it.next();
 
            // getKey é utilizado para obter a chave do mapa
            int key=(Integer)m.getKey();
 
            // getValue é utilizado para obter o valor do mapa
            String value=(String)m.getValue();
 
            System.out.println("Chave :"+key+"  Valor :"+value);
        }
    }
}
