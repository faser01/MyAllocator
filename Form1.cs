using System;
using System.Windows.Forms;
using static MyAllocator.Form1;

namespace MyAllocator
{
    public partial class Form1 : Form
    {
        private MyAllocator allocator;
        private Timer timer;


        public Form1()
        {
            InitializeComponent();
            allocator = new MyAllocator();
            timer = new Timer();
            timer.Interval = 1000; // обновлять информацию каждую секунду
            timer.Tick += UpdateLabels; // метод UpdateLabels будет вызываться по таймеру
            timer.Start();
        }
        private void UpdateLabels(object sender, EventArgs e)
        {
            // обновляем информацию на Label-элементах
            usedMemLabel.Text = "Используется памяти: " + allocator.UsedMemory.ToString() + " байт";
            freeMemLabel.Text = "Свободно памяти: " + allocator.FreeMemory.ToString() + " байт";
        }


        class MyAllocator
        {
            private byte[] memory;
            private int pointer;

            public int UsedMemory { get { return pointer; } }
            public int FreeMemory { get { return memory.Length - pointer; } }

            public MyAllocator()
            {
                // выделяем 1 мегабайт памяти
                memory = new byte[1024 * 1024];
                pointer = 0;
            }

            public int Alloc(int size)
            {
                if (pointer + size > memory.Length)
                    throw new OutOfMemoryException("Недостаточно памяти");

                int address = pointer;
                pointer += size;
                return address;
            }

            public void Free()
            {
                // освобождаем память путем просто установки указателя на начало
                pointer = 0;
            }
        }

        private void AllocButton_Click(object sender, EventArgs e)
        {
            int size = int.Parse(sizeTextBox.Text);
            int address = allocator.Alloc(size);
            addressLabel.Text = "Адрес выделенной памяти: 0x" + address.ToString("X");
        }

        private void freeButton_Click(object sender, EventArgs e)
        {
            allocator.Free();
        }
    }
    
}
