using System;
using System.Windows.Forms;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Controller controller = new Controller(form);
            form.Click += controller.FormCicked;
            form.ShowDialog();
        }

        class Controller
        {
            private Form form;
            public Controller(Form form)
            {
                if (form != null)
                {
                    this.form = form;
                    //this.form.Click += this.FormCicked;
                }
            }

            //public void FormCicked(object sender, EventArgs e)
            //{
            //    form.Text = DateTime.Now.ToString();
            //}
            internal void FormCicked(object sender, EventArgs e)
            {
                form.Text = DateTime.Now.ToString();
            }
        }
    }
}
