
namespace Morse_encoder_decoder__interface_C_sharp_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Decode_button = new System.Windows.Forms.RadioButton();
            this.Encode_button = new System.Windows.Forms.RadioButton();
            this.Input_box = new System.Windows.Forms.RichTextBox();
            this.Input_label = new System.Windows.Forms.Label();
            this.Output_box = new System.Windows.Forms.RichTextBox();
            this.Output_label = new System.Windows.Forms.Label();
            this.Blink_box = new System.Windows.Forms.PictureBox();
            this.Go_button = new System.Windows.Forms.Button();
            this.Play_off = new System.Windows.Forms.RadioButton();
            this.Play_on = new System.Windows.Forms.RadioButton();
            this.Stop_play_button = new System.Windows.Forms.Button();
            this.Play_label = new System.Windows.Forms.GroupBox();
            this.Encode_decode_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Blink_box)).BeginInit();
            this.Play_label.SuspendLayout();
            this.Encode_decode_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Decode_button
            // 
            this.Decode_button.AutoSize = true;
            this.Decode_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decode_button.Location = new System.Drawing.Point(9, 48);
            this.Decode_button.Margin = new System.Windows.Forms.Padding(4);
            this.Decode_button.Name = "Decode_button";
            this.Decode_button.Size = new System.Drawing.Size(193, 32);
            this.Decode_button.TabIndex = 8;
            this.Decode_button.Text = "Decodificare";
            this.Decode_button.UseVisualStyleBackColor = true;
            this.Decode_button.CheckedChanged += new System.EventHandler(this.Decode_button_CheckedChanged);
            // 
            // Encode_button
            // 
            this.Encode_button.AutoSize = true;
            this.Encode_button.Checked = true;
            this.Encode_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encode_button.Location = new System.Drawing.Point(8, 9);
            this.Encode_button.Margin = new System.Windows.Forms.Padding(4);
            this.Encode_button.Name = "Encode_button";
            this.Encode_button.Size = new System.Drawing.Size(167, 32);
            this.Encode_button.TabIndex = 0;
            this.Encode_button.TabStop = true;
            this.Encode_button.Text = "Codificare";
            this.Encode_button.UseVisualStyleBackColor = true;
            this.Encode_button.CheckedChanged += new System.EventHandler(this.Encode_button_CheckedChanged);
            // 
            // Input_box
            // 
            this.Input_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input_box.DetectUrls = false;
            this.Input_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_box.Location = new System.Drawing.Point(18, 735);
            this.Input_box.Margin = new System.Windows.Forms.Padding(4);
            this.Input_box.Name = "Input_box";
            this.Input_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Input_box.Size = new System.Drawing.Size(1729, 242);
            this.Input_box.TabIndex = 1;
            this.Input_box.Text = "";
            // 
            // Input_label
            // 
            this.Input_label.AutoSize = true;
            this.Input_label.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_label.Location = new System.Drawing.Point(18, 696);
            this.Input_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Input_label.Name = "Input_label";
            this.Input_label.Size = new System.Drawing.Size(300, 33);
            this.Input_label.TabIndex = 2;
            this.Input_label.Text = "Introduceti textul:";
            // 
            // Output_box
            // 
            this.Output_box.BackColor = System.Drawing.SystemColors.Window;
            this.Output_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output_box.DetectUrls = false;
            this.Output_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_box.Location = new System.Drawing.Point(18, 423);
            this.Output_box.Margin = new System.Windows.Forms.Padding(4);
            this.Output_box.Name = "Output_box";
            this.Output_box.ReadOnly = true;
            this.Output_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Output_box.Size = new System.Drawing.Size(1729, 242);
            this.Output_box.TabIndex = 3;
            this.Output_box.Text = "";
            this.Output_box.TextChanged += new System.EventHandler(this.Output_box_TextChanged);
            // 
            // Output_label
            // 
            this.Output_label.AutoSize = true;
            this.Output_label.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_label.Location = new System.Drawing.Point(18, 381);
            this.Output_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(225, 33);
            this.Output_label.TabIndex = 4;
            this.Output_label.Text = "Text procesat:";
            // 
            // Blink_box
            // 
            this.Blink_box.BackColor = System.Drawing.Color.Transparent;
            this.Blink_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Blink_box.Location = new System.Drawing.Point(510, 51);
            this.Blink_box.Margin = new System.Windows.Forms.Padding(4);
            this.Blink_box.Name = "Blink_box";
            this.Blink_box.Size = new System.Drawing.Size(749, 269);
            this.Blink_box.TabIndex = 5;
            this.Blink_box.TabStop = false;
            this.Blink_box.Visible = false;
            // 
            // Go_button
            // 
            this.Go_button.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_button.Location = new System.Drawing.Point(1500, 1023);
            this.Go_button.Margin = new System.Windows.Forms.Padding(4);
            this.Go_button.Name = "Go_button";
            this.Go_button.Size = new System.Drawing.Size(249, 75);
            this.Go_button.TabIndex = 6;
            this.Go_button.Text = "Procesare";
            this.Go_button.UseVisualStyleBackColor = true;
            this.Go_button.Click += new System.EventHandler(this.Go_button_Click);
            // 
            // Play_off
            // 
            this.Play_off.AutoSize = true;
            this.Play_off.Checked = true;
            this.Play_off.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_off.Location = new System.Drawing.Point(9, 82);
            this.Play_off.Margin = new System.Windows.Forms.Padding(4);
            this.Play_off.Name = "Play_off";
            this.Play_off.Size = new System.Drawing.Size(180, 32);
            this.Play_off.TabIndex = 1;
            this.Play_off.TabStop = true;
            this.Play_off.Text = "Dezactivată";
            this.Play_off.UseVisualStyleBackColor = true;
            this.Play_off.CheckedChanged += new System.EventHandler(this.Play_off_CheckedChanged);
            // 
            // Play_on
            // 
            this.Play_on.AutoSize = true;
            this.Play_on.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_on.Location = new System.Drawing.Point(9, 46);
            this.Play_on.Margin = new System.Windows.Forms.Padding(4);
            this.Play_on.Name = "Play_on";
            this.Play_on.Size = new System.Drawing.Size(141, 32);
            this.Play_on.TabIndex = 0;
            this.Play_on.Text = "Activată";
            this.Play_on.UseVisualStyleBackColor = true;
            this.Play_on.CheckedChanged += new System.EventHandler(this.Play_on_CheckedChanged);
            // 
            // Stop_play_button
            // 
            this.Stop_play_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Stop_play_button.Enabled = false;
            this.Stop_play_button.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_play_button.Location = new System.Drawing.Point(1450, 111);
            this.Stop_play_button.Margin = new System.Windows.Forms.Padding(4);
            this.Stop_play_button.Name = "Stop_play_button";
            this.Stop_play_button.Size = new System.Drawing.Size(150, 150);
            this.Stop_play_button.TabIndex = 9;
            this.Stop_play_button.Text = "Stop";
            this.Stop_play_button.UseVisualStyleBackColor = true;
            this.Stop_play_button.Visible = false;
            this.Stop_play_button.Click += new System.EventHandler(this.Stop_play_button_Click);
            // 
            // Play_label
            // 
            this.Play_label.Controls.Add(this.Play_off);
            this.Play_label.Controls.Add(this.Play_on);
            this.Play_label.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_label.Location = new System.Drawing.Point(18, 134);
            this.Play_label.Margin = new System.Windows.Forms.Padding(4);
            this.Play_label.Name = "Play_label";
            this.Play_label.Padding = new System.Windows.Forms.Padding(4);
            this.Play_label.Size = new System.Drawing.Size(368, 150);
            this.Play_label.TabIndex = 10;
            this.Play_label.TabStop = false;
            this.Play_label.Text = "Redare audio/video";
            // 
            // Encode_decode_panel
            // 
            this.Encode_decode_panel.Controls.Add(this.Decode_button);
            this.Encode_decode_panel.Controls.Add(this.Encode_button);
            this.Encode_decode_panel.Location = new System.Drawing.Point(18, 985);
            this.Encode_decode_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Encode_decode_panel.Name = "Encode_decode_panel";
            this.Encode_decode_panel.Size = new System.Drawing.Size(258, 93);
            this.Encode_decode_panel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1761, 1107);
            this.Controls.Add(this.Play_label);
            this.Controls.Add(this.Stop_play_button);
            this.Controls.Add(this.Go_button);
            this.Controls.Add(this.Blink_box);
            this.Controls.Add(this.Output_label);
            this.Controls.Add(this.Output_box);
            this.Controls.Add(this.Input_label);
            this.Controls.Add(this.Input_box);
            this.Controls.Add(this.Encode_decode_panel);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Codificator & Decodificator Morse";
            ((System.ComponentModel.ISupportInitialize)(this.Blink_box)).EndInit();
            this.Play_label.ResumeLayout(false);
            this.Play_label.PerformLayout();
            this.Encode_decode_panel.ResumeLayout(false);
            this.Encode_decode_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Input_box;
        private System.Windows.Forms.Label Input_label;
        private System.Windows.Forms.RichTextBox Output_box;
        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.PictureBox Blink_box;
        private System.Windows.Forms.Button Go_button;
        private System.Windows.Forms.RadioButton Encode_button;
        private System.Windows.Forms.RadioButton Decode_button;
        private System.Windows.Forms.RadioButton Play_off;
        private System.Windows.Forms.RadioButton Play_on;
        private System.Windows.Forms.Button Stop_play_button;
        private System.Windows.Forms.GroupBox Play_label;
        private System.Windows.Forms.Panel Encode_decode_panel;
    }
}

