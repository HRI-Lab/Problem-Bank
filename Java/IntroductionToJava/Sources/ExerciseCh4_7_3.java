public class ExerciseCh4_7_3 {
    public static void main(String[] args) {
        int count = 0;
        for (int i=0; i<10; i++) {
            for (int j=0; j<10; j++) {
                if (j==3) continue;
                if (j==5) break;
                count++;
            }
            if (i==5) break;
        }
        System.out.println("count = " + count);
    }
}