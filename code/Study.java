import java.util.ArrayList;

public class Main {
	public static void main(String[] args) {
		int number = 1;
		Integer num2 = 2;
		float f = 1.234f;
		double d = 2.66;
		String str = "test";
		char c = 'c';
		long l = 225678901;
		byte b = 1;
		boolean bool = true;
		short s = 12;
		int[] arr = {1, 2, 3};
		if (bool)
			print(123);
		for (int i = 0; i < 9; i++)
			print(i);
		for (int a : arr)
			print(a);
		int j = 1;
		while (j <= 10)
			print(j++);
		do {
			break;
		} while (true);
		ArrayList<String> list = new ArrayList<String>();
		list.add("1");
		switch (Integer.parseInt(list.get(0).toString())) {
		case 0:
			print(0);
			break;
		case 1:
			print(1);
		case 2:
			print(2);
			break;
		}
		Type type = new Type();
		type.print0("test");

		print(number + num2);
		StringBuilder str0 = new StringBuilder(str);
		str0.append(c);
		print(str0);
		print(s > l / d);
		print(f + b);
		Anmail a = Anmail.cat;
		print(a);

	}


	static void print(Object obj) {
		System.out.println(obj);
	}


}

class Type extends Main {
	void print0(Object obj) {
		System.out.print(obj);
	}
}

enum Anmail {
	dog, cat, mouse, duck, chick, sheep, cow, monkey, tiger, dragon, snake

}