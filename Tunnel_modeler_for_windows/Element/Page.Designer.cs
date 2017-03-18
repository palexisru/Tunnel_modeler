namespace Modeler.Tunnel.Windows.Element
{
    partial class Page
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
            this.segment_control1 = new Modeler.Tunnel.Windows.Element.Figure.Segment_control();
            this.SuspendLayout();
            // 
            // segment_control1
            // 
            this.segment_control1.Location = new System.Drawing.Point(52, 24);
            this.segment_control1.Margin = new System.Windows.Forms.Padding(4);
            this.segment_control1.Name = "segment_control1";
            this.segment_control1.Size = new System.Drawing.Size(247, 146);
            this.segment_control1.TabIndex = 0;
            // 
            // Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 222);
            this.Controls.Add(this.segment_control1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Page";
            this.Text = "Page";
            this.ResumeLayout(false);

        }

        #endregion

        private Figure.Segment_control segment_control1;
    }
}