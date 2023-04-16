using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class PersonContactFile
    {
        
        public void FileExistOrNot(string path)
        {
            if(File.Exists(path)) 
            {
                Console.WriteLine("file Exist");
            }
            else 
            { 
                Console.WriteLine("FileNotExist");
            }
        }
     /*   public void WriteContactIntoFile(string path)
        {
            StreamWriter stream= new StreamWriter(path);
            string word = "firstName: prachi \n lastNAme = kale \n city = nagpur \n state = MH";
            stream.Write(word);
            stream.Close();
            Console.WriteLine(File.ReadAllText(path));
        }
        public void ReadContactFromFile(string path) 
        {
            StreamReader stream= new StreamReader(path);
            Console.WriteLine(stream.ReadToEnd());
            stream.Close();
        }*/
    }
}
