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
        //this is initializing the varible number of genra.
        public int Int_Number_of_Genera;
        //thsi is the array we will be using to store the file 
        ListBox[] Media_Library;

        public string StrApplicationMediaPath = Directory.GetCurrentDirectory();

        public Form1()
        {
            InitializeComponent();
        }
        //this is a void that sets a minimun for the genra and sets the maximun scroll and how far it scrolls. and then passes through to populate genra which genra so that we can use hscroll value in that void.
        private bool Initailise()
        {
            //thsi is the minimun for the scorller 
            Select_Genre_Hscroll.Minimum = 1;
            //this is the change when u scroll on the scroller
            Select_Genre_Hscroll.SmallChange = 1;
            //this is the maximun you can scroll which will come from the file 
            Select_Genre_Hscroll.Maximum = Int_Number_of_Genera;
            //this is the initial value which is the minimun.
            Select_Genre_Hscroll.Value = Select_Genre_Hscroll.Minimum;
            //this is passing the value of hscroll to populate genra list 
            Populate_Genera_List(Select_Genre_Hscroll.Value - 1);
            return true;

        }

        
        private bool Load_Media_Lists()
        {

            //this checks if the file exists in the location and will carry on if it does
            if (File.Exists(StrApplicationMediaPath + "\\Media.txt"))
               
            {
               
                try
                {
                    //this will read the file and we use streamreader so we dont have to type it allot of times.
                    using (StreamReader streamReader = new StreamReader(StrApplicationMediaPath + "\\Media.txt"))
                    {
                        //this reads in the number of genra form the first line and will then be used ina ll the loops so that we can read the correct amount.
                        Int_Number_of_Genera = Convert.ToInt32(streamReader.ReadLine());

                        Media_Library = new ListBox[Int_Number_of_Genera];
                        //this will loop through the for loop 
                        for (int i = 0; i < Int_Number_of_Genera; i++)
                        {

                            Media_Library[i] = new ListBox();
                            //this will convert the int in the file into the array so we can use it later
                            int num = Convert.ToInt32(streamReader.ReadLine());
                            //this adds the second number in the file to the array 
                            Media_Library[i].Items.Add(streamReader.ReadLine());
                            //this will for loop through the file and add it to the array
                            for (int j = 0; j < num; j++)
                            {
                                //this checks the item/word in the file and adds it to the array 
                                string word = streamReader.ReadLine();
                                Media_Library[i].Items.Add(word);
                            }
                        }
                        //this stops reading form the file 
                        streamReader.Close();
                    }
                    //from here down we have the error checking 
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
           
            return false;
        }

        //populate genra list will add the text to the list 
        private void Populate_Genera_List(int Which_Genera)
        {
            //this clears the items 
            Genre_List.Items.Clear();
            //this makes the text in the genre title the same as the hscroll bar and will read it from the array where it is stored
            Genre_Title.Text = Media_Library[Which_Genera].Items[0].ToString();
            //this for loop it will loop through the array and then use the scroll bar value to add to the list
            for (int i = 1; i <= Media_Library[Which_Genera].Items.Count - 1; i++)
            {
                //this adds to the list from the array.
                Genre_List.Items.Add(Media_Library[Which_Genera].Items[i].ToString());
            }
        }
        //this checks if the hscroll has changed value and then will update the text of the title and repopulate the the genral list using populate genra procedure.
        private void hScroll_Genera_ValueChanged(object sender, EventArgs e)
        {

            Genre_Title.Text = Media_Library[Select_Genre_Hscroll.Value - 1].Items[0].ToString();
            Populate_Genera_List(Select_Genre_Hscroll.Value - 1);
        }






        private void JukeBox_Shown(object sender, EventArgs e)
        {
            //these are error checks to see if u load the file or not 
            if (Load_Media_Lists() == false) {
                MessageBox.Show("Unable to load the 'Media Content'.");
                Close();
            }
            //this error checks to see if u have the correct media
            if (Initailise() == false) {
             MessageBox.Show("Unable to display the 'Media Content'.");
                Close();
            }
         }
         
        


        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Media_Lists();






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
