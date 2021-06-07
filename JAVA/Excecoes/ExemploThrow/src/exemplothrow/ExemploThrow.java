/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exemplothrow;

import java.io.IOException;

/**
 *
 * @author julio
 */
class TesteThrow { 
  void meuMetodo(int num)throws IOException, ClassNotFoundException{ 
     if(num==1)
        throw new IOException("Ocorreu IOException!");
     else
        throw new ClassNotFoundException("ClassNotFoundException");
  } 
} 

public class ExemploThrow{ 
  public static void main(String args[]){ 
   try{ 
     TesteThrow obj=new TesteThrow(); 
     obj.meuMetodo(1); 
   }catch(Exception ex){
     System.out.println(ex);
    } 
  }
}
