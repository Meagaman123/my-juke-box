using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int Int_Number_of_Genera;
        ListBox[] Media_Library;
        public string StrApplicationMediaPath = Directory.GetCurrentDirectory();

        public Form1()
        {
            InitializeComponent();
        }

        private bool Initailise()
        {
            Select_Genre_Hscroll.Minimum = 1;
            Select_Genre_Hscroll.SmallChange = 1;
            Select_Genre_Hscroll.Maximum = Int_Number_of_Genera;
            Select_Genre_Hscroll.Value = Select_Genre_Hscroll.Minimum;
            Select_Genre_Hscroll.Value - 1;
            return true;
        }



        private bool Load_Media_Lists()
        {
            if (File.Exists(StrApplicationMediaPath + "\\Media\\Media.txt"))
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(StrApplicationMediaPath + "\\Media\\Media.txt"))
                    {
                        Int_Number_of_Genera = Convert.ToInt32(streamReader.ReadLine());
                        Media_Library = new ListBox[Int_Number_of_Genera];
                        for (int i = 0; i < Int_Number_of_Genera; i++)
                        {
                            Media_Library[i] = new ListBox();
                            int num = Convert.ToInt32(streamReader.ReadLine());
                            Media_Library[i].Items.Add(streamReader.ReadLine());
                            for (int j = 0; j < num; j++)
                            {
                                string item = streamReader.ReadLine();
                                Media_Library[i].Items.Add(item);
                            }
                        }
                        streamReader.Close();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            {
                
               

                

                


                
                string applicationPath = Directory.GetCurrentDirectory() + "\\";


                //this reads the file file stream is a short way of writing it instead of the whole thing.
                StreamReader Filestream = new StreamReader(applicationPath + ("Media.txt"));


                //this gets the first line in the file and converts it into an int puts it as number of genera 
                Int_Number_of_Genera = Convert.ToInt32(Filestream.ReadLine());


                //this takes the int number of genra string and puts it into the array.
                Media_Library = new ListBox[Int_Number_of_Genera];


                //this then goes through the foor loop exactly the amount of number of genra there is in the file it will then read in the next 2 lines and store them in the array 
                for (int i = 0; i < Int_Number_of_Genera; i++)
                {
                   
                    Media_Library[i] = new ListBox();
                    int num = Convert.ToInt32(Filestream.ReadLine());
                    Media_Library[i].Items.Add(Filestream.ReadLine());
                    //this adds the the text in the file to the text file and displays it 
                    for (int j = 0; j < num; j++)
                    {
                        string item = Filestream.ReadLine();
                        Media_Library[i].Items.Add(item);
                    }
                }
                Filestream.Close();

                
                


                Genre_Title.Text = Media_Library[Select_Genre_Hscroll.Value-1].Items[0].ToString();




                int Which_Genera = Select_Genre_Hscroll.Value - 1 ;

                Genre_List.Items.Clear();
                Genre_Title.Text = Media_Library[Which_Genera].Items[0].ToString();
                for (int i = 1; i <= Media_Library[Which_Genera].Items.Count - 1; i++)
                {
                    Genre_List.Items.Add(Media_Library[Which_Genera].Items[i].ToString());
                }


            }
        }



        private void Genre_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cp_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
