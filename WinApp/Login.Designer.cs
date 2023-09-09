namespace WinApp
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonIngresar = new System.Windows.Forms.Button();
            this.ButtonRegistrarse = new System.Windows.Forms.Button();
            this.ButtonRecuperarContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 38);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(375, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(386, 38);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // ButtonIngresar
            // 
            this.ButtonIngresar.Location = new System.Drawing.Point(590, 264);
            this.ButtonIngresar.Name = "ButtonIngresar";
            this.ButtonIngresar.Size = new System.Drawing.Size(171, 59);
            this.ButtonIngresar.TabIndex = 4;
            this.ButtonIngresar.Text = "Ingresar";
            this.ButtonIngresar.UseVisualStyleBackColor = true;
            this.ButtonIngresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // ButtonRegistrarse
            // 
            this.ButtonRegistrarse.Location = new System.Drawing.Point(588, 338);
            this.ButtonRegistrarse.Name = "ButtonRegistrarse";
            this.ButtonRegistrarse.Size = new System.Drawing.Size(173, 54);
            this.ButtonRegistrarse.TabIndex = 5;
            this.ButtonRegistrarse.Text = "Registrarse";
            this.ButtonRegistrarse.UseVisualStyleBackColor = true;
            this.ButtonRegistrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // ButtonRecuperarContraseña
            // 
            this.ButtonRecuperarContraseña.Location = new System.Drawing.Point(438, 410);
            this.ButtonRecuperarContraseña.Name = "ButtonRecuperarContraseña";
            this.ButtonRecuperarContraseña.Size = new System.Drawing.Size(323, 54);
            this.ButtonRecuperarContraseña.TabIndex = 6;
            this.ButtonRecuperarContraseña.Text = "Recuperar contraseña";
            this.ButtonRecuperarContraseña.UseVisualStyleBackColor = true;
            this.ButtonRecuperarContraseña.Click += new System.EventHandler(this.RecuperarContraseña_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 579);
            this.Controls.Add(this.ButtonRecuperarContraseña);
            this.Controls.Add(this.ButtonRegistrarse);
            this.Controls.Add(this.ButtonIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonIngresar;
        private System.Windows.Forms.Button ButtonRegistrarse;
        private System.Windows.Forms.Button ButtonRecuperarContraseña;
    }
}