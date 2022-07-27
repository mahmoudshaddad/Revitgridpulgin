namespace gridform
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
            this.btncreate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txb_NumberofAxisinX = new System.Windows.Forms.TextBox();
            this.txb_NumberofAxisinY = new System.Windows.Forms.TextBox();
            this.txb_SpacinginX = new System.Windows.Forms.TextBox();
            this.txb_SpacinginY = new System.Windows.Forms.TextBox();
            this.lab_NumberofXAxis = new System.Windows.Forms.Label();
            this.lab_NumberofYAxis = new System.Windows.Forms.Label();
            this.lab_SpacinginY = new System.Windows.Forms.Label();
            this.lab_SpacinginX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(411, 197);
            this.btncreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(385, 108);
            this.btncreate.TabIndex = 0;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(18, 197);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(385, 108);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // txb_NumberofAxisinX
            // 
            this.txb_NumberofAxisinX.Location = new System.Drawing.Point(200, 12);
            this.txb_NumberofAxisinX.Name = "txb_NumberofAxisinX";
            this.txb_NumberofAxisinX.Size = new System.Drawing.Size(341, 34);
            this.txb_NumberofAxisinX.TabIndex = 2;
            // 
            // txb_NumberofAxisinY
            // 
            this.txb_NumberofAxisinY.Location = new System.Drawing.Point(200, 52);
            this.txb_NumberofAxisinY.Name = "txb_NumberofAxisinY";
            this.txb_NumberofAxisinY.Size = new System.Drawing.Size(341, 34);
            this.txb_NumberofAxisinY.TabIndex = 3;
            // 
            // txb_SpacinginX
            // 
            this.txb_SpacinginX.Location = new System.Drawing.Point(200, 104);
            this.txb_SpacinginX.Name = "txb_SpacinginX";
            this.txb_SpacinginX.Size = new System.Drawing.Size(341, 34);
            this.txb_SpacinginX.TabIndex = 4;
            // 
            // txb_SpacinginY
            // 
            this.txb_SpacinginY.Location = new System.Drawing.Point(200, 156);
            this.txb_SpacinginY.Name = "txb_SpacinginY";
            this.txb_SpacinginY.Size = new System.Drawing.Size(341, 34);
            this.txb_SpacinginY.TabIndex = 5;
            // 
            // lab_NumberofXAxis
            // 
            this.lab_NumberofXAxis.AutoSize = true;
            this.lab_NumberofXAxis.Location = new System.Drawing.Point(11, 19);
            this.lab_NumberofXAxis.Name = "lab_NumberofXAxis";
            this.lab_NumberofXAxis.Size = new System.Drawing.Size(174, 27);
            this.lab_NumberofXAxis.TabIndex = 6;
            this.lab_NumberofXAxis.Text = "Number of X Axis";
            // 
            // lab_NumberofYAxis
            // 
            this.lab_NumberofYAxis.AutoSize = true;
            this.lab_NumberofYAxis.Location = new System.Drawing.Point(11, 59);
            this.lab_NumberofYAxis.Name = "lab_NumberofYAxis";
            this.lab_NumberofYAxis.Size = new System.Drawing.Size(174, 27);
            this.lab_NumberofYAxis.TabIndex = 7;
            this.lab_NumberofYAxis.Text = "Number of Y Axis";
            // 
            // lab_SpacinginY
            // 
            this.lab_SpacinginY.AutoSize = true;
            this.lab_SpacinginY.Location = new System.Drawing.Point(61, 163);
            this.lab_SpacinginY.Name = "lab_SpacinginY";
            this.lab_SpacinginY.Size = new System.Drawing.Size(124, 27);
            this.lab_SpacinginY.TabIndex = 8;
            this.lab_SpacinginY.Text = "Spacing in Y";
            // 
            // lab_SpacinginX
            // 
            this.lab_SpacinginX.AutoSize = true;
            this.lab_SpacinginX.Location = new System.Drawing.Point(61, 107);
            this.lab_SpacinginX.Name = "lab_SpacinginX";
            this.lab_SpacinginX.Size = new System.Drawing.Size(124, 27);
            this.lab_SpacinginX.TabIndex = 9;
            this.lab_SpacinginX.Text = "Spacing in X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 326);
            this.Controls.Add(this.lab_SpacinginX);
            this.Controls.Add(this.lab_SpacinginY);
            this.Controls.Add(this.lab_NumberofYAxis);
            this.Controls.Add(this.lab_NumberofXAxis);
            this.Controls.Add(this.txb_SpacinginY);
            this.Controls.Add(this.txb_SpacinginX);
            this.Controls.Add(this.txb_NumberofAxisinY);
            this.Controls.Add(this.txb_NumberofAxisinX);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btncreate);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Create a Gird";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txb_NumberofAxisinX;
        private System.Windows.Forms.TextBox txb_NumberofAxisinY;
        private System.Windows.Forms.TextBox txb_SpacinginX;
        private System.Windows.Forms.TextBox txb_SpacinginY;
        private System.Windows.Forms.Label lab_NumberofXAxis;
        private System.Windows.Forms.Label lab_NumberofYAxis;
        private System.Windows.Forms.Label lab_SpacinginY;
        private System.Windows.Forms.Label lab_SpacinginX;
    }
}

