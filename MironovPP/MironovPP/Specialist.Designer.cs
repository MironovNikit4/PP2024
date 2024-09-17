namespace MironovPP
{
    partial class Specialist
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
            this.Close = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IDRequest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DetailNumber = new System.Windows.Forms.TextBox();
            this.AcceptRequest = new System.Windows.Forms.Button();
            this.DeclineRequest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DetailKolvo = new System.Windows.Forms.TextBox();
            this.Warehouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ремонт автомобиля";
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(737, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(33, 25);
            this.Close.TabIndex = 55;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(42, 88);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersVisible = false;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(699, 134);
            this.dataGridViewAdmin.TabIndex = 57;
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
            this.Search.Location = new System.Drawing.Point(291, 239);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(216, 25);
            this.Search.TabIndex = 63;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vivaldi", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 22);
            this.label2.TabIndex = 64;
            this.label2.Text = "Текущие заявки на ремонт -";
            // 
            // IDRequest
            // 
            this.IDRequest.BackColor = System.Drawing.Color.DarkGray;
            this.IDRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDRequest.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDRequest.ForeColor = System.Drawing.Color.Black;
            this.IDRequest.Location = new System.Drawing.Point(42, 304);
            this.IDRequest.Margin = new System.Windows.Forms.Padding(4);
            this.IDRequest.Name = "IDRequest";
            this.IDRequest.Size = new System.Drawing.Size(216, 24);
            this.IDRequest.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vivaldi", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(42, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(209, 22);
            this.label3.TabIndex = 70;
            this.label3.Text = "Номер заявки на ремонт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vivaldi", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(291, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 72;
            this.label4.Text = "Номер детали";
            // 
            // DetailNumber
            // 
            this.DetailNumber.BackColor = System.Drawing.Color.DarkGray;
            this.DetailNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailNumber.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailNumber.ForeColor = System.Drawing.Color.Black;
            this.DetailNumber.Location = new System.Drawing.Point(291, 304);
            this.DetailNumber.Margin = new System.Windows.Forms.Padding(4);
            this.DetailNumber.Name = "DetailNumber";
            this.DetailNumber.Size = new System.Drawing.Size(216, 24);
            this.DetailNumber.TabIndex = 71;
            // 
            // AcceptRequest
            // 
            this.AcceptRequest.BackColor = System.Drawing.Color.SaddleBrown;
            this.AcceptRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptRequest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AcceptRequest.FlatAppearance.BorderSize = 0;
            this.AcceptRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptRequest.Font = new System.Drawing.Font("Vivaldi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptRequest.ForeColor = System.Drawing.Color.White;
            this.AcceptRequest.Location = new System.Drawing.Point(42, 347);
            this.AcceptRequest.Margin = new System.Windows.Forms.Padding(4);
            this.AcceptRequest.Name = "AcceptRequest";
            this.AcceptRequest.Size = new System.Drawing.Size(216, 25);
            this.AcceptRequest.TabIndex = 73;
            this.AcceptRequest.Text = "Выполнить";
            this.AcceptRequest.UseVisualStyleBackColor = false;
            this.AcceptRequest.Click += new System.EventHandler(this.AcceptRequest_Click);
            // 
            // DeclineRequest
            // 
            this.DeclineRequest.BackColor = System.Drawing.Color.SaddleBrown;
            this.DeclineRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeclineRequest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeclineRequest.FlatAppearance.BorderSize = 0;
            this.DeclineRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeclineRequest.Font = new System.Drawing.Font("Vivaldi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineRequest.ForeColor = System.Drawing.Color.White;
            this.DeclineRequest.Location = new System.Drawing.Point(291, 347);
            this.DeclineRequest.Margin = new System.Windows.Forms.Padding(4);
            this.DeclineRequest.Name = "DeclineRequest";
            this.DeclineRequest.Size = new System.Drawing.Size(216, 25);
            this.DeclineRequest.TabIndex = 74;
            this.DeclineRequest.Text = "Отклонить";
            this.DeclineRequest.UseVisualStyleBackColor = false;
            this.DeclineRequest.Click += new System.EventHandler(this.DeclineRequest_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vivaldi", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(525, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(174, 22);
            this.label5.TabIndex = 76;
            this.label5.Text = "Количество деталей";
            // 
            // DetailKolvo
            // 
            this.DetailKolvo.BackColor = System.Drawing.Color.DarkGray;
            this.DetailKolvo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailKolvo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetailKolvo.ForeColor = System.Drawing.Color.Black;
            this.DetailKolvo.Location = new System.Drawing.Point(525, 304);
            this.DetailKolvo.Margin = new System.Windows.Forms.Padding(4);
            this.DetailKolvo.Name = "DetailKolvo";
            this.DetailKolvo.Size = new System.Drawing.Size(216, 24);
            this.DetailKolvo.TabIndex = 75;
            // 
            // Warehouse
            // 
            this.Warehouse.BackColor = System.Drawing.Color.SaddleBrown;
            this.Warehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Warehouse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Warehouse.FlatAppearance.BorderSize = 0;
            this.Warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Warehouse.Font = new System.Drawing.Font("Vivaldi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warehouse.ForeColor = System.Drawing.Color.White;
            this.Warehouse.Location = new System.Drawing.Point(525, 347);
            this.Warehouse.Margin = new System.Windows.Forms.Padding(4);
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.Size = new System.Drawing.Size(216, 25);
            this.Warehouse.TabIndex = 77;
            this.Warehouse.Text = "Склад";
            this.Warehouse.UseVisualStyleBackColor = false;
            this.Warehouse.Click += new System.EventHandler(this.Warehouse_Click);
            // 
            // Specialist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 408);
            this.Controls.Add(this.Warehouse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DetailKolvo);
            this.Controls.Add(this.DeclineRequest);
            this.Controls.Add(this.AcceptRequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DetailNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Specialist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Specialist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DetailNumber;
        private System.Windows.Forms.Button AcceptRequest;
        private System.Windows.Forms.Button DeclineRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DetailKolvo;
        private System.Windows.Forms.Button Warehouse;
    }
}