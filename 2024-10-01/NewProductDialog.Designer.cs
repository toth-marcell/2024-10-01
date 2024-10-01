
namespace _2024_10_01
{
    partial class NewProductDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.quantityField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(61, 12);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(310, 20);
            this.nameField.TabIndex = 1;
            this.nameField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameField_KeyDown);
            // 
            // quantityField
            // 
            this.quantityField.Location = new System.Drawing.Point(61, 38);
            this.quantityField.Name = "quantityField";
            this.quantityField.Size = new System.Drawing.Size(310, 20);
            this.quantityField.TabIndex = 3;
            this.quantityField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantityField_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(61, 64);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(310, 20);
            this.priceField.TabIndex = 5;
            this.priceField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceField_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(296, 116);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Add";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 116);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NewProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 150);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewProductDialog";
            this.Text = "New product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox quantityField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}