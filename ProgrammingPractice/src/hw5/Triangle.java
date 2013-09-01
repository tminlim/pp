package hw5;

public class Triangle {
	MyPoint pointA, pointB, pointC;

	public Triangle() {
		pointA = new MyPoint();
		pointB = new MyPoint();
		pointC = new MyPoint();
		pointA.setPoint(0, 0);
		pointB.setPoint(0, 0);
		pointC.setPoint(0, 0);
	}

	public void setPointA(MyPoint a) {
		pointA = a;
	}

	public void setPointB(MyPoint a) {
		pointB = a;
	}

	public void setPointC(MyPoint a) {
		pointC = a;
	}

	void printTriangle() {
		System.out.printf("pointA=(%2.1f,%2.1f)\n", pointA.getX(), pointA.getY());
		System.out.printf("pointB=(%2.1f,%2.1f)\n", pointB.getX(), pointB.getY());
		System.out.printf("pointC=(%2.1f,%2.1f)\n", pointC.getX(), pointC.getY());
	}

	public static void main(String[] args) {
		MyPoint a = new MyPoint(4.5f, 3.5f); 
		MyPoint b = new MyPoint(15f, 3.5f);
		MyPoint c = new MyPoint(10f,9.5f);
		Triangle triPoint = new Triangle();
		triPoint.setPointA(a);
		triPoint.setPointB(b);
		triPoint.setPointC(c);
		triPoint.printTriangle();
}

}
