
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ans = new System.Windows.Forms.DataGridView();
            this.fileselect = new System.Windows.Forms.Button();
            this.filetext = new System.Windows.Forms.TextBox();
            this.newcol = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ans)).BeginInit();
            this.SuspendLayout();
            // 
            // ans
            // 
            this.ans.AllowDrop = true;
            this.ans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ans.Location = new System.Drawing.Point(81, 72);
            this.ans.Name = "ans";
            this.ans.RowTemplate.Height = 25;
            this.ans.Size = new System.Drawing.Size(554, 268);
            this.ans.TabIndex = 0;
            this.ans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fileselect
            // 
            this.fileselect.Location = new System.Drawing.Point(560, 26);
            this.fileselect.Name = "fileselect";
            this.fileselect.Size = new System.Drawing.Size(75, 23);
            this.fileselect.TabIndex = 1;
            this.fileselect.Text = "選擇檔案";
            this.fileselect.UseVisualStyleBackColor = true;
            this.fileselect.Click += new System.EventHandler(this.button1_Click);
            // 
            // filetext
            // 
            this.filetext.Location = new System.Drawing.Point(81, 26);
            this.filetext.Name = "filetext";
            this.filetext.Size = new System.Drawing.Size(460, 23);
            this.filetext.TabIndex = 2;
            // 
            // newcol
            // 
            this.newcol.Location = new System.Drawing.Point(660, 86);
            this.newcol.Name = "newcol";
            this.newcol.Size = new System.Drawing.Size(75, 23);
            this.newcol.TabIndex = 3;
            this.newcol.Text = "新增";
            this.newcol.UseVisualStyleBackColor = true;
            this.newcol.Click += new System.EventHandler(this.newcol_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(660, 129);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "刪除";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.newcol);
            this.Controls.Add(this.filetext);
            this.Controls.Add(this.fileselect);
            this.Controls.Add(this.ans);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ans;
        private System.Windows.Forms.Button fileselect;
        private System.Windows.Forms.TextBox filetext;
        private System.Windows.Forms.Button newcol;
        private System.Windows.Forms.Button btn_remove;
    }
}

