namespace VideoDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.caputureBtn = new System.Windows.Forms.Button();
            this.cropCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFolderText = new System.Windows.Forms.TextBox();
            this.viewFolderBtn = new System.Windows.Forms.Button();
            this.openFolderBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.videoFormatComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resoultionComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.caputureBtn1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 398);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // caputureBtn
            // 
            this.caputureBtn.Location = new System.Drawing.Point(530, 426);
            this.caputureBtn.Name = "caputureBtn";
            this.caputureBtn.Size = new System.Drawing.Size(154, 33);
            this.caputureBtn.TabIndex = 1;
            this.caputureBtn.Text = "样品照片拍照";
            this.caputureBtn.UseVisualStyleBackColor = true;
            this.caputureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // cropCheckbox
            // 
            this.cropCheckbox.AutoSize = true;
            this.cropCheckbox.Location = new System.Drawing.Point(15, 20);
            this.cropCheckbox.Name = "cropCheckbox";
            this.cropCheckbox.Size = new System.Drawing.Size(72, 16);
            this.cropCheckbox.TabIndex = 2;
            this.cropCheckbox.Text = "自动裁切";
            this.cropCheckbox.UseVisualStyleBackColor = true;
            this.cropCheckbox.CheckedChanged += new System.EventHandler(this.cropCheckbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "存储路径:";
            // 
            // saveFolderText
            // 
            this.saveFolderText.Location = new System.Drawing.Point(585, 12);
            this.saveFolderText.Name = "saveFolderText";
            this.saveFolderText.Size = new System.Drawing.Size(260, 21);
            this.saveFolderText.TabIndex = 4;
            // 
            // viewFolderBtn
            // 
            this.viewFolderBtn.Location = new System.Drawing.Point(530, 42);
            this.viewFolderBtn.Name = "viewFolderBtn";
            this.viewFolderBtn.Size = new System.Drawing.Size(154, 23);
            this.viewFolderBtn.TabIndex = 7;
            this.viewFolderBtn.Text = "浏览";
            this.viewFolderBtn.UseVisualStyleBackColor = true;
            this.viewFolderBtn.Click += new System.EventHandler(this.viewFolderBtn_Click);
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.Location = new System.Drawing.Point(691, 42);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Size = new System.Drawing.Size(154, 23);
            this.openFolderBtn.TabIndex = 8;
            this.openFolderBtn.Text = "打开";
            this.openFolderBtn.UseVisualStyleBackColor = true;
            this.openFolderBtn.Click += new System.EventHandler(this.openFolderBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cropCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(530, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.videoFormatComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.resoultionComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.deviceComboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 63);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备信息";
            // 
            // videoFormatComboBox
            // 
            this.videoFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoFormatComboBox.FormattingEnabled = true;
            this.videoFormatComboBox.Location = new System.Drawing.Point(378, 22);
            this.videoFormatComboBox.Name = "videoFormatComboBox";
            this.videoFormatComboBox.Size = new System.Drawing.Size(121, 20);
            this.videoFormatComboBox.TabIndex = 5;
            this.videoFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.videoFormatComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "视频格式";
            // 
            // resoultionComboBox
            // 
            this.resoultionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resoultionComboBox.FormattingEnabled = true;
            this.resoultionComboBox.Location = new System.Drawing.Point(210, 22);
            this.resoultionComboBox.Name = "resoultionComboBox";
            this.resoultionComboBox.Size = new System.Drawing.Size(103, 20);
            this.resoultionComboBox.TabIndex = 3;
            this.resoultionComboBox.SelectedIndexChanged += new System.EventHandler(this.resoultionComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "分辨率";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(54, 22);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(103, 20);
            this.deviceComboBox.TabIndex = 1;
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "设备名";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(851, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 496);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "入库";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox2.Location = new System.Drawing.Point(124, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 21);
            this.textBox2.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "样品ID：";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox13.Location = new System.Drawing.Point(125, 461);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(182, 21);
            this.textBox13.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "样品名称：";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox12.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox12.Location = new System.Drawing.Point(125, 425);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(182, 21);
            this.textBox12.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(5, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "国审编号：";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox11.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox11.Location = new System.Drawing.Point(124, 386);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(182, 21);
            this.textBox11.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(6, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "送样单位：";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox10.Location = new System.Drawing.Point(124, 345);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(182, 21);
            this.textBox10.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(6, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "送样人：";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox9.Location = new System.Drawing.Point(124, 305);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(182, 21);
            this.textBox9.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(6, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "送样时间：";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox8.Location = new System.Drawing.Point(125, 265);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(182, 21);
            this.textBox8.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(6, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "样品数量：";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox7.Location = new System.Drawing.Point(125, 222);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(182, 21);
            this.textBox7.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F);
            this.label13.Location = new System.Drawing.Point(5, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "样品存放地：     ";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox6.Location = new System.Drawing.Point(125, 181);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(182, 21);
            this.textBox6.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F);
            this.label14.Location = new System.Drawing.Point(5, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "样品状态：";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox5.Location = new System.Drawing.Point(125, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 21);
            this.textBox5.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F);
            this.label15.Location = new System.Drawing.Point(5, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "样品照片：";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox4.Location = new System.Drawing.Point(124, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 21);
            this.textBox4.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F);
            this.label16.Location = new System.Drawing.Point(6, 424);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "承诺书照片：";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox3.Location = new System.Drawing.Point(125, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 21);
            this.textBox3.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F);
            this.label17.Location = new System.Drawing.Point(6, 460);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 16;
            this.label17.Text = "入库人：";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F);
            this.button2.Location = new System.Drawing.Point(530, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "打码入库";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // caputureBtn1
            // 
            this.caputureBtn1.Location = new System.Drawing.Point(691, 425);
            this.caputureBtn1.Name = "caputureBtn1";
            this.caputureBtn1.Size = new System.Drawing.Size(154, 33);
            this.caputureBtn1.TabIndex = 32;
            this.caputureBtn1.Text = "承诺书照片拍照";
            this.caputureBtn1.UseVisualStyleBackColor = true;
            this.caputureBtn1.Click += new System.EventHandler(this.caputureBtn1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F);
            this.label18.Location = new System.Drawing.Point(542, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(296, 256);
            this.label18.TabIndex = 12;
            this.label18.Text = resources.GetString("label18.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 510);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.caputureBtn1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.viewFolderBtn);
            this.Controls.Add(this.saveFolderText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caputureBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mysher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button caputureBtn;
        private System.Windows.Forms.CheckBox cropCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saveFolderText;
        private System.Windows.Forms.Button viewFolderBtn;
        private System.Windows.Forms.Button openFolderBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox videoFormatComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox resoultionComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button caputureBtn1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
    }
}

