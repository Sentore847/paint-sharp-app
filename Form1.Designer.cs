namespace PaintApplication
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsBinaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openBinaryFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBoxPanel = new System.Windows.Forms.Panel();
            this.pen_width = new System.Windows.Forms.NumericUpDown();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.pick_color = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DrawingArea = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.MenuBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pen_width)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            this.SuspendLayout();
            
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.SerializationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            
            this.newToolStripMenuItem.Image = global::PaintApplication.Properties.Resources.icons8_file_24;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
             
            this.loadToolStripMenuItem.Image = global::PaintApplication.Properties.Resources.icons8_opened_folder_26;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
             
            this.clearToolStripMenuItem.Image = global::PaintApplication.Properties.Resources.icons8_broom_32;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            
            this.saveToolStripMenuItem.Image = global::PaintApplication.Properties.Resources.Save_32px;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            
            this.SerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsBinaryToolStripMenuItem1,
            this.openBinaryFileToolStripMenuItem});
            this.SerializationToolStripMenuItem.Name = "SerializationToolStripMenuItem";
            this.SerializationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SerializationToolStripMenuItem.Text = "Serialization";
            
            this.saveAsBinaryToolStripMenuItem1.Name = "saveAsBinaryToolStripMenuItem1";
            this.saveAsBinaryToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.saveAsBinaryToolStripMenuItem1.Text = "Save As Binary";
            this.saveAsBinaryToolStripMenuItem1.Click += new System.EventHandler(this.SaveAsBinaryToolStripMenuItem1_Click);
             
            this.openBinaryFileToolStripMenuItem.Name = "openBinaryFileToolStripMenuItem";
            this.openBinaryFileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openBinaryFileToolStripMenuItem.Text = "Open Binary File";
            this.openBinaryFileToolStripMenuItem.Click += new System.EventHandler(this.OpenBinaryFileToolStripMenuItem_Click);
            
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
             
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
            
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.ImageToolStripMenuItem_Click);
             
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.ColorsToolStripMenuItem_Click);
            
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
             
            this.MenuBoxPanel.Controls.Add(this.pen_width);
            this.MenuBoxPanel.Controls.Add(this.btn_save);
            this.MenuBoxPanel.Controls.Add(this.btn_clear);
            this.MenuBoxPanel.Controls.Add(this.btn_triangle);
            this.MenuBoxPanel.Controls.Add(this.btn_rectangle);
            this.MenuBoxPanel.Controls.Add(this.btn_ellipse);
            this.MenuBoxPanel.Controls.Add(this.btn_line);
            this.MenuBoxPanel.Controls.Add(this.btn_erase);
            this.MenuBoxPanel.Controls.Add(this.btn_fill);
            this.MenuBoxPanel.Controls.Add(this.btn_color);
            this.MenuBoxPanel.Controls.Add(this.pick_color);
            this.MenuBoxPanel.Controls.Add(this.btn_pencil);
            this.MenuBoxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBoxPanel.Location = new System.Drawing.Point(0, 24);
            this.MenuBoxPanel.Name = "MenuBoxPanel";
            this.MenuBoxPanel.Size = new System.Drawing.Size(59, 545);
            this.MenuBoxPanel.TabIndex = 2;
            
            this.pen_width.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pen_width.Location = new System.Drawing.Point(9, 54);
            this.pen_width.Name = "pen_width";
            this.pen_width.Size = new System.Drawing.Size(37, 20);
            this.pen_width.TabIndex = 11;
            this.toolTip1.SetToolTip(this.pen_width, "Pen And Shapes Width Size");
            this.pen_width.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pen_width.ValueChanged += new System.EventHandler(this.Pen_width_ValueChanged);
             
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Image = global::PaintApplication.Properties.Resources.Save_32px;
            this.btn_save.Location = new System.Drawing.Point(9, 449);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(37, 35);
            this.btn_save.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btn_save, "Save Drawing");
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
             
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Image = global::PaintApplication.Properties.Resources.icons8_broom_32;
            this.btn_clear.Location = new System.Drawing.Point(9, 408);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(37, 35);
            this.btn_clear.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_clear, "Clear Drawing");
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            
            this.btn_triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_triangle.Image = global::PaintApplication.Properties.Resources.Triangle_32px;
            this.btn_triangle.Location = new System.Drawing.Point(9, 367);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(37, 35);
            this.btn_triangle.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_triangle, "Triangle");
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.Btn_triangle_Click);
            
            this.btn_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rectangle.Image = global::PaintApplication.Properties.Resources.Rectangle_Stroked_32px;
            this.btn_rectangle.Location = new System.Drawing.Point(9, 326);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(37, 35);
            this.btn_rectangle.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_rectangle, "Rectangle");
            this.btn_rectangle.UseVisualStyleBackColor = true;
            this.btn_rectangle.Click += new System.EventHandler(this.Btn_rectangle_Click);
            
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.Image = global::PaintApplication.Properties.Resources.Circle_32px;
            this.btn_ellipse.Location = new System.Drawing.Point(9, 285);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(37, 35);
            this.btn_ellipse.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_ellipse, "Ellipse");
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.Btn_ellipse_Click);
             
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.Image = global::PaintApplication.Properties.Resources.icons8_line_24;
            this.btn_line.Location = new System.Drawing.Point(9, 244);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(37, 35);
            this.btn_line.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_line, "Line");
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.Btn_line_Click);
            
            this.btn_erase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_erase.Image = global::PaintApplication.Properties.Resources.Erase_32px;
            this.btn_erase.Location = new System.Drawing.Point(9, 203);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(37, 35);
            this.btn_erase.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_erase, "Eraser");
            this.btn_erase.UseVisualStyleBackColor = true;
            this.btn_erase.Click += new System.EventHandler(this.Btn_erase_Click);
            
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.Image = global::PaintApplication.Properties.Resources.icons8_fill_color_30;
            this.btn_fill.Location = new System.Drawing.Point(9, 162);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(37, 35);
            this.btn_fill.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_fill, "Fill Selected Color In Shapes");
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.Btn_fill_Click);
             
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.Image = global::PaintApplication.Properties.Resources.icons8_color_64;
            this.btn_color.Location = new System.Drawing.Point(9, 121);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(37, 35);
            this.btn_color.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_color, "Color Picker");
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.Btn_color_Click);
            
            this.pick_color.BackColor = System.Drawing.Color.Black;
            this.pick_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pick_color.Location = new System.Drawing.Point(9, 80);
            this.pick_color.Name = "pick_color";
            this.pick_color.Size = new System.Drawing.Size(37, 35);
            this.pick_color.TabIndex = 1;
            this.toolTip1.SetToolTip(this.pick_color, "Current Color For Pen And Shapes");
            this.pick_color.UseVisualStyleBackColor = false;
             
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_pencil.Image = global::PaintApplication.Properties.Resources.Edit_32px;
            this.btn_pencil.Location = new System.Drawing.Point(9, 12);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(37, 35);
            this.btn_pencil.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_pencil, "Pen");
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.Btn_pencil_Click);
             
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(810, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
             
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            
            this.DrawingArea.BackColor = System.Drawing.Color.White;
            this.DrawingArea.Location = new System.Drawing.Point(52, 24);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(758, 545);
            this.DrawingArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DrawingArea.TabIndex = 3;
            this.DrawingArea.TabStop = false;
            this.DrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingArea_Paint);
            this.DrawingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseClick);
            this.DrawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseDown);
            this.DrawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseMove);
            this.DrawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseUp);
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 591);
            this.Controls.Add(this.DrawingArea);
            this.Controls.Add(this.MenuBoxPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pen_width)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel MenuBoxPanel;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button pick_color;
        private System.Windows.Forms.PictureBox DrawingArea;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_erase;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ToolStripMenuItem SerializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsBinaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openBinaryFileToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown pen_width;
    }
}

