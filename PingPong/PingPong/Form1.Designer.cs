namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Playground = new System.Windows.Forms.Panel();
            this.Ball_pctBox = new System.Windows.Forms.PictureBox();
            this.Raket_pctbox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball_pctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raket_pctbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Playground
            // 
            this.Playground.Controls.Add(this.Ball_pctBox);
            this.Playground.Controls.Add(this.Raket_pctbox);
            this.Playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Playground.Location = new System.Drawing.Point(0, 0);
            this.Playground.Name = "Playground";
            this.Playground.Size = new System.Drawing.Size(685, 593);
            this.Playground.TabIndex = 0;
            // 
            // Ball_pctBox
            // 
            this.Ball_pctBox.Location = new System.Drawing.Point(256, 158);
            this.Ball_pctBox.Name = "Ball_pctBox";
            this.Ball_pctBox.Size = new System.Drawing.Size(30, 30);
            this.Ball_pctBox.TabIndex = 1;
            this.Ball_pctBox.TabStop = false;
            // 
            // Raket_pctbox
            // 
            this.Raket_pctbox.BackColor = System.Drawing.Color.Salmon;
            this.Raket_pctbox.Location = new System.Drawing.Point(235, 369);
            this.Raket_pctbox.Name = "Raket_pctbox";
            this.Raket_pctbox.Size = new System.Drawing.Size(200, 20);
            this.Raket_pctbox.TabIndex = 0;
            this.Raket_pctbox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 593);
            this.Controls.Add(this.Playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Playground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ball_pctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raket_pctbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Playground;
        private System.Windows.Forms.PictureBox Ball_pctBox;
        private System.Windows.Forms.PictureBox Raket_pctbox;
        private System.Windows.Forms.Timer timer1;
    }
}

