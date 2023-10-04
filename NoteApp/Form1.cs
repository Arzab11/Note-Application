using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    
    public partial class Form1 : Form
    {
        DataTable NoteTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NoteTable = new DataTable();
            NoteTable.Columns.Add("Title", typeof(string));
            NoteTable.Columns.Add("Note", typeof(string));

            NoteView.DataSource = NoteTable;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            TitleMessage.Clear();
            NoteMessage.Clear();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            NoteTable.Rows.Add(TitleMessage.Text, NoteMessage.Text);
            ButtonCreate.PerformClick();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            int index = NoteView.CurrentCell.RowIndex;
            if (index >= 0 )
            {
                TitleMessage.Text = NoteTable.Rows[index].ItemArray[0].ToString();
                NoteMessage.Text = NoteTable.Rows[index].ItemArray[1].ToString();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int index = NoteView.CurrentCell.RowIndex;
            NoteTable.Rows[index].Delete();
        }
    }
}
