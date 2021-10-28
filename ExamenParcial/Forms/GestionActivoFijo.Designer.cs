namespace ExamenParcial.Forms
{
    partial class GestionActivoFijo
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
            this.rtbEmpleadoView = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbEmpleadoView
            // 
            this.rtbEmpleadoView.Location = new System.Drawing.Point(22, 46);
            this.rtbEmpleadoView.Name = "rtbEmpleadoView";
            this.rtbEmpleadoView.Size = new System.Drawing.Size(751, 331);
            this.rtbEmpleadoView.TabIndex = 0;
            this.rtbEmpleadoView.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GestionActivoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbEmpleadoView);
            this.Name = "GestionActivoFijo";
            this.Text = "GestionActivoFijo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEmpleadoView;
        private System.Windows.Forms.Button button1;
    }
}