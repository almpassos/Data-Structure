package genericQueue;

public class QueueProgram {

	public static void main(String[] args) throws Exception {
		Queue<Integer> queue = new Queue<Integer>();

        System.out.println("Puting 14 into the Queue");
        queue.Enqueue(14);
        queue.Display();
        System.out.println("Puting 17 into the Queue");
        queue.Enqueue(17);
        queue.Display();
        System.out.println("Puting 18 into the Queue");
        queue.Enqueue(18);
        queue.Display();
        System.out.println("Puting 21 into the Queue");
        queue.Enqueue(21);
        queue.Display();

        System.out.println();

        System.out.println("Removing a element from the Queue");
        queue.Dequeue();
        queue.Display();
        System.out.println("Removing a element from the Queue");
        queue.Dequeue();
        queue.Display();
        System.out.println("Removing a element from the Queue");
        queue.Dequeue();
        queue.Display();
        System.out.println("Removing a element from the Queue");
        queue.Dequeue();
        queue.Display();


	}

}
