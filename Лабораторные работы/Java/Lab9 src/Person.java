/*// Правило: «Используйте в открытых классах методы доступа, а не открытые поля».
public class Person {

    private String firstName;
    //public String firstName;

    public void setFirstName(String firstName) { this.firstName = firstName; }

    public String getFirstName() { return firstName; }

}*/


/*import java.util.Arrays;

// Правило: если вы передаете ссылку на объект в сеттер,
// то не копируйте ее во внутреннюю переменную напрямую.
// Вместо этого делайте ее копию и только тогда присваивайте ее полю.
public class Person {

    private int[] scores;

    public void setScores(int[] scores) {
        this.scores = Arrays.copyOf(scores, scores.length);
    }
    *//*public void setScores(int[] scores) {
        this.scores = new int[scores.length];
        System.arraycopy(scores, 0, this.scores, 0, scores.length);
    }*//*
    //public void setScores(int[] scores) { this.scores = scores; }

    public void displayScores() {
        for (int number : scores) System.out.print(number + " ");
        System.out.println();
    }

}*/


/*import java.util.Arrays;

// Правило: не возвращайте ссылку на исходный объект в геттере.
// Возвращайте копию.
public class Person {

    private int[] scores;

    public void setScores(int[] scores) {
        this.scores = Arrays.copyOf(scores, scores.length);
    }

    public int[] getScores() {
        return Arrays.copyOf(scores, scores.length);
    }
    *//*public int[] getScores() {
        int[] copyScores = new int[scores.length];
        System.arraycopy(scores, 0, copyScores,0, copyScores.length);
        return copyScores;
    }*//*
    *//*public int[] getScores() { return scores; }*//*

    public void displayScores() {
        for (int number : scores) System.out.print(number + " ");
        System.out.println();
    }

}*/



























/*// 9.2
public class Person {

    private String name;
    private int age = 1;

    public Person(String name, int age) {

        setName(name);
        setAge(age);

    }


    public String getName() { return this.name; }

    public void setName(String name) { this.name = name; }


    public int getAge() { return this.age; }

    public void setAge(int age) { this.age = (age > 0 && age < 110) ? age : 110; }
    //public void setAge(int age) { if (age > 0 && age < 110) this.age = age; }

}*/

/*// 9.1
class Person {
    String name;
    protected int age;
    public String address;
    String phNumber;
    //private String phNumber;


    public Person(String name, int age, String address, String phNumber) {
        this.name = name;
        this.age = age;
        this.address = address;
        this.phNumber = phNumber;
    }

    public void printName() {
        System.out.printf("Имя: %s \n", name);
    }

    void printAge() {
        System.out.printf("Возраст: %s \n", age);
    }

    void printAddress() {
    //private void printAddress() {
        System.out.printf("Адрес: %s \n", address);
    }

    protected void printPhNumber() {
        System.out.printf("Телефон: %s \n", phNumber);
    }
}*/
