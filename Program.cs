using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BIT706_A2_Campen_5047211
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CustomerController control = new CustomerController();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Objects.bin", FileMode.Open, FileAccess.Read,
            FileShare.Read);
            control.AllCustomers = (List<Customer>)formatter.Deserialize(stream);
            CustomerSingleton.setInstance((CustomerSingleton)formatter.Deserialize(stream));
            AccountSingleton.setInstance((AccountSingleton)formatter.Deserialize(stream));
            stream.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var main_form = new Dashboard();
            main_form.FormClosed += new FormClosedEventHandler(FormClosed);
            main_form.Show();
            Application.Run();
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerController control = new CustomerController();

            //create a formatting object
            IFormatter formatter = new BinaryFormatter();
            //Create a new IO stream to write to the file Objects.bin
            Stream stream = new FileStream("objects.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);
            //use the formatter to serialize the collection and send it to the filestream
            formatter.Serialize(stream, control.AllCustomers);
            formatter.Serialize(stream, CustomerSingleton.getInstance());
            formatter.Serialize(stream, AccountSingleton.getInstance());
            //close the file
            stream.Close();

            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
