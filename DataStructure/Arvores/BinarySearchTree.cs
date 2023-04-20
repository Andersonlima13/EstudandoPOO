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
   return searchHelper(root, data);
  }

  private bool searchHelper(Node root, int data)
  {
     if(root == null)
      {
      return false; 
      }
     else if(root.data == data)
      {
      return true;
      }
     else if(root.data > data)
      {
        return searchHelper(root.left, data);
      }
     else
      {
        return searchHelper(root.right, data);
      }
  }

  public void remove(int data)
  {
    if(search(data))
    {
      removeHelper(root, data);
    }
    else
    {
      Console.WriteLine($" o valor {data} não foi encontrado");
    }
  }

  public Node removeHelper(Node root, int data)
  {
    if(root == null)
    {
     return root;
    }
    else if(data < root.data)
    {
     root.left = removeHelper(root.left, data);
      
    }
    else if(data > root.data)
    {
     root.right = removeHelper(root.right, data);
    }
    else 
    {
      if(root.left == null && root.right == null)
      {
        root = null;
      }
      else if(root.right != null)
      {
        root.data = sucessor(root);
        root.right = removeHelper(root.right, root.data);
      }
      else
      {
        root.data = predecessor(root);
        root.left = removeHelper(root.left, root.data);
        
      }
    }
    return root;
    
  }
  
  private int sucessor(Node root) // o valor sucessor deverá ser o valor à direita da raiz de nossa árvore ( o menor valor ) 
  {
    root = root.right;
    while(root.left != null)
    {
      root = root.left;
    }
    return root.data;
  }

    private int predecessor(Node root) // o valor antecessor deverá ser o valor à esquerda da raiz de nossa árvore ( o maior valor ) 
  {
     root = root.left;
    while(root.right != null)
    {
      root = root.right;
    }
    return root.data;
  }

     
   
}