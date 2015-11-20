namespace PlatformTest
{
    partial class FormMain
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
            this.numDataID = new System.Windows.Forms.NumericUpDown();
            this.textSrc = new System.Windows.Forms.TextBox();
            this.textDst = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textPlugin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDataID)).BeginInit();
            this.SuspendLayout();
            // 
            // numDataID
            // 
            this.numDataID.Location = new System.Drawing.Point(12, 12);
            this.numDataID.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numDataID.Name = "numDataID";
            this.numDataID.Size = new System.Drawing.Size(281, 20);
            this.numDataID.TabIndex = 0;
            this.numDataID.Value = new decimal(new int[] {
            2333,
            0,
            0,
            0});
            // 
            // textSrc
            // 
            this.textSrc.Location = new System.Drawing.Point(12, 38);
            this.textSrc.Name = "textSrc";
            this.textSrc.Size = new System.Drawing.Size(281, 20);
            this.textSrc.TabIndex = 1;
            this.textSrc.Text = "We are having fun";
            // 
            // textDst
            // 
            this.textDst.Location = new System.Drawing.Point(12, 64);
            this.textDst.Name = "textDst";
            this.textDst.Size = new System.Drawing.Size(281, 20);
            this.textDst.TabIndex = 2;
            this.textDst.Text = "but do not happy";
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.Location = new System.Drawing.Point(12, 116);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textResult.Size = new System.Drawing.Size(424, 411);
            this.textResult.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(299, 11);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 72);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textPlugin
            // 
            this.textPlugin.BackColor = System.Drawing.SystemColors.Info;
            this.textPlugin.Location = new System.Drawing.Point(12, 90);
            this.textPlugin.Name = "textPlugin";
            this.textPlugin.Size = new System.Drawing.Size(424, 20);
            this.textPlugin.TabIndex = 5;
            this.textPlugin.Text = "Sherlock";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 543);
            this.Controls.Add(this.textPlugin);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textDst);
            this.Controls.Add(this.textSrc);
            this.Controls.Add(this.numDataID);
            this.Name = "FormMain";
            this.Text = "PluginTest";
            ((System.ComponentModel.ISupportInitialize)(this.numDataID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDataID;
        private System.Windows.Forms.TextBox textSrc;
        private System.Windows.Forms.TextBox textDst;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textPlugin;
    }
}

