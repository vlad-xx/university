public class Task1 {
    public static void main(String[] args) {
        Integer int1 = new Integer(42);
        Integer int2 = new Integer("42");

        Float float1 = new Float(3.14f);
        Float float2 = new Float("3.14f");

        Boolean bool1 = new Boolean(true);
        Boolean bool2 = new Boolean("smth");

        Character char1 = new Character('c');

        System.out.println(int1);
        System.out.println(int2);
        System.out.println(float1);
        System.out.println(float2);
        System.out.println(bool1);
        System.out.println(bool2);
        System.out.println(char1);
    }
}