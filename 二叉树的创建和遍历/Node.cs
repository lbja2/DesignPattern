﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树的创建和遍历
{
    class Node<T>
    {
        public T data { get; set; }
        public Node<T> lchild { get; set; }
        public Node<T> rchild { get; set; }
        public Node(T data)
        {
            this.data = data;
        }
        public Node(T data,Node<T>lchild,Node<T>rchild)
        {
            this.data = data;
            this.lchild = lchild;
            this.rchild = rchild;
        }
    }
}
