namespace introJSON
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(144, 107);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(121, 62);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Serializar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(394, 107);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(122, 62);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Deserializar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(144, 218);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(121, 63);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Grabar fichero";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(394, 218);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(122, 63);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Leer fichero";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(144, 330);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 15);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "label1";
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(394, 350);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(122, 80);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "Leer lista";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 15;
            this.lst1.Location = new System.Drawing.Point(577, 359);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(215, 109);
            this.lst1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 566);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Label lbl1;
        private Button btn5;
        private ListBox lst1;
    }
}