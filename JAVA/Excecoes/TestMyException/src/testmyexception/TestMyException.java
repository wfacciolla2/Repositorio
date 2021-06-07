/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package testmyexception;

/**
 *
 * @author julio
 */
// Minha classe de exceção
class MyException extends Exception{
   String str1;

   MyException(String str2) {
	str1=str2;
   }
   @Override
   public String toString(){ 
	return ("Ocorrreu a minha exceção: "+str1) ;
   }
}

public class TestMyException{
   public static void main(String args[]){
	try{
		System.out.println("Início do bloco try...");
		// Laço minha exceção usando o comando throw
		throw new MyException("Minha mensagem de erro!");
	}
	catch(MyException exp){
		System.out.println("Bloco catch") ;
		System.out.println(exp) ;
	}
   }
}