namespace ContextMenu
{
    public partial class Form1 : Form
    {
        int num = 1;
        public Form1()
        {
            AddMenu(toolStripComboBox1, num);
            InitializeComponent();
        }

        private void AddMenu(ToolStripMenuItem item, int n)
        {
            n += 1;
            ToolStripMenuItem i = new ToolStripMenuItem($"{n}");
            item.DropDownItems.Add(i);
            AddMenu(i, n);
        }

    }
}
