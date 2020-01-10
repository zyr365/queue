using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Collections;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Queue队列就是先进先出。它并没有实现 IList，ICollection。所以它不能按索引访问元素，不能使用Add和Remove。下面是 Queue的一些方法和属性
        //Enqueue():在队列的末端添加元素
        //Dequeue():在队列的头部读取和删除一个元素，注意，这里读取元素的同时也删除了这个元素。如果队列中不再有任何元素。就抛出异常
        //Peek():在队列的头读取一个元素，但是不删除它
        //Count：返回队列中的元素个数
        //TrimExcess():重新设置队列的容量，因为调用Dequeue方法读取删除元素后不会重新设置队列的容量。
        //Contains():确定某个元素是否在队列中
        //CopyTo():把元素队列复制到一个已有的数组中
        //ToArray():返回一个包含元素的新数组
        private void Form1_Load(object sender, EventArgs e)
        {

            //string[] str =new  string[2]{"123","321" };
            string[] str =  { "123", "321" };
            Queue<string> q = new Queue<string>();
            //Queue q = new Queue();
            q.Enqueue("Aa");//向 Queue 的末尾添加一个对象。
            q.Enqueue("Ma");
            q.Enqueue("Ga");
            q.Enqueue("W");

            q.Dequeue();//在队列的头部读取和删除一个元素，注意，这里读取元素的同时也删除了这个元素。如果队列中不再有任何元素。就抛出异常
            int tep = q.Count;
            MessageBox.Show(tep.ToString());
            str=q.ToArray(); //返回一个包含元素的新数组
            foreach (string s in str)
            {
                MessageBox.Show(s.ToString());
            }
        }
    }
}
