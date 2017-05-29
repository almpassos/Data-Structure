package genericStack;

public class StackNode<T> {
	
	public T data;

    public StackNode<T> next;

    public StackNode(T dataValue, StackNode<T> nextNode)
    {
        data = dataValue;
        next = nextNode;
    }

    public StackNode(T dataValue){
    	data = dataValue;
        next = null;
    }

}
