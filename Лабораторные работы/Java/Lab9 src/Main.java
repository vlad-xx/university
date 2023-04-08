public class Main {
    public static void main(String[] args) {

        Vector2D vector2D = new Vector2D(12, 15);
        Vector2D secondVector2D = new Vector2D(12, 13);

        System.out.printf("get X: %d\n", vector2D.getX());
        System.out.printf("get Y: %d\n", vector2D.getY());

        vector2D.setX(10);
        vector2D.setY(18);

        System.out.printf("get new X: %d\n", vector2D.getX());
        System.out.printf("get new Y: %d\n", vector2D.getY());

        System.out.printf("[INFO] Object vector2D\n%s", vector2D.toString());

        vector2D.setSecondVector2D(secondVector2D);
        System.out.printf("[INFO] Object secondVector2D\n%s",
                vector2D.getSecondVector2D().toString()
        );

    }
}


/*public class Main {
    public static void main(String[] args) {
        Dog jack = new Dog("Джек", 6, 15);
        String jackName = jack.getName();
        int jackAge = jack.getAge();
        int jackWeight = jack.getWeight();

        System.out.println("Кличка собаки: " + jackName);
        System.out.println("Сколько лет собаке: " + jackAge);
        System.out.println("Сколько весит собака: " + jackWeight);
    }
}*/


/*// 9.2
public class Main {
    public static void main(String[] args) {

        Person Kate = new Person("Kate", 30);

        System.out.println(Kate.getAge());
        Kate.setAge(33);
        System.out.println(Kate.getAge());
        Kate.setAge(112345);
        System.out.println(Kate.getAge());

    }
}*/


/*// 9.1
public class Main {
    public static void main(String[] args) {
        Person Kate = new Person(
                "Kate",
                22,
                "Gagarina st.",
                "+7 940 894 2020"
                );

        Kate.printName();
        Kate.printAge();
        Kate.printPhNumber();
        Kate.printAddress();

        System.out.println(Kate.name);
        System.out.println(Kate.address);
        System.out.println(Kate.age);
        System.out.println(Kate.phNumber);
    }
}*/






















