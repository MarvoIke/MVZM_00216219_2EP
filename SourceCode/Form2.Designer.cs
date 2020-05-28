using System.ComponentModel;

namespace parcialDos
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnlF2 = new System.Windows.Forms.Panel();
            this.btnPreoceder = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsrnm = new System.Windows.Forms.TextBox();
            this.lblUsrnm = new System.Windows.Forms.Label();
            this.pnlF2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlF2
            // 
            this.pnlF2.BackColor = System.Drawing.SystemColors.Control;
            this.pnlF2.Controls.Add(this.btnPreoceder);
            this.pnlF2.Controls.Add(this.txtPass);
            this.pnlF2.Controls.Add(this.lblPass);
            this.pnlF2.Controls.Add(this.txtUsrnm);
            this.pnlF2.Controls.Add(this.lblUsrnm);
            this.pnlF2.Location = new System.Drawing.Point(0, 84);
            this.pnlF2.Name = "pnlF2";
            this.pnlF2.Size = new System.Drawing.Size(367, 323);
            this.pnlF2.TabIndex = 0;
            // 
            // btnPreoceder
            // 
            this.btnPreoceder.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnPreoceder.Location = new System.Drawing.Point(135, 250);
            this.btnPreoceder.Name = "btnPreoceder";
            this.btnPreoceder.Size = new System.Drawing.Size(102, 32);
            this.btnPreoceder.TabIndex = 6;
            this.btnPreoceder.Text = "Listo";
            this.btnPreoceder.UseVisualStyleBackColor = true;
            this.btnPreoceder.Click += new System.EventHandler(this.btnPreoceder_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPass.Location = new System.Drawing.Point(84, 171);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(203, 29);
            this.txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPass.Location = new System.Drawing.Point(84, 141);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(200, 27);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Contraseña:";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtUsrnm
            // 
            this.txtUsrnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsrnm.Location = new System.Drawing.Point(84, 84);
            this.txtUsrnm.Name = "txtUsrnm";
            this.txtUsrnm.Size = new System.Drawing.Size(203, 29);
            this.txtUsrnm.TabIndex = 1;
            // 
            // lblUsrnm
            // 
            this.lblUsrnm.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsrnm.Location = new System.Drawing.Point(84, 59);
            this.lblUsrnm.Name = "lblUsrnm";
            this.lblUsrnm.Size = new System.Drawing.Size(156, 22);
            this.lblUsrnm.TabIndex = 0;
            this.lblUsrnm.Text = "Usuario:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (43)))), ((int) (((byte) (110)))));
            this.ClientSize = new System.Drawing.Size(366, 404);
            this.Controls.Add(this.pnlF2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlF2.ResumeLayout(false);
            this.pnlF2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPreoceder;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsrnm;
        private System.Windows.Forms.Panel pnlF2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsrnm;

        #endregion
    }
}