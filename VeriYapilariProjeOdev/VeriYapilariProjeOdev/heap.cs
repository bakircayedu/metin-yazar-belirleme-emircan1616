using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProjeOdev
{
    public class heap
    {
        public TreeNode root;
        public TreeNode insertPos;

        public heap(TreeNode temp)
        {
            root = temp;
            insertPos = temp;
        }

        public void insert (TreeNode temp)
        {
            if (insertPos.left == null)
            {
                insertPos.left = temp;
                temp.parent = insertPos;

                balanceHeap(temp);

                return;
            }

            else
            {
                insertPos.right = temp;
                temp.parent = insertPos;

                adjustInsertPos();
                balanceHeap(temp);

            }
        }

        private void balanceHeap(TreeNode temp)
        {
            while (temp.parent != null)
            {
                if (string.Compare(temp.parent.data, temp.data)==1)
                {
                    string tmp = temp.data;
                    temp.data = temp.parent.data;
                    temp.parent.data = tmp;

                    temp = temp.parent;

                }

                else
                {
                    break;                                         
                }
            }
        }

        private void adjustInsertPos()
        {
            TreeNode temp;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                temp = q.Dequeue();
                if (temp.left != null)
                    q.Enqueue(temp.left);
                else
                {
                    insertPos = temp;
                    break;
                }

                if (temp.right != null)
                    q.Enqueue(temp.right);
                else
                {
                    insertPos = temp;
                    break;
                }
            }

        }


        public void bfsTraver()
        {
            TreeNode temp;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                temp = q.Dequeue();

                if (temp.left != null)
                    q.Enqueue(temp.left);

                if (temp.right != null)
                    q.Enqueue(temp.right); 
            }
        }

    }
}
