
namespace _2024_10_01
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.newProductButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 390);
            this.listBox1.TabIndex = 0;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // newProductButton
            // 
            this.newProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newProductButton.Location = new System.Drawing.Point(12, 408);
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(151, 23);
            this.newProductButton.TabIndex = 1;
            this.newProductButton.Text = "New product";
            this.newProductButton.UseVisualStyleBackColor = true;
            this.newProductButton.Click += new System.EventHandler(this.newProductButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteSelectedButton.Location = new System.Drawing.Point(169, 408);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(151, 23);
            this.deleteSelectedButton.TabIndex = 2;
            this.deleteSelectedButton.Text = "Delete selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteAllButton.Location = new System.Drawing.Point(326, 408);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(151, 23);
            this.deleteAllButton.TabIndex = 3;
            this.deleteAllButton.Text = "Delete all";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.newProductButton);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button newProductButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button deleteAllButton;
    }
}

