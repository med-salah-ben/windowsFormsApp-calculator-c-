namespace windowsFormsAppDotnet
{
    partial class Calculer_Prix
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnCalculer = new Button();
            button2 = new Button();
            fontDialog1 = new FontDialog();
            label4 = new Label();
            lblResultat = new Label();
            label6 = new Label();
            lblErreur = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 68);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Prix Unitaire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 170);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantité";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 265);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "TVA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(307, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(307, 257);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 23);
            textBox3.TabIndex = 5;
            // 
            // btnCalculer
            // 
            btnCalculer.Location = new Point(143, 341);
            btnCalculer.Name = "btnCalculer";
            btnCalculer.Size = new Size(193, 44);
            btnCalculer.TabIndex = 6;
            btnCalculer.Text = "Calculer";
            btnCalculer.UseVisualStyleBackColor = true;
            btnCalculer.Click += btnCalculer_Click;
            // 
            // button2
            // 
            button2.Location = new Point(439, 341);
            button2.Name = "button2";
            button2.Size = new Size(195, 44);
            button2.TabIndex = 7;
            button2.Text = "Vider";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(632, 260);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 8;
            label4.Text = "%";
            // 
            // lblResultat
            // 
            lblResultat.AutoSize = true;
            lblResultat.Location = new Point(356, 397);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(0, 15);
            lblResultat.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 10;
            label6.Text = "label6";
            // 
            // lblErreur
            // 
            lblErreur.AutoSize = true;
            lblErreur.Location = new Point(58, 402);
            lblErreur.Name = "lblErreur";
            lblErreur.Size = new Size(0, 15);
            lblErreur.TabIndex = 11;
            // 
            // Calculer_Prix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErreur);
            Controls.Add(label6);
            Controls.Add(lblResultat);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(btnCalculer);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculer_Prix";
            Text = "Calculer_Prix";
            Load += Calculer_Prix_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnCalculer;
        private Button button2;
        private FontDialog fontDialog1;
        private Label label4;
        private Label label5;
        private Label lblResultat;
        private Label label6;
        private Label lblErreur;



    }
}