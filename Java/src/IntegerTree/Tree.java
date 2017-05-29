package IntegerTree;

public class Tree {
	
	private TreeNode root; 


    public void InsertData(int value)
    {
        if(root == null)
        {
            root = new TreeNode(value);
        }else
        {
            root.Insert(value);
        }
    }

    public void PreOrderPrint()
    {
        PreOrder(root);
    }

    private void PreOrder(TreeNode node)
    {
        if(node != null)
        {
        	System.out.print("  "+node.data);
            PreOrder(node.leftNode);
            PreOrder(node.rightNode);
        }
    }

    public void InOrderPrint()
    {
        InOrder(root);
    }

    private void InOrder(TreeNode node)
    {
        if (node != null)
        {
            InOrder(node.leftNode);

            System.out.print("  "+node.data);
            
            InOrder(node.rightNode);
        }
    }

    public void PostOrderPrint()
    {
        PostOrder(root);
    }

    private void PostOrder(TreeNode node)
    {
        if (node != null)
        {
            InOrder(node.leftNode);

            InOrder(node.rightNode);

            System.out.print("  "+node.data);
            
        }
    }

}
