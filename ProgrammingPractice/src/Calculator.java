public class Calculator {

	public static void main(String[] args) {
		System.out.println(subtract(20, 10));
		System.out.println(multiply(20, 10));
		System.out.println(divide(20, 10)); 
		System.out.println(remainder(25, 10));
		System.out.println(square(3));
	}

	private static int square(int i) {
		int answer;
		answer = i * i;
		return answer;
	}

	private static int divide(int i, int j) {
		int answer;
		answer = i / j;
		return answer;
	}

	private static int remainder(int i, int j) {
		int answer;
		answer = i % j;
		return answer;
	}

	private static int multiply(int i, int j) {
		int answer;
		answer = i * j;
		return answer;
	}

	private static int subtract(int i, int j) {
		int answer;
		answer = i - j;
		return answer;
	}

}
