public class ExerciseCh4_7_2 {
    static final int N = 10;
    public static void main(String[] args) {
        int i,j;

        for (i=1; i<N; i++) {
            for (j=1; j<N-i; j++) System.out.print(' ');
            for (j=1; j<=i; j++)
                if (j==1) System.out.print('*');
                    else System.out.print(' ');
            for (j=1; j<=i-1; j++)
                if (j==i-1) System.out.print('*');
                    else System.out.print(' ');
            System.out.println();
        }

        for (i=N-1; i>0; i--) {
            for (j=i; j<N; j++) System.out.print(' ');
            for (j=1; j<=i-1; j++)
                if (j==1) System.out.print('*');
                    else System.out.print(' ');
            for (j=1; j<=i-2; j++)
                if (j==i-2) System.out.print('*');
                    else System.out.print(' ');
            System.out.println();
        }
    }
}