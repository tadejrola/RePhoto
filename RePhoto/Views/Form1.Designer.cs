namespace RePhoto
{
    partial class RePhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RePhoto));
            this.btn_loadFiles = new System.Windows.Forms.Button();
            this.btn_resize = new System.Windows.Forms.Button();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_removeAll = new System.Windows.Forms.Button();
            this.btn_removeSelected = new System.Windows.Forms.Button();
            this.lv_files = new System.Windows.Forms.ListView();
            this.btn_newProject = new System.Windows.Forms.Button();
            this.btn_rename = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_newProjectGer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_loadFiles
            // 
            resources.ApplyResources(this.btn_loadFiles, "btn_loadFiles");
            this.btn_loadFiles.Name = "btn_loadFiles";
            this.btn_loadFiles.UseVisualStyleBackColor = true;
            this.btn_loadFiles.Click += new System.EventHandler(this.btn_loadFiles_Click);
            // 
            // btn_resize
            // 
            resources.ApplyResources(this.btn_resize, "btn_resize");
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // txt_width
            // 
            resources.ApplyResources(this.txt_width, "txt_width");
            this.txt_width.Name = "txt_width";
            // 
            // txt_height
            // 
            resources.ApplyResources(this.txt_height, "txt_height");
            this.txt_height.Name = "txt_height";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btn_removeAll
            // 
            resources.ApplyResources(this.btn_removeAll, "btn_removeAll");
            this.btn_removeAll.Name = "btn_removeAll";
            this.btn_removeAll.UseVisualStyleBackColor = true;
            this.btn_removeAll.Click += new System.EventHandler(this.btn_removeAll_Click);
            // 
            // btn_removeSelected
            // 
            resources.ApplyResources(this.btn_removeSelected, "btn_removeSelected");
            this.btn_removeSelected.Name = "btn_removeSelected";
            this.btn_removeSelected.UseVisualStyleBackColor = true;
            this.btn_removeSelected.Click += new System.EventHandler(this.btn_removeSelected_Click);
            // 
            // lv_files
            // 
            resources.ApplyResources(this.lv_files, "lv_files");
            this.lv_files.Name = "lv_files";
            this.lv_files.UseCompatibleStateImageBehavior = false;
            this.lv_files.View = System.Windows.Forms.View.List;
            // 
            // btn_newProject
            // 
            resources.ApplyResources(this.btn_newProject, "btn_newProject");
            this.btn_newProject.Name = "btn_newProject";
            this.btn_newProject.UseVisualStyleBackColor = true;
            this.btn_newProject.Click += new System.EventHandler(this.btn_newProject_Click);
            // 
            // btn_rename
            // 
            resources.ApplyResources(this.btn_rename, "btn_rename");
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // txt_name
            // 
            resources.ApplyResources(this.txt_name, "txt_name");
            this.txt_name.Name = "txt_name";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btn_newProjectGer
            // 
            resources.ApplyResources(this.btn_newProjectGer, "btn_newProjectGer");
            this.btn_newProjectGer.Name = "btn_newProjectGer";
            this.btn_newProjectGer.UseVisualStyleBackColor = true;
            this.btn_newProjectGer.Click += new System.EventHandler(this.btn_newProjectGer_Click);
            // 
            // RePhoto
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_newProjectGer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_rename);
            this.Controls.Add(this.btn_newProject);
            this.Controls.Add(this.lv_files);
            this.Controls.Add(this.btn_removeSelected);
            this.Controls.Add(this.btn_removeAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.btn_resize);
            this.Controls.Add(this.btn_loadFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RePhoto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadFiles;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_removeAll;
        private System.Windows.Forms.Button btn_removeSelected;
        private System.Windows.Forms.ListView lv_files;
        private System.Windows.Forms.Button btn_newProject;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_newProjectGer;
    }
}

