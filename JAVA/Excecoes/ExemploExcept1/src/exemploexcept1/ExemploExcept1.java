/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exemploexcept1;

import java.io.*;

/**
 *
 * @author julio
 */
public class ExemploExcept1 {

   public static void main(String args[]) 
   {
	FileInputStream fis = null;
        fis = new FileInputStream("C:/meuarquivo.txt"); 
	int k; 

	while(( k = fis.read() ) != -1) 
	{ 
		System.out.print((char)k); 
	} 

	fis.close(); 	
   }
}
