package hw4;

public class ProfilePrint {
	byte age;
	String name;
	boolean inMarried;
	
	public void setAge(byte age){
		this.age = age;
	}
	
	public byte getAge(){
		return age;
	}
	
	public void setName(String name){
		this.name = name;
	}
	
	public String getName(){
		return name;
	}
	
	public void setMarried(boolean flag){
		this.inMarried = flag;
	}
	
	public boolean isMarried(){
		return inMarried;
		
	}
	public static void main(String[] args) {
		ProfilePrint profile = new ProfilePrint();
		profile.setAge((byte)30);
		profile.setName("lim jungmin");
		profile.setMarried(false);
		System.out.println(profile.getAge());
		System.out.println(profile.getName());
		System.out.println(profile.isMarried());
	}

}
