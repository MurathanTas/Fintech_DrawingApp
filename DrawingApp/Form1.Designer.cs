namespace DrawingApp
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
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            pick_save = new Button();
            pick_file = new Button();
            groupBox3 = new GroupBox();
            pick_refresh = new Button();
            pick_delete = new Button();
            pick_cursor = new Button();
            groupBox2 = new GroupBox();
            pick_white = new Button();
            pick_brown = new Button();
            pick_purple = new Button();
            pick_yellow = new Button();
            pick_black = new Button();
            pick_orange = new Button();
            pick_green = new Button();
            pick_blue = new Button();
            pick_red = new Button();
            groupBox1 = new GroupBox();
            pick_hexagon = new Button();
            pick_triangle = new Button();
            pick_ellipse = new Button();
            pick_rectangle = new Button();
            panelCanvas = new Panel();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(739, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 1019);
            panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.AppWorkspace;
            groupBox4.Controls.Add(pick_save);
            groupBox4.Controls.Add(pick_file);
            groupBox4.Location = new Point(3, 614);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(261, 95);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dosya İşlemleri";
            // 
            // pick_save
            // 
            pick_save.BackColor = Color.GhostWhite;
            pick_save.ForeColor = Color.Transparent;
            pick_save.Image = Properties.Resources.save_download_icon_10__1_;
            pick_save.Location = new Point(101, 26);
            pick_save.Name = "pick_save";
            pick_save.Size = new Size(66, 62);
            pick_save.TabIndex = 12;
            pick_save.UseVisualStyleBackColor = false;
            // 
            // pick_file
            // 
            pick_file.BackColor = Color.GhostWhite;
            pick_file.ForeColor = Color.Transparent;
            pick_file.Image = Properties.Resources.png_transparent_directory_icon_folder_miscellaneous_angle_rectangle_thumbnail__1_;
            pick_file.Location = new Point(15, 26);
            pick_file.Name = "pick_file";
            pick_file.Size = new Size(66, 62);
            pick_file.TabIndex = 11;
            pick_file.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.AppWorkspace;
            groupBox3.Controls.Add(pick_refresh);
            groupBox3.Controls.Add(pick_delete);
            groupBox3.Controls.Add(pick_cursor);
            groupBox3.Location = new Point(3, 513);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(261, 95);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Şekil İşlemleri";
            // 
            // pick_refresh
            // 
            pick_refresh.BackColor = Color.GhostWhite;
            pick_refresh.Image = Properties.Resources.png_transparent_pencil_drawing_pencil_pencil_orange_pen__1_;
            pick_refresh.Location = new Point(186, 26);
            pick_refresh.Name = "pick_refresh";
            pick_refresh.Size = new Size(66, 62);
            pick_refresh.TabIndex = 12;
            pick_refresh.UseVisualStyleBackColor = false;
            // 
            // pick_delete
            // 
            pick_delete.BackColor = Color.GhostWhite;
            pick_delete.Image = Properties.Resources.png_transparent_recycling_bin_trash_windows_7_rubbish_bins_waste_paper_baskets_computer_icons_others_glass_recycling_waste_containment_thumbnail__1_;
            pick_delete.Location = new Point(101, 26);
            pick_delete.Name = "pick_delete";
            pick_delete.Size = new Size(66, 62);
            pick_delete.TabIndex = 11;
            pick_delete.UseVisualStyleBackColor = false;
            // 
            // pick_cursor
            // 
            pick_cursor.BackColor = Color.GhostWhite;
            pick_cursor.ForeColor = Color.Transparent;
            pick_cursor.Image = Properties.Resources.Cursor_icon_with_shadow1;
            pick_cursor.Location = new Point(15, 27);
            pick_cursor.Name = "pick_cursor";
            pick_cursor.Size = new Size(66, 62);
            pick_cursor.TabIndex = 10;
            pick_cursor.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.AppWorkspace;
            groupBox2.Controls.Add(pick_white);
            groupBox2.Controls.Add(pick_brown);
            groupBox2.Controls.Add(pick_purple);
            groupBox2.Controls.Add(pick_yellow);
            groupBox2.Controls.Add(pick_black);
            groupBox2.Controls.Add(pick_orange);
            groupBox2.Controls.Add(pick_green);
            groupBox2.Controls.Add(pick_blue);
            groupBox2.Controls.Add(pick_red);
            groupBox2.Location = new Point(3, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 249);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Renk Seçimi";
            // 
            // pick_white
            // 
            pick_white.Location = new Point(186, 181);
            pick_white.Name = "pick_white";
            pick_white.Size = new Size(66, 62);
            pick_white.TabIndex = 9;
            pick_white.UseVisualStyleBackColor = true;
            // 
            // pick_brown
            // 
            pick_brown.BackColor = Color.FromArgb(192, 64, 0);
            pick_brown.Location = new Point(101, 181);
            pick_brown.Name = "pick_brown";
            pick_brown.Size = new Size(66, 62);
            pick_brown.TabIndex = 8;
            pick_brown.UseVisualStyleBackColor = false;
            // 
            // pick_purple
            // 
            pick_purple.BackColor = Color.Purple;
            pick_purple.Location = new Point(15, 181);
            pick_purple.Name = "pick_purple";
            pick_purple.Size = new Size(66, 62);
            pick_purple.TabIndex = 7;
            pick_purple.UseVisualStyleBackColor = false;
            // 
            // pick_yellow
            // 
            pick_yellow.BackColor = Color.Yellow;
            pick_yellow.Location = new Point(186, 103);
            pick_yellow.Name = "pick_yellow";
            pick_yellow.Size = new Size(66, 62);
            pick_yellow.TabIndex = 6;
            pick_yellow.UseVisualStyleBackColor = false;
            // 
            // pick_black
            // 
            pick_black.BackColor = Color.Black;
            pick_black.Location = new Point(101, 103);
            pick_black.Name = "pick_black";
            pick_black.Size = new Size(66, 62);
            pick_black.TabIndex = 5;
            pick_black.UseVisualStyleBackColor = false;
            // 
            // pick_orange
            // 
            pick_orange.BackColor = Color.FromArgb(255, 128, 0);
            pick_orange.Location = new Point(15, 103);
            pick_orange.Name = "pick_orange";
            pick_orange.Size = new Size(66, 62);
            pick_orange.TabIndex = 4;
            pick_orange.UseVisualStyleBackColor = false;
            // 
            // pick_green
            // 
            pick_green.BackColor = Color.Green;
            pick_green.Location = new Point(186, 26);
            pick_green.Name = "pick_green";
            pick_green.Size = new Size(66, 62);
            pick_green.TabIndex = 3;
            pick_green.UseVisualStyleBackColor = false;
            // 
            // pick_blue
            // 
            pick_blue.BackColor = Color.Blue;
            pick_blue.Location = new Point(101, 26);
            pick_blue.Name = "pick_blue";
            pick_blue.Size = new Size(66, 62);
            pick_blue.TabIndex = 2;
            pick_blue.UseVisualStyleBackColor = false;
            // 
            // pick_red
            // 
            pick_red.BackColor = Color.Red;
            pick_red.Location = new Point(15, 26);
            pick_red.Name = "pick_red";
            pick_red.Size = new Size(66, 62);
            pick_red.TabIndex = 1;
            pick_red.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(pick_hexagon);
            groupBox1.Controls.Add(pick_triangle);
            groupBox1.Controls.Add(pick_ellipse);
            groupBox1.Controls.Add(pick_rectangle);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 249);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çizim Şekli";
            // 
            // pick_hexagon
            // 
            pick_hexagon.BackColor = Color.White;
            pick_hexagon.Image = Properties.Resources.hexagon;
            pick_hexagon.Location = new Point(132, 135);
            pick_hexagon.Name = "pick_hexagon";
            pick_hexagon.Size = new Size(120, 103);
            pick_hexagon.TabIndex = 4;
            pick_hexagon.UseVisualStyleBackColor = false;
            // 
            // pick_triangle
            // 
            pick_triangle.BackColor = Color.White;
            pick_triangle.Image = Properties.Resources.triangle1;
            pick_triangle.Location = new Point(15, 135);
            pick_triangle.Name = "pick_triangle";
            pick_triangle.Size = new Size(111, 103);
            pick_triangle.TabIndex = 3;
            pick_triangle.UseVisualStyleBackColor = false;
            // 
            // pick_ellipse
            // 
            pick_ellipse.BackColor = Color.White;
            pick_ellipse.ForeColor = Color.Transparent;
            pick_ellipse.Image = Properties.Resources.ellipse1;
            pick_ellipse.Location = new Point(132, 26);
            pick_ellipse.Name = "pick_ellipse";
            pick_ellipse.Size = new Size(120, 103);
            pick_ellipse.TabIndex = 2;
            pick_ellipse.UseVisualStyleBackColor = false;
            // 
            // pick_rectangle
            // 
            pick_rectangle.BackColor = Color.White;
            pick_rectangle.Image = Properties.Resources.rectangle;
            pick_rectangle.Location = new Point(15, 26);
            pick_rectangle.Name = "pick_rectangle";
            pick_rectangle.Size = new Size(111, 103);
            pick_rectangle.TabIndex = 1;
            pick_rectangle.UseVisualStyleBackColor = false;
            // 
            // panelCanvas
            // 
            panelCanvas.Dock = DockStyle.Fill;
            panelCanvas.Location = new Point(0, 0);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(739, 1019);
            panelCanvas.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1006, 1019);
            Controls.Add(panelCanvas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button pick_rectangle;
        private Button pick_ellipse;
        private Button pick_hexagon;
        private Button pick_triangle;
        private Button pick_white;
        private Button pick_brown;
        private Button pick_purple;
        private Button pick_yellow;
        private Button pick_black;
        private Button pick_orange;
        private Button pick_green;
        private Button pick_blue;
        private Button pick_red;
        private Button pick_refresh;
        private Button pick_delete;
        private Button pick_cursor;
        private Button pick_save;
        private Button pick_file;
        private Panel panelCanvas;
    }
}
