
public class PrintLoop {

	public static void main(String[] args) {
		PrintLoop pl = new PrintLoop();
		pl.printLoop5();
		
	}
	
	
	void printLoop1(){
		for(int i =0; i<5; i++){
			for(int j = 0; j <= i ; j++){
				System.out.print("*");
			}
			System.out.println();
		}
	}
	
	void printLoop2(){
		for(int i =1; i<6; i++){
			for(int j = 1; j <= i ; j++){
				System.out.print(j);
			}
			System.out.println();
		}
	}
	void printLoop3() {
		double z = 1.0;
		for (int i = 1; i <= 5; i++) {
			for (int j = 1; j <= i; j++) {
				System.out.printf("%2.0f ", z);
				z++;
			}
			System.out.println();
		}
	}

	void printLoop4() {
		for (int i = 1; i <= 5; i++) {
			for (int loop = 5 - i; loop > 0; loop--) {
				System.out.print(" ");
			}
			for (int j = 1; j <= i; j++) {
				System.out.print("*");
			}
			System.out.println();
		}
	}
	
	
	
	void printLoop5() {
		int max = 11;
		int variable= (max/2);
		
		for (int i = 1; i <= variable; i++) {
			for (int j = variable - i; j > 0; j--) {
				System.out.print(" ");
			}
			for (int k = 2 * i - 1; k > 0; k--) {
				System.out.print("*");
			}
			System.out.println();
		}
		for(int loop = 1; loop <= variable;loop++){
			for (int j = 1; j <= loop; j++) {
				System.out.print(" ");
			}
			for (int k = -2 * loop + max; k > 0; k--) {
				System.out.print("*");
			}
			System.out.println();
		}
	}
}




