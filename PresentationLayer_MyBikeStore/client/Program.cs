using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBikeBusLayer;
using ClassLibraryBikeDataLayer;


namespace prjWinForm_MyBike
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()


        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form2 myBikesFormLog = new Form2();
            Application.Run(myBikesFormLog);
        }
    }
}
