
namespace Exam
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
            this.buStart = new System.Windows.Forms.Button();
            this.laTimer = new System.Windows.Forms.Label();
            this.laCorrect = new System.Windows.Forms.Label();
            this.laIncorrect = new System.Windows.Forms.Label();
            this.laLevel = new System.Windows.Forms.Label();
            this.buIncrease = new System.Windows.Forms.Button();
            this.buDecrease = new System.Windows.Forms.Button();
            this.px = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.px)).BeginInit();
            this.SuspendLayout();
            // 
            // buStart
            // 
            this.buStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buStart.Location = new System.Drawing.Point(463, 36);
            this.buStart.Name = "buStart";
            this.buStart.Size = new System.Drawing.Size(162, 69);
            this.buStart.TabIndex = 0;
            this.buStart.Text = "Старт";
            this.buStart.UseVisualStyleBackColor = true;
            // 
            // laTimer
            // 
            this.laTimer.AutoSize = true;
            this.laTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laTimer.Location = new System.Drawing.Point(767, 62);
            this.laTimer.Name = "laTimer";
            this.laTimer.Size = new System.Drawing.Size(74, 25);
            this.laTimer.TabIndex = 1;
            this.laTimer.Text = "Время";
            // 
            // laCorrect
            // 
            this.laCorrect.AutoSize = true;
            this.laCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCorrect.Location = new System.Drawing.Point(273, 36);
            this.laCorrect.Name = "laCorrect";
            this.laCorrect.Size = new System.Drawing.Size(68, 25);
            this.laCorrect.TabIndex = 2;
            this.laCorrect.Text = "Верно";
            // 
            // laIncorrect
            // 
            this.laIncorrect.AutoSize = true;
            this.laIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laIncorrect.Location = new System.Drawing.Point(273, 74);
            this.laIncorrect.Name = "laIncorrect";
            this.laIncorrect.Size = new System.Drawing.Size(90, 25);
            this.laIncorrect.TabIndex = 3;
            this.laIncorrect.Text = "Неверно";
            // 
            // laLevel
            // 
            this.laLevel.AutoSize = true;
            this.laLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laLevel.Location = new System.Drawing.Point(72, 21);
            this.laLevel.Name = "laLevel";
            this.laLevel.Size = new System.Drawing.Size(88, 25);
            this.laLevel.TabIndex = 4;
            this.laLevel.Text = "Уровень";
            // 
            // buIncrease
            // 
            this.buIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buIncrease.Location = new System.Drawing.Point(52, 62);
            this.buIncrease.Name = "buIncrease";
            this.buIncrease.Size = new System.Drawing.Size(45, 47);
            this.buIncrease.TabIndex = 5;
            this.buIncrease.Text = "+";
            this.buIncrease.UseVisualStyleBackColor = true;
            // 
            // buDecrease
            // 
            this.buDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buDecrease.Location = new System.Drawing.Point(115, 63);
            this.buDecrease.Name = "buDecrease";
            this.buDecrease.Size = new System.Drawing.Size(53, 46);
            this.buDecrease.TabIndex = 6;
            this.buDecrease.Text = "-";
            this.buDecrease.UseVisualStyleBackColor = true;
            // 
            // px
            // 
            this.px.Location = new System.Drawing.Point(26, 141);
            this.px.Name = "px";
            this.px.Size = new System.Drawing.Size(823, 422);
            this.px.TabIndex = 7;
            this.px.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 587);
            this.Controls.Add(this.px);
            this.Controls.Add(this.buDecrease);
            this.Controls.Add(this.buIncrease);
            this.Controls.Add(this.laLevel);
            this.Controls.Add(this.laIncorrect);
            this.Controls.Add(this.laCorrect);
            this.Controls.Add(this.laTimer);
            this.Controls.Add(this.buStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.px)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buStart;
        private System.Windows.Forms.Label laTimer;
        private System.Windows.Forms.Label laCorrect;
        private System.Windows.Forms.Label laIncorrect;
        private System.Windows.Forms.Label laLevel;
        private System.Windows.Forms.Button buIncrease;
        private System.Windows.Forms.Button buDecrease;
        private System.Windows.Forms.PictureBox px;
    }
}

