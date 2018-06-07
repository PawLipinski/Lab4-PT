namespace Lab4_PT
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
            this.heroGrid = new System.Windows.Forms.DataGridView();
            this.professionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.intelligenceBox = new System.Windows.Forms.NumericUpDown();
            this.strengthBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heroGrid
            // 
            this.heroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.heroGrid.Location = new System.Drawing.Point(12, 12);
            this.heroGrid.Name = "heroGrid";
            this.heroGrid.Size = new System.Drawing.Size(374, 429);
            this.heroGrid.TabIndex = 0;
            // 
            // professionBox
            // 
            this.professionBox.FormattingEnabled = true;
            this.professionBox.Location = new System.Drawing.Point(479, 71);
            this.professionBox.Name = "professionBox";
            this.professionBox.Size = new System.Drawing.Size(121, 21);
            this.professionBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj postać";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profesja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imię";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(479, 45);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 20);
            this.nameBox.TabIndex = 5;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inteligencja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Siła";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(406, 154);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(194, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // intelligenceBox
            // 
            this.intelligenceBox.Location = new System.Drawing.Point(480, 101);
            this.intelligenceBox.Name = "intelligenceBox";
            this.intelligenceBox.Size = new System.Drawing.Size(120, 20);
            this.intelligenceBox.TabIndex = 11;
            // 
            // strengthBox
            // 
            this.strengthBox.Location = new System.Drawing.Point(480, 128);
            this.strengthBox.Name = "strengthBox";
            this.strengthBox.Size = new System.Drawing.Size(120, 20);
            this.strengthBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sortuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.strengthBox);
            this.Controls.Add(this.intelligenceBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.professionBox);
            this.Controls.Add(this.heroGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.heroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strengthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView heroGrid;
        private System.Windows.Forms.ComboBox professionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown intelligenceBox;
        private System.Windows.Forms.NumericUpDown strengthBox;
        private System.Windows.Forms.Button button1;
    }
}

