namespace Flappy_Bird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.top1 = new System.Windows.Forms.PictureBox();
            this.bottom1 = new System.Windows.Forms.PictureBox();
            this.top2 = new System.Windows.Forms.PictureBox();
            this.bottom2 = new System.Windows.Forms.PictureBox();
            this.conchim = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.top1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchim)).BeginInit();
            this.SuspendLayout();
            // 
            // top1
            // 
            this.top1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top1.BackgroundImage")));
            this.top1.Location = new System.Drawing.Point(91, -660);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(264, 990);
            this.top1.TabIndex = 0;
            this.top1.TabStop = false;
            // 
            // bottom1
            // 
            this.bottom1.Image = ((System.Drawing.Image)(resources.GetObject("bottom1.Image")));
            this.bottom1.Location = new System.Drawing.Point(461, 362);
            this.bottom1.Name = "bottom1";
            this.bottom1.Size = new System.Drawing.Size(270, 327);
            this.bottom1.TabIndex = 1;
            this.bottom1.TabStop = false;
            // 
            // top2
            // 
            this.top2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top2.BackgroundImage")));
            this.top2.Location = new System.Drawing.Point(878, -781);
            this.top2.Name = "top2";
            this.top2.Size = new System.Drawing.Size(264, 990);
            this.top2.TabIndex = 2;
            this.top2.TabStop = false;
            // 
            // bottom2
            // 
            this.bottom2.Image = ((System.Drawing.Image)(resources.GetObject("bottom2.Image")));
            this.bottom2.Location = new System.Drawing.Point(939, 420);
            this.bottom2.Name = "bottom2";
            this.bottom2.Size = new System.Drawing.Size(270, 327);
            this.bottom2.TabIndex = 3;
            this.bottom2.TabStop = false;
            // 
            // conchim
            // 
            this.conchim.Image = ((System.Drawing.Image)(resources.GetObject("conchim.Image")));
            this.conchim.Location = new System.Drawing.Point(56, 374);
            this.conchim.Name = "conchim";
            this.conchim.Size = new System.Drawing.Size(129, 102);
            this.conchim.TabIndex = 4;
            this.conchim.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn
            // 
            this.btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn.BackgroundImage")));
            this.btn.Location = new System.Drawing.Point(37, 25);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(48, 48);
            this.btn.TabIndex = 5;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1221, 672);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.conchim);
            this.Controls.Add(this.bottom2);
            this.Controls.Add(this.top2);
            this.Controls.Add(this.bottom1);
            this.Controls.Add(this.top1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.top1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox top1;
        private PictureBox bottom1;
        private PictureBox top2;
        private PictureBox bottom2;
        private PictureBox conchim;
        private System.Windows.Forms.Timer timer;
        private Button btn;
    }
}