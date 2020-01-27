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
        private struct Candidate
        {
            public int keywordCount;
            public KeyValuePair<string, string> text;
            public Candidate(KeyValuePair<string, string> subChapter)
            {
                keywordCount = 0;
                text = subChapter;
            }
        }

        public OutputForm(List<string> keyPhrases)
        {
            InitializeComponent();

            //key phrases: get the input from edit text box and split by line
            // look to see which sub chapter has the most key phrases

            //int keywordCount = 0;
            int highestKeywordCount = 0;
            Stack<Candidate> candidates = new Stack<Candidate>();

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
                    Candidate candidate = new Candidate(section);

                    Debug.WriteLine(section.Key + " contains these keyphrases:");

                    string[] words = section.Value.Split(' ');

                    foreach (string phrase in keyPhrases)
                    {
                        //note: seems to grab phrases within words like "crust" in "encrusted"
                        if (section.Value.Contains(phrase))
                        {
                            Debug.Write(phrase + " ");
                            candidate.keywordCount++;
                        }
                    }
                    Debug.WriteLine("");

                    //stack keeps track of who's winning
                    if (candidate.keywordCount >= highestKeywordCount)
                    {
                        Debug.WriteLine("Highest keyword count was: " + highestKeywordCount);
                        candidates.Push(candidate);
                        highestKeywordCount = candidate.keywordCount;
                        Debug.WriteLine("Now it was updated to: " + highestKeywordCount);
                    }

                    //keywordCount = 0;
                }
            }

            // the winners are the ones with the highest keyword count
            List<Candidate> winners = new List<Candidate>();

            while (candidates.Count != 0)
            {
                if (candidates.Peek().keywordCount == highestKeywordCount)
                {
                    Debug.WriteLine("pushed");
                    winners.Add(candidates.Pop());
                }
                else
                {
                    candidates.Pop();
                }
            }

            if (highestKeywordCount != 0)
            {
                Debug.WriteLine("Winners: ");
                foreach (Candidate winner in winners)
                {
                    // each winner should have its own tab and text box
                    Debug.Write(winner.text.Key + " ");

                    TabPage page = new TabPage(winner.text.Key);

                    RichTextBox textBox = new RichTextBox();
                    textBox.MinimumSize = new Size(500, 200);
                    textBox.Multiline = true;
                    textBox.ReadOnly = true;
                    textBox.ScrollBars = RichTextBoxScrollBars.Vertical;
                    textBox.Text = winner.text.Value;

                    HighlightText(keyPhrases, textBox);

                    page.Name = winner.text.Key;
                    page.Controls.Add(textBox);
                    outputTabs.Controls.Add(page);
                }
            }


            //RichTextBox box = new RichTextBox();

            //box.MinimumSize = new Size(500, 200);

            //box.Multiline = true;
            //box.ReadOnly = true;
            //box.ScrollBars = RichTextBoxScrollBars.Vertical;
            //box.Text = winner.Value;

            //TabPage tabPage = new TabPage(winner.Key);
            //tabPage.Name = winner.Key;
            //tabPage.Controls.Add(box);

        }

        private static void HighlightText(List<string> keyPhrases, RichTextBox box)
        {
            foreach (string phrase in keyPhrases)
            {
                int startIndex = 0;
                while (startIndex < box.TextLength)
                {
                    //find the next phrase within the loop
                    int phraseStartIndex = box.Find(phrase, startIndex, RichTextBoxFinds.None);

                    //highlight if there are any words found, -1 means nothing was found
                    if (phraseStartIndex != -1)
                    {
                        //Highlight text 
                        box.SelectionStart = phraseStartIndex;
                        box.SelectionLength = phrase.Length;
                        box.SelectionBackColor = Color.Yellow;
                    }
                    else
                    {
                        break;
                    }

                    //start searching at the end of the word that was just found
                    startIndex += phraseStartIndex + phrase.Length;
                }
            }
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
