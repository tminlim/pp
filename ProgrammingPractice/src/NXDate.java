public class NXDate {
	public static void main(String[] args) {
		NXDate aDate = new NXDate();
		aDate.printDate();
		aDate.setDateTime(1984, 10, 30, 03, 30, 30);
		aDate.printDate();
		System.out.println("datetime = " + aDate.getDateTime());
		aDate.setDateTime(1372352410);
		aDate.printDate();
		aDate.printThisMonth();
		aDate.printWholeMonth(2) ;
	}

	long totalSec;
	int aYear;
	int aMonth;
	int aDay;
	int aHour;
	int aMinute;
	int aSecond;
	static String[] monthName = { "Jan", "Feb", "Mar", "Apr", "May", " Jun",
			"Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

	static int[] monthDay = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	public NXDate() {
		this(0);
	}

	public NXDate(long totalSec) {
		setDateTime(totalSec);
	}

	private void setDateTime(int aYear, int aMonth, int aDay, int aHour,
			int aMinute, int aSecond) {
		totalSec = (aYear - 1970) * 31536000 + (aMonth - 1) * 2592000
				+ (aDay - 1) * 86400 + aHour * 3600 + aMinute * 60 + aSecond;

		this.aYear = aYear;
		this.aMonth = aMonth;
		this.aDay = aDay;
		this.aHour = aHour;
		this.aMinute = aMinute;
		this.aSecond = aSecond;

	}

	private void printDate() {

		System.out.printf("date = %04d - %02d -%02d %02d:%02d:%02d\n", aYear,
				aMonth, aDay, aHour, aMinute, aSecond);
	}

	public long getDateTime() {
		return totalSec;
	}

	public void setDateTime(long totalsec) {
		this.totalSec = totalsec;
		int dSec = 60 * 60 * 24;
		int ySec = dSec * 365;
		aYear = (int) (totalSec / ySec);
		aMonth = (int) (totalSec % ySec) / (dSec * 30);
		aDay = (int) (totalSec % ySec) % (dSec * 30) / dSec;

		aHour = (int) (totalSec % ySec) % (dSec * 30) % dSec / 3600;
		aMinute = (int) (totalSec % ySec) % (dSec * 30) % dSec % 3600;
		aSecond = (int) (totalSec % ySec) % (dSec * 30) % dSec % 3600 / 60;
		aSecond = (int) (totalSec % ySec) % (dSec * 30) % dSec % 3600 % 60;
		
		aYear = aYear + 1970;
		aMonth = aMonth + 1;
		aDay += 1;
	}

	public void printThisMonth() {
		String m = monthName[this.aMonth - 1];
		System.out.println("This month is " + m);
	}

	// private void printThisMonth() {
	// String engMonth = monName;
	//
	// System.out.println("This month is " + engMonth);
	// }

	private void printWholeMonth(int aStartWeek) {
		int endDay = monthDay[this.aMonth - 1];

		for (int i = 0; i < aStartWeek; i++) {
			System.out.print("   ");
		}
		for (int i = 1; i <= endDay; i++) {
			System.out.printf("%02d ", i);
			if ((aStartWeek + i) % 7 == 0)
				System.out.println("");
		}
	}

}
