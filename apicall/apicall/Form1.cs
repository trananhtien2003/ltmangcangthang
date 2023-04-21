
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace apicall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly HttpClient _httpClient = new HttpClient();

        private async void MainForm_Load(object sender, EventArgs e)
        {
            List<Todo> todos = await FetchTodosAsync();
            DisplayTodos(todos);
        }

        private async Task<List<Todo>> FetchTodosAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos");
            string json = await response.Content.ReadAsStringAsync();
            List<Todo> todos = JsonConvert.DeserializeObject<List<Todo>>(json);
            return todos;
        }
        public class Todo
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Title { get; set; }
            public bool Completed { get; set; }
        }
        private void DisplayTodos(List<Todo> todos)
        {
            listView1.BeginUpdate();
            foreach (Todo todo in todos)
            {
                ListViewItem item = new ListViewItem(todo.Id.ToString());
                item.SubItems.Add(todo.UserId.ToString());
                item.SubItems.Add(todo.Title);
                item.SubItems.Add(todo.Completed ? "Có" : "Không");
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Todo> todos = await FetchTodosAsync();
            DisplayTodos(todos);
        }
    }
}