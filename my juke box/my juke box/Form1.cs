﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using WMPLib;
//using AxWMPLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //this is initializing the varible number of genra.
        public int Int_Number_of_Genera;
        //thsi is the array we will be using to store the file 
        ListBox[] Media_Library;

        public bool Currently_Playing_song = false;

        public string StrApplicationMediaPath = Directory.GetCurrentDirectory();

        //private AxWindowsMediaPlayer myMediaPlayer;

        public Form1()
        {
            InitializeComponent();
        }
        //this is a void that sets a minimun for the genra and sets the maximun scroll and how far it scrolls. and then passes through to populate genra which genra so that we can use hscroll value in that void.
        private void Initailise()
        {
            //thsi is the minimun for the scorller 
            Select_Genre_Hscroll.Minimum = 1;
            //this is the change when u scroll on the scroller
            Select_Genre_Hscroll.SmallChange = 1;
            //this is the maximun you can scroll which will come from the file 
            Select_Genre_Hscroll.Maximum = Int_Number_of_Genera;
            //this is passing the value of hscroll to populate genra list 
            Populate_Genera_List(Select_Genre_Hscroll.Value - 1);
            //this is the initial value which is the minimun.
            Select_Genre_Hscroll.Value = Select_Genre_Hscroll.Minimum;
            
           

        }

        
        private void Load_Media_Lists()
        {

            StreamReader streamReader = new StreamReader(StrApplicationMediaPath + "\\Media.txt");
                    
                        //this reads in the number of genra form the first line and will then be used in the loops so that we can read the correct amount.
                        Int_Number_of_Genera = Convert.ToInt32(streamReader.ReadLine());
                        //this adds the number of genra to the array
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



         
        


        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Media_Lists();
            Initailise();






        }



        private void Genre_List_SelectedIndexChanged(object sender, EventArgs e)
        {

              //this adds the items that are in genre list and that are selected to the play list.        
              Play_List.Items.Add(Genre_List.Items[Genre_List.SelectedIndex]);
            //this checks the bool currenlty playing song if it is false it will then take currently the top of genre list and put it in currenlty playing txt and removes it from playlist
            if (Currently_Playing_song == false)
            {
                Currently_Playing.Text = Play_List.Items[0].ToString();
                Play_List.Items.Remove(Play_List.Items[0]);
                
                Currently_Playing_song = true;
                
            }


        }

        private void cp_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Select_Genre_Hscroll_Scroll(object sender, ScrollEventArgs e)
        {
            Genre_Title.Text = Media_Library[Select_Genre_Hscroll.Value - 1].Items[0].ToString();
            Populate_Genera_List(Select_Genre_Hscroll.Value - 1);
        }

        private void Play_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Currently_Playing_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutForm = new about();
            aboutForm.ShowDialog();
        }
    }
}
