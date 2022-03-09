namespace Picture_scroll_bar
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
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteAndBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorNoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonьMirrow1 = new System.Windows.Forms.Button();
            this.buttonMirrow2 = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.pictureBoxInitial = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInitialColor = new System.Windows.Forms.TextBox();
            this.buttonRedraw = new System.Windows.Forms.Button();
            this.pictureBoxWant = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWant = new System.Windows.Forms.TextBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMH = new System.Windows.Forms.TextBox();
            this.textBoxMW = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(400, 400);
            this.panel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.effectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteAndBlackToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.brightToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.colorNoiceToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.effectsToolStripMenuItem.Text = "Effects";
            // 
            // whiteAndBlackToolStripMenuItem
            // 
            this.whiteAndBlackToolStripMenuItem.Name = "whiteAndBlackToolStripMenuItem";
            this.whiteAndBlackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.whiteAndBlackToolStripMenuItem.Text = "White and Black";
            this.whiteAndBlackToolStripMenuItem.Click += new System.EventHandler(this.whiteAndBlackToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // brightToolStripMenuItem
            // 
            this.brightToolStripMenuItem.Name = "brightToolStripMenuItem";
            this.brightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brightToolStripMenuItem.Text = "Bright";
            this.brightToolStripMenuItem.Click += new System.EventHandler(this.brightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // colorNoiceToolStripMenuItem
            // 
            this.colorNoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sepiaToolStripMenuItem,
            this.mosaicToolStripMenuItem});
            this.colorNoiceToolStripMenuItem.Name = "colorNoiceToolStripMenuItem";
            this.colorNoiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorNoiceToolStripMenuItem.Text = "Color noice";
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // mosaicToolStripMenuItem
            // 
            this.mosaicToolStripMenuItem.Name = "mosaicToolStripMenuItem";
            this.mosaicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mosaicToolStripMenuItem.Text = "Mosaic";
            this.mosaicToolStripMenuItem.Click += new System.EventHandler(this.mosaicToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(406, 244);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(25, 25);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonьMirrow1
            // 
            this.buttonьMirrow1.Location = new System.Drawing.Point(406, 182);
            this.buttonьMirrow1.Name = "buttonьMirrow1";
            this.buttonьMirrow1.Size = new System.Drawing.Size(25, 25);
            this.buttonьMirrow1.TabIndex = 18;
            this.buttonьMirrow1.Text = "| ";
            this.buttonьMirrow1.UseVisualStyleBackColor = true;
            this.buttonьMirrow1.Click += new System.EventHandler(this.buttonьMirrow1_Click);
            // 
            // buttonMirrow2
            // 
            this.buttonMirrow2.Location = new System.Drawing.Point(406, 213);
            this.buttonMirrow2.Name = "buttonMirrow2";
            this.buttonMirrow2.Size = new System.Drawing.Size(25, 25);
            this.buttonMirrow2.TabIndex = 17;
            this.buttonMirrow2.Text = "__";
            this.buttonMirrow2.UseVisualStyleBackColor = true;
            this.buttonMirrow2.Click += new System.EventHandler(this.buttonMirrow2_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(406, 151);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(25, 25);
            this.buttonLeft.TabIndex = 16;
            this.buttonLeft.Text = "<-";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(406, 120);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(25, 25);
            this.buttonRight.TabIndex = 15;
            this.buttonRight.Text = "->";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(406, 89);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(25, 25);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(406, 58);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(25, 25);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(406, 27);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(25, 25);
            this.buttonPlus.TabIndex = 11;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // pictureBoxInitial
            // 
            this.pictureBoxInitial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxInitial.Location = new System.Drawing.Point(476, 44);
            this.pictureBoxInitial.Name = "pictureBoxInitial";
            this.pictureBoxInitial.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxInitial.TabIndex = 20;
            this.pictureBoxInitial.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Initial color";
            // 
            // textBoxInitialColor
            // 
            this.textBoxInitialColor.Location = new System.Drawing.Point(552, 63);
            this.textBoxInitialColor.Multiline = true;
            this.textBoxInitialColor.Name = "textBoxInitialColor";
            this.textBoxInitialColor.Size = new System.Drawing.Size(137, 20);
            this.textBoxInitialColor.TabIndex = 22;
            // 
            // buttonRedraw
            // 
            this.buttonRedraw.Location = new System.Drawing.Point(729, 80);
            this.buttonRedraw.Name = "buttonRedraw";
            this.buttonRedraw.Size = new System.Drawing.Size(75, 43);
            this.buttonRedraw.TabIndex = 23;
            this.buttonRedraw.Text = "Redraw";
            this.buttonRedraw.UseVisualStyleBackColor = true;
            this.buttonRedraw.Click += new System.EventHandler(this.buttonRedraw_Click);
            // 
            // pictureBoxWant
            // 
            this.pictureBoxWant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxWant.Location = new System.Drawing.Point(476, 168);
            this.pictureBoxWant.Name = "pictureBoxWant";
            this.pictureBoxWant.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxWant.TabIndex = 24;
            this.pictureBoxWant.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Desired color";
            // 
            // textBoxWant
            // 
            this.textBoxWant.Location = new System.Drawing.Point(552, 187);
            this.textBoxWant.Multiline = true;
            this.textBoxWant.Name = "textBoxWant";
            this.textBoxWant.Size = new System.Drawing.Size(137, 20);
            this.textBoxWant.TabIndex = 26;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(729, 142);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 43);
            this.buttonChoose.TabIndex = 27;
            this.buttonChoose.Text = "Choose color";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(500, 272);
            this.trackBarRed.Maximum = 256;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(251, 45);
            this.trackBarRed.TabIndex = 28;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(500, 313);
            this.trackBarGreen.Maximum = 256;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(251, 45);
            this.trackBarGreen.TabIndex = 29;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(500, 364);
            this.trackBarBlue.Maximum = 256;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(251, 45);
            this.trackBarBlue.TabIndex = 30;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(769, 272);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(73, 20);
            this.textBoxRed.TabIndex = 31;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(769, 313);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(73, 20);
            this.textBoxGreen.TabIndex = 32;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(769, 364);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(73, 20);
            this.textBoxBlue.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Blue";
            // 
            // textBoxMH
            // 
            this.textBoxMH.Location = new System.Drawing.Point(537, 415);
            this.textBoxMH.Name = "textBoxMH";
            this.textBoxMH.Size = new System.Drawing.Size(68, 20);
            this.textBoxMH.TabIndex = 37;
            // 
            // textBoxMW
            // 
            this.textBoxMW.Location = new System.Drawing.Point(627, 415);
            this.textBoxMW.Name = "textBoxMW";
            this.textBoxMW.Size = new System.Drawing.Size(68, 20);
            this.textBoxMW.TabIndex = 38;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(716, 414);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 39;
            this.buttonCreate.Text = "create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 479);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxMW);
            this.Controls.Add(this.textBoxMH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.textBoxWant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxWant);
            this.Controls.Add(this.buttonRedraw);
            this.Controls.Add(this.textBoxInitialColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxInitial);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonьMirrow1);
            this.Controls.Add(this.buttonMirrow2);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonьMirrow1;
        private System.Windows.Forms.Button buttonMirrow2;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.PictureBox pictureBoxInitial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInitialColor;
        private System.Windows.Forms.Button buttonRedraw;
        private System.Windows.Forms.PictureBox pictureBoxWant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWant;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteAndBlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorNoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxMH;
        private System.Windows.Forms.TextBox textBoxMW;
        private System.Windows.Forms.Button buttonCreate;
    }
}

