namespace draughts
{
    partial class htpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(htpForm));
            this.instructions = new System.Windows.Forms.Label();
            this.htpTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(1, 70);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(484, 112);
            this.instructions.TabIndex = 0;
            this.instructions.Text = resources.GetString("instructions.Text");
            this.instructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // htpTitle
            // 
            this.htpTitle.AutoSize = true;
            this.htpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htpTitle.Location = new System.Drawing.Point(-1, 20);
            this.htpTitle.Name = "htpTitle";
            this.htpTitle.Size = new System.Drawing.Size(113, 25);
            this.htpTitle.TabIndex = 4;
            this.htpTitle.Text = "How to play";
            // 
            // htpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 261);
            this.Controls.Add(this.htpTitle);
            this.Controls.Add(this.instructions);
            this.Name = "htpForm";
            this.Text = "How To Play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Label htpTitle;
    }
}