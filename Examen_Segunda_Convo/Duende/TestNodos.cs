/*
namespace CDuende;
public static class Program
{
    public static void Main(){
        List list = new List();

    }
}
public class List
{
    public List()
    {
        firstElem = new Node("a");
        firstElem.reference = new Node("b");
        firstElem.reference.reference = new Node("c");
    }
    Node firstElem = null;
    public void AddElem(string newData)
    {
        Node currNode = firstElem;
        if(currNode == null){
            firstElem = new Node(newData);
        }
        else{
             //find last node
            while(currNode.reference != null)
            {
                currNode = currNode.reference;
            }

            Node lastNode = currNode;
            lastNode.reference = new Node(newData);
        }
    }
    public string ReadElem(int id){
        Node other = firstElem;
        for(int i = 0; i < id; i++){
            other = other.reference;
        }
        return other.data;
    }

}
public class Stack
{
    public Stack(){
        firstNode = new Node("a");
        firstNode.reference = new Node("b");
        firstNode.reference.reference = new Node("c");
    }
    Node firstNode;
    public void Push(string data){
        Node newNode = new Node(data);
        newNode.reference = firstNode;

        firstNode = newNode;
    }
    public string Pop(){
        Node removedNode = firstNode;

        firstNode = removedNode.reference;

        removedNode.reference = null;

        return removedNode.data;
    }
    //

    //firstNode --> secondNode --> thirdNode -->
}
public class Queue
{
    public Queue(){

    }
    BiNode firstNode = null, lastNode = null;
    public void Push(string data){
        if(firstNode == null && lastNode == null){
            firstNode = new BiNode(data);
            lastNode = firstNode;
            return;
        }

        BiNode newNode = new BiNode(data);

        newNode.next = firstNode;
        firstNode.prev = newNode;

        firstNode = newNode;


    }
    public string Pop(){
        BiNode removedNode = lastNode;

        BiNode prevNode = removedNode.prev;
        removedNode.prev = null;
        prevNode.next = null;

        lastNode = prevNode;

        return removedNode.data;
    }
    // F <--> A <--> B <--> C =>
}
public class Node 
{
    public string data;
    public Node reference = null;
    public Node(string _data){
        data = _data;
    }
    
}
public class BiNode
{
    public string data;
    public BiNode next = null, prev = null;
    public BiNode(string _data){
        data = _data;
    }

}*/
