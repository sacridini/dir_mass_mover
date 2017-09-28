namespace dir_mover
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
            this.btn_origem = new System.Windows.Forms.Button();
            this.btn_destino = new System.Windows.Forms.Button();
            this.btn_rodar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_extensao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_origem
            // 
            this.btn_origem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_origem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_origem.Location = new System.Drawing.Point(13, 45);
            this.btn_origem.Name = "btn_origem";
            this.btn_origem.Size = new System.Drawing.Size(75, 55);
            this.btn_origem.TabIndex = 0;
            this.btn_origem.Text = "Origem";
            this.btn_origem.UseVisualStyleBackColor = false;
            this.btn_origem.Click += new System.EventHandler(this.btn_origem_Click);
            // 
            // btn_destino
            // 
            this.btn_destino.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_destino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_destino.Location = new System.Drawing.Point(138, 45);
            this.btn_destino.Name = "btn_destino";
            this.btn_destino.Size = new System.Drawing.Size(75, 55);
            this.btn_destino.TabIndex = 1;
            this.btn_destino.Text = "Destino";
            this.btn_destino.UseVisualStyleBackColor = false;
            this.btn_destino.Click += new System.EventHandler(this.btn_destino_Click);
            // 
            // btn_rodar
            // 
            this.btn_rodar.BackColor = System.Drawing.Color.Plum;
            this.btn_rodar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rodar.Location = new System.Drawing.Point(266, 45);
            this.btn_rodar.Name = "btn_rodar";
            this.btn_rodar.Size = new System.Drawing.Size(75, 55);
            this.btn_rodar.TabIndex = 4;
            this.btn_rodar.Text = "Rodar";
            this.btn_rodar.UseVisualStyleBackColor = false;
            this.btn_rodar.Click += new System.EventHandler(this.btn_rodar_Click);
            // 
            // txt_extensao
            // 
            this.txt_extensao.BackColor = System.Drawing.Color.Black;
            this.txt_extensao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_extensao.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_extensao.Location = new System.Drawing.Point(205, 18);
            this.txt_extensao.Name = "txt_extensao";
            this.txt_extensao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_extensao.Size = new System.Drawing.Size(136, 20);
            this.txt_extensao.TabIndex = 5;
            this.txt_extensao.Text = "mp3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Formato do arquivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(98, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = ">";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(225, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = ">";
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Black;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 120);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(353, 195);
            this.listBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(353, 315);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_extensao);
            this.Controls.Add(this.btn_rodar);
            this.Controls.Add(this.btn_destino);
            this.Controls.Add(this.btn_origem);
            this.Name = "Form1";
            this.Text = "dir_mover 0.1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_origem;
        private System.Windows.Forms.Button btn_destino;
        private System.Windows.Forms.Button btn_rodar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txt_extensao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox;
    }
}

