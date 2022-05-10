
namespace PageSplit
{
    partial class form_home
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
            this.btn_Convert = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Convert
            // 
            this.btn_Convert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Convert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Convert.Location = new System.Drawing.Point(316, 330);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(137, 36);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            this.btn_Convert.MouseEnter += new System.EventHandler(this.btn_Convert_MouseEnter);
            this.btn_Convert.MouseLeave += new System.EventHandler(this.btn_Convert_MouseLeave);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(277, 251);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_message.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_title.Location = new System.Drawing.Point(309, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(158, 40);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Page Split";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.BackColor = System.Drawing.Color.Transparent;
            this.lbl_author.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_author.Location = new System.Drawing.Point(690, 422);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(98, 19);
            this.lbl_author.TabIndex = 2;
            this.lbl_author.Text = "Zach Swogger";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_description.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_description.Location = new System.Drawing.Point(33, 71);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(734, 46);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = "This application takes a multi-page word document and splits it into multiple PDF" +
    " documents.\r\nIt will split it into 1 PDF per page.";
            // 
            // form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_Convert);
            this.Name = "form_home";
            this.Text = "Page Split";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_description;
    }
}

