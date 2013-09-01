package hw5;

public class Rectangle {
	MyPoint leftTop;
	MyPoint rightBottom;

	Rectangle() {
		leftTop = new MyPoint(0, 0);
		rightBottom = new MyPoint(0, 0);
	}

	Rectangle(MyPoint a, float width, float height) {
		leftTop = a;
		rightBottom = new MyPoint(a.getX() + width, a.getY() + height);
	}

	void setPoint() {

		leftTop.setX(4.5f);
		leftTop.setY(10.5f);
		rightBottom.setX(15);
		rightBottom.setY(3.5f);
	}

	void printRect() {
		System.out.println(leftTop.getX() + ", " + leftTop.getY());
		System.out.println(rightBottom.getX() + ", " + leftTop.getY());
		System.out.println(rightBottom.getX() + ", " + rightBottom.getY());
		System.out.println(leftTop.getX() + ", " + rightBottom.getY());
	}

	void printArea() {
		float width = rightBottom.getX() - leftTop.getX();
		float height = leftTop.getY() - rightBottom.getY();
		float area = width * height;
		System.out.println(area);
	}

	public void printCenter() {
		System.out.println("x : " + (leftTop.getX() + rightBottom.getX()) / 2
				+ ",  y : " + (leftTop.getY() + rightBottom.getY()) / 2);
	}
	
	

	public static void main(String[] args) {
		Rectangle rect = new Rectangle();
		rect.setPoint();
		rect.printArea();
		rect.printRect();
		rect.printCenter();
		
		
		
		
	}

}
