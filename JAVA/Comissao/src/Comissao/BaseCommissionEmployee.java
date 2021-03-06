package Comissao;

public class BaseCommissionEmployee extends ComissionEmployee{
	
	private double baseSalary;
	
	public BaseCommissionEmployee (String first, String last, String ssn,
			double sales, double rate, double salary){
		super();
		
		setBaseSalary(salary);
		
	}
	public void setBaseSalary(double salary){
		baseSalary = (salary < 0.0) ? 0.0 : salary;
	}
	
	public double getBaseSalary(){
		return baseSalary;
	}
	
	@Override
	public double earnings(){
		return baseSalary + (commissionRate * grossSales);
	}
	
	@Override
	public String toString(){
		return String.format("%s: %s %s\n%s: %s\n%s: %.2f\n%s: %.2f\n%s: %.2f",
				"base-salaried commission employee", firstName, lastName,
				"social security number", socialSecurityNumber,
				"gross sales", grossSales,"commission rate", commissionRate,
				"base salary", baseSalary);
	}
}
