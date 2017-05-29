package genericQueue;

public class Queue<T> {
	
	public QueueNode<T> firstNode;
    public QueueNode<T> lastNode;

    private T myData;

    public Queue() { }

    public Queue(T value)
    {
        myData = value;
        firstNode = null;
    }

    // return true if List is empty
    public boolean IsEmpty()
    {
        return firstNode == null;
    }

    public void Enqueue(T insertItem)
    {
        if (IsEmpty())
        {
            firstNode = lastNode = new QueueNode<T>(insertItem);
        }
        else
        {
            lastNode = lastNode.next = new QueueNode<T>(insertItem);
        }
    }

    public T Dequeue() throws Exception
    {
        if (IsEmpty())
        {
            throw new Exception("The Queue is Empty");
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

    // output List contents
    public void Display()
    {
        if (IsEmpty())
        {
            //throw new Exception("The List is Empty");
        	System.out.println();
            System.out.println("Empty -- Nothing to show\n");
        }
        else
        {
        	System.out.print("Elements stored: ");

            QueueNode<T> current = firstNode;

            // output current node data while not at end of list
            while (current != null)
            {
            	System.out.print(" "+current.data);
                current = current.next;
            }

            System.out.println("\n");
        }
    }

    public void Search(T value)
    {
        QueueNode<T> current = firstNode;
        int position = 1;
        boolean found = false;
        // output current node data while not at end of list
        while (current != null)
        {
            if (current.data==value)
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

        QueueNode<T> current = firstNode;

        // output current node data while not at end of list
        while (current != null)
        {
            current = current.next;
            count++;
        }
        return count;
    }

}
