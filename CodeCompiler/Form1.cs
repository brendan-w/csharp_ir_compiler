using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCompiler
{
    public partial class Form1 : Form
    {

        private Manager mgr;

        public Form1()
        {
            InitializeComponent();

            CodeType.Items.Add("tv");
            CodeType.Items.Add("projector");
            CodeType.Items.Add("source");
            CodeType.Items.Add("light");
            CodeType.SelectedIndex = 0;

            CodeName.Items.Add("POWER_ON");
            CodeName.Items.Add("POWER_OFF");
            CodeName.Items.Add("MUTE");
            CodeName.Items.Add("VOLUME_UP");
            CodeName.Items.Add("VOLUME_DOWN");
            CodeName.Items.Add("CHANNEL_UP");
            CodeName.Items.Add("CHANNEL_DOWN");
            CodeName.Items.Add("PLAY");
            CodeName.Items.Add("PAUSE");
            CodeName.Items.Add("NEXT_TRACK");
            CodeName.Items.Add("PREVIOUS_TRACK");
            CodeName.SelectedIndex = 0;

            mgr = new Manager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            if ((Input.Text != "") && (Brand.Text != ""))
            {
                Input.Text = Input.Text.Replace('\n', ' ');
                Input.Text = Input.Text.Replace('\r', ' ');
                Input.Text = trim(Input.Text, ' ');
                mgr.addCode(new Code("code_" + Brand.Text + "_" + CodeType.Text + "_" + CodeName.Text, Input.Text));
                EnteredCodes.Items.Add(CodeName.Text);
                Input.Text = "";
                if (CodeName.SelectedIndex < CodeName.Items.Count - 1)
                {
                    CodeName.SelectedIndex++;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //compile
            String dictName = "dict_" + Brand.Text + "_" + CodeType.Text;
            mgr.run();
            Output.Text = "const BurstPair " + dictName + "[] PROGMEM = " + mgr.GetDict() + ";";
            Output.Text += Environment.NewLine + Environment.NewLine + mgr.ToCode();
            Output.Text += Environment.NewLine + Environment.NewLine + mgr.GetEntries(dictName);
        }


        private String trim(String text, char character)
        {
            String c = character.ToString();
            String twoC = c + c;

            while (text.Contains(twoC))
            {
                text = text.Replace(twoC, c);
            }
            //trim edges (causes extraneous elements with .Split())
            if (text.StartsWith(c)) { text = text.Remove(0, 1); }
            if (text.EndsWith(c)) { text = text.Remove(text.Length - 1, 1); }

            return text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mgr.reset();
            Input.Clear();
            Output.Clear();
            EnteredCodes.Items.Clear();
        }
    }
}
