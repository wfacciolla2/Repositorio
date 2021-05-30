public class GenericosTipo<T> {

	private T t;
	
	public T get(){
		return this.t;
	}
	
	public void set(T t1){
		this.t=t1;
	}
	
	public static void main(String args[]){
		GenericosTipo<String> tipo = new GenericosTipo<>();
		tipo.set("Teste"); 
		
		GenericosTipo tipo1 = new GenericosTipo(); 
		tipo1.set("Teste1"); 
		tipo1.set(10); 
	}
}
