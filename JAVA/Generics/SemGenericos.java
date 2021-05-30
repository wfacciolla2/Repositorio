public class SemGenericos {

	private Object t;

	public Object get() {
		return t;
	}

	public void set(Object t) {
		this.t = t;
	}

        public static void main(String args[]){
		SemGenericos type = new SemGenericos();
		type.set("Teste"); 
		String str = type.get(); 
	}
}
