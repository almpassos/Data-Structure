package IntegerTree;

public class TreeNode{
	
	public int data;

    public TreeNode leftNode;

    public TreeNode rightNode;

    public TreeNode(int myData)
    {
        data = myData;
    }

    public void Insert(int newData)
    {
        if (newData < this.data)
        {
            if (leftNode == null)
            {
                leftNode = new TreeNode(newData);
            }
            else
            {
                leftNode.Insert(newData);
            }
        }else if(newData > this.data)
        {
            if(rightNode == null)
            {
                rightNode = new TreeNode(newData);
            }else
            {
                rightNode.Insert(newData);
            }
        }
    }
    

	

}
