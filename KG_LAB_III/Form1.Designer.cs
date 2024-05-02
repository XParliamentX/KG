namespace KG_LAB_III
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDrawAxes = new System.Windows.Forms.Button();
            this.buttonDrawFigure = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelSlide = new System.Windows.Forms.Label();
            this.buttonSlideOxRt = new System.Windows.Forms.Button();
            this.buttonSlideOxLt = new System.Windows.Forms.Button();
            this.buttonSlideOyDown = new System.Windows.Forms.Button();
            this.buttonSlideOyUp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReflectOXandOY = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.labelScale = new System.Windows.Forms.Label();
            this.buttonTurnLt = new System.Windows.Forms.Button();
            this.buttonTurnRt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelForEx3 = new System.Windows.Forms.Label();
            this.labelReflect = new System.Windows.Forms.Label();
            this.buttonReflectOX = new System.Windows.Forms.Button();
            this.buttonReflectOY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 625);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDrawAxes
            // 
            this.buttonDrawAxes.Location = new System.Drawing.Point(644, 13);
            this.buttonDrawAxes.Name = "buttonDrawAxes";
            this.buttonDrawAxes.Size = new System.Drawing.Size(196, 54);
            this.buttonDrawAxes.TabIndex = 1;
            this.buttonDrawAxes.Text = "Нарисовать Оси";
            this.buttonDrawAxes.UseVisualStyleBackColor = true;
            this.buttonDrawAxes.Click += new System.EventHandler(this.buttonDrawAxes_Click);
            // 
            // buttonDrawFigure
            // 
            this.buttonDrawFigure.Location = new System.Drawing.Point(643, 73);
            this.buttonDrawFigure.Name = "buttonDrawFigure";
            this.buttonDrawFigure.Size = new System.Drawing.Size(196, 54);
            this.buttonDrawFigure.TabIndex = 2;
            this.buttonDrawFigure.Text = "Нарисовать Фигуру";
            this.buttonDrawFigure.UseVisualStyleBackColor = true;
            this.buttonDrawFigure.Click += new System.EventHandler(this.buttonDrawFigure_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(644, 133);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(196, 54);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelSlide
            // 
            this.labelSlide.AutoSize = true;
            this.labelSlide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSlide.Location = new System.Drawing.Point(675, 233);
            this.labelSlide.Name = "labelSlide";
            this.labelSlide.Size = new System.Drawing.Size(128, 54);
            this.labelSlide.TabIndex = 4;
            this.labelSlide.Text = "Сдвиг";
            this.labelSlide.UseCompatibleTextRendering = true;
            // 
            // buttonSlideOxRt
            // 
            this.buttonSlideOxRt.Location = new System.Drawing.Point(643, 290);
            this.buttonSlideOxRt.Name = "buttonSlideOxRt";
            this.buttonSlideOxRt.Size = new System.Drawing.Size(196, 54);
            this.buttonSlideOxRt.TabIndex = 5;
            this.buttonSlideOxRt.Text = "По оси OX вправо";
            this.buttonSlideOxRt.UseVisualStyleBackColor = true;
            this.buttonSlideOxRt.Click += new System.EventHandler(this.buttonSlideOxRt_Click);
            // 
            // buttonSlideOxLt
            // 
            this.buttonSlideOxLt.Location = new System.Drawing.Point(643, 350);
            this.buttonSlideOxLt.Name = "buttonSlideOxLt";
            this.buttonSlideOxLt.Size = new System.Drawing.Size(196, 54);
            this.buttonSlideOxLt.TabIndex = 6;
            this.buttonSlideOxLt.Text = "По оси OX влево";
            this.buttonSlideOxLt.UseVisualStyleBackColor = true;
            this.buttonSlideOxLt.Click += new System.EventHandler(this.buttonSlideOxLt_Click);
            // 
            // buttonSlideOyDown
            // 
            this.buttonSlideOyDown.Location = new System.Drawing.Point(643, 410);
            this.buttonSlideOyDown.Name = "buttonSlideOyDown";
            this.buttonSlideOyDown.Size = new System.Drawing.Size(196, 54);
            this.buttonSlideOyDown.TabIndex = 7;
            this.buttonSlideOyDown.Text = "По оси OY вниз";
            this.buttonSlideOyDown.UseVisualStyleBackColor = true;
            this.buttonSlideOyDown.Click += new System.EventHandler(this.buttonSlideOyDown_Click);
            // 
            // buttonSlideOyUp
            // 
            this.buttonSlideOyUp.Location = new System.Drawing.Point(644, 470);
            this.buttonSlideOyUp.Name = "buttonSlideOyUp";
            this.buttonSlideOyUp.Size = new System.Drawing.Size(196, 54);
            this.buttonSlideOyUp.TabIndex = 8;
            this.buttonSlideOyUp.Text = "По оси OY вверх";
            this.buttonSlideOyUp.UseVisualStyleBackColor = true;
            this.buttonSlideOyUp.Click += new System.EventHandler(this.buttonSlideOyUp_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(643, 583);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(196, 54);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonReflectOXandOY
            // 
            this.buttonReflectOXandOY.Location = new System.Drawing.Point(877, 253);
            this.buttonReflectOXandOY.Name = "buttonReflectOXandOY";
            this.buttonReflectOXandOY.Size = new System.Drawing.Size(196, 54);
            this.buttonReflectOXandOY.TabIndex = 10;
            this.buttonReflectOXandOY.Text = "Отражение по OX и OY";
            this.buttonReflectOXandOY.UseVisualStyleBackColor = true;
            this.buttonReflectOXandOY.Click += new System.EventHandler(this.buttonReflect_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(877, 350);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(99, 54);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(974, 350);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(99, 54);
            this.buttonMinus.TabIndex = 14;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScale.Location = new System.Drawing.Point(876, 310);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(187, 29);
            this.labelScale.TabIndex = 15;
            this.labelScale.Text = "Масштабирование";
            this.labelScale.UseCompatibleTextRendering = true;
            // 
            // buttonTurnLt
            // 
            this.buttonTurnLt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTurnLt.Location = new System.Drawing.Point(876, 467);
            this.buttonTurnLt.Name = "buttonTurnLt";
            this.buttonTurnLt.Size = new System.Drawing.Size(99, 54);
            this.buttonTurnLt.TabIndex = 16;
            this.buttonTurnLt.Text = "Налево";
            this.buttonTurnLt.UseVisualStyleBackColor = true;
            this.buttonTurnLt.Click += new System.EventHandler(this.buttonTurnLt_Click);
            // 
            // buttonTurnRt
            // 
            this.buttonTurnRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTurnRt.Location = new System.Drawing.Point(974, 467);
            this.buttonTurnRt.Name = "buttonTurnRt";
            this.buttonTurnRt.Size = new System.Drawing.Size(99, 54);
            this.buttonTurnRt.TabIndex = 17;
            this.buttonTurnRt.Text = "Направо";
            this.buttonTurnRt.UseVisualStyleBackColor = true;
            this.buttonTurnRt.Click += new System.EventHandler(this.buttonTurnRt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(925, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Поворот";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // labelForEx3
            // 
            this.labelForEx3.AutoSize = true;
            this.labelForEx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForEx3.Location = new System.Drawing.Point(876, 28);
            this.labelForEx3.Name = "labelForEx3";
            this.labelForEx3.Size = new System.Drawing.Size(207, 39);
            this.labelForEx3.TabIndex = 19;
            this.labelForEx3.Text = "Для 3 задания";
            this.labelForEx3.UseCompatibleTextRendering = true;
            // 
            // labelReflect
            // 
            this.labelReflect.AutoSize = true;
            this.labelReflect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReflect.Location = new System.Drawing.Point(899, 95);
            this.labelReflect.Name = "labelReflect";
            this.labelReflect.Size = new System.Drawing.Size(165, 32);
            this.labelReflect.TabIndex = 20;
            this.labelReflect.Text = "Отражение";
            // 
            // buttonReflectOX
            // 
            this.buttonReflectOX.Location = new System.Drawing.Point(877, 133);
            this.buttonReflectOX.Name = "buttonReflectOX";
            this.buttonReflectOX.Size = new System.Drawing.Size(196, 54);
            this.buttonReflectOX.TabIndex = 21;
            this.buttonReflectOX.Text = "Отражение по OX";
            this.buttonReflectOX.UseVisualStyleBackColor = true;
            this.buttonReflectOX.Click += new System.EventHandler(this.buttonReflectOX_Click);
            // 
            // buttonReflectOY
            // 
            this.buttonReflectOY.Location = new System.Drawing.Point(876, 193);
            this.buttonReflectOY.Name = "buttonReflectOY";
            this.buttonReflectOY.Size = new System.Drawing.Size(196, 54);
            this.buttonReflectOY.TabIndex = 22;
            this.buttonReflectOY.Text = "Отражение по OY";
            this.buttonReflectOY.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 649);
            this.Controls.Add(this.buttonReflectOY);
            this.Controls.Add(this.buttonReflectOX);
            this.Controls.Add(this.labelReflect);
            this.Controls.Add(this.labelForEx3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTurnRt);
            this.Controls.Add(this.buttonTurnLt);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonReflectOXandOY);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSlideOyUp);
            this.Controls.Add(this.buttonSlideOyDown);
            this.Controls.Add(this.buttonSlideOxLt);
            this.Controls.Add(this.buttonSlideOxRt);
            this.Controls.Add(this.labelSlide);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDrawFigure);
            this.Controls.Add(this.buttonDrawAxes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDrawAxes;
        private System.Windows.Forms.Button buttonDrawFigure;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelSlide;
        private System.Windows.Forms.Button buttonSlideOxRt;
        private System.Windows.Forms.Button buttonSlideOxLt;
        private System.Windows.Forms.Button buttonSlideOyDown;
        private System.Windows.Forms.Button buttonSlideOyUp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReflectOXandOY;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.Button buttonTurnLt;
        private System.Windows.Forms.Button buttonTurnRt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelForEx3;
        private System.Windows.Forms.Label labelReflect;
        private System.Windows.Forms.Button buttonReflectOX;
        private System.Windows.Forms.Button buttonReflectOY;
    }
}

