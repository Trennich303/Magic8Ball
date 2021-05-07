
namespace Magic8Ball
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
            this.Button8Ball = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button8Ball
            // 
            this.Button8Ball.BackColor = System.Drawing.Color.Transparent;
            this.Button8Ball.BackgroundImage = global::Magic8Ball.Properties.Resources.clickBall;
            this.Button8Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button8Ball.FlatAppearance.BorderSize = 0;
            this.Button8Ball.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button8Ball.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button8Ball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8Ball.Location = new System.Drawing.Point(128, 44);
            this.Button8Ball.Name = "Button8Ball";
            this.Button8Ball.Size = new System.Drawing.Size(553, 362);
            this.Button8Ball.TabIndex = 0;
            this.Button8Ball.UseVisualStyleBackColor = false;
            this.Button8Ball.Click += new System.EventHandler(this.Button8Ball_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(192, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(413, 51);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Think of a Question";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.Color.DarkRed;
            this.OutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTextBox.Location = new System.Drawing.Point(288, 397);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(500, 41);
            this.OutputTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Button8Ball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button8Ball;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}

