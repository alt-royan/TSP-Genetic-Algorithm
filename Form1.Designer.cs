
namespace Kursovoi_proekt
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обАлгоритмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.populationLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.citygenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАлгоритмеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обАлгоритмеToolStripMenuItem
            // 
            this.обАлгоритмеToolStripMenuItem.Name = "обАлгоритмеToolStripMenuItem";
            this.обАлгоритмеToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.обАлгоритмеToolStripMenuItem.Text = "Об алгоритме";
            this.обАлгоритмеToolStripMenuItem.Click += new System.EventHandler(this.обАлгоритмеToolStripMenuItem_Click);
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.startButton.Location = new System.Drawing.Point(12, 439);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(83, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Старт";
            this.toolTip1.SetToolTip(this.startButton, "Алгоритм начинает свою работу");
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(101, 439);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Стоп";
            this.toolTip1.SetToolTip(this.stopButton, "Алгоритм заканчивает свою работу. После этого его можно будет запустить заново");
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.populationLabel.Location = new System.Drawing.Point(416, 442);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(101, 20);
            this.populationLabel.TabIndex = 6;
            this.populationLabel.Text = "Поколение: ";
            this.toolTip1.SetToolTip(this.populationLabel, "Номер поколения отображенного на поле");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 406);
            this.panel1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.panel1, "Поле для прорисовки городов и путей. Всегда изображён лучший экземпляр из всего п" +
        "околения.");
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // citygenButton
            // 
            this.citygenButton.Location = new System.Drawing.Point(202, 438);
            this.citygenButton.Name = "citygenButton";
            this.citygenButton.Size = new System.Drawing.Size(153, 23);
            this.citygenButton.TabIndex = 8;
            this.citygenButton.Text = "Сгенерировать города";
            this.toolTip1.SetToolTip(this.citygenButton, "Генерирует города в случайных точках на поле.");
            this.citygenButton.UseVisualStyleBackColor = true;
            this.citygenButton.Click += new System.EventHandler(this.citygenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Количество городов";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(315, 463);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.numericUpDown1, "Не рекомендуется ставить значение больше 150 (медленно). Для значений меньше 50 и" +
        "спользуйте \"Медленный просмотр\"");
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanceLabel.Location = new System.Drawing.Point(416, 465);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(159, 20);
            this.distanceLabel.TabIndex = 13;
            this.distanceLabel.Text = "Минимальный путь:";
            this.toolTip1.SetToolTip(this.distanceLabel, "Минимальный путь обхода городов в этом поколении.");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 468);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Медленный просмотр";
            this.toolTip1.SetToolTip(this.checkBox1, "Замедляет время между эволюцией поколения");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 498);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.citygenButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Генетический алгоритм";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ToolStripMenuItem обАлгоритмеToolStripMenuItem;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button citygenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

