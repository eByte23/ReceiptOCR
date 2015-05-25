namespace ReceiptOCRForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.autoGammaChk = new System.Windows.Forms.CheckBox();
            this.medianInt = new System.Windows.Forms.NumericUpDown();
            this.medianChk = new System.Windows.Forms.CheckBox();
            this.invertChk = new System.Windows.Forms.CheckBox();
            this.autoLevelChk = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sharpenIntY = new System.Windows.Forms.NumericUpDown();
            this.sharpenIntX = new System.Windows.Forms.NumericUpDown();
            this.sharpenChk = new System.Windows.Forms.CheckBox();
            this.wtThresInt = new System.Windows.Forms.NumericUpDown();
            this.despeckleChk = new System.Windows.Forms.CheckBox();
            this.autoOrientChk = new System.Windows.Forms.CheckBox();
            this.wtThresholdChk = new System.Windows.Forms.CheckBox();
            this.contrastChk = new System.Windows.Forms.CheckBox();
            this.enhanceChk = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageRenderSettings = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.EnhanceTab = new System.Windows.Forms.TabPage();
            this.UnsharpmaskChk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpenIntY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpenIntX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wtThresInt)).BeginInit();
            this.panel1.SuspendLayout();
            this.imageRenderSettings.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.EnhanceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(27, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 536);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(444, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 536);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(903, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(685, 467);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(900, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output Text";
            // 
            // autoGammaChk
            // 
            this.autoGammaChk.AutoSize = true;
            this.autoGammaChk.Location = new System.Drawing.Point(6, 6);
            this.autoGammaChk.Name = "autoGammaChk";
            this.autoGammaChk.Size = new System.Drawing.Size(84, 17);
            this.autoGammaChk.TabIndex = 6;
            this.autoGammaChk.Text = "AutoGamma";
            this.autoGammaChk.UseVisualStyleBackColor = true;
            this.autoGammaChk.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // medianInt
            // 
            this.medianInt.Enabled = false;
            this.medianInt.Location = new System.Drawing.Point(527, 582);
            this.medianInt.Name = "medianInt";
            this.medianInt.Size = new System.Drawing.Size(38, 20);
            this.medianInt.TabIndex = 22;
            this.medianInt.ValueChanged += new System.EventHandler(this.ParamVal_ValueChanged);
            // 
            // medianChk
            // 
            this.medianChk.AutoSize = true;
            this.medianChk.Location = new System.Drawing.Point(616, 629);
            this.medianChk.Name = "medianChk";
            this.medianChk.Size = new System.Drawing.Size(83, 17);
            this.medianChk.TabIndex = 21;
            this.medianChk.Text = "MedianFilter";
            this.medianChk.UseVisualStyleBackColor = true;
            this.medianChk.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // invertChk
            // 
            this.invertChk.AutoSize = true;
            this.invertChk.Location = new System.Drawing.Point(311, 629);
            this.invertChk.Name = "invertChk";
            this.invertChk.Size = new System.Drawing.Size(53, 17);
            this.invertChk.TabIndex = 20;
            this.invertChk.Text = "Invert";
            this.invertChk.UseVisualStyleBackColor = true;
            this.invertChk.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // autoLevelChk
            // 
            this.autoLevelChk.AutoSize = true;
            this.autoLevelChk.Location = new System.Drawing.Point(6, 77);
            this.autoLevelChk.Name = "autoLevelChk";
            this.autoLevelChk.Size = new System.Drawing.Size(74, 17);
            this.autoLevelChk.TabIndex = 19;
            this.autoLevelChk.Text = "AutoLevel";
            this.autoLevelChk.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 744);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Run OCR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 744);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "x";
            // 
            // sharpenIntY
            // 
            this.sharpenIntY.Enabled = false;
            this.sharpenIntY.Location = new System.Drawing.Point(211, 116);
            this.sharpenIntY.Name = "sharpenIntY";
            this.sharpenIntY.Size = new System.Drawing.Size(38, 20);
            this.sharpenIntY.TabIndex = 14;
            this.sharpenIntY.ValueChanged += new System.EventHandler(this.ParamVal_ValueChanged);
            // 
            // sharpenIntX
            // 
            this.sharpenIntX.Enabled = false;
            this.sharpenIntX.Location = new System.Drawing.Point(147, 116);
            this.sharpenIntX.Name = "sharpenIntX";
            this.sharpenIntX.Size = new System.Drawing.Size(38, 20);
            this.sharpenIntX.TabIndex = 13;
            this.sharpenIntX.ValueChanged += new System.EventHandler(this.ParamVal_ValueChanged);
            // 
            // sharpenChk
            // 
            this.sharpenChk.AutoSize = true;
            this.sharpenChk.Location = new System.Drawing.Point(9, 116);
            this.sharpenChk.Name = "sharpenChk";
            this.sharpenChk.Size = new System.Drawing.Size(66, 17);
            this.sharpenChk.TabIndex = 12;
            this.sharpenChk.Text = "Sharpen";
            this.sharpenChk.UseVisualStyleBackColor = true;
            this.sharpenChk.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // wtThresInt
            // 
            this.wtThresInt.Enabled = false;
            this.wtThresInt.Location = new System.Drawing.Point(571, 626);
            this.wtThresInt.Name = "wtThresInt";
            this.wtThresInt.Size = new System.Drawing.Size(39, 20);
            this.wtThresInt.TabIndex = 11;
            this.wtThresInt.ValueChanged += new System.EventHandler(this.ParamVal_ValueChanged);
            // 
            // despeckleChk
            // 
            this.despeckleChk.AutoSize = true;
            this.despeckleChk.Location = new System.Drawing.Point(423, 582);
            this.despeckleChk.Name = "despeckleChk";
            this.despeckleChk.Size = new System.Drawing.Size(77, 17);
            this.despeckleChk.TabIndex = 9;
            this.despeckleChk.Text = "Despeckle";
            this.despeckleChk.UseVisualStyleBackColor = true;
            this.despeckleChk.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // autoOrientChk
            // 
            this.autoOrientChk.AutoSize = true;
            this.autoOrientChk.Location = new System.Drawing.Point(6, 52);
            this.autoOrientChk.Name = "autoOrientChk";
            this.autoOrientChk.Size = new System.Drawing.Size(76, 17);
            this.autoOrientChk.TabIndex = 10;
            this.autoOrientChk.Text = "AutoOrient";
            this.autoOrientChk.UseVisualStyleBackColor = true;
            this.autoOrientChk.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // wtThresholdChk
            // 
            this.wtThresholdChk.AutoSize = true;
            this.wtThresholdChk.Location = new System.Drawing.Point(464, 629);
            this.wtThresholdChk.Name = "wtThresholdChk";
            this.wtThresholdChk.Size = new System.Drawing.Size(101, 17);
            this.wtThresholdChk.TabIndex = 7;
            this.wtThresholdChk.Text = "WhiteThreshold";
            this.wtThresholdChk.UseVisualStyleBackColor = true;
            this.wtThresholdChk.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // contrastChk
            // 
            this.contrastChk.AutoSize = true;
            this.contrastChk.Location = new System.Drawing.Point(6, 29);
            this.contrastChk.Name = "contrastChk";
            this.contrastChk.Size = new System.Drawing.Size(65, 17);
            this.contrastChk.TabIndex = 8;
            this.contrastChk.Text = "Contrast";
            this.contrastChk.UseVisualStyleBackColor = true;
            this.contrastChk.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // enhanceChk
            // 
            this.enhanceChk.AutoSize = true;
            this.enhanceChk.Location = new System.Drawing.Point(6, 6);
            this.enhanceChk.Name = "enhanceChk";
            this.enhanceChk.Size = new System.Drawing.Size(69, 17);
            this.enhanceChk.TabIndex = 0;
            this.enhanceChk.Text = "Enhance";
            this.enhanceChk.UseVisualStyleBackColor = true;
            this.enhanceChk.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.invertChk);
            this.panel1.Controls.Add(this.medianInt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.despeckleChk);
            this.panel1.Controls.Add(this.medianChk);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.wtThresholdChk);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.wtThresInt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 861);
            this.panel1.TabIndex = 8;
            // 
            // imageRenderSettings
            // 
            this.imageRenderSettings.Controls.Add(this.GeneralTab);
            this.imageRenderSettings.Controls.Add(this.EnhanceTab);
            this.imageRenderSettings.Location = new System.Drawing.Point(903, 500);
            this.imageRenderSettings.Name = "imageRenderSettings";
            this.imageRenderSettings.SelectedIndex = 0;
            this.imageRenderSettings.Size = new System.Drawing.Size(685, 373);
            this.imageRenderSettings.TabIndex = 9;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.autoGammaChk);
            this.GeneralTab.Controls.Add(this.contrastChk);
            this.GeneralTab.Controls.Add(this.autoLevelChk);
            this.GeneralTab.Controls.Add(this.autoOrientChk);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTab.Size = new System.Drawing.Size(677, 347);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // EnhanceTab
            // 
            this.EnhanceTab.Controls.Add(this.UnsharpmaskChk);
            this.EnhanceTab.Controls.Add(this.enhanceChk);
            this.EnhanceTab.Controls.Add(this.sharpenChk);
            this.EnhanceTab.Controls.Add(this.sharpenIntY);
            this.EnhanceTab.Controls.Add(this.sharpenIntX);
            this.EnhanceTab.Controls.Add(this.label4);
            this.EnhanceTab.Controls.Add(this.label5);
            this.EnhanceTab.Location = new System.Drawing.Point(4, 22);
            this.EnhanceTab.Name = "EnhanceTab";
            this.EnhanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.EnhanceTab.Size = new System.Drawing.Size(677, 347);
            this.EnhanceTab.TabIndex = 1;
            this.EnhanceTab.Text = "Enhance";
            this.EnhanceTab.UseVisualStyleBackColor = true;
            // 
            // UnsharpmaskChk
            // 
            this.UnsharpmaskChk.AutoSize = true;
            this.UnsharpmaskChk.Location = new System.Drawing.Point(9, 93);
            this.UnsharpmaskChk.Name = "UnsharpmaskChk";
            this.UnsharpmaskChk.Size = new System.Drawing.Size(93, 17);
            this.UnsharpmaskChk.TabIndex = 17;
            this.UnsharpmaskChk.Text = "UnSharpmask";
            this.UnsharpmaskChk.UseVisualStyleBackColor = true;
            this.UnsharpmaskChk.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 885);
            this.Controls.Add(this.imageRenderSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpenIntY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpenIntX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wtThresInt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.imageRenderSettings.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.GeneralTab.PerformLayout();
            this.EnhanceTab.ResumeLayout(false);
            this.EnhanceTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox autoGammaChk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sharpenIntY;
        private System.Windows.Forms.NumericUpDown sharpenIntX;
        private System.Windows.Forms.CheckBox sharpenChk;
        private System.Windows.Forms.NumericUpDown wtThresInt;
        private System.Windows.Forms.CheckBox despeckleChk;
        private System.Windows.Forms.CheckBox autoOrientChk;
        private System.Windows.Forms.CheckBox wtThresholdChk;
        private System.Windows.Forms.CheckBox contrastChk;
        private System.Windows.Forms.CheckBox enhanceChk;
        private System.Windows.Forms.CheckBox autoLevelChk;
        private System.Windows.Forms.CheckBox invertChk;
        private System.Windows.Forms.CheckBox medianChk;
        private System.Windows.Forms.NumericUpDown medianInt;
        private System.Windows.Forms.TabControl imageRenderSettings;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TabPage EnhanceTab;
        private System.Windows.Forms.CheckBox UnsharpmaskChk;
    }
}

