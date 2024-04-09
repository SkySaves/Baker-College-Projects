import java.util.Scanner;

public class RecursiveProduct {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter five numbers to multiply:");

        // no check for integer inputs
        int num1 = scanner.nextInt();
        int num2 = scanner.nextInt();
        int num3 = scanner.nextInt();
        int num4 = scanner.nextInt();
        int num5 = scanner.nextInt();

        int product = multiplyNumbers(num1, num2, num3, num4, num5);
        System.out.println("The product of the numbers is: " + product);
    }

    // recursive method using varargs
    public static int multiplyNumbers(int... numbers) {
        return multiplyHelper(0, numbers);
    }

    private static int multiplyHelper(int index, int... numbers) {
        // base case: when we've processed all elements
        if (index == numbers.length - 1) {
            return numbers[index];
        }
        // recursive case: multiply current element with result of remaining elements
        return numbers[index] * multiplyHelper(index + 1, numbers);
    }
}
