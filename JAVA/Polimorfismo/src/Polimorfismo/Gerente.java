package Polimorfismo;

public class Gerente extends Funcionario {
	    private int senha;
	    private int numeroDeFuncionariosGerenciados;
	    
	    @Override
	    public double getBonificacao(){
	    	return super.getBonificacao() + 1000;
	    }
	    
	    public boolean autentica(int senha) {
	        if (this.senha == senha) {
	            System.out.println("Acesso Permitido!");
	            return true;
	        } else {
	            System.out.println("Acesso Negado!");
	            return false;
	        }
	    }

		public void setNome(String string) {
			// TODO Auto-generated method stub
			
		}

		public void setSenha(int i) {
			// TODO Auto-generated method stub
			
		}

		public int getNumeroDeFuncionariosGerenciados() {
			return numeroDeFuncionariosGerenciados;
		}

		public void setNumeroDeFuncionariosGerenciados(
				int numeroDeFuncionariosGerenciados) {
			this.numeroDeFuncionariosGerenciados = numeroDeFuncionariosGerenciados;
		}
 
}
