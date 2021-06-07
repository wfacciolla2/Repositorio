/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exemploexcept3;

/**
 *
 * @author julio
 */
public class ExemploExcept3 {
   public static void main(String args[]) {
      int result, num1, num2;
      try {
         /* Suspeitamos que este bloco de declarações pode lançar exceção, 
         então tratamos disso colocando essas instruçõesdentro de try e manipulamos a exceção no bloco catch */
         num1 = 0;
         num2 = 25;
         result = num2/num1;
         System.out.println(result);
         System.out.println("Estou no bloco try");
      }
      catch (ArithmeticException e) { 
         /* Somente vai executar se ocorrer Arithmetic exception 
          * no bloco try
          */
         System.out.println("Divisão por zero não permitida!");
      }
      System.out.println("Fora do bloco try/catch");
   }
}
