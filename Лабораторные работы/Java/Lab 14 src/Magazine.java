public class Magazine implements Printable{

    String name;

    Magazine(String name) { this.name= name; }

    public static void printMagazines(Printable[] printables) {
        for (Printable pr: printables) {
            if (pr instanceof Magazine) { pr.print(); }
        }
    }

    @Override
    public void print() {
        System.out.printf("Magazine: %s\n", name);
    }
}
