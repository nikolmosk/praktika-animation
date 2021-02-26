
namespace Практика04._02._2021
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.But_Anim = new System.Windows.Forms.Button();
            this.But_Del = new System.Windows.Forms.Button();
            this.But_Draw = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 30;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 166);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // But_Anim
            // 
            this.But_Anim.Location = new System.Drawing.Point(328, 31);
            this.But_Anim.Margin = new System.Windows.Forms.Padding(2);
            this.But_Anim.Name = "But_Anim";
            this.But_Anim.Size = new System.Drawing.Size(116, 29);
            this.But_Anim.TabIndex = 2;
            this.But_Anim.Text = "Оживить";
            this.But_Anim.UseVisualStyleBackColor = true;
            this.But_Anim.Click += new System.EventHandler(this.But_Anim_Click);
            // 
            // But_Del
            // 
            this.But_Del.Location = new System.Drawing.Point(201, 31);
            this.But_Del.Margin = new System.Windows.Forms.Padding(2);
            this.But_Del.Name = "But_Del";
            this.But_Del.Size = new System.Drawing.Size(113, 29);
            this.But_Del.TabIndex = 1;
            this.But_Del.Text = "Стереть";
            this.But_Del.UseVisualStyleBackColor = true;
            this.But_Del.Click += new System.EventHandler(this.But_Del_Click);
            // 
            // But_Draw
            // 
            this.But_Draw.Location = new System.Drawing.Point(78, 31);
            this.But_Draw.Margin = new System.Windows.Forms.Padding(2);
            this.But_Draw.Name = "But_Draw";
            this.But_Draw.Size = new System.Drawing.Size(113, 29);
            this.But_Draw.TabIndex = 0;
            this.But_Draw.Text = "Нарисовать";
            this.But_Draw.UseVisualStyleBackColor = true;
            this.But_Draw.Click += new System.EventHandler(this.But_Draw_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.splitContainer1.Panel2.Controls.Add(this.But_Anim);
            this.splitContainer1.Panel2.Controls.Add(this.But_Del);
            this.splitContainer1.Panel2.Controls.Add(this.But_Draw);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(516, 287);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 287);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button But_Anim;
        private System.Windows.Forms.Button But_Del;
        private System.Windows.Forms.Button But_Draw;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

