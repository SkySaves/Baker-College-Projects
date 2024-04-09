public class ShapeArray {
    public static void main(String[] args) {
        Shape[] shapeArray = new Shape[3];

        shapeArray[0] = new Sphere(13);
        shapeArray[1] = new Cylinder(3, 7);
        shapeArray[2] = new Cone(3, 6); 

        for (Shape shape : shapeArray) {
            System.out.println(shape.toString());
        }
    }
}
