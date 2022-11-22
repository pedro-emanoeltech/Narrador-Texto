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
            this.components = new System.ComponentModel.Container();
            this.ExecutarNarracaoButton = new System.Windows.Forms.Button();
            this.ConteudoNarrarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VozeslistBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PararNarracaobutton = new System.Windows.Forms.Button();
            this.ConvertendoTextoProgressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ExecutarNarracaoButton
            // 
            this.ExecutarNarracaoButton.Location = new System.Drawing.Point(501, 363);
            this.ExecutarNarracaoButton.Name = "ExecutarNarracaoButton";
            this.ExecutarNarracaoButton.Size = new System.Drawing.Size(120, 45);
            this.ExecutarNarracaoButton.TabIndex = 0;
            this.ExecutarNarracaoButton.Text = "Narrar";
            this.ExecutarNarracaoButton.UseVisualStyleBackColor = true;
            this.ExecutarNarracaoButton.Click += new System.EventHandler(this.ExecutarNarracaoButton_Click);
            // 
            // ConteudoNarrarTextBox
            // 
            this.ConteudoNarrarTextBox.Location = new System.Drawing.Point(16, 32);
            this.ConteudoNarrarTextBox.Multiline = true;
            this.ConteudoNarrarTextBox.Name = "ConteudoNarrarTextBox";
            this.ConteudoNarrarTextBox.Size = new System.Drawing.Size(718, 312);
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
            // VozeslistBox
            // 
            this.VozeslistBox.FormattingEnabled = true;
            this.VozeslistBox.Items.AddRange(new object[] {
            "pt-BR-FranciscaNeural, ",
            "pt-BR-AntonioNeural, ",
            "pt-BR-Daniel, ",
            "pt-BR-HeloisaRUS"});
            this.VozeslistBox.Location = new System.Drawing.Point(16, 363);
            this.VozeslistBox.Name = "VozeslistBox";
            this.VozeslistBox.Size = new System.Drawing.Size(113, 56);
            this.VozeslistBox.TabIndex = 3;
            this.VozeslistBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Voz para narração";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PararNarracaobutton
            // 
            this.PararNarracaobutton.Location = new System.Drawing.Point(627, 363);
            this.PararNarracaobutton.Name = "PararNarracaobutton";
            this.PararNarracaobutton.Size = new System.Drawing.Size(120, 45);
            this.PararNarracaobutton.TabIndex = 5;
            this.PararNarracaobutton.Text = "Parar";
            this.PararNarracaobutton.UseVisualStyleBackColor = true;
            this.PararNarracaobutton.Visible = false;
            this.PararNarracaobutton.Click += new System.EventHandler(this.PararNarracaobutton_Click);
            // 
            // ConvertendoTextoProgressBar
            // 
            this.ConvertendoTextoProgressBar.Location = new System.Drawing.Point(156, 374);
            this.ConvertendoTextoProgressBar.Name = "ConvertendoTextoProgressBar";
            this.ConvertendoTextoProgressBar.Size = new System.Drawing.Size(317, 23);
            this.ConvertendoTextoProgressBar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Convertendo..";
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // FormNarrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConvertendoTextoProgressBar);
            this.Controls.Add(this.PararNarracaobutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VozeslistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConteudoNarrarTextBox);
            this.Controls.Add(this.ExecutarNarracaoButton);
            this.Name = "FormNarrar";
            this.Text = "Narrador de Texto: by Pedro Emanoe, Emerson";
            this.Load += new System.EventHandler(this.FormNarrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecutarNarracaoButton;
        private System.Windows.Forms.TextBox ConteudoNarrarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox VozeslistBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PararNarracaobutton;
        private System.Windows.Forms.ProgressBar ConvertendoTextoProgressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}

