using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLibraryBikeBusLayer;


namespace ClassLibraryBikeDataLayer
{
    public class FileHandler
    {
        public static String binFilePath = @"../../my_bikes.ser";

        public static void WriteToBinaryFile(List<Bike> list)
        {
            FileStream fs = new FileStream(binFilePath, FileMode.OpenOrCreate, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, list);     

            fs.Close(); 

        }

        public static List<Bike> ReadFromBinaryFile()
        {
            List<Bike> list = new List<Bike>();

            if (File.Exists(binFilePath))
            {
                FileStream fs = new FileStream(binFilePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                list = (List<Bike>) bf.Deserialize(fs);
           

                fs.Close();
            }

            return list;
        }


    }
}
