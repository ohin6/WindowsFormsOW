
namespace ManipulateCsv
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Btn_CreateFile = new System.Windows.Forms.Button();
            this.Btn_WriteFile = new System.Windows.Forms.Button();
            this.Btn_ExportExcel = new System.Windows.Forms.Button();
            this.Btn_DeleteFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Btn_SaveExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(327, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(394, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(370, 339);
            this.dataGridView2.TabIndex = 1;
            // 
            // Btn_CreateFile
            // 
            this.Btn_CreateFile.Location = new System.Drawing.Point(54, 395);
            this.Btn_CreateFile.Name = "Btn_CreateFile";
            this.Btn_CreateFile.Size = new System.Drawing.Size(99, 28);
            this.Btn_CreateFile.TabIndex = 2;
            this.Btn_CreateFile.Text = "Create file";
            this.Btn_CreateFile.UseVisualStyleBackColor = true;
            this.Btn_CreateFile.Click += new System.EventHandler(this.Btn_CreateFile_Click);
            // 
            // Btn_WriteFile
            // 
            this.Btn_WriteFile.Location = new System.Drawing.Point(186, 395);
            this.Btn_WriteFile.Name = "Btn_WriteFile";
            this.Btn_WriteFile.Size = new System.Drawing.Size(99, 28);
            this.Btn_WriteFile.TabIndex = 3;
            this.Btn_WriteFile.Text = "Write FIle";
            this.Btn_WriteFile.UseVisualStyleBackColor = true;
            this.Btn_WriteFile.Click += new System.EventHandler(this.Btn_WriteFile_Click);
            // 
            // Btn_ExportExcel
            // 
            this.Btn_ExportExcel.Location = new System.Drawing.Point(305, 395);
            this.Btn_ExportExcel.Name = "Btn_ExportExcel";
            this.Btn_ExportExcel.Size = new System.Drawing.Size(99, 28);
            this.Btn_ExportExcel.TabIndex = 4;
            this.Btn_ExportExcel.Text = "Export to Excel";
            this.Btn_ExportExcel.UseVisualStyleBackColor = true;
            this.Btn_ExportExcel.Click += new System.EventHandler(this.Btn_ExportExcel_Click);
            // 
            // Btn_DeleteFile
            // 
            this.Btn_DeleteFile.Location = new System.Drawing.Point(426, 395);
            this.Btn_DeleteFile.Name = "Btn_DeleteFile";
            this.Btn_DeleteFile.Size = new System.Drawing.Size(99, 28);
            this.Btn_DeleteFile.TabIndex = 5;
            this.Btn_DeleteFile.Text = "DeleteFile";
            this.Btn_DeleteFile.UseVisualStyleBackColor = true;
            this.Btn_DeleteFile.Click += new System.EventHandler(this.Btn_DeleteFile_Click);
            // 
            // Btn_SaveExcel
            // 
            this.Btn_SaveExcel.Location = new System.Drawing.Point(551, 395);
            this.Btn_SaveExcel.Name = "Btn_SaveExcel";
            this.Btn_SaveExcel.Size = new System.Drawing.Size(99, 28);
            this.Btn_SaveExcel.TabIndex = 6;
            this.Btn_SaveExcel.Text = "Save Excel";
            this.Btn_SaveExcel.UseVisualStyleBackColor = true;
            this.Btn_SaveExcel.Click += new System.EventHandler(this.Btn_SaveExcel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save Excel2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(804, 29);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(370, 339);
            this.dataGridView3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_SaveExcel);
            this.Controls.Add(this.Btn_DeleteFile);
            this.Controls.Add(this.Btn_ExportExcel);
            this.Controls.Add(this.Btn_WriteFile);
            this.Controls.Add(this.Btn_CreateFile);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Btn_CreateFile;
        private System.Windows.Forms.Button Btn_WriteFile;
        private System.Windows.Forms.Button Btn_ExportExcel;
        private System.Windows.Forms.Button Btn_DeleteFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Btn_SaveExcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

