using System;
using System.Windows.Forms;
using static MyAllocator.Form1;

namespace MyAllocator
{
    public partial class Form1 : Form
    {
        private MyAllocator _allocator;
        private IntPtr _allocatedPtr;

        public Form1()
        {
            InitializeComponent();
            _allocator = new MyAllocator(1024);
        }



        public class MyAllocator
        {
            private int _pageSize;
            private byte[][] _chunks = null;
            private int _curChunkIdx = -1;
            private int _curByteIdx = 0;


            public MyAllocator(int pageSize)
            {
                _pageSize = pageSize;
            }

            public IntPtr Alloc(int size)
            {
                if (_chunks == null || _curByteIdx + size > _pageSize)
                {
                    _chunks = new byte[10][];
                    for (int i = 0; i < 10; i++)
                    {
                        _chunks[i] = new byte[_pageSize];
                    }
                    _curChunkIdx = 0;
                    _curByteIdx = 0;
                }

                IntPtr ptr = new IntPtr(BitConverter.ToInt32(_chunks[_curChunkIdx], 0) + _curByteIdx);
                _curByteIdx += size;
                if (_curByteIdx >= _pageSize)
                {
                    _curChunkIdx++;
                    _curByteIdx = 0;
                }
                return ptr;
            }



        }

        private void AllocButton_Click(object sender, EventArgs e)
        {
            int size;
            if (!int.TryParse(sizeTextBox.Text, out size))
            {
                MessageBox.Show("Недопустимый размер");
                return;
            }

            _allocatedPtr = _allocator.Alloc(size);
            MessageBox.Show($"Память, выделенная по адресу {_allocatedPtr.ToInt32()}");
        }
    }
    
}
