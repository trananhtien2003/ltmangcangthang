using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace th2._2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            // Check if selected node is a directory
            if (Directory.Exists(e.Node.FullPath))
            {
                // Clear child nodes of selected node
                e.Node.Nodes.Clear();

                // Load subdirectories
                foreach (var directory in Directory.GetDirectories(e.Node.FullPath))
                {
                    // Add child node for each subdirectory
                    TreeNode node = new TreeNode(Path.GetFileName(directory));
                    node.Tag = directory; // Save directory path as node tag
                    node.Nodes.Add(""); // Add dummy node to show expand symbol
                    e.Node.Nodes.Add(node);
                }

                // Load files
                foreach (var file in Directory.GetFiles(e.Node.FullPath))
                {
                    // Add child node for each file
                    TreeNode node = new TreeNode(Path.GetFileName(file));
                    node.Tag = file; // Save file path as node tag
                    e.Node.Nodes.Add(node);
                }
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // Hiển thị tất cả các ổ đĩa trên hệ thống
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode driveNode = new TreeNode(drive.Name);
                driveNode.Tag = drive.RootDirectory;
                treeView1.Nodes.Add(driveNode);
                driveNode.Nodes.Add("Loading...");
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Check if selected node is a directory
            if (Directory.Exists(e.Node.FullPath))
            {
                // Clear child nodes of selected node
                e.Node.Nodes.Clear();

                // Load subdirectories
                foreach (var directory in Directory.GetDirectories(e.Node.FullPath))
                {
                    // Add child node for each subdirectory
                    TreeNode node = new TreeNode(Path.GetFileName(directory));
                    node.Tag = directory; // Save directory path as node tag
                    node.Nodes.Add(""); // Add dummy node to show expand symbol
                    e.Node.Nodes.Add(node);
                }

                // Load files
                foreach (var file in Directory.GetFiles(e.Node.FullPath))
                {
                    // Add child node for each file
                    TreeNode node = new TreeNode(Path.GetFileName(file));
                    node.Tag = file; // Save file path as node tag
                    e.Node.Nodes.Add(node);
                }
            }
            if (File.Exists(e.Node.Tag.ToString())) // Check if selected node is a file
            {
                // Load file content to RichTextBox1
                richTextBox1.LoadFile(e.Node.Tag.ToString(), RichTextBoxStreamType.PlainText);
            }
            else if (Directory.Exists(e.Node.FullPath)) // Check if selected node is a directory
            {
                // Clear child nodes of selected node
                e.Node.Nodes.Clear();

                // Load subdirectories
                foreach (var directory in Directory.GetDirectories(e.Node.FullPath))
                {
                    // Add child node for each subdirectory
                    TreeNode node = new TreeNode(Path.GetFileName(directory));
                    node.Tag = directory; // Save directory path as node tag
                    node.Nodes.Add(""); // Add dummy node to show expand symbol
                    e.Node.Nodes.Add(node);
                }

                // Load files
                foreach (var file in Directory.GetFiles(e.Node.FullPath))
                {
                    // Add child node for each file
                    TreeNode node = new TreeNode(Path.GetFileName(file));
                    node.Tag = file; // Save file path as node tag
                    e.Node.Nodes.Add(node);
                }
            }
        }
        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            // Xóa các nút con cũ trước khi thêm các nút con mới
            e.Node.Nodes.Clear();



            // Lấy đường dẫn của thư mục được mở rộng
            DirectoryInfo expandedDir = new DirectoryInfo(e.Node.Tag.ToString());

            // Thêm các thư mục con
            foreach (DirectoryInfo dir in expandedDir.GetDirectories())
            {
                TreeNode dirNode = new TreeNode(dir.Name);
                dirNode.Tag = dir.FullName;
                dirNode.Nodes.Add("Loading...");
                e.Node.Nodes.Add(dirNode);
            }

            // Thêm các file trong thư mục
            foreach (FileInfo file in expandedDir.GetFiles())
            {
                TreeNode fileNode = new TreeNode(file.Name);
                fileNode.Tag = file.FullName;
                e.Node.Nodes.Add(fileNode);
            }


        }
        //afterselect tree view to see subdirectory
        
        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            // Check if selected node is a directory
            if (Directory.Exists(e.Node.FullPath))
            {
                // Clear child nodes of selected node
                e.Node.Nodes.Clear();

                // Load subdirectories
                foreach (var directory in Directory.GetDirectories(e.Node.FullPath))
                {
                    // Add child node for each subdirectory
                    TreeNode node = new TreeNode(Path.GetFileName(directory));
                    node.Tag = directory; // Save directory path as node tag
                    node.Nodes.Add(""); // Add dummy node to show expand symbol
                    e.Node.Nodes.Add(node);
                }

                // Load files
                foreach (var file in Directory.GetFiles(e.Node.FullPath))
                {
                    // Add child node for each file
                    TreeNode node = new TreeNode(Path.GetFileName(file));
                    node.Tag = file; // Save file path as node tag
                    e.Node.Nodes.Add(node);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }      
}
