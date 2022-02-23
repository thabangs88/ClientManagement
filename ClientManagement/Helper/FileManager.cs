using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.Helper
{
    public class FileManager
    {
        public static void WriteToCSVAndSave(string header, string data)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            saveFileDialog1.Filter = filter;

            //const string header = "Animal_Name,Hair,Feathers,Eggs,Milk,Airborne,Aquatic,Predator,Toothed,Backbone,Breathes,Venomous,Fins,Legs,Tail,Domestic,Catsize,Type";

            StreamWriter writer = null;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filter = saveFileDialog1.FileName;
                writer = new StreamWriter(filter);

                writer.WriteLine(header);
                writer.WriteLine(data);

                writer.Close();
            }
        }
    }
}
