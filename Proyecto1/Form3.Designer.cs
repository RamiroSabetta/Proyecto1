namespace Proyecto1
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            MAIL = new DataGridViewTextBoxColumn();
            MATERIA = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NOMBRE, APELLIDO, MAIL, MATERIA, DNI });
            dataGridView1.Location = new Point(12, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 221);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(144, 9);
            label2.Name = "label2";
            label2.Size = new Size(320, 30);
            label2.TabIndex = 13;
            label2.Text = "INFORMACIÓN GENERAL";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Nachlieli CLM", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(403, 340);
            button2.Name = "button2";
            button2.Size = new Size(153, 40);
            button2.TabIndex = 19;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            APELLIDO.HeaderText = "APELLIDO";
            APELLIDO.Name = "APELLIDO";
            // 
            // MAIL
            // 
            MAIL.HeaderText = "DNI";
            MAIL.Name = "MAIL";
            // 
            // MATERIA
            // 
            MATERIA.HeaderText = "MATERIA";
            MATERIA.Name = "MATERIA";
            // 
            // DNI
            // 
            DNI.HeaderText = "MAIL";
            DNI.Name = "DNI";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(568, 392);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Button button2;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn MAIL;
        private DataGridViewTextBoxColumn G;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn MATERIA;
    }
}