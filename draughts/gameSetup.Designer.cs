namespace draughts
{
    partial class gameSetup
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
            this.menuButton = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.timeLimitLabel = new System.Windows.Forms.Label();
            this.p1ColourLabel = new System.Windows.Forms.Label();
            this.p2ColourLabel = new System.Windows.Forms.Label();
            this.timeLimitCombo = new System.Windows.Forms.ComboBox();
            this.p1ColourCombo = new System.Windows.Forms.ComboBox();
            this.p2ColourCombo = new System.Windows.Forms.ComboBox();
            this.p1cRequired = new System.Windows.Forms.Label();
            this.p2cRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(21, 209);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(124, 40);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(151, 209);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(124, 40);
            this.startGame.TabIndex = 1;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // timeLimitLabel
            // 
            this.timeLimitLabel.AutoSize = true;
            this.timeLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLimitLabel.Location = new System.Drawing.Point(27, 45);
            this.timeLimitLabel.Name = "timeLimitLabel";
            this.timeLimitLabel.Size = new System.Drawing.Size(118, 17);
            this.timeLimitLabel.TabIndex = 2;
            this.timeLimitLabel.Text = "Game Time Limit:";
            // 
            // p1ColourLabel
            // 
            this.p1ColourLabel.AutoSize = true;
            this.p1ColourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ColourLabel.Location = new System.Drawing.Point(27, 74);
            this.p1ColourLabel.Name = "p1ColourLabel";
            this.p1ColourLabel.Size = new System.Drawing.Size(128, 17);
            this.p1ColourLabel.TabIndex = 3;
            this.p1ColourLabel.Text = "Player One Colour:";
            // 
            // p2ColourLabel
            // 
            this.p2ColourLabel.AutoSize = true;
            this.p2ColourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ColourLabel.Location = new System.Drawing.Point(27, 104);
            this.p2ColourLabel.Name = "p2ColourLabel";
            this.p2ColourLabel.Size = new System.Drawing.Size(127, 17);
            this.p2ColourLabel.TabIndex = 4;
            this.p2ColourLabel.Text = "Player Two Colour:";
            // 
            // timeLimitCombo
            // 
            this.timeLimitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeLimitCombo.FormattingEnabled = true;
            this.timeLimitCombo.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.timeLimitCombo.Location = new System.Drawing.Point(167, 45);
            this.timeLimitCombo.Name = "timeLimitCombo";
            this.timeLimitCombo.Size = new System.Drawing.Size(121, 21);
            this.timeLimitCombo.TabIndex = 5;
            this.timeLimitCombo.SelectedIndexChanged += new System.EventHandler(this.timeLimitCombo_SelectedIndexChanged);
            // 
            // p1ColourCombo
            // 
            this.p1ColourCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p1ColourCombo.FormattingEnabled = true;
            this.p1ColourCombo.Items.AddRange(new object[] {
            "White",
            "Red"});
            this.p1ColourCombo.Location = new System.Drawing.Point(167, 74);
            this.p1ColourCombo.Name = "p1ColourCombo";
            this.p1ColourCombo.Size = new System.Drawing.Size(121, 21);
            this.p1ColourCombo.TabIndex = 6;
            this.p1ColourCombo.SelectedIndexChanged += new System.EventHandler(this.p1ColourCombo_SelectedIndexChanged);
            // 
            // p2ColourCombo
            // 
            this.p2ColourCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p2ColourCombo.FormattingEnabled = true;
            this.p2ColourCombo.Items.AddRange(new object[] {
            "White",
            "Red"});
            this.p2ColourCombo.Location = new System.Drawing.Point(167, 104);
            this.p2ColourCombo.Name = "p2ColourCombo";
            this.p2ColourCombo.Size = new System.Drawing.Size(121, 21);
            this.p2ColourCombo.TabIndex = 7;
            this.p2ColourCombo.SelectedIndexChanged += new System.EventHandler(this.p2ColourCombo_SelectedIndexChanged);
            // 
            // p1cRequired
            // 
            this.p1cRequired.AutoSize = true;
            this.p1cRequired.BackColor = System.Drawing.SystemColors.Control;
            this.p1cRequired.Cursor = System.Windows.Forms.Cursors.Default;
            this.p1cRequired.ForeColor = System.Drawing.Color.DarkRed;
            this.p1cRequired.Location = new System.Drawing.Point(295, 74);
            this.p1cRequired.Name = "p1cRequired";
            this.p1cRequired.Size = new System.Drawing.Size(45, 13);
            this.p1cRequired.TabIndex = 8;
            this.p1cRequired.Text = "required";
            // 
            // p2cRequired
            // 
            this.p2cRequired.AutoSize = true;
            this.p2cRequired.ForeColor = System.Drawing.Color.DarkRed;
            this.p2cRequired.Location = new System.Drawing.Point(295, 104);
            this.p2cRequired.Name = "p2cRequired";
            this.p2cRequired.Size = new System.Drawing.Size(45, 13);
            this.p2cRequired.TabIndex = 9;
            this.p2cRequired.Text = "required";
            // 
            // gameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 261);
            this.Controls.Add(this.p2cRequired);
            this.Controls.Add(this.p1cRequired);
            this.Controls.Add(this.p2ColourCombo);
            this.Controls.Add(this.p1ColourCombo);
            this.Controls.Add(this.timeLimitCombo);
            this.Controls.Add(this.p2ColourLabel);
            this.Controls.Add(this.p1ColourLabel);
            this.Controls.Add(this.timeLimitLabel);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.menuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "gameSetup";
            this.Text = "Game Setup Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label timeLimitLabel;
        private System.Windows.Forms.Label p1ColourLabel;
        private System.Windows.Forms.Label p2ColourLabel;
        private System.Windows.Forms.ComboBox timeLimitCombo;
        private System.Windows.Forms.ComboBox p1ColourCombo;
        private System.Windows.Forms.ComboBox p2ColourCombo;
        private System.Windows.Forms.Label p1cRequired;
        private System.Windows.Forms.Label p2cRequired;
    }
}