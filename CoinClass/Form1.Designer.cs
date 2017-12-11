namespace CoinClass
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
            this.coinListbox = new System.Windows.Forms.ListBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coinListbox
            // 
            this.coinListbox.FormattingEnabled = true;
            this.coinListbox.Location = new System.Drawing.Point(60, 12);
            this.coinListbox.Name = "coinListbox";
            this.coinListbox.Size = new System.Drawing.Size(161, 160);
            this.coinListbox.TabIndex = 0;
            // 
            // tossButton
            // 
            this.tossButton.Location = new System.Drawing.Point(47, 178);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(85, 56);
            this.tossButton.TabIndex = 1;
            this.tossButton.Text = "Toss Five Times";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(146, 178);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 56);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.coinListbox);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox coinListbox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
    }
}

