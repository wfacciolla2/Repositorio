/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package testehashtable;

import java.util.Hashtable;

public class TesteHashTable {

  public static void main(String[] args) {

    Cliente c1 = new Cliente("715.156.861-81","Jose");
    Cliente c2 = new Cliente("821.229.322.21","Clara");
    Cliente c3 = new Cliente("151.565.536-68","Milton");

    Hashtable<Integer, Cliente=""> ht = new Hashtable<Integer, Cliente="">();
    ht.put(1, c1);
    ht.put(2, c2);
    ht.put(3, c3);

    System.out.println("CPF \t\t Cliente");
    for (int i = 1; i <= ht.size(); i++) {
      System.out.println(ht.get(i));
    }
  }
}

class Cliente{
  public String cpf;
  public String nome;

  public Cliente(String cpf, String nome) {
    this.cpf = cpf;
    this.nome = nome;
  }

  @Override
  public String toString() {
    return cpf + " | " + nome;
  }
}
