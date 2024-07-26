namespace loginex
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            label1 = new Label();
            txtusuario = new TextBox();
            label2 = new Label();
            txtclave = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 152);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(258, 152);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(229, 31);
            txtusuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 228);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            label2.Click += label2_Click;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(258, 222);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(229, 31);
            txtclave.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(120, 333);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(166, 53);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Iniciar Sesion";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(330, 333);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 53);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(460, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 41);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(606, 508);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtclave);
            Controls.Add(label2);
            Controls.Add(txtusuario);
            Controls.Add(label1);
            Name = "frmlogin";
            Text = "Form1";
            Load += frmlogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtusuario;
        private Label label2;
        private TextBox txtclave;
        private Button btnIngresar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
