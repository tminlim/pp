
public class InterestManager {

	public double getInterestRate(int day){
		if(day > 0 && day <=90){
			return 0.005;
		}else if(day >=91 && day <= 180){
			return 0.01;
		}else if(day >=181 && day <=364){
			return 0.02;
		}else if(day >=365){
			return 0.056;
		}		
		
		
		return 0;
	}
	public static void main(String[] args) {

	}

}
