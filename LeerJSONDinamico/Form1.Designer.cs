namespace LeerJSONDinamico
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.tree1 = new System.Windows.Forms.TreeView();
            this.btn2 = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(111, 48);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(133, 85);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "leer Json";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(277, 80);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(563, 23);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "https://raw.githubusercontent.com/LearnWebCode/json-example/refs/heads/master/pet" +
    "s-data.json";
            // 
            // tree1
            // 
            this.tree1.Location = new System.Drawing.Point(111, 139);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(729, 523);
            this.tree1.TabIndex = 2;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(979, 80);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(123, 89);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Leer C#";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 15;
            this.lst1.Location = new System.Drawing.Point(979, 202);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(850, 634);
            this.lst1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1871, 939);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.tree1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private TextBox txt1;
        private TreeView tree1;
        private Button btn2;
        private ListBox lst1;
    }
}