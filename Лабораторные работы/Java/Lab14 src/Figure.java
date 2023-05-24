abstract class Figure {

    String name;
    abstract double Perimeter();
    abstract double Square();

    public void display() {
        System.out.printf("Фигура %s\n", name);
    }

}

class Triangle extends Figure {
    double a, b, c;

    Triangle(double a, double b, double c) {
        name = "Треугольник";
        this.a = a;
        this.b = b;
        this.c = c;
    }

    @Override
    double Perimeter() {
        return a+b+c;
    }

    @Override
    double Square() {
        double demiPerimeter = Perimeter() / 2;
        return Math.sqrt(demiPerimeter * (demiPerimeter - a) * (demiPerimeter - b) * (demiPerimeter - c));
    }

    public void display() {
        System.out.printf("Фигура: %s\n" +
                "Стороны: %f, %f, %f\n" +
                "Периметр = %f\n" +
                "Площадь = %f\n", name, a, b, c, Perimeter(), Square());
    }
}


class Rectangle extends Figure {
    double a, b;

    Rectangle(double a, double b) {
        name = "Прямоугольник";
        this.a = a;
        this.b = b;
    }

    @Override
    double Perimeter() {
        return (a+b)*2;
    }

    @Override
    double Square() {
        return a*b;
    }

    public void display() {
        System.out.printf("Фигура: %s\n" +
                "Стороны: %f, %f\n" +
                "Периметр = %f\n" +
                "Площадь = %f\n", name, a, b, Perimeter(), Square());
    }
}