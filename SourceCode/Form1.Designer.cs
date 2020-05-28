namespace parcialDos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlF1 = new System.Windows.Forms.Panel();
            this.lblChar1 = new System.Windows.Forms.Label();
            this.pnlF1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlF1
            // 
            this.pnlF1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlF1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pnlF1.BackgroundImage")));
            this.pnlF1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlF1.Controls.Add(this.lblChar1);
            this.pnlF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlF1.Location = new System.Drawing.Point(0, 0);
            this.pnlF1.Name = "pnlF1";
            this.pnlF1.Size = new System.Drawing.Size(257, 247);
            this.pnlF1.TabIndex = 0;
            this.pnlF1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlF1_Paint);
            // 
            // lblChar1
            // 
            this.lblChar1.BackColor = System.Drawing.Color.Transparent;
            this.lblChar1.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblChar1.ForeColor = System.Drawing.Color.White;
            this.lblChar1.Location = new System.Drawing.Point(0, 171);
            this.lblChar1.Name = "lblChar1";
            this.lblChar1.Size = new System.Drawing.Size(257, 55);
            this.lblChar1.TabIndex = 0;
            this.lblChar1.Text = "Cargando...";
            this.lblChar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(257, 247);
            this.ControlBox = false;
            this.Controls.Add(this.pnlF1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlF1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblChar1;
        private System.Windows.Forms.Panel pnlF1;

        #endregion
    }
}