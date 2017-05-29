package genericStack;

public class StackProgram {

	public static void main(String[] args) {
		Stack<Integer> myStack = new Stack<Integer>();

        myStack.Display();
        System.out.println("\nPushing Element into the stack: ");
        myStack.Push(14);
        myStack.Display();
        System.out.println("\nPushing Element into the stack: ");
        myStack.Push(17);
        myStack.Display();

        System.out.println("\nTop element of the stack: "+ myStack.Peek());

        System.out.println("\nPushing Element into the stack: ");
        myStack.Push(18);
        myStack.Display();
        System.out.println("\nPushing Element into the stack: ");
        myStack.Push(21);
        myStack.Display();

        System.out.println("\nTop element of the stack: " + myStack.Peek());
        System.out.println("\nStack size: " + myStack.Size());

        System.out.println("\nSearching for 18: ");
        myStack.Search(18);
        System.out.println("\nSearching for 15: ");
        myStack.Search(15);

        System.out.println("\nPoping Element from the stack: ");
        myStack.Pop();
        myStack.Display();
        System.out.println("\nPoping Element from the stack: ");
        myStack.Pop();
        myStack.Display();
        System.out.println("\nPoping Element from the stack: ");
        myStack.Pop();
        myStack.Display();
        System.out.println("\nPoping Element from the stack: ");
        myStack.Pop();
        myStack.Display();

	}

}
