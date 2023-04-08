public class Task3C {
    public static void main(String[] args) {
        // int n = 123;
        int n = 482;
        int sum = 0;
        char[] nums = String.valueOf(n).toCharArray();

        for(char c:nums){ sum += c - '0'; } // '0' -> 48

        System.out.println(sum);
    }
}
