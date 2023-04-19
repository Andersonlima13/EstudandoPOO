using System;

class Program {
  public static void Main (string[] args) {
    BinarySearchTree tree = new BinarySearchTree();
    tree.insert(new Node(5));
    tree.insert(new Node(25));
    tree.insert(new Node(51));
    tree.insert(new Node(15));
    tree.insert(new Node(57));
    tree.insert(new Node(7));
    tree.insert(new Node(8));

    tree.display();

  }
}