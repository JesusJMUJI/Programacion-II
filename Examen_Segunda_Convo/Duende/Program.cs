namespace Duende;
public static class Program
{
    public static void Main(){
        List list = new List();

    }
}
public class List
{
    Node firstElem = null;
    public void AddElem(string newData){
        //add data at the end of the list
    }
    public string ReadElem(int id){
        return "";
    }

}

public class Node 
{
    public string data;
    public Node reference = null;
    public Node(string _data){
        data = _data;
    }
    
}