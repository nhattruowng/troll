namespace WindowsFormsApp1
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
            this.btnCleck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCleck
            // 
            this.btnCleck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCleck.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCleck.Location = new System.Drawing.Point(344, 407);
            this.btnCleck.Name = "btnCleck";
            this.btnCleck.Size = new System.Drawing.Size(287, 113);
            this.btnCleck.TabIndex = 0;
            this.btnCleck.Text = "CLICK ";
            this.btnCleck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCleck.UseVisualStyleBackColor = true;
            this.btnCleck.UseWaitCursor = true;
            this.btnCleck.Click += new System.EventHandler(this.btnCleck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 616);
            this.ControlBox = false;
            this.Controls.Add(this.btnCleck);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "Form1";
            this.Text = "SAY_LAG";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCleck;

        #endregion
    }
}