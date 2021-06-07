/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exemploexcept4;

/**
 *
 * @author julio
 */
public class ExemploExcept4 {
   public static void main(String args[]){
     try{
         int[] a = new int[4];
         //a[4] = 30/0;
         a[5] = 31;
         System.out.println("Primeira declaração impressa no bloco try");
     }
     catch(ArithmeticException e){
        System.out.println("Aviso: ArithmeticException");
     }
     catch(ArrayIndexOutOfBoundsException e){
        System.out.println("Aviso: ArrayIndexOutOfBoundsException");
     }
     catch(Exception e){
        System.out.println("Aviso: Outro tipo de exception");
     }
   System.out.println("Fora do bloco try-catch...");
  }
}  