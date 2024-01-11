namespace quiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonAyikla = new Button();
            labelBaslangic = new Label();
            labelBitis = new Label();
            textBoxBaslangic = new TextBox();
            textBoxBitis = new TextBox();
            richTextBoxCift = new RichTextBox();
            richTextBoxTek = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            buttonStart = new Button();
            buttonStop = new Button();
            buttonReset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonAyikla
            // 
            buttonAyikla.Location = new Point(267, 160);
            buttonAyikla.Name = "buttonAyikla";
            buttonAyikla.Size = new Size(94, 29);
            buttonAyikla.TabIndex = 0;
            buttonAyikla.Text = "Ayıkla";
            buttonAyikla.UseVisualStyleBackColor = true;
            buttonAyikla.Click += buttonAyikla_Click_1;
            // 
            // labelBaslangic
            // 
            labelBaslangic.AutoSize = true;
            labelBaslangic.ForeColor = SystemColors.ActiveCaption;
            labelBaslangic.Location = new Point(97, 76);
            labelBaslangic.Name = "labelBaslangic";
            labelBaslangic.Size = new Size(75, 20);
            labelBaslangic.TabIndex = 1;
            labelBaslangic.Text = "Başlangıç:";
            // 
            // labelBitis
            // 
            labelBitis.AutoSize = true;
            labelBitis.ForeColor = SystemColors.ActiveCaption;
            labelBitis.Location = new Point(97, 138);
            labelBitis.Name = "labelBitis";
            labelBitis.Size = new Size(40, 20);
            labelBitis.TabIndex = 2;
            labelBitis.Text = "Bitiş:";
            // 
            // textBoxBaslangic
            // 
            textBoxBaslangic.BackColor = SystemColors.InactiveCaption;
            textBoxBaslangic.Location = new Point(97, 99);
            textBoxBaslangic.Name = "textBoxBaslangic";
            textBoxBaslangic.Size = new Size(125, 27);
            textBoxBaslangic.TabIndex = 3;
            // 
            // textBoxBitis
            // 
            textBoxBitis.BackColor = SystemColors.InactiveCaption;
            textBoxBitis.Location = new Point(97, 160);
            textBoxBitis.Name = "textBoxBitis";
            textBoxBitis.Size = new Size(125, 27);
            textBoxBitis.TabIndex = 4;
            // 
            // richTextBoxCift
            // 
            richTextBoxCift.BackColor = SystemColors.InactiveCaption;
            richTextBoxCift.Location = new Point(254, 259);
            richTextBoxCift.Name = "richTextBoxCift";
            richTextBoxCift.Size = new Size(107, 101);
            richTextBoxCift.TabIndex = 7;
            richTextBoxCift.Text = "";
            // 
            // richTextBoxTek
            // 
            richTextBoxTek.BackColor = SystemColors.InactiveCaption;
            richTextBoxTek.Location = new Point(97, 259);
            richTextBoxTek.Name = "richTextBoxTek";
            richTextBoxTek.Size = new Size(107, 101);
            richTextBoxTek.TabIndex = 8;
            richTextBoxTek.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(97, 220);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 9;
            label1.Text = "Tek Sayılar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(254, 220);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 10;
            label2.Text = "Çift Sayılar";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(157, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 29);
            progressBar1.TabIndex = 11;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(43, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 12;
            buttonStart.Text = "Başlat";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(301, 2);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(94, 29);
            buttonStop.TabIndex = 13;
            buttonStop.Text = "Bitir";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(176, 37);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "Sıfırla";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(446, 450);
            Controls.Add(buttonReset);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBoxTek);
            Controls.Add(richTextBoxCift);
            Controls.Add(textBoxBitis);
            Controls.Add(textBoxBaslangic);
            Controls.Add(labelBitis);
            Controls.Add(labelBaslangic);
            Controls.Add(buttonAyikla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAyikla;
        private Label labelBaslangic;
        private Label labelBitis;
        private TextBox textBoxBaslangic;
        private TextBox textBoxBitis;
        private RichTextBox richTextBoxCift;
        private RichTextBox richTextBoxTek;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private Button buttonStart;
        private Button buttonStop;
        private Button buttonReset;
        private System.Windows.Forms.Timer timer1;
    }
}
