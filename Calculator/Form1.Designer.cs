namespace WinFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_file = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_create = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_open = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_save = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_page_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_print = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_del = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_bing = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_search = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_find_more = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_replace = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_go_to = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_select_all = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_date_time = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_format = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_word_hyp = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_font = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_view = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_scale = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_increase = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_decrease = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_default_scale = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_status_bar = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_view_help = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_abt = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_file,
            this.btn_edit,
            this.btn_format,
            this.btn_view,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_file
            // 
            this.btn_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_create,
            this.btn_open,
            this.btn_save,
            this.btn_save_as,
            this.btn_page_settings,
            this.btn_print,
            this.btn_exit});
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(48, 20);
            this.btn_file.Text = "Файл";
            // 
            // btn_create
            // 
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(204, 22);
            this.btn_create.Text = "Создать";
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(204, 22);
            this.btn_open.Text = "Открыть...";
            this.btn_open.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // btn_save
            // 
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(204, 22);
            this.btn_save.Text = "Сохранить";
            // 
            // btn_save_as
            // 
            this.btn_save_as.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btn_save_as.Name = "btn_save_as";
            this.btn_save_as.Size = new System.Drawing.Size(204, 22);
            this.btn_save_as.Text = "Сохранить как...";
            this.btn_save_as.Click += new System.EventHandler(this.btn_save_as_Click);
            // 
            // btn_page_settings
            // 
            this.btn_page_settings.Name = "btn_page_settings";
            this.btn_page_settings.Size = new System.Drawing.Size(204, 22);
            this.btn_page_settings.Text = "Параметры страницы...";
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(204, 22);
            this.btn_print.Text = "Печать...";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(204, 22);
            this.btn_exit.Text = "Выход";
            // 
            // btn_edit
            // 
            this.btn_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cancel,
            this.вырезатьToolStripMenuItem,
            this.btn_copy,
            this.btn_paste,
            this.btn_del,
            this.btn_bing,
            this.btn_search,
            this.btn_find_more,
            this.btn_replace,
            this.btn_go_to,
            this.btn_select_all,
            this.btn_date_time});
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(59, 20);
            this.btn_edit.Text = "Правка";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(214, 22);
            this.btn_cancel.Text = "Отменить";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // btn_copy
            // 
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(214, 22);
            this.btn_copy.Text = "Копировать";
            // 
            // btn_paste
            // 
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(214, 22);
            this.btn_paste.Text = "Вставить";
            // 
            // btn_del
            // 
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(214, 22);
            this.btn_del.Text = "Удалить";
            // 
            // btn_bing
            // 
            this.btn_bing.Name = "btn_bing";
            this.btn_bing.Size = new System.Drawing.Size(214, 22);
            this.btn_bing.Text = "Поиск с помощью Bing...";
            // 
            // btn_search
            // 
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(214, 22);
            this.btn_search.Text = "Найти...";
            // 
            // btn_find_more
            // 
            this.btn_find_more.Name = "btn_find_more";
            this.btn_find_more.Size = new System.Drawing.Size(214, 22);
            this.btn_find_more.Text = "Найти далее";
            // 
            // btn_replace
            // 
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(214, 22);
            this.btn_replace.Text = "Заменить...";
            // 
            // btn_go_to
            // 
            this.btn_go_to.Name = "btn_go_to";
            this.btn_go_to.Size = new System.Drawing.Size(214, 22);
            this.btn_go_to.Text = "Перейти...";
            // 
            // btn_select_all
            // 
            this.btn_select_all.Name = "btn_select_all";
            this.btn_select_all.Size = new System.Drawing.Size(214, 22);
            this.btn_select_all.Text = "Выделелить все";
            // 
            // btn_date_time
            // 
            this.btn_date_time.Name = "btn_date_time";
            this.btn_date_time.Size = new System.Drawing.Size(214, 22);
            this.btn_date_time.Text = "Время и дата";
            // 
            // btn_format
            // 
            this.btn_format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_word_hyp,
            this.btn_font});
            this.btn_format.Name = "btn_format";
            this.btn_format.Size = new System.Drawing.Size(62, 20);
            this.btn_format.Text = "Формат";
            // 
            // btn_word_hyp
            // 
            this.btn_word_hyp.Name = "btn_word_hyp";
            this.btn_word_hyp.Size = new System.Drawing.Size(183, 22);
            this.btn_word_hyp.Text = "Перенос по словам";
            // 
            // btn_font
            // 
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(183, 22);
            this.btn_font.Text = "Шрифт...";
            // 
            // btn_view
            // 
            this.btn_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_scale,
            this.btn_status_bar});
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(39, 20);
            this.btn_view.Text = "Вид";
            // 
            // btn_scale
            // 
            this.btn_scale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_increase,
            this.btn_decrease,
            this.btn_default_scale});
            this.btn_scale.Name = "btn_scale";
            this.btn_scale.Size = new System.Drawing.Size(173, 22);
            this.btn_scale.Text = "Масштаб";
            // 
            // btn_increase
            // 
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(288, 22);
            this.btn_increase.Text = "Увеличить";
            // 
            // btn_decrease
            // 
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Size = new System.Drawing.Size(288, 22);
            this.btn_decrease.Text = "Уменьшить";
            // 
            // btn_default_scale
            // 
            this.btn_default_scale.Name = "btn_default_scale";
            this.btn_default_scale.Size = new System.Drawing.Size(288, 22);
            this.btn_default_scale.Text = "Восстановить масштаб по умолчанию";
            // 
            // btn_status_bar
            // 
            this.btn_status_bar.CheckOnClick = true;
            this.btn_status_bar.Name = "btn_status_bar";
            this.btn_status_bar.Size = new System.Drawing.Size(173, 22);
            this.btn_status_bar.Text = "Строка состояния";
            // 
            // about
            // 
            this.about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_view_help,
            this.btn_abt});
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(65, 20);
            this.about.Text = "Справка";
            // 
            // btn_view_help
            // 
            this.btn_view_help.Name = "btn_view_help";
            this.btn_view_help.Size = new System.Drawing.Size(195, 22);
            this.btn_view_help.Text = "Просмотреть справку";
            // 
            // btn_abt
            // 
            this.btn_abt.Name = "btn_abt";
            this.btn_abt.Size = new System.Drawing.Size(195, 22);
            this.btn_abt.Text = "О программе";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(685, 471);
            this.textBox1.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(762, 167);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(10, 213);
            this.vScrollBar1.TabIndex = 2;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 471);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(685, 17);
            this.hScrollBar1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vScrollBar2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 488);
            this.panel1.TabIndex = 4;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar2.Location = new System.Drawing.Point(668, 0);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 471);
            this.vScrollBar2.TabIndex = 4;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btn_file;
        private ToolStripMenuItem btn_create;
        private ToolStripMenuItem btn_open;
        private ToolStripMenuItem btn_save;
        private ToolStripMenuItem btn_save_as;
        private ToolStripMenuItem btn_page_settings;
        private ToolStripMenuItem btn_print;
        private ToolStripMenuItem btn_exit;
        private ToolStripMenuItem btn_edit;
        private ToolStripMenuItem btn_cancel;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem btn_copy;
        private ToolStripMenuItem btn_paste;
        private ToolStripMenuItem btn_del;
        private ToolStripMenuItem btn_bing;
        private ToolStripMenuItem btn_search;
        private ToolStripMenuItem btn_find_more;
        private ToolStripMenuItem btn_replace;
        private ToolStripMenuItem btn_go_to;
        private ToolStripMenuItem btn_select_all;
        private ToolStripMenuItem btn_date_time;
        private ToolStripMenuItem btn_format;
        private ToolStripMenuItem btn_word_hyp;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem btn_view;
        private ToolStripMenuItem about;
        private ToolStripMenuItem btn_font;
        private ToolStripMenuItem btn_scale;
        private ToolStripMenuItem btn_status_bar;
        private ToolStripMenuItem btn_view_help;
        private ToolStripMenuItem btn_abt;
        private TextBox textBox1;
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
        private Panel panel1;
        private VScrollBar vScrollBar2;
        private ToolStripMenuItem btn_increase;
        private ToolStripMenuItem btn_decrease;
        private ToolStripMenuItem btn_default_scale;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
    }
}