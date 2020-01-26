using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace Scraper
{
    public partial class EntryForm : Form
    {

        RichTextBox entryBox;
        string input;
        ListBox selectedChaptersBox;
        Button search;

        public EntryForm()
        {
            InitializeComponent();
            search = searchButton;
            entryBox = keywordEntry;
            input = keywordEntry.Text;
            selectedChaptersBox = chapterSelect;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            // these are the items selected in the form and the # of items selected
            SelectedIndexCollection selected = selectedChaptersBox.SelectedIndices;
            int selectedItemCount = selected.Count;

            // make an array that will store the items selected
            TextData.chaptersToSearch = new TextData.ChapterText[selectedItemCount];

            // loop through each index in the SelectedIndices, getting the selected item from TextData's ChapterText dictionary and placing it into the dictionary
            int index = 0;
            foreach (int itemIndex in selected)
            {
                TextData.chapterTexts.TryGetValue(itemIndex, out TextData.chaptersToSearch[index]);
                index++;
            }

           // input = entryBox.Text;
            List<string> phrases = entryBox.Text.Split('\n').ToList();

            OutputForm outputForm = new OutputForm(phrases);
            outputForm.ShowDialog();
        }

        private void chapterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedChaptersBox.SelectedIndices.Count > 0)
            {
                search.Enabled = true;
            }
            else
            {
                search.Enabled = false;
            }
        }
    }
}
