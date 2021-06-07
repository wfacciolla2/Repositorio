/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exemploexcept2;

/**
 *
 * @author julio
 */
public class ExemploExcept2 {

   public static void main(String args[])
   {
	int num1=10;
	int num2=0;
	/* Divisão por zero - Exceção será lançada */
	int res=num1/num2;
	System.out.println(res);
   }
}
