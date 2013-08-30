package hw4;
public class Rectangle {
	float leftTopX, leftTopY;
	float rightBottomX, rightBottomY;

	Rectangle() {
		leftTopX = 5;
		leftTopY = 11;
		rightBottomX = 15;
		rightBottomY = 4;
	}

	void setWeek5() {
		leftTopX = 4.5f;
		leftTopY = 10.5f;
		rightBottomX = 15;
		rightBottomY = 3.5f;
	}

	void printRect() {
		System.out.println(leftTopX + ", " + leftTopY);
		System.out.println(rightBottomX + ", " + leftTopY);
		System.out.println(rightBottomX + ", " + rightBottomY);
		System.out.println(leftTopX + ", " + rightBottomY);
	}

	void printArea() {
		float width = rightBottomX - leftTopX;
		float height = leftTopY - rightBottomY;
		float area = width * height;
		System.out.println(area);
	}
	public void printCenter() {
		System.out.println("x : "+ (leftTopX+rightBottomX)/2 +",  y : "+(leftTopY+rightBottomY)/2);
	}
	public static void main(String[] args) {
		Rectangle rect = new Rectangle();
		
		rect.printArea();
		rect.printRect();
		rect.setWeek5();
		rect.printCenter();
	}

}
