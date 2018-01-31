namespace RePhoto.Views
{
    partial class NewProject
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
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_typeOfWork = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num_numberOfPhotos = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_numberOfPhotos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(12, 33);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(161, 20);
            this.txt_title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type of work:";
            // 
            // txt_typeOfWork
            // 
            this.txt_typeOfWork.Location = new System.Drawing.Point(12, 91);
            this.txt_typeOfWork.Name = "txt_typeOfWork";
            this.txt_typeOfWork.Size = new System.Drawing.Size(161, 20);
            this.txt_typeOfWork.TabIndex = 3;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(231, 33);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(161, 20);
            this.txt_city.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "City:";
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(12, 148);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(164, 20);
            this.txt_country.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Country:";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(231, 91);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(161, 20);
            this.txt_description.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            // 
            // num_numberOfPhotos
            // 
            this.num_numberOfPhotos.Location = new System.Drawing.Point(231, 148);
            this.num_numberOfPhotos.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.num_numberOfPhotos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_numberOfPhotos.Name = "num_numberOfPhotos";
            this.num_numberOfPhotos.Size = new System.Drawing.Size(57, 20);
            this.num_numberOfPhotos.TabIndex = 12;
            this.num_numberOfPhotos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Number of photos:";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(434, 79);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(197, 70);
            this.btn_create.TabIndex = 14;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 212);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_numberOfPhotos);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_typeOfWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_title);
            this.Name = "NewProject";
            this.Text = "NewProject";
            ((System.ComponentModel.ISupportInitialize)(this.num_numberOfPhotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_typeOfWork;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_numberOfPhotos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_create;
    }
}