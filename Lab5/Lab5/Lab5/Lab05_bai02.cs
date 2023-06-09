﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit;
using MailKit.Search;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Lab05_bai02 : Form
    {
        public Lab05_bai02()
        {
            InitializeComponent();           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var client = new ImapClient())
            {
                listView1.View = View.Details;
                listView1.Columns.Add("Email", 200);
                listView1.Columns.Add("From", 200);
                listView1.Columns.Add("Thời gian", 200);
                var username = textBox1.Text.ToString();
                var password = textBox2.Text.ToString();
                client.Connect("127.0.0.1", 143, MailKit.Security.SecureSocketOptions.None);
                client.Authenticate(username, password);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem name = new ListViewItem(message.Subject);
                    ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());                    
                    ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                    name.SubItems.Add(from);
                    name.SubItems.Add(date);
                    listView1.Items.Add(name);
                }
                label5.Text = inbox.Count.ToString();
                label6.Text = inbox.Recent.ToString();
                client.Disconnect(true);
            }
        }
        
    }
}
