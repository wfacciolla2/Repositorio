package Comissao;

// Classe ComissionEmployee representa um funcionario que recebeu uma porcentagem das vendas brutas
public class ComissionEmployee extends Object {
	protected String firstName;
	protected String lastName;
	protected String socialSecurityNumber;
	protected double grossSales; //vendas brutas semanais
	protected double commissionRate; // porcentagemd e comissao
	
	
	//construtor de argumentos
	public void CommissionEmployee (String first, String last, String ssn, double sales, double rate){
		firstName = first;
		lastName = last;
		socialSecurityNumber = ssn;
		setGrossSales(sales);
		setCommissionRate(rate);
		}
	

	public void setFirstName (String first){
		firstName = first;
	}
	
	public String getFirstName(){
		return firstName;
	}
	
	public void setLastName(String last){
		lastName = last;
	}
	
	public String getLastName(){
		return lastName;
	}
	
	public void setSocialSecurityNumber (String ssn){
		socialSecurityNumber = ssn;
	}
	
	public String getSocialSecurityNumber(){
		return socialSecurityNumber;
	}
	
	public void setGrossSales (double sales){
		grossSales = (sales < 0.0) ? 0.0 : sales;
	}
	
	public double getGrossSales(){
		return grossSales;
	}
	
	public void setCommissionRate(double rate){
		commissionRate = (rate > 0.0) ? rate : 0.0;
	}
	
	public double getCommisionRate(){
		return commissionRate;
	}
	// calculando lucros
	
	public double earnings(){
		return commissionRate * grossSales;
	}
	
	@Override //sobrescreve a superclasse
	public String toString(){
		return String.format("%s: %s %s\n%s: %s\n%s: %.2f\n%s: %.2f",
				"commission employee", firstName, lastName,
				"social security number", socialSecurityNumber,
				"gross salaes", grossSales,
				"commission rate", commissionRate);
	}
}
