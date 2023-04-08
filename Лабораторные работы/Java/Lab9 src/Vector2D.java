public class Vector2D {

    private int x;
    private int y;

    private Vector2D secondVector2D;

    public Vector2D(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public Object clone() { return new Vector2D(x, y); }

    public int getX() { return x; }
    public int getY() { return y; }

    public void setX(int x) { this.x = x; }
    public void setY(int y) { this.y = y; }

    public String toString() {
        String xString = Integer.toString(x);
        String yString = Integer.toString(y);
        return "X: " + xString + "\nY: " + yString + "\n";
    }

    public void setSecondVector2D(Vector2D vector2D) { this.secondVector2D = (Vector2D) vector2D.clone(); }
    public Vector2D getSecondVector2D() { return (Vector2D) secondVector2D.clone(); }
}


