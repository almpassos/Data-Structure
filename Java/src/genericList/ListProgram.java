package genericList;

public class ListProgram {

	public static void main(String[] args) {
		try {
			List<Integer> myList = new List<Integer>();
			
			System.out.println("Inserting element at front: ");
            myList.InsertAtFront(18);
            myList.Display();
            System.out.println("Inserting element at front: ");
            myList.InsertAtFront(17);
            myList.Display();
            System.out.println("Inserting element at back: ");
            myList.InsertAtBack(14);
            myList.Display();
            System.out.println("Inserting element at back: ");
            myList.InsertAtBack(21);
            myList.Display();

            System.out.println("Counting elements: ");
            System.out.println(myList.Size() + " elements in this list \n");

            System.out.println("Searching element: 17 ");
            myList.Search(17);
            myList.Display();
            System.out.println("Searching element: 12 ");
            myList.Search(12);
            myList.Display();

            System.out.println("Removing Element from the Front: ");
            Integer removedObject = myList.RemoveFromFront();
            System.out.println(removedObject+" removed");
            myList.Display();

            System.out.println("Removing Element from the Front: ");
            removedObject = myList.RemoveFromFront();
            System.out.println(removedObject+" removed");
            myList.Display();

            System.out.println("Removing Element from the Back: ");
            removedObject = myList.RemoveFromFront();
            System.out.println(removedObject+" removed");
            myList.Display();

            System.out.println("Removing Element from the Back: ");
            removedObject = myList.RemoveFromFront();
            System.out.println(removedObject+" removed");
            myList.Display();

            System.out.println("Counting elements: ");
            System.out.println(myList.Size() + " elements in this list\n");

            
			
		} catch (Exception e) {
			// TODO: handle exception
		}

	}

}
