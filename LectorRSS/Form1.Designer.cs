namespace LectorRSS
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
            this.titulosComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.descripcionWebBrowser = new System.Windows.Forms.WebBrowser();
            this.canalesListBox = new System.Windows.Forms.ListBox();
            this.fuenteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fuenteLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.borrarButton = new System.Windows.Forms.Button();
            this.proxyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulosComboBox
            // 
            this.titulosComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulosComboBox.FormattingEnabled = true;
            this.titulosComboBox.Location = new System.Drawing.Point(417, 63);
            this.titulosComboBox.Name = "titulosComboBox";
            this.titulosComboBox.Size = new System.Drawing.Size(655, 21);
            this.titulosComboBox.TabIndex = 1;
            this.titulosComboBox.SelectedIndexChanged += new System.EventHandler(this.titulosComboBox_SelectedIndexChanged);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionTextBox.Location = new System.Drawing.Point(417, 110);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(655, 64);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // descripcionWebBrowser
            // 
            this.descripcionWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionWebBrowser.Location = new System.Drawing.Point(12, 202);
            this.descripcionWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.descripcionWebBrowser.Name = "descripcionWebBrowser";
            this.descripcionWebBrowser.Size = new System.Drawing.Size(1060, 348);
            this.descripcionWebBrowser.TabIndex = 5;
            // 
            // canalesListBox
            // 
            this.canalesListBox.FormattingEnabled = true;
            this.canalesListBox.Location = new System.Drawing.Point(12, 40);
            this.canalesListBox.Name = "canalesListBox";
            this.canalesListBox.Size = new System.Drawing.Size(399, 134);
            this.canalesListBox.TabIndex = 6;
            this.canalesListBox.SelectedIndexChanged += new System.EventHandler(this.canalesListBox_SelectedIndexChanged);
            // 
            // fuenteTextBox
            // 
            this.fuenteTextBox.Location = new System.Drawing.Point(58, 8);
            this.fuenteTextBox.Name = "fuenteTextBox";
            this.fuenteTextBox.Size = new System.Drawing.Size(273, 20);
            this.fuenteTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Noticias:";
            // 
            // fuenteLabel
            // 
            this.fuenteLabel.AutoSize = true;
            this.fuenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuenteLabel.Location = new System.Drawing.Point(413, 9);
            this.fuenteLabel.Name = "fuenteLabel";
            this.fuenteLabel.Size = new System.Drawing.Size(64, 20);
            this.fuenteLabel.TabIndex = 14;
            this.fuenteLabel.Text = "Fuente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Navegador:";
            // 
            // agregarButton
            // 
            this.agregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarButton.FlatAppearance.BorderSize = 0;
            this.agregarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.agregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarButton.Image = global::LectorRSS.Properties.Resources.add;
            this.agregarButton.Location = new System.Drawing.Point(337, 1);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(34, 34);
            this.agregarButton.TabIndex = 9;
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // borrarButton
            // 
            this.borrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrarButton.FlatAppearance.BorderSize = 0;
            this.borrarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.borrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarButton.Image = global::LectorRSS.Properties.Resources.delete;
            this.borrarButton.Location = new System.Drawing.Point(377, 1);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(34, 34);
            this.borrarButton.TabIndex = 8;
            this.borrarButton.UseVisualStyleBackColor = true;
            this.borrarButton.Click += new System.EventHandler(this.borrarButton_Click);
            // 
            // proxyButton
            // 
            this.proxyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyButton.Location = new System.Drawing.Point(955, 12);
            this.proxyButton.Name = "proxyButton";
            this.proxyButton.Size = new System.Drawing.Size(117, 32);
            this.proxyButton.TabIndex = 16;
            this.proxyButton.Text = "Configurar Proxy";
            this.proxyButton.UseVisualStyleBackColor = true;
            this.proxyButton.Click += new System.EventHandler(this.proxyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.proxyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fuenteLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fuenteTextBox);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.borrarButton);
            this.Controls.Add(this.canalesListBox);
            this.Controls.Add(this.descripcionWebBrowser);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.titulosComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Form1";
            this.Text = "Lector RSS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox titulosComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.WebBrowser descripcionWebBrowser;
        private System.Windows.Forms.ListBox canalesListBox;
        private System.Windows.Forms.Button borrarButton;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox fuenteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fuenteLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button proxyButton;
    }
}

