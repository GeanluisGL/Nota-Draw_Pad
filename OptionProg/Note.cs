using OptionProg;
using Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Principal
{
    public partial class Note : Form
    {

        [System.ComponentModel.Browsable(false)]
        public System.Drawing.Color SelectionColor { get; set; }
        string filePath = "";
        FontDialog fontDialog1 = new FontDialog();
        RichTextBox richTextBox1 = new RichTextBox();
        SaveFileDialog sfd = new SaveFileDialog();
        public string contents = string.Empty;
        //string to hold file location
        string currentFileLoc;



        public Note()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true, Multiselect = false })
            {



                DialogResult = MessageBox.Show("¿Desa crear un nuevo documento sin guardar?", "Salir sin guardar", MessageBoxButtons.YesNoCancel);

                if (DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    textBox1.Clear();
                }
                else
                {

                    if (DialogResult == System.Windows.Forms.DialogResult.No)
                    {
                        SaveFile();
                    }
                    else
                    {
                        if (DialogResult == System.Windows.Forms.DialogResult.Cancel)
                        {

                        }


                    }
                    // Closes the parent form.

                }


            }

        }



        private void Openbtn_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        filePath = ofd.FileName;
                        Task<string> text = sr.ReadToEndAsync();
                        textBox1.Text = text.Result;
                    }
                }
            }


        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private int SaveFile()
        {
            sfd.Filter = "Text Documents|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                textBox1.Focus();
                return 0;
            }
            else
            {
                contents = textBox1.Text;
                if (this.Text == "Untitled")
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                else
                {
                    sfd.FileName = this.Text;
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = sfd.FileName;
                //
                currentFileLoc = sfd.FileName;
                return 1;
            }
        }

        private void Returnbutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Prinp prinp = new Prinp();
            prinp.Show();
        }

        private void Copybtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);

        }

        private void Cutbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
                textBox1.Cut();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            textBox1.Paste();

        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            //ColorDialog colorDialog1 = new ColorDialog();
            //colorDialog1.Color = richTextBox1.SelectionColor;
            //if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            //    colorDialog1.Color != richTextBox1.SelectionColor)
            //{
            //    // Change the selection color to the user specified color.
            //    richTextBox1.SelectionColor = colorDialog1.Color;
            //}
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {

            fontDialog1.ShowColor = true;

            fontDialog1.Font = textBox1.Font;
            fontDialog1.Color = textBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }

        }
    }
}
