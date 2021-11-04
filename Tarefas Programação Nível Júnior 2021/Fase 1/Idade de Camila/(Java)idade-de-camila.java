import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

class idade {

	public static void main(String[] args) {
		
		Scanner in = new Scanner(System.in);
		ArrayList idades = new ArrayList();
		
		while(idades.size() < 3) {
			idades.add(in.nextInt());
		}
		
		Collections.sort(idades);
		
		
		
		System.out.println(idades.get(1));
		
		in.close();
		
	}
}	
