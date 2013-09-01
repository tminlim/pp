package hw5;

public class MyPoint {
	float myX, myY;

	public MyPoint() {
		myX = 9.75f;
		myY = 7f;
	}

	public MyPoint(float x, float y) {
		myX = x;
		myY = y;
	}

	public void setPoint(float f, float g) {
		myX = f;
		myY = g;
	}

	void printPoint() {
		System.out.println(myX + "," + myY);
	}

	public void setX(float x) {
		myX = x;
	}

	public void setY(float y) {
		myY = y;
	}

	public float getX() {
		return myX;
	}

	public float getY() {
		return myY;
	}

	public double getDistanceTo(MyPoint toPoint) {
		double distance;
		distance = Math.sqrt((Math.pow(getX() - toPoint.getX(), 2) + Math.pow(
				getY() - toPoint.getY(), 2)));
		return distance;

	}
//
//	public static void main(String[] args) {
//		MyPoint point = new MyPoint();
//		point.setPoint(2.5f, 15.8f);
//		point.printPoint();
//		point.setX(15.2f);
//		point.setY(7.4f);
//		point.printPoint();
//
//		System.out
//				.printf("pointA=(%2.1f, %2.1f)\n", point.getX(), point.getY());
//
//	}

}
