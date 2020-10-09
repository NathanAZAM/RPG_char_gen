using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Word
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace RPG_char_gen
{
    public partial class Main_window : Form
    {
        public Main_window()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            //Microsoft.Office.Interop.Word.Application oWord;
            //Microsoft.Office.Interop.Word.Document oDoc;
            //oWord = new Microsoft.Office.Interop.Word.Application();
            //oWord.Visible = true;
            //oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            //ref oMissing, ref oMissing);

            //Open template
            Word.Application oWord;
            Word.Document oDoc;
            object oTemplate = "D:\\Projets\\Cpp\\RPG_char_gen\\bin\\Debug\\Templates\\Joueur.dotx";
            oWord = new Word.Application();
            //displays word doc after generation
            oWord.Visible = true;
            ///TODO : add an assert if we dont find the doc
            oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing,
            ref oMissing, ref oMissing);

            ///TODO : condition not working, have to find a isEmpty()
            if (Tbox_name.Text.Length < 1 )
                MessageBox.Show("Character name empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                object playername_bookmark = "player_name";
                oDoc.Bookmarks[ref playername_bookmark].Range.Text = Tbox_name.Text;
            }

            //Close this form.
            this.Close();
        }
    }
}
