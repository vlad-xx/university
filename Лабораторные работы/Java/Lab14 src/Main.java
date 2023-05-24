public class Main {
    public static void main(String[] args) {
        Printable[] printables = {
                new Book("Book1"),
                new Book("Book2"),
                new Magazine("Magazine1"),
                new Magazine("Magazine2")
        };

        for (Printable pr:printables) {
            pr.print();
        }

        Book.printBooks(printables);
        Magazine.printMagazines(printables);
    }
}












//public class Main {
//    public static void main(String[] args) {
//        Triangle triangle = new Triangle(4, 2, 7);
//        Rectangle rectangle = new Rectangle(23, 15);
//
//        triangle.display();
//        rectangle.display();
//    }
//}
