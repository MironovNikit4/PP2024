namespace MironovPP
{
    partial class WareHouse
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
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewWarehouse = new System.Windows.Forms.DataGridView();
            this.CheckWarehouse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DetailNumber = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(375, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(33, 25);
            this.Close.TabIndex = 53;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Склад деталей для ремонта";
            // 
            // dataGridViewWarehouse
            // 
            this.dataGridViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouse.Location = new System.Drawing.Point(48, 51);
            this.dataGridViewWarehouse.Name = "dataGridViewWarehouse";
            this.dataGridViewWarehouse.RowHeadersVisible = false;
            this.dataGridViewWarehouse.Size = new System.Drawing.Size(295, 134);
            this.dataGridViewWarehouse.TabIndex = 57;
            // 
            // CheckWarehouse
            // 
            this.CheckWarehouse.BackColor = System.Drawing.Color.SaddleBrown;
            this.CheckWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckWarehouse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckWarehouse.FlatAppearance.BorderSize = 0;
            this.CheckWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckWarehouse.Font = new System.Drawing.Font("Vivaldi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckWarehouse.ForeColor = System.Drawing.Color.White;
            this.CheckWarehouse.Location = new System.Drawing.Point(48, 192);
            this.CheckWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.CheckWarehouse.Name = "CheckWarehouse";
            this.CheckWarehouse.Size = new System.Drawing.Size(295, 25);
            this.CheckWarehouse.TabIndex = 64;
            this.CheckWarehouse.Text = "Поиск";
            this.CheckWarehouse.UseVisualStyleBackColor = false;
            this.CheckWarehouse.Click += new System.EventHandler(this.CheckWarehouse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vivaldi", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(47, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 74;
            this.label4.Text = "Номер детали";
            // 
            // DetailNumber
            // 
            this.DetailNumber.BackColor = System.Drawing.Color.DarkGray;
            this.DetailNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailNumber.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailNumber.ForeColor = System.Drawing.Color.Black;
            this.DetailNumber.Location = new System.Drawing.Point(47, 256);
            this.DetailNumber.Margin = new System.Windows.Forms.Padding(4);
            this.DetailNumber.Name = "DetailNumber";
            this.DetailNumber.Size = new System.Drawing.Size(216, 24);
            this.DetailNumber.TabIndex = 73;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.SaddleBrown;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Vivaldi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(47, 288);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(216, 25);
            this.Search.TabIndex = 75;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 326);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DetailNumber);
            this.Controls.Add(this.CheckWarehouse);
            this.Controls.Add(this.dataGridViewWarehouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WareHouse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewWarehouse;
        private System.Windows.Forms.Button CheckWarehouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DetailNumber;
        private System.Windows.Forms.Button Search;
    }
}