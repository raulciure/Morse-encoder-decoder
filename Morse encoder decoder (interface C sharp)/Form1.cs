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
using System.Media;
using System.Threading;

namespace Morse_encoder_decoder__interface_C_sharp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Main_code();
        }

        #region Original driver code

        public const int base_time = 80, base_freq = 400;

        string[] table = new string[36];
        string text, proc_text;
        bool audio_stop;

        void Main_code()
        {
            Table_construct();
            Play_label.Visible = Play_label.Visible = true;
        }

        void Table_construct()
        {
            table = File.ReadAllLines("morse.in");
        }
        
        void Uppercase(char[] text)
        {
            for (int i = 0; i<text.Length; i++)
                if (text[i] >= 'a' && text[i] <= 'z') text[i] -= (char) 32;
        }

        void Encode()
        {
            char[] text_char = text.ToCharArray();
            Uppercase(text_char);
            text = new string(text_char);
            //Output_box.Text = text; <-- this works (Uppercase() return char[] reference
            int i, poz;
            for (i = 0; i<text.Length; i++)
            {
                if ((text[i] >= '0' && text[i] <= '9') || (text[i] >= 'A' && text[i] <= 'Z'))
                {
                    poz = Search_encode(text[i]);
                    if (poz != -1) proc_text += table[poz].Substring(1) + " ";
                }
                else
                    if (text[i] == ' ') proc_text += "/ ";
                    else if (text[i] == '\n') proc_text += "\n";
            }
        }
        
        int Search_encode(char x)
        {
            for(int i=0; i<36; i++)
                if (table[i][0]==x) return i;
            return -1;
        }
        
        void Print_encode_non_visual()
        {
            if (proc_text != null)
            {
                char[] proc_text_char = proc_text.ToCharArray();
                for (int i = 0; i < proc_text_char.Length; i++)
                    if (proc_text_char[i] == '0') proc_text_char[i] = '·';          /*
                                                                                    {
                                                                                        proc_text.Remove(i, 1);
                                                                                        proc_text.Insert(i, "o");
                                                                                    }      */
                    else if (proc_text_char[i] == '1') proc_text_char[i] = '−';      /*
                                                                                    {
                                                                                        proc_text.Remove(i, 1);
                                                                                        proc_text.Insert(i, "-");
                                                                                    } */
                proc_text = new string(proc_text_char);
            }
        }

        async void Print_encode_visual()
        {
            Stop_play_button.Enabled = true;
            audio_stop = false;
            Output_box.Text = "";
            Go_button.Enabled = false;
            Play_label.Enabled = Encode_decode_panel.Enabled = false;

            for (int i = 0; i < proc_text.Length; i++)
            {
                if (audio_stop == true) break;
                if (proc_text[i] == '0')
                {
                    Output_box.AppendText("·");
                    Blink_box.BackColor = Color.Blue;
                    await Task.Delay(1);
                    Console.Beep(base_freq, base_time);
                    await Task.Delay(10);
                    Blink_box.BackColor = Color.Transparent;
                    await Task.Delay(base_time);

                }
                else if (proc_text[i] == '1')
                {
                    Output_box.AppendText("−");
                    Blink_box.BackColor = Color.Blue;
                    await Task.Delay(1);
                    Console.Beep(base_freq, 3*base_time);
                    await Task.Delay(10);
                    Blink_box.BackColor = Color.Transparent;
                    await Task.Delay(base_time);
                }
                else
                {
                    if (proc_text[i] == ' ')
                    {
                        Output_box.AppendText(" ");
                        await Task.Delay(base_time);
                    }
                    else
                    {
                        if (proc_text[i] == '/') Output_box.AppendText("/");
                        if (proc_text[i] == '\n') Output_box.AppendText("\n");
                        await Task.Delay(3 * base_time);
                    }
                }
            }

            Stop_play_button.Enabled = false;
            Go_button.Enabled = true;
            Play_label.Enabled = Encode_decode_panel.Enabled = true;
        }
        
        void Decode()
        {
            // only decodes morse text encoded with '0' for short and '1' for long
            string aux;
            int i, j, poz;
            proc_text = "";
            text = To_binary(text);
            for (i = 0; i < text.Length; i++)
            {
                if (text[i] == '1' || text[i] == '0')
                {
                    aux = text.Substring(i, 1);
                    for (j = i + 1; j < text.Length && (text[j] == '0' || text[j] == '1'); j++)
                        aux += text.Substring(j, 1);
                    poz = Search_decode(aux);
                    if (poz != -1) proc_text += table[poz].Substring(0, 1);
                    i = j;
                }
                else if (text[i] == '/') proc_text += " ";
                else if (text[i] == '\n') proc_text += "\n";
            }
        }

        string To_binary(string text)
        {
            string aux="", allowed_content= "·−10";
            for (int i = 0; i < text.Length; i++)
            {
                if (allowed_content.IndexOf(text[i]) == 0) aux += "0";
                else if (allowed_content.IndexOf(text[i]) == 1) aux += "1";
                else aux += text[i];
            }
            return aux;
        }
        
        int Search_decode(string aux)
        {
            for (int i = 0; i < 36; i++)
                if (aux == table[i].Substring(1)) return i;
            return -1;
        }

        #endregion

        private void Go_button_Click(object sender, EventArgs e)
        {
            text = null;
            text = Input_box.Text;
            proc_text = "";

            if (Encode_button.Checked)
           {
                Encode();
                if (Play_on.Checked) Print_encode_visual();
                else
                {
                    Print_encode_non_visual();
                    Output_box.Text = proc_text;
                }
           }
           else
           {
               Decode();
               Output_box.Text = proc_text;
           }
        }

        private void Encode_button_CheckedChanged(object sender, EventArgs e)
        {
            Play_label.Visible = Play_label.Visible = true;
            if (Play_on.Checked)
            {
                Blink_box.Visible = true;
                Stop_play_button.Visible = true;
            }
            else
            {
                Blink_box.Visible = false;
                Stop_play_button.Visible = false;
            }
        }

        private void Decode_button_CheckedChanged(object sender, EventArgs e)
        {
            Play_label.Visible = Play_label.Visible = false;
            Blink_box.Visible = Stop_play_button.Visible = false;
        }

        private void Play_on_CheckedChanged(object sender, EventArgs e)
        {
            Blink_box.Visible = true;
            Stop_play_button.Visible = true;
        }

        private void Play_off_CheckedChanged(object sender, EventArgs e)
        {
            Blink_box.Visible = false;
            Stop_play_button.Visible = false;
            //Stop_play_button.Enabled = false;
        }

        private void Output_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stop_play_button_Click(object sender, EventArgs e)
        {
            audio_stop = true;
            Stop_play_button.Enabled = false;
            Play_label.Enabled = Encode_decode_panel.Enabled = true;
            Go_button.Enabled = true;
        }
    }
}
