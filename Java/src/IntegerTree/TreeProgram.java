package IntegerTree;

import java.util.Random;

public class TreeProgram {

	public static void main(String[] args) {
		Tree myTree = new Tree();
		
		

        for(int i=0; i<20; i++)
        {
        	
            Random rand = new Random(i * System.currentTimeMillis());
            myTree.InsertData(rand.nextInt(99));
        }
        System.out.println();
        System.out.println("Printing Tree in PreOrder");
        myTree.PreOrderPrint();
        System.out.println("\n");
        System.out.println("Printing Tree in InOrder");
        myTree.InOrderPrint();
        System.out.println("\n");
        System.out.println("Printing Tree in PostOrder");
        myTree.PostOrderPrint();

	}

}
