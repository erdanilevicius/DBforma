namespace DBforma
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
            this.vardas = new System.Windows.Forms.TextBox();
            this.pavarde = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.adresas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gridas = new System.Windows.Forms.DataGridView();
            this.srcnm = new System.Windows.Forms.TextBox();
            this.srcpv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ieskoti = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.swid = new System.Windows.Forms.TextBox();
            this.swad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridas)).BeginInit();
            this.SuspendLayout();
            // 
            // vardas
            // 
            this.vardas.Location = new System.Drawing.Point(12, 42);
            this.vardas.Name = "vardas";
            this.vardas.Size = new System.Drawing.Size(149, 23);
            this.vardas.TabIndex = 1;
            this.vardas.TextChanged += new System.EventHandler(this.vardas_TextChanged);
            // 
            // pavarde
            // 
            this.pavarde.Location = new System.Drawing.Point(12, 100);
            this.pavarde.Name = "pavarde";
            this.pavarde.Size = new System.Drawing.Size(149, 23);
            this.pavarde.TabIndex = 3;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(12, 158);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(149, 23);
            this.tel.TabIndex = 4;
            this.tel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // adresas
            // 
            this.adresas.Location = new System.Drawing.Point(12, 216);
            this.adresas.Name = "adresas";
            this.adresas.Size = new System.Drawing.Size(149, 23);
            this.adresas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vardas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pavarde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "tel.nr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adresas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Irasyti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridas
            // 
            this.gridas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridas.Location = new System.Drawing.Point(135, 257);
            this.gridas.Name = "gridas";
            this.gridas.RowTemplate.Height = 25;
            this.gridas.Size = new System.Drawing.Size(575, 188);
            this.gridas.TabIndex = 11;
            // 
            // srcnm
            // 
            this.srcnm.Location = new System.Drawing.Point(203, 42);
            this.srcnm.Name = "srcnm";
            this.srcnm.Size = new System.Drawing.Size(149, 23);
            this.srcnm.TabIndex = 12;
            // 
            // srcpv
            // 
            this.srcpv.Location = new System.Drawing.Point(203, 100);
            this.srcpv.Name = "srcpv";
            this.srcpv.Size = new System.Drawing.Size(149, 23);
            this.srcpv.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ieskomas vardas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ieskoma pavarde";
            // 
            // ieskoti
            // 
            this.ieskoti.Location = new System.Drawing.Point(203, 140);
            this.ieskoti.Name = "ieskoti";
            this.ieskoti.Size = new System.Drawing.Size(117, 23);
            this.ieskoti.TabIndex = 16;
            this.ieskoti.Text = "ieskoti";
            this.ieskoti.UseVisualStyleBackColor = true;
            this.ieskoti.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Trinti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(408, 42);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(149, 23);
            this.id.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Trinamas ID";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Rodyti duomenis";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // swid
            // 
            this.swid.Location = new System.Drawing.Point(608, 42);
            this.swid.Name = "swid";
            this.swid.Size = new System.Drawing.Size(149, 23);
            this.swid.TabIndex = 22;
            // 
            // swad
            // 
            this.swad.Location = new System.Drawing.Point(610, 100);
            this.swad.Name = "swad";
            this.swad.Size = new System.Drawing.Size(147, 23);
            this.swad.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Keiciamos eilutes id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Keiciamas adresas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Keisti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.swad);
            this.Controls.Add(this.swid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ieskoti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.srcpv);
            this.Controls.Add(this.srcnm);
            this.Controls.Add(this.gridas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adresas);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.pavarde);
            this.Controls.Add(this.vardas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox vardas;
        private TextBox pavarde;
        private TextBox tel;
        private TextBox adresas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private DataGridView gridas;
        private TextBox srcnm;
        private TextBox srcpv;
        private Label label5;
        private Label label6;
        private Button ieskoti;
        private Button button3;
        private TextBox id;
        private Label label7;
        private Button button4;
        private TextBox swid;
        private TextBox swad;
        private Label label8;
        private Label label9;
        private Button button1;
    }
}