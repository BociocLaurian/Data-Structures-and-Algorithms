using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable 
    {     
        private class Node : List<Node>
        {
            public string key { get;  set; }
            public int value { get;  set; }
            public Node()
            { 
            
            }
            public Node(string key, int value)
            {
                this.key = key;
                this.value = value;
            }
        }
        
        private int length;
        private Node[] data;

        public HashTable(int size)
        {
            {
                this.length = size;
                this.data = new Node[size];
            }

        }

        public int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.length;
            }
            return hash;                 
        }

        public void Set(string key, int value)
        {
            int index = Hash(key);
            if (this.data[index] == null)
            {
                this.data[index] = new Node();
            }
            this.data[index].Add(new Node(key, value));
        }

        public int Get(string key)
        {
            int index = Hash(key);   
            if(this.data[index] == null) 
            {
                return 0;
            }
            foreach (var node in this.data[index])
            {
                if (node.key.Equals(key))   
                {
                    return node.value;
                }
            }
            return 0;
        }
        public List<string> Keys()
        {
            List<string> result = new List<string>();
            
            for (int i = 0; i < this.data.Length-1; i++) 
            {
                if (this.data[i]!= null)
                {
                    for (int j = 0; j < length-1; j++)
                    {
                        result.Add(this.data[i][j].key);
                        Console.WriteLine(this.data[i][j].key);
                    }
                }
            }           
            return result;
        }
    }
}
