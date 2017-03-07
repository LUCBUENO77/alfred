namespace JARVIS
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
            this.btnexecuta = new System.Windows.Forms.Button();
            this.rTBTexto = new System.Windows.Forms.RichTextBox();
            this.tkbVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tkbVelecidade = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVelecidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexecuta
            // 
            this.btnexecuta.Location = new System.Drawing.Point(306, 418);
            this.btnexecuta.Name = "btnexecuta";
            this.btnexecuta.Size = new System.Drawing.Size(75, 27);
            this.btnexecuta.TabIndex = 0;
            this.btnexecuta.Text = "Fala";
            this.btnexecuta.UseVisualStyleBackColor = true;
            this.btnexecuta.Click += new System.EventHandler(this.btnexecuta_Click);
            // 
            // rTBTexto
            // 
            this.rTBTexto.Location = new System.Drawing.Point(12, 25);
            this.rTBTexto.Name = "rTBTexto";
            this.rTBTexto.Size = new System.Drawing.Size(369, 245);
            this.rTBTexto.TabIndex = 1;
            this.rTBTexto.Text = "";
            // 
            // tkbVolume
            // 
            this.tkbVolume.Location = new System.Drawing.Point(12, 298);
            this.tkbVolume.Maximum = 100;
            this.tkbVolume.Name = "tkbVolume";
            this.tkbVolume.Size = new System.Drawing.Size(369, 45);
            this.tkbVolume.TabIndex = 2;
            this.tkbVolume.TickFrequency = 10;
            this.tkbVolume.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "velocidade";
            // 
            // tkbVelecidade
            // 
            this.tkbVelecidade.Location = new System.Drawing.Point(12, 362);
            this.tkbVelecidade.Minimum = -10;
            this.tkbVelecidade.Name = "tkbVelecidade";
            this.tkbVelecidade.Size = new System.Drawing.Size(369, 45);
            this.tkbVelecidade.TabIndex = 5;
            this.tkbVelecidade.TickFrequency = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 457);
            this.Controls.Add(this.tkbVelecidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tkbVolume);
            this.Controls.Add(this.rTBTexto);
            this.Controls.Add(this.btnexecuta);
            this.Name = "Form1";
            this.Text = "Fala";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVelecidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexecuta;
        private System.Windows.Forms.RichTextBox rTBTexto;
        private System.Windows.Forms.TrackBar tkbVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tkbVelecidade;
    }
}

