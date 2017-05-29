package genericList;

public class ListNode<T> {
	
	public T data;
	
	public ListNode<T> next;
	
	public ListNode(T dataValue, ListNode<T> nextNode){
		this.data = dataValue;
		this.next = nextNode;
	}
	
	public ListNode(T dataValue){
		this.data = dataValue;
		this.next = null;
	}

}
