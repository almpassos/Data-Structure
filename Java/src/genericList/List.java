package genericList;

public class List <T>{
	
	public ListNode<T> firstNode;
	public ListNode<T> lastNode;
	
	private T myData;
	
	public List(){}
	
	public List(T value){
		myData = value;
		firstNode = null;
	}
	
	public boolean IsEmpty(){
		return firstNode == null;
	}
	
	public void InsertAtFront(T insertItem){
		if(IsEmpty()){
			firstNode = new ListNode<T>(insertItem);
			lastNode = firstNode;
		}
		else{
			firstNode = new ListNode<T>(insertItem, firstNode);
		}
	}
	
	public void InsertAtBack(T insertItem)
    {
        if (IsEmpty())
        {
        	firstNode = new ListNode<T>(insertItem);
			lastNode = firstNode;
        }
        else
        {
        	
        	lastNode.next = new ListNode<T>(insertItem);
            lastNode = lastNode.next;
        }
    }
	
	public T RemoveFromFront() throws Exception
    {
        if (IsEmpty())
        {
            throw new Exception("The List is Empty");
        }

        T removeItem = firstNode.data;

        if(firstNode == lastNode)
        {
            firstNode = lastNode = null;
        }
        else
        {
            firstNode = firstNode.next;
        }
        return removeItem;
    }
	
	 public T RemoveFromBack() throws Exception
     {
         if (IsEmpty())
         {
             throw new Exception("The List is Empty");
         }

         T removeItem = firstNode.data;

         if (firstNode == lastNode)
         {
             firstNode = lastNode = null;
         }
         else
         {
             ListNode<T> current = firstNode;

             // loop while current.Next is not lastNode
             while (current.next != lastNode)
             {
                 current = current.next; // move to next node
             }

             // current is new lastNode
             lastNode = current;
             current.next = null;
         }

         return removeItem; // return removed data
     }
	 
	// output List contents
     public void Display()
     {
         if (IsEmpty())
         {
             //throw new Exception("The List is Empty");
        	 System.out.println("Empty -- Nothing to show\n");
         }
         else
         {
        	 System.out.print("Elements stored: ");
             ListNode<T> current = firstNode;

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
         ListNode<T> current = firstNode;
         int position = 1;
         boolean found = false;
         // output current node data while not at end of list
         while (current != null)
         {
             if (current.data==value)
             {
                 found = true;
                 System.out.println("Element found at position "+ position);
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

         ListNode<T> current = firstNode;

         // output current node data while not at end of list
         while (current != null)
         {
             current = current.next;
             count++;
         }
         return count;
     }


}
