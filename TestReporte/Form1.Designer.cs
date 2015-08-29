namespace TestReporte
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
            this.crvRepresentacionImpresa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvRepresentacionImpresa
            // 
            this.crvRepresentacionImpresa.ActiveViewIndex = -1;
            this.crvRepresentacionImpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepresentacionImpresa.CachedPageNumberPerDoc = 10;
            this.crvRepresentacionImpresa.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepresentacionImpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepresentacionImpresa.Location = new System.Drawing.Point(0, 0);
            this.crvRepresentacionImpresa.Name = "crvRepresentacionImpresa";
            this.crvRepresentacionImpresa.Size = new System.Drawing.Size(284, 261);
            this.crvRepresentacionImpresa.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.crvRepresentacionImpresa);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Previa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepresentacionImpresa;
    }
}

