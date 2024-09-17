namespace MironovPP
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.IDRequest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SpecialistList = new System.Windows.Forms.ComboBox();
            this.AddSpecialist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SpecialistManage = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(293, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Администрирование";
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(759, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(33, 25);
            this.Close.TabIndex = 53;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(66, 51);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersVisible = false;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(690, 87);
            this.dataGridViewAdmin.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vivaldi", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(97, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 55;
            this.label2.Text = "Выбор заявки -";
            // 
            // IDRequest
            // 
            this.IDRequest.BackColor = System.Drawing.Color.DarkGray;
            this.IDRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDRequest.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDRequest.ForeColor = System.Drawing.Color.Black;
            this.IDRequest.Location = new System.Drawing.Point(101, 225);
            this.IDRequest.Margin = new System.Windows.Forms.Padding(4);
            this.IDRequest.Name = "IDRequest";
            this.IDRequest.Size = new System.Drawing.Size(216, 24);
            this.IDRequest.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vivaldi", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(338, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 57;
            this.label3.Text = "Выбор специалиста -";
            // 
            // SpecialistList
            // 
            this.SpecialistList.FormattingEnabled = true;
            this.SpecialistList.Items.AddRange(new object[] {
            "Орлов Геннадий Викторович",
            "Жуков Сергей Иванович",
            "Синицин Андрей Михайлович",
            "Сидоров Евгений Андреевич"});
            this.SpecialistList.Location = new System.Drawing.Point(338, 225);
            this.SpecialistList.Name = "SpecialistList";
            this.SpecialistList.Size = new System.Drawing.Size(189, 21);
            this.SpecialistList.TabIndex = 58;
            // 
            // AddSpecialist
            // 
            this.AddSpecialist.BackColor = System.Drawing.Color.SaddleBrown;
            this.AddSpecialist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSpecialist.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddSpecialist.FlatAppearance.BorderSize = 0;
            this.AddSpecialist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSpecialist.Font = new System.Drawing.Font("Vivaldi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSpecialist.ForeColor = System.Drawing.Color.White;
            this.AddSpecialist.Location = new System.Drawing.Point(101, 257);
            this.AddSpecialist.Margin = new System.Windows.Forms.Padding(4);
            this.AddSpecialist.Name = "AddSpecialist";
            this.AddSpecialist.Size = new System.Drawing.Size(216, 41);
            this.AddSpecialist.TabIndex = 59;
            this.AddSpecialist.Text = "Назначить";
            this.AddSpecialist.UseVisualStyleBackColor = false;
            this.AddSpecialist.Click += new System.EventHandler(this.AddSpecialist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(606, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // SpecialistManage
            // 
            this.SpecialistManage.BackColor = System.Drawing.Color.SaddleBrown;
            this.SpecialistManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpecialistManage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SpecialistManage.FlatAppearance.BorderSize = 0;
            this.SpecialistManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpecialistManage.Font = new System.Drawing.Font("Vivaldi", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialistManage.ForeColor = System.Drawing.Color.White;
            this.SpecialistManage.Location = new System.Drawing.Point(338, 257);
            this.SpecialistManage.Margin = new System.Windows.Forms.Padding(4);
            this.SpecialistManage.Name = "SpecialistManage";
            this.SpecialistManage.Size = new System.Drawing.Size(189, 41);
            this.SpecialistManage.TabIndex = 61;
            this.SpecialistManage.Text = "Управление персоналом";
            this.SpecialistManage.UseVisualStyleBackColor = false;
            this.SpecialistManage.Click += new System.EventHandler(this.SpecialistManage_Click);
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
            this.Search.Location = new System.Drawing.Point(311, 145);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(216, 25);
            this.Search.TabIndex = 62;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 321);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SpecialistManage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddSpecialist);
            this.Controls.Add(this.SpecialistList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SpecialistList;
        private System.Windows.Forms.Button AddSpecialist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SpecialistManage;
        private System.Windows.Forms.Button Search;
    }
}