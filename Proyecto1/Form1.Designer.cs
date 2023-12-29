namespace Proyecto1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(124, 30);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(128, 9);
            label2.Name = "label2";
            label2.Size = new Size(321, 30);
            label2.TabIndex = 1;
            label2.Text = "REGISTRO DE MATERIAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(139, 30);
            label3.TabIndex = 2;
            label3.Text = "APELLIDO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 201);
            label6.Name = "label6";
            label6.Size = new Size(125, 30);
            label6.TabIndex = 5;
            label6.Text = "MATERIA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(56, 30);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 246);
            label7.Name = "label7";
            label7.Size = new Size(74, 30);
            label7.TabIndex = 6;
            label7.Text = "MAIL";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(182, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 23);
            textBox4.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sistemas operativos", "Redes de datos", "Sistemas digitales", "Base de datos", "Ingles", "Programación", "Matemática" });
            comboBox1.Location = new Point(182, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(182, 295);
            button1.Name = "button1";
            button1.Size = new Size(184, 40);
            button1.TabIndex = 12;
            button1.Text = "INSERTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 360);
            button2.Name = "button2";
            button2.Size = new Size(153, 40);
            button2.TabIndex = 13;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(182, 358);
            button3.Name = "button3";
            button3.Size = new Size(278, 42);
            button3.TabIndex = 14;
            button3.Text = "NUEVO REGISTRO";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(495, 276);
            button4.Name = "button4";
            button4.Size = new Size(178, 59);
            button4.TabIndex = 15;
            button4.Text = "PANTALLA 2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(495, 341);
            button5.Name = "button5";
            button5.Size = new Size(178, 59);
            button5.TabIndex = 16;
            button5.Text = "PANTALLA 3";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(432, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(685, 404);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "PANTALLA PRINCIPAL";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
    }
}