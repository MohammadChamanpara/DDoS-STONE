namespace Stone
{
    partial class MainForm
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGeneratePath = new System.Windows.Forms.Button();
            this.textBoxGeneratePath = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxLoadPath = new System.Windows.Forms.TextBox();
            this.buttonLoadFilePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConvertReportPath = new System.Windows.Forms.Button();
            this.textBoxConvertReportPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConvertToPath = new System.Windows.Forms.Button();
            this.textBoxConvertToPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConvertFromPath = new System.Windows.Forms.Button();
            this.textBoxConvertFromPath = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(206, 59);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.propertyGrid1.Location = new System.Drawing.Point(470, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(320, 428);
            this.propertyGrid1.TabIndex = 1;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonGeneratePath);
            this.groupBox1.Controls.Add(this.textBoxGeneratePath);
            this.groupBox1.Controls.Add(this.buttonGenerate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Dataset ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path :";
            // 
            // buttonGeneratePath
            // 
            this.buttonGeneratePath.Location = new System.Drawing.Point(413, 31);
            this.buttonGeneratePath.Name = "buttonGeneratePath";
            this.buttonGeneratePath.Size = new System.Drawing.Size(24, 23);
            this.buttonGeneratePath.TabIndex = 2;
            this.buttonGeneratePath.Text = "...";
            this.buttonGeneratePath.UseVisualStyleBackColor = true;
            this.buttonGeneratePath.Click += new System.EventHandler(this.buttonGeneratePath_Click);
            // 
            // textBoxGeneratePath
            // 
            this.textBoxGeneratePath.Location = new System.Drawing.Point(80, 33);
            this.textBoxGeneratePath.Name = "textBoxGeneratePath";
            this.textBoxGeneratePath.Size = new System.Drawing.Size(327, 20);
            this.textBoxGeneratePath.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(206, 55);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxLoadPath
            // 
            this.textBoxLoadPath.Location = new System.Drawing.Point(80, 29);
            this.textBoxLoadPath.Name = "textBoxLoadPath";
            this.textBoxLoadPath.Size = new System.Drawing.Size(327, 20);
            this.textBoxLoadPath.TabIndex = 1;
            // 
            // buttonLoadFilePath
            // 
            this.buttonLoadFilePath.Location = new System.Drawing.Point(413, 27);
            this.buttonLoadFilePath.Name = "buttonLoadFilePath";
            this.buttonLoadFilePath.Size = new System.Drawing.Size(24, 23);
            this.buttonLoadFilePath.TabIndex = 2;
            this.buttonLoadFilePath.Text = "...";
            this.buttonLoadFilePath.UseVisualStyleBackColor = true;
            this.buttonLoadFilePath.Click += new System.EventHandler(this.buttonLoadFilePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonLoadFilePath);
            this.groupBox2.Controls.Add(this.textBoxLoadPath);
            this.groupBox2.Controls.Add(this.buttonLoad);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load Dataset ";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(206, 36);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRun);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 85);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Run Stone";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.buttonConvertReportPath);
            this.groupBox4.Controls.Add(this.textBoxConvertReportPath);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonConvertToPath);
            this.groupBox4.Controls.Add(this.textBoxConvertToPath);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.buttonConvertFromPath);
            this.groupBox4.Controls.Add(this.textBoxConvertFromPath);
            this.groupBox4.Controls.Add(this.buttonConvert);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 159);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Generate Dataset ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Report File :";
            // 
            // buttonConvertReportPath
            // 
            this.buttonConvertReportPath.Location = new System.Drawing.Point(413, 82);
            this.buttonConvertReportPath.Name = "buttonConvertReportPath";
            this.buttonConvertReportPath.Size = new System.Drawing.Size(24, 23);
            this.buttonConvertReportPath.TabIndex = 8;
            this.buttonConvertReportPath.Text = "...";
            this.buttonConvertReportPath.UseVisualStyleBackColor = true;
            this.buttonConvertReportPath.Click += new System.EventHandler(this.buttonConvertReportPath_Click);
            // 
            // textBoxConvertReportPath
            // 
            this.textBoxConvertReportPath.Location = new System.Drawing.Point(80, 85);
            this.textBoxConvertReportPath.Name = "textBoxConvertReportPath";
            this.textBoxConvertReportPath.Size = new System.Drawing.Size(327, 20);
            this.textBoxConvertReportPath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output File :";
            // 
            // buttonConvertToPath
            // 
            this.buttonConvertToPath.Location = new System.Drawing.Point(413, 56);
            this.buttonConvertToPath.Name = "buttonConvertToPath";
            this.buttonConvertToPath.Size = new System.Drawing.Size(24, 23);
            this.buttonConvertToPath.TabIndex = 5;
            this.buttonConvertToPath.Text = "...";
            this.buttonConvertToPath.UseVisualStyleBackColor = true;
            this.buttonConvertToPath.Click += new System.EventHandler(this.buttonConvertToPath_Click);
            // 
            // textBoxConvertToPath
            // 
            this.textBoxConvertToPath.Location = new System.Drawing.Point(80, 59);
            this.textBoxConvertToPath.Name = "textBoxConvertToPath";
            this.textBoxConvertToPath.Size = new System.Drawing.Size(327, 20);
            this.textBoxConvertToPath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input File :";
            // 
            // buttonConvertFromPath
            // 
            this.buttonConvertFromPath.Location = new System.Drawing.Point(413, 31);
            this.buttonConvertFromPath.Name = "buttonConvertFromPath";
            this.buttonConvertFromPath.Size = new System.Drawing.Size(24, 23);
            this.buttonConvertFromPath.TabIndex = 2;
            this.buttonConvertFromPath.Text = "...";
            this.buttonConvertFromPath.UseVisualStyleBackColor = true;
            this.buttonConvertFromPath.Click += new System.EventHandler(this.convertFromPathButton_Click);
            // 
            // textBoxConvertFromPath
            // 
            this.textBoxConvertFromPath.Location = new System.Drawing.Point(80, 33);
            this.textBoxConvertFromPath.Name = "textBoxConvertFromPath";
            this.textBoxConvertFromPath.Size = new System.Drawing.Size(327, 20);
            this.textBoxConvertFromPath.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(206, 116);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 428);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGeneratePath;
        private System.Windows.Forms.TextBox textBoxGeneratePath;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxLoadPath;
        private System.Windows.Forms.Button buttonLoadFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonConvertToPath;
        private System.Windows.Forms.TextBox textBoxConvertToPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConvertFromPath;
        private System.Windows.Forms.TextBox textBoxConvertFromPath;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConvertReportPath;
        private System.Windows.Forms.TextBox textBoxConvertReportPath;
    }
}

