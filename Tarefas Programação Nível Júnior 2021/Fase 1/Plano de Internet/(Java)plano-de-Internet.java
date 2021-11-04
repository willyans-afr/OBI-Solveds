import java.util.Scanner;

class plano {

	public static void main(String[] args) throws Throwable {

		Scanner in = new Scanner(System.in);
		
		int quota = in.nextInt();
		
		int meses = in.nextInt();
		
		int[] usoPorMes = new int[meses];
		
		for (int i = 0; i < usoPorMes.length; i++) {
			usoPorMes[i] = quota;
		}
		
		for(int i = 0; i < usoPorMes.length; i++) {
			int usoAtual =  in.nextInt();
			
			usoPorMes[i] -= usoAtual;
			if(usoPorMes[i] > 0) {
				if(i+1 < usoPorMes.length) {
					usoPorMes[i+1] += usoPorMes[i];
				}
			}
		}
		
		System.out.println(quota+usoPorMes[usoPorMes.length-1]);
		
	}

}
