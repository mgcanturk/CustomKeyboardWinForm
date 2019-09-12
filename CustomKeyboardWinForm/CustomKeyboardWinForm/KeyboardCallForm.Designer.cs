namespace CustomKeyboardWinForm
{
    partial class KeyboardCallForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox.Location = new System.Drawing.Point(7, 6);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(234, 62);
            this.textBox.TabIndex = 0;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(7, 74);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(234, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Open Custom Keyboard";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // KeyboardCallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 252);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "KeyboardCallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KeyboardCallForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button;
    }
}