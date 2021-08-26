using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayImplementation
{
    class MyArray
    {
        public int length;
        private Object[] data;

        public MyArray()
        {
            this.length = 0;
            this.data = new Object[1];
        }

        public Object Get(int index)
        {
            return data[index];
        }

        public Object[] Push(Object item)
        {
            if (this.data.Length == this.length)
            {
                Object[] temp = new Object[this.length];
                Array.Copy(this.data, temp, length);
                this.data = new Object[length + 1];
                Array.Copy(temp, this.data, length);
            }
            this.data[this.length] = item;
            this.length++;
            return this.data;
        }

        public Object Pop()
        {
            Object poped = data[this.length - 1];
            this.data[this.length - 1] = null;
            this.length--;
            return poped;
        }

        public Object Delete(int index)
        {
            Object itemToDelete = data[index];
            ShiftItems(index);
            return itemToDelete;
        }

        private void ShiftItems(int index)
        {
            for (int i = index; i < length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            data[length - 1] = null;
            length--;
        }       

    }
}
