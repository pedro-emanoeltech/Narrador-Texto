namespace Narrador_Texto
{
    partial class FormNarrar
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
            this.ExecutarNarracaoButton = new System.Windows.Forms.Button();
            this.ConteudoNarrarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExecutarNarracaoButton
            // 
            this.ExecutarNarracaoButton.Location = new System.Drawing.Point(614, 371);
            this.ExecutarNarracaoButton.Name = "ExecutarNarracaoButton";
            this.ExecutarNarracaoButton.Size = new System.Drawing.Size(120, 45);
            this.ExecutarNarracaoButton.TabIndex = 0;
            this.ExecutarNarracaoButton.Text = "Narrar";
            this.ExecutarNarracaoButton.UseVisualStyleBackColor = true;
            // 
            // ConteudoNarrarTextBox
            // 
            this.ConteudoNarrarTextBox.Location = new System.Drawing.Point(16, 32);
            this.ConteudoNarrarTextBox.Multiline = true;
            this.ConteudoNarrarTextBox.Name = "ConteudoNarrarTextBox";
            this.ConteudoNarrarTextBox.Size = new System.Drawing.Size(722, 333);
            this.ConteudoNarrarTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto para narração";
            // 
            // FormNarrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConteudoNarrarTextBox);
            this.Controls.Add(this.ExecutarNarracaoButton);
            this.Name = "FormNarrar";
            this.Text = "Narrador de Texto: by Pedro Emanoe, Emerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecutarNarracaoButton;
        private System.Windows.Forms.TextBox ConteudoNarrarTextBox;
        private System.Windows.Forms.Label label1;
    }
}

