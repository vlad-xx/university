public class Book implements Printable {

    String name;

    Book(String name) { this.name = name; }

    public static void printBooks(Printable[] printables) {
        for (Printable pr: printables) {
            if (pr instanceof Book) { pr.print(); }
        }
    }

    @Override
    public void print() {
        System.out.printf("Book: %s\n", name);
    }
}
