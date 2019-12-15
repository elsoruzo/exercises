using System;
using data_structures.SLinkedListModel;
using data_structures.Trees;

namespace data_structures
{

    class Program
    {
        static void Main(string[] args)
        {
            BSearchTree tree = new BSearchTree();

            /* Let us create following BST  
                50  
            / \  
            30 70  
            / \ / \  
            20 40 60 80 */            
            tree.insert(50);
            tree.insert(30);
            tree.insert(20);
            tree.insert(40);
            tree.insert(70);
            tree.insert(60);
            tree.insert(80);

            Console.WriteLine("Inorder traversal of the given tree");
            tree.inorder();

            Console.WriteLine("\nDelete 20");
            tree.deleteKey(20);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.inorder();

            Console.WriteLine("\nDelete 30");
            tree.deleteKey(30);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.inorder();

            Console.WriteLine("\nDelete 50");
            tree.deleteKey(50);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.inorder();
            tree.dispouse();


            BSearchTree treeNonRec = new BSearchTree();

            /* Let us create following BST  
             50
            / \  
            30 70  
            / \ / \  
            20 40 60 80 */
            treeNonRec.insertNonRec(50);
            treeNonRec.insertNonRec(30);
            treeNonRec.insertNonRec(20);
            treeNonRec.insertNonRec(40);
            treeNonRec.insertNonRec(70);
            treeNonRec.insertNonRec(60);
            treeNonRec.insertNonRec(80);

            Console.WriteLine("Inorder traversal of the given treeNonRec");
            treeNonRec.inorder();

            Console.WriteLine("\nDelete 20");
            treeNonRec.removeNonRec(20);
            Console.WriteLine("Inorder traversal of the modified treeNonRec");
            treeNonRec.inorder();

            Console.WriteLine("\nDelete 30");
            treeNonRec.removeNonRec(30);
            Console.WriteLine("Inorder traversal of the modified treeNonRec");
            tree.inorder();

            Console.WriteLine("\nDelete 50");
            treeNonRec.RemoveNonRec(50);
            Console.WriteLine("Inorder traversal of the modified treeNonRec");
            treeNonRec.inorder();


            var list = new SLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.AppendHead(7);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.InsertAfter(4, 8);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
