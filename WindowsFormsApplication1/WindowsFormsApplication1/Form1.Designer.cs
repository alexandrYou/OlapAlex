namespace WindowsFormsApplication1
{
  partial class Form1
  {
    /// <summary>
    /// Требуется переменная конструктора.
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
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.декодироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переводСтрокиMACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранениеMACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.передачаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.передатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.декодироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 111);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 195);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 111);
            this.textBox2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.кодироватьToolStripMenuItem,
            this.декодироватьToolStripMenuItem,
            this.переводСтрокиMACToolStripMenuItem,
            this.сохранениеMACToolStripMenuItem,
            this.проверкаToolStripMenuItem,
            this.передачаДанныхToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // кодироватьToolStripMenuItem
            // 
            this.кодироватьToolStripMenuItem.Name = "кодироватьToolStripMenuItem";
            this.кодироватьToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.кодироватьToolStripMenuItem.Text = "Кодировать";
            this.кодироватьToolStripMenuItem.Click += new System.EventHandler(this.кодироватьToolStripMenuItem_Click);
            // 
            // декодироватьToolStripMenuItem
            // 
            this.декодироватьToolStripMenuItem.Name = "декодироватьToolStripMenuItem";
            this.декодироватьToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.декодироватьToolStripMenuItem.Text = "Декодировать";
            this.декодироватьToolStripMenuItem.Click += new System.EventHandler(this.декодироватьToolStripMenuItem_Click);
            // 
            // переводСтрокиMACToolStripMenuItem
            // 
            this.переводСтрокиMACToolStripMenuItem.Name = "переводСтрокиMACToolStripMenuItem";
            this.переводСтрокиMACToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.переводСтрокиMACToolStripMenuItem.Text = "Перевод строки MAC";
            this.переводСтрокиMACToolStripMenuItem.Click += new System.EventHandler(this.переводСтрокиMACToolStripMenuItem_Click);
            // 
            // сохранениеMACToolStripMenuItem
            // 
            this.сохранениеMACToolStripMenuItem.Name = "сохранениеMACToolStripMenuItem";
            this.сохранениеMACToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.сохранениеMACToolStripMenuItem.Text = "Сохранение MAC";
            this.сохранениеMACToolStripMenuItem.Click += new System.EventHandler(this.сохранениеMACToolStripMenuItem_Click);
            // 
            // проверкаToolStripMenuItem
            // 
            this.проверкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кодироватьToolStripMenuItem1,
            this.проверкаToolStripMenuItem1});
            this.проверкаToolStripMenuItem.Name = "проверкаToolStripMenuItem";
            this.проверкаToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.проверкаToolStripMenuItem.Text = "Проверка";
            // 
            // кодироватьToolStripMenuItem1
            // 
            this.кодироватьToolStripMenuItem1.Name = "кодироватьToolStripMenuItem1";
            this.кодироватьToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.кодироватьToolStripMenuItem1.Text = "Кодировать";
            this.кодироватьToolStripMenuItem1.Click += new System.EventHandler(this.кодироватьToolStripMenuItem1_Click);
            // 
            // проверкаToolStripMenuItem1
            // 
            this.проверкаToolStripMenuItem1.Name = "проверкаToolStripMenuItem1";
            this.проверкаToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.проверкаToolStripMenuItem1.Text = "Проверка";
            this.проверкаToolStripMenuItem1.Click += new System.EventHandler(this.проверкаToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 328);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 101);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(203, 66);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 111);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(203, 195);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 111);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(391, 66);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(258, 111);
            this.textBox6.TabIndex = 7;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(391, 328);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(258, 101);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(391, 195);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(258, 111);
            this.textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(203, 328);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(182, 101);
            this.textBox9.TabIndex = 10;
            // 
            // передачаДанныхToolStripMenuItem
            // 
            this.передачаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.передатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem1,
            this.декодироватьToolStripMenuItem1});
            this.передачаДанныхToolStripMenuItem.Name = "передачаДанныхToolStripMenuItem";
            this.передачаДанныхToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.передачаДанныхToolStripMenuItem.Text = "Передача данных";
            // 
            // передатьToolStripMenuItem
            // 
            this.передатьToolStripMenuItem.Name = "передатьToolStripMenuItem";
            this.передатьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.передатьToolStripMenuItem.Text = "Передать";
            this.передатьToolStripMenuItem.Click += new System.EventHandler(this.передатьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click_1);
            // 
            // декодироватьToolStripMenuItem1
            // 
            this.декодироватьToolStripMenuItem1.Name = "декодироватьToolStripMenuItem1";
            this.декодироватьToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.декодироватьToolStripMenuItem1.Text = "Декодировать";
            this.декодироватьToolStripMenuItem1.Click += new System.EventHandler(this.декодироватьToolStripMenuItem1_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(655, 66);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(272, 111);
            this.textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(655, 195);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(272, 111);
            this.textBox11.TabIndex = 12;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(655, 328);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(272, 101);
            this.textBox12.TabIndex = 13;
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(939, 499);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ToolStripMenuItem кодироватьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem декодироватьToolStripMenuItem;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.ToolStripMenuItem переводСтрокиMACToolStripMenuItem;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.ToolStripMenuItem сохранениеMACToolStripMenuItem;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.ToolStripMenuItem проверкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem кодироватьToolStripMenuItem1;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.ToolStripMenuItem проверкаToolStripMenuItem1;
    private System.Windows.Forms.OpenFileDialog openFileDialog2;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.TextBox textBox9;
    private System.Windows.Forms.ToolStripMenuItem передачаДанныхToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem передатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem декодироватьToolStripMenuItem1;
    private System.Windows.Forms.TextBox textBox10;
    private System.Windows.Forms.TextBox textBox11;
    private System.Windows.Forms.TextBox textBox12;
    private System.Windows.Forms.SaveFileDialog saveFileDialog2;

  }
}

