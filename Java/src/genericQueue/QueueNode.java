package genericQueue;

public class QueueNode<T> {
	
	public T data;

    public QueueNode<T> next;

    public QueueNode(T dataValue, QueueNode<T> nextNode){
        data = dataValue;
        next = nextNode;
    }

    public QueueNode(T dataValue){
    	data = dataValue;
        next = null;
    }

}
