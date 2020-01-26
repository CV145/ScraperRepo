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

namespace Scraper
{
    public partial class OutputForm : Form
    {
        public OutputForm(List<string> keyPhrases)
        {
            InitializeComponent();

            //key phrases: get the input from edit text box and split by line
            // look to see which sub chapter has the most key phrases

            //string[] keywords = inputText.Split(' ');
            int keywordCount = 0;
            int highestKeywordCount = 0;
            KeyValuePair<string, string> winner = new KeyValuePair<string, string>();

            Debug.WriteLine("Keyphrases:");
            foreach (string word in keyPhrases)
            {
                Debug.WriteLine(word);
            }
            Debug.WriteLine("");

            //look through each subtext, increase the keyword count, output the subtext or subtexts with the most keywords
            foreach (TextData.ChapterText selectedChapter in TextData.chaptersToSearch)
            {
                foreach (KeyValuePair<string, string> section in selectedChapter.subChapters)
                {
                    Debug.WriteLine(section.Key + " contains these keyphrases:");
                    foreach (string phrase in keyPhrases)
                    {
                        if (section.Value.Contains(phrase))
                        {
                            Debug.Write(phrase + " ");
                            keywordCount++;
                        }
                    }
                    Debug.WriteLine("");

                    //section with most keywords
                    if (keywordCount > highestKeywordCount)
                    {
                        winner = section;
                        highestKeywordCount = keywordCount;
                    }

                    keywordCount = 0;
                }
            }

            Debug.WriteLine("Winner: " + winner.Key);

            RichTextBox newText = new RichTextBox();

            newText.MinimumSize = new Size(500, 200);

            newText.Multiline = true;
            newText.ReadOnly = true;
            newText.ScrollBars = RichTextBoxScrollBars.Vertical;
            newText.Text = winner.Value;

            //newText.SelectionColor = Color.Yellow;
            
            //foreach (string phrase in keyPhrases)
            //{
            //    int index = newText.Find(phrase);
            //    newText.SelectionStart = index;
            //    Debug.WriteLine("start index: " + index);
            //    newText.SelectionLength = index + phrase.Length;
            //    newText.Select();
            //    //newText.Select(index, index + phrase.Length);
            //}

            TabPage tabPage = new TabPage(winner.Key);
            tabPage.Name = winner.Key;
            tabPage.Controls.Add(newText);
            outputTabs.Controls.Add(tabPage);
        }


        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
