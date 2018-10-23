namespace Clase06
{
    partial class frmTinta
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboTinta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tinta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboColor
            // 
            this.cboColor.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(84, 32);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(243, 21);
            this.cboColor.TabIndex = 2;
            this.cboColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboTinta
            // 
            this.cboTinta.AccessibleDescription = "";
            this.cboTinta.FormattingEnabled = true;
            this.cboTinta.Location = new System.Drawing.Point(84, 90);
            this.cboTinta.Name = "cboTinta";
            this.cboTinta.Size = new System.Drawing.Size(243, 21);
            this.cboTinta.TabIndex = 3;
            this.cboTinta.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tinta
            // 
            this.Tinta.AutoSize = true;
            this.Tinta.Location = new System.Drawing.Point(84, 74);
            this.Tinta.Name = "Tinta";
            this.Tinta.Size = new System.Drawing.Size(31, 13);
            this.Tinta.TabIndex = 5;
            this.Tinta.Text = "Tinta";
            this.Tinta.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmTinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 255);
            this.Controls.Add(this.Tinta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTinta);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmTinta";
            this.Text = "frmTinta";
            this.Load += new System.EventHandler(this.frmTinta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.ComboBox cboTinta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tinta;
    }
}