package genericStack;

public class Stack<T> implements Comparable<T> {
	
	public StackNode<T> firstNode;
    public StackNode<T> lastNode;
    
    public boolean IsEmpty()
    {
        return firstNode == null;
    }

    public void Push(T dataValue)
    {
        if(IsEmpty())
        {
            firstNode = new StackNode<T>(dataValue);
            lastNode = firstNode;
        }
        else
        {
            firstNode = new StackNode<T>(dataValue, firstNode);
        }
    }

    // remove item from top of stack by removing
    // item at front of linked list
    public T Pop()
    {
        if (IsEmpty())
        {
        	System.out.println("Stack is Empty");
        }

        T removeItem = firstNode.data;

        if (firstNode == lastNode)
        {
            firstNode = lastNode = null;
        }
        else
        {
            firstNode = firstNode.next;
        }
        return removeItem;
    }

    public T Peek()
    {
        return firstNode.data;
    }

    // output List contents
    public void Display()
    {
        if (IsEmpty())
        {
            //throw new Exception("The Stack is Empty");
            System.out.println("Empty -- Nothing to show\n");
        }
        else
        {
            System.out.print("Elements stored: ");

            StackNode<T> current = firstNode;

            // output current node data while not at end of list
            while (current != null)
            {
                System.out.print(current.data+" ");
                current = current.next;
            }

            System.out.println("\n");
        }
    }

    public void Search(T value)
    {
        StackNode<T> current = firstNode;
        int position = 1;
        boolean found = false;
        // output current node data while not at end of list
        while (current != null)
        {
            if (current.data == value)
            {
                found = true;
                System.out.println("Element found at position " + position);
            }
            current = current.next;
            position = position + 1;
        }
        if (found == false)
        {
            System.out.println("Element not found");
        }
    }

    public int Size()
    {
        int count = 0;

        StackNode<T> current = firstNode;

        // output current node data while not at end of list
        while (current != null)
        {
            current = current.next;
            count++;
        }
        return count;
    }

	@Override
	public int compareTo(T value) {
		
		
		return 0;
	}

}
