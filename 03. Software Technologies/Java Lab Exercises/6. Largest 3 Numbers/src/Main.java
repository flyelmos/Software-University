import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    int [] nums = Arrays.stream(
        new Scanner(System.in).nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

	    Arrays.sort(nums);

	    int count = Math.min(3, nums.length);

	    for(int i = 0; i < count; i++ ){
	        System.out.print(nums[nums.length - i - 1] + " ");
        }
    }
}
