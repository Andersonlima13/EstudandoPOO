public class BinarySearchTree
{
   
  Node root;

  public void insert(Node node)
  {
    root = insertHelper(root , node);
  }

  private Node insertHelper(Node root, Node node)
  {
    int data = node.data;

    if(root == null)
    {
      root = node;
      return root;
    }
    else if(data < root.data)
    {
      root.left = insertHelper(root.left, node);
    }
    else
    {
      root.right = insertHelper(root.right, node);
    }

    return root;
  }

  public void display()
  {
   displayHelper(root); 
  }

  private void displayHelper(Node root)
  {
    if(root != null)
    {
      displayHelper(root.left);
      Console.WriteLine(root.data);
      displayHelper(root.right);
    }
  }

  public bool search(int data)
  {
    return false;
  }

  private bool searchHelper(node root, int data)
  {

  }

  public void remove(int data)
  {

  }

  public Node removeHelper(Node root, int data)
  {
    return null;
  }
  
  private int sucessor(Node root)
  {
    return 0;
  }

    private int predecessor(Node root)
  {
    return 0;
  }

     
   
}