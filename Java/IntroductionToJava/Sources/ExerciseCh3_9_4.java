public class ExerciseCh3_9_4 {
    static int f(int x, int p, int n) {
        return (x >> (p+1-n)) & -(-0 << n);
    }
    public static void main(String[] args) {
        System.out.println(f(0x0C,3,2));
    }
}