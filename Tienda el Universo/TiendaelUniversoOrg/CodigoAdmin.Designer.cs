namespace TiendaelUniversoOrg
{
    partial class CodigoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodigoAdmin));
            this.tx_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regresar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tx_user
            // 
            this.tx_user.Location = new System.Drawing.Point(185, 11);
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(160, 20);
            this.tx_user.TabIndex = 5;
            this.tx_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_user_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de  Usuario:";
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.Transparent;
            this.regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regresar.BackgroundImage")));
            this.regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regresar.FlatAppearance.BorderSize = 0;
            this.regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar.Location = new System.Drawing.Point(12, 76);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(110, 31);
            this.regresar.TabIndex = 7;
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.Color.Transparent;
            this.aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptar.BackgroundImage")));
            this.aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aceptar.FlatAppearance.BorderSize = 0;
            this.aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(243, 76);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(102, 31);
            this.aceptar.TabIndex = 6;
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña:";
            // 
            // tx_password
            // 
            this.tx_password.Location = new System.Drawing.Point(184, 42);
            this.tx_password.Name = "tx_password";
            this.tx_password.PasswordChar = '*';
            this.tx_password.Size = new System.Drawing.Size(160, 20);
            this.tx_password.TabIndex = 9;
            this.tx_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_password_KeyPress);
            // 
            // CodigoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 112);
            this.Controls.Add(this.tx_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.tx_user);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CodigoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CodigoAdmincs";
            this.Load += new System.EventHandler(this.CodigoAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox tx_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_password;
    }
}