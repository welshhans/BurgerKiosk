namespace BurgerOrderForm
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
            this.newOrderButton = new System.Windows.Forms.Button();
            this.inProgressButton = new System.Windows.Forms.Button();
            this.completedButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(40, 485);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(110, 30);
            this.newOrderButton.TabIndex = 0;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // inProgressButton
            // 
            this.inProgressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inProgressButton.Location = new System.Drawing.Point(214, 485);
            this.inProgressButton.Name = "inProgressButton";
            this.inProgressButton.Size = new System.Drawing.Size(110, 30);
            this.inProgressButton.TabIndex = 1;
            this.inProgressButton.Text = "In Progress";
            this.inProgressButton.UseVisualStyleBackColor = true;
            this.inProgressButton.Click += new System.EventHandler(this.inProgressButton_Click);
            // 
            // completedButton
            // 
            this.completedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedButton.Location = new System.Drawing.Point(40, 558);
            this.completedButton.Name = "completedButton";
            this.completedButton.Size = new System.Drawing.Size(110, 30);
            this.completedButton.TabIndex = 2;
            this.completedButton.Text = "Completed";
            this.completedButton.UseVisualStyleBackColor = true;
            this.completedButton.Click += new System.EventHandler(this.completedButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(214, 558);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(40, 33);
            this.orderTextBox.Multiline = true;
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(284, 419);
            this.orderTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 618);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.completedButton);
            this.Controls.Add(this.inProgressButton);
            this.Controls.Add(this.newOrderButton);
            this.Name = "Form1";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button inProgressButton;
        private System.Windows.Forms.Button completedButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox orderTextBox;
    }
}

