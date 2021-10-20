namespace draughts
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
            this.playGameButton = new System.Windows.Forms.Button();
            this.htpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGameButton
            // 
            this.playGameButton.Location = new System.Drawing.Point(157, 76);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(149, 32);
            this.playGameButton.TabIndex = 0;
            this.playGameButton.Text = "Play Game";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // htpButton
            // 
            this.htpButton.Location = new System.Drawing.Point(157, 114);
            this.htpButton.Name = "htpButton";
            this.htpButton.Size = new System.Drawing.Size(149, 32);
            this.htpButton.TabIndex = 1;
            this.htpButton.Text = "How to play? ";
            this.htpButton.UseVisualStyleBackColor = true;
            this.htpButton.Click += new System.EventHandler(this.htpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(157, 152);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit Program";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Draughts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.htpButton);
            this.Controls.Add(this.playGameButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Draughts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button htpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

