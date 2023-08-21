
namespace Counting_Numbers_Project2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textFrom = new System.Windows.Forms.TextBox();
            this.textTo = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbDivisibleNumber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.chBold = new System.Windows.Forms.CheckBox();
            this.chItalic = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            // 
            // textFrom
            // 
            this.textFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFrom.Location = new System.Drawing.Point(147, 33);
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(150, 26);
            this.textFrom.TabIndex = 0;
            this.textFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFrom_KeyPress);
            // 
            // textTo
            // 
            this.textTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTo.Location = new System.Drawing.Point(338, 33);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(151, 26);
            this.textTo.TabIndex = 1;
            this.textTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTo_KeyPress);
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(199, 167);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(98, 31);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(338, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbDivisibleNumber
            // 
            this.cmbDivisibleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDivisibleNumber.FormattingEnabled = true;
            this.cmbDivisibleNumber.Location = new System.Drawing.Point(235, 106);
            this.cmbDivisibleNumber.Name = "cmbDivisibleNumber";
            this.cmbDivisibleNumber.Size = new System.Drawing.Size(192, 28);
            this.cmbDivisibleNumber.TabIndex = 2;
            this.cmbDivisibleNumber.SelectedIndexChanged += new System.EventHandler(this.cmbDivisibleNumber_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Divisible Number";
            // 
            // textOutput
            // 
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput.Location = new System.Drawing.Point(27, 232);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(705, 222);
            this.textOutput.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbYellow);
            this.groupBox1.Controls.Add(this.rbOrange);
            this.groupBox1.Controls.Add(this.rbGreen);
            this.groupBox1.Controls.Add(this.rbBlue);
            this.groupBox1.Controls.Add(this.rbRed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(515, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Colors";
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.Location = new System.Drawing.Point(24, 145);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(72, 21);
            this.rbYellow.TabIndex = 0;
            this.rbYellow.TabStop = true;
            this.rbYellow.Text = "Yellow";
            this.rbYellow.UseVisualStyleBackColor = true;
            this.rbYellow.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Location = new System.Drawing.Point(24, 118);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(80, 21);
            this.rbOrange.TabIndex = 0;
            this.rbOrange.TabStop = true;
            this.rbOrange.Text = "Orange";
            this.rbOrange.UseVisualStyleBackColor = true;
            this.rbOrange.CheckedChanged += new System.EventHandler(this.rbOrange_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(24, 91);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(71, 21);
            this.rbGreen.TabIndex = 0;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(24, 64);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(58, 21);
            this.rbBlue.TabIndex = 0;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Checked = true;
            this.rbRed.Location = new System.Drawing.Point(24, 37);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(55, 21);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // chBold
            // 
            this.chBold.AutoSize = true;
            this.chBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBold.Location = new System.Drawing.Point(50, 154);
            this.chBold.Name = "chBold";
            this.chBold.Size = new System.Drawing.Size(64, 24);
            this.chBold.TabIndex = 3;
            this.chBold.Text = "Bold";
            this.chBold.UseVisualStyleBackColor = true;
            this.chBold.CheckedChanged += new System.EventHandler(this.chBold_CheckedChanged);
            // 
            // chItalic
            // 
            this.chItalic.AutoSize = true;
            this.chItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chItalic.Location = new System.Drawing.Point(50, 184);
            this.chItalic.Name = "chItalic";
            this.chItalic.Size = new System.Drawing.Size(67, 24);
            this.chItalic.TabIndex = 4;
            this.chItalic.Text = "Italic";
            this.chItalic.UseVisualStyleBackColor = true;
            this.chItalic.CheckedChanged += new System.EventHandler(this.chBold_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.chItalic);
            this.Controls.Add(this.chBold);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.cmbDivisibleNumber);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.textFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "c";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFrom;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbDivisibleNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbOrange;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.CheckBox chBold;
        private System.Windows.Forms.CheckBox chItalic;
    }
}

