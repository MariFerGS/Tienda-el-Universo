namespace TiendaelUniversoOrg
{
    partial class Forminico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forminico));
            this.enter = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labname2 = new System.Windows.Forms.Label();
            this.lbname1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enter.BackgroundImage")));
            this.enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enter.FlatAppearance.BorderSize = 0;
            this.enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Location = new System.Drawing.Point(284, 331);
            this.enter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(154, 54);
            this.enter.TabIndex = 1;
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(696, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 15);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labname2
            // 
            this.labname2.AutoSize = true;
            this.labname2.BackColor = System.Drawing.Color.Transparent;
            this.labname2.Font = new System.Drawing.Font("Castellar", 27F);
            this.labname2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labname2.Location = new System.Drawing.Point(164, 37);
            this.labname2.Name = "labname2";
            this.labname2.Size = new System.Drawing.Size(447, 43);
            this.labname2.TabIndex = 4;
            this.labname2.Text = "Tienda el Universo";
            // 
            // lbname1
            // 
            this.lbname1.AutoSize = true;
            this.lbname1.BackColor = System.Drawing.Color.Transparent;
            this.lbname1.Font = new System.Drawing.Font("Castellar", 27F);
            this.lbname1.ForeColor = System.Drawing.Color.Lavender;
            this.lbname1.Location = new System.Drawing.Point(164, 37);
            this.lbname1.Name = "lbname1";
            this.lbname1.Size = new System.Drawing.Size(447, 43);
            this.lbname1.TabIndex = 5;
            this.lbname1.Text = "Tienda el Universo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            // 
            // Forminico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 463);
            this.Controls.Add(this.lbname1);
            this.Controls.Add(this.labname2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Forminico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda El Universo";
            this.Load += new System.EventHandler(this.Forminico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labname2;
        private System.Windows.Forms.Label lbname1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

