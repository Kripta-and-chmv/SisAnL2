﻿namespace SisAn
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
            this.dtgrdwMatrix = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаПредпочтенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЭкспертовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаПредпочтенийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокАльтернативToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЭкспертовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lstbxAltList = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxProblem = new System.Windows.Forms.TextBox();
            this.txtbxAddAlt = new System.Windows.Forms.TextBox();
            this.btnAddAlt = new System.Windows.Forms.Button();
            this.btnDelAlt = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnEditing = new System.Windows.Forms.Button();
            this.txtbxEditing = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lstbxAltNewList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddEval = new System.Windows.Forms.TextBox();
            this.dtgrdwExp = new System.Windows.Forms.DataGridView();
            this.del_exp = new System.Windows.Forms.Button();
            this.add_exp = new System.Windows.Forms.Button();
            this.txtAddExp = new System.Windows.Forms.TextBox();
            this.edit_exp = new System.Windows.Forms.Button();
            this.txtExpEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clear_all = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.list_Alt_new = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edit_alt = new System.Windows.Forms.Button();
            this.del_alt = new System.Windows.Forms.Button();
            this.txtAltEdit = new System.Windows.Forms.TextBox();
            this.add_alt = new System.Windows.Forms.Button();
            this.txtAddAlt = new System.Windows.Forms.TextBox();
            this.list_Alt = new System.Windows.Forms.ListBox();
            this.expEval = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtgrdwMatrix2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdwMatrix)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdwExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdwMatrix2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdwMatrix
            // 
            this.dtgrdwMatrix.AllowUserToOrderColumns = true;
            this.dtgrdwMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdwMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdwMatrix.Location = new System.Drawing.Point(17, 45);
            this.dtgrdwMatrix.Name = "dtgrdwMatrix";
            this.dtgrdwMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgrdwMatrix.Size = new System.Drawing.Size(607, 244);
            this.dtgrdwMatrix.TabIndex = 0;
            this.dtgrdwMatrix.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.альтернативаToolStripMenuItem,
            this.списокЭкспертовToolStripMenuItem1,
            this.матрицаПредпочтенийToolStripMenuItem});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // альтернативаToolStripMenuItem
            // 
            this.альтернативаToolStripMenuItem.Name = "альтернативаToolStripMenuItem";
            this.альтернативаToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.альтернативаToolStripMenuItem.Text = "Список альтернатив";
            this.альтернативаToolStripMenuItem.Click += new System.EventHandler(this.альтернативаToolStripMenuItem_Click);
            // 
            // матрицаПредпочтенийToolStripMenuItem
            // 
            this.матрицаПредпочтенийToolStripMenuItem.Name = "матрицаПредпочтенийToolStripMenuItem";
            this.матрицаПредпочтенийToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.матрицаПредпочтенийToolStripMenuItem.Text = "Матрица предпочтений";
            this.матрицаПредпочтенийToolStripMenuItem.Click += new System.EventHandler(this.матрицаПредпочтенийToolStripMenuItem_Click);
            // 
            // списокЭкспертовToolStripMenuItem1
            // 
            this.списокЭкспертовToolStripMenuItem1.Name = "списокЭкспертовToolStripMenuItem1";
            this.списокЭкспертовToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.списокЭкспертовToolStripMenuItem1.Text = "Список экспертов";
            this.списокЭкспертовToolStripMenuItem1.Click += new System.EventHandler(this.списокЭкспертовToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЭкспертовToolStripMenuItem,
            this.списокАльтернативToolStripMenuItem,
            this.матрицаПредпочтенийToolStripMenuItem1});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // матрицаПредпочтенийToolStripMenuItem1
            // 
            this.матрицаПредпочтенийToolStripMenuItem1.Name = "матрицаПредпочтенийToolStripMenuItem1";
            this.матрицаПредпочтенийToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.матрицаПредпочтенийToolStripMenuItem1.Text = "Матрица предпочтений";
            this.матрицаПредпочтенийToolStripMenuItem1.Click += new System.EventHandler(this.матрицаПредпочтенийToolStripMenuItem1_Click);
            // 
            // списокАльтернативToolStripMenuItem
            // 
            this.списокАльтернативToolStripMenuItem.Name = "списокАльтернативToolStripMenuItem";
            this.списокАльтернативToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.списокАльтернативToolStripMenuItem.Text = "Список альтернатив";
            this.списокАльтернативToolStripMenuItem.Click += new System.EventHandler(this.списокАльтернативToolStripMenuItem_Click);
            // 
            // списокЭкспертовToolStripMenuItem
            // 
            this.списокЭкспертовToolStripMenuItem.Name = "списокЭкспертовToolStripMenuItem";
            this.списокЭкспертовToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.списокЭкспертовToolStripMenuItem.Text = "Список экспертов";
            this.списокЭкспертовToolStripMenuItem.Click += new System.EventHandler(this.списокЭкспертовToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstbxAltList
            // 
            this.lstbxAltList.FormattingEnabled = true;
            this.lstbxAltList.Location = new System.Drawing.Point(17, 327);
            this.lstbxAltList.Name = "lstbxAltList";
            this.lstbxAltList.Size = new System.Drawing.Size(300, 121);
            this.lstbxAltList.TabIndex = 2;
            this.lstbxAltList.DoubleClick += new System.EventHandler(this.lstbxAltList_DoubleClick);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(641, 45);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 55);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Упорядочить";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Проблема:";
            // 
            // txtbxProblem
            // 
            this.txtbxProblem.Location = new System.Drawing.Point(17, 19);
            this.txtbxProblem.Multiline = true;
            this.txtbxProblem.Name = "txtbxProblem";
            this.txtbxProblem.Size = new System.Drawing.Size(722, 20);
            this.txtbxProblem.TabIndex = 5;
            // 
            // txtbxAddAlt
            // 
            this.txtbxAddAlt.Location = new System.Drawing.Point(17, 454);
            this.txtbxAddAlt.Multiline = true;
            this.txtbxAddAlt.Name = "txtbxAddAlt";
            this.txtbxAddAlt.Size = new System.Drawing.Size(397, 41);
            this.txtbxAddAlt.TabIndex = 6;
            // 
            // btnAddAlt
            // 
            this.btnAddAlt.Location = new System.Drawing.Point(420, 455);
            this.btnAddAlt.Name = "btnAddAlt";
            this.btnAddAlt.Size = new System.Drawing.Size(100, 40);
            this.btnAddAlt.TabIndex = 7;
            this.btnAddAlt.Text = "Добавить альтернативу\r\n";
            this.btnAddAlt.UseVisualStyleBackColor = true;
            this.btnAddAlt.Click += new System.EventHandler(this.Add_altern_Click);
            // 
            // btnDelAlt
            // 
            this.btnDelAlt.Location = new System.Drawing.Point(524, 455);
            this.btnDelAlt.Name = "btnDelAlt";
            this.btnDelAlt.Size = new System.Drawing.Size(100, 40);
            this.btnDelAlt.TabIndex = 8;
            this.btnDelAlt.Text = "Удалить альтернативу";
            this.btnDelAlt.UseVisualStyleBackColor = true;
            this.btnDelAlt.Click += new System.EventHandler(this.Del_altern_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(641, 104);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(100, 40);
            this.btnDelAll.TabIndex = 9;
            this.btnDelAll.Text = "Очистить все\r\n";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.Del_All_Click);
            // 
            // btnEditing
            // 
            this.btnEditing.Location = new System.Drawing.Point(639, 455);
            this.btnEditing.Name = "btnEditing";
            this.btnEditing.Size = new System.Drawing.Size(100, 40);
            this.btnEditing.TabIndex = 10;
            this.btnEditing.Text = "Редактировать";
            this.btnEditing.UseVisualStyleBackColor = true;
            this.btnEditing.Click += new System.EventHandler(this.btnEditing_Click);
            // 
            // txtbxEditing
            // 
            this.txtbxEditing.Location = new System.Drawing.Point(639, 410);
            this.txtbxEditing.Multiline = true;
            this.txtbxEditing.Name = "txtbxEditing";
            this.txtbxEditing.Size = new System.Drawing.Size(100, 39);
            this.txtbxEditing.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 690);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lstbxAltNewList);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtbxProblem);
            this.tabPage1.Controls.Add(this.btnDelAll);
            this.tabPage1.Controls.Add(this.btnEditing);
            this.tabPage1.Controls.Add(this.btnDelAlt);
            this.tabPage1.Controls.Add(this.txtbxEditing);
            this.tabPage1.Controls.Add(this.btnAddAlt);
            this.tabPage1.Controls.Add(this.dtgrdwMatrix);
            this.tabPage1.Controls.Add(this.txtbxAddAlt);
            this.tabPage1.Controls.Add(this.btnSort);
            this.tabPage1.Controls.Add(this.lstbxAltList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 664);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Метод парных сравнений";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Итоговый список альтернатив:";
            // 
            // lstbxAltNewList
            // 
            this.lstbxAltNewList.FormattingEnabled = true;
            this.lstbxAltNewList.Location = new System.Drawing.Point(323, 327);
            this.lstbxAltNewList.Name = "lstbxAltNewList";
            this.lstbxAltNewList.Size = new System.Drawing.Size(301, 121);
            this.lstbxAltNewList.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Исходный список альтернатив:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtAddEval);
            this.tabPage2.Controls.Add(this.dtgrdwExp);
            this.tabPage2.Controls.Add(this.del_exp);
            this.tabPage2.Controls.Add(this.add_exp);
            this.tabPage2.Controls.Add(this.txtAddExp);
            this.tabPage2.Controls.Add(this.edit_exp);
            this.tabPage2.Controls.Add(this.txtExpEdit);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.clear_all);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.list_Alt_new);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.edit_alt);
            this.tabPage2.Controls.Add(this.del_alt);
            this.tabPage2.Controls.Add(this.txtAltEdit);
            this.tabPage2.Controls.Add(this.add_alt);
            this.tabPage2.Controls.Add(this.txtAddAlt);
            this.tabPage2.Controls.Add(this.list_Alt);
            this.tabPage2.Controls.Add(this.expEval);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dtgrdwMatrix2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 664);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Метод взвешенных экспертных оценок";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 572);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Оценка компетентности:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 573);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Эксперт:";
            // 
            // txtAddEval
            // 
            this.txtAddEval.Location = new System.Drawing.Point(275, 589);
            this.txtAddEval.Multiline = true;
            this.txtAddEval.Name = "txtAddEval";
            this.txtAddEval.Size = new System.Drawing.Size(130, 41);
            this.txtAddEval.TabIndex = 33;
            // 
            // dtgrdwExp
            // 
            this.dtgrdwExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdwExp.Location = new System.Drawing.Point(8, 448);
            this.dtgrdwExp.Name = "dtgrdwExp";
            this.dtgrdwExp.Size = new System.Drawing.Size(398, 121);
            this.dtgrdwExp.TabIndex = 32;
            this.dtgrdwExp.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgrdwExp_CellMouseDoubleClick);
            // 
            // del_exp
            // 
            this.del_exp.Location = new System.Drawing.Point(515, 590);
            this.del_exp.Name = "del_exp";
            this.del_exp.Size = new System.Drawing.Size(100, 40);
            this.del_exp.TabIndex = 31;
            this.del_exp.Text = "Удалить эксперта";
            this.del_exp.UseVisualStyleBackColor = true;
            this.del_exp.Click += new System.EventHandler(this.del_exp_Click);
            // 
            // add_exp
            // 
            this.add_exp.Location = new System.Drawing.Point(411, 590);
            this.add_exp.Name = "add_exp";
            this.add_exp.Size = new System.Drawing.Size(100, 40);
            this.add_exp.TabIndex = 30;
            this.add_exp.Text = "Добавить эксперта\r\n";
            this.add_exp.UseVisualStyleBackColor = true;
            this.add_exp.Click += new System.EventHandler(this.add_exp_Click);
            // 
            // txtAddExp
            // 
            this.txtAddExp.Location = new System.Drawing.Point(8, 589);
            this.txtAddExp.Multiline = true;
            this.txtAddExp.Name = "txtAddExp";
            this.txtAddExp.Size = new System.Drawing.Size(258, 41);
            this.txtAddExp.TabIndex = 29;
            // 
            // edit_exp
            // 
            this.edit_exp.Location = new System.Drawing.Point(412, 512);
            this.edit_exp.Name = "edit_exp";
            this.edit_exp.Size = new System.Drawing.Size(100, 40);
            this.edit_exp.TabIndex = 27;
            this.edit_exp.Text = "Редактировать ";
            this.edit_exp.UseVisualStyleBackColor = true;
            this.edit_exp.Click += new System.EventHandler(this.edit_exp_Click);
            // 
            // txtExpEdit
            // 
            this.txtExpEdit.Location = new System.Drawing.Point(412, 467);
            this.txtExpEdit.Multiline = true;
            this.txtExpEdit.Name = "txtExpEdit";
            this.txtExpEdit.Size = new System.Drawing.Size(100, 39);
            this.txtExpEdit.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Эксперты:";
            // 
            // clear_all
            // 
            this.clear_all.Location = new System.Drawing.Point(632, 104);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(100, 40);
            this.clear_all.TabIndex = 24;
            this.clear_all.Text = "Очистить все\r\n";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Итоговый список альтернатив:";
            // 
            // list_Alt_new
            // 
            this.list_Alt_new.FormattingEnabled = true;
            this.list_Alt_new.Location = new System.Drawing.Point(314, 274);
            this.list_Alt_new.Name = "list_Alt_new";
            this.list_Alt_new.Size = new System.Drawing.Size(301, 108);
            this.list_Alt_new.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Исходный список альтернатив:";
            // 
            // edit_alt
            // 
            this.edit_alt.Location = new System.Drawing.Point(630, 389);
            this.edit_alt.Name = "edit_alt";
            this.edit_alt.Size = new System.Drawing.Size(100, 40);
            this.edit_alt.TabIndex = 19;
            this.edit_alt.Text = "Редактировать";
            this.edit_alt.UseVisualStyleBackColor = true;
            this.edit_alt.Click += new System.EventHandler(this.edit_alt_Click);
            // 
            // del_alt
            // 
            this.del_alt.Location = new System.Drawing.Point(515, 389);
            this.del_alt.Name = "del_alt";
            this.del_alt.Size = new System.Drawing.Size(100, 40);
            this.del_alt.TabIndex = 18;
            this.del_alt.Text = "Удалить альтернативу";
            this.del_alt.UseVisualStyleBackColor = true;
            this.del_alt.Click += new System.EventHandler(this.del_alt_Click);
            // 
            // txtAltEdit
            // 
            this.txtAltEdit.Location = new System.Drawing.Point(630, 343);
            this.txtAltEdit.Multiline = true;
            this.txtAltEdit.Name = "txtAltEdit";
            this.txtAltEdit.Size = new System.Drawing.Size(100, 39);
            this.txtAltEdit.TabIndex = 20;
            // 
            // add_alt
            // 
            this.add_alt.Location = new System.Drawing.Point(411, 389);
            this.add_alt.Name = "add_alt";
            this.add_alt.Size = new System.Drawing.Size(100, 40);
            this.add_alt.TabIndex = 17;
            this.add_alt.Text = "Добавить альтернативу\r\n";
            this.add_alt.UseVisualStyleBackColor = true;
            this.add_alt.Click += new System.EventHandler(this.add_alt_Click);
            // 
            // txtAddAlt
            // 
            this.txtAddAlt.Location = new System.Drawing.Point(8, 388);
            this.txtAddAlt.Multiline = true;
            this.txtAddAlt.Name = "txtAddAlt";
            this.txtAddAlt.Size = new System.Drawing.Size(397, 41);
            this.txtAddAlt.TabIndex = 16;
            // 
            // list_Alt
            // 
            this.list_Alt.FormattingEnabled = true;
            this.list_Alt.Location = new System.Drawing.Point(8, 274);
            this.list_Alt.Name = "list_Alt";
            this.list_Alt.Size = new System.Drawing.Size(300, 108);
            this.list_Alt.TabIndex = 15;
            this.list_Alt.DoubleClick += new System.EventHandler(this.list_Alt_DoubleClick);
            // 
            // expEval
            // 
            this.expEval.Location = new System.Drawing.Point(632, 45);
            this.expEval.Name = "expEval";
            this.expEval.Size = new System.Drawing.Size(98, 53);
            this.expEval.TabIndex = 8;
            this.expEval.Text = "Упорядочить";
            this.expEval.UseVisualStyleBackColor = true;
            this.expEval.Click += new System.EventHandler(this.expEval_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Проблема:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(722, 20);
            this.textBox1.TabIndex = 7;
            // 
            // dtgrdwMatrix2
            // 
            this.dtgrdwMatrix2.AllowUserToOrderColumns = true;
            this.dtgrdwMatrix2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdwMatrix2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdwMatrix2.Location = new System.Drawing.Point(8, 45);
            this.dtgrdwMatrix2.Name = "dtgrdwMatrix2";
            this.dtgrdwMatrix2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgrdwMatrix2.Size = new System.Drawing.Size(607, 209);
            this.dtgrdwMatrix2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 721);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdwMatrix)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdwExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdwMatrix2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdwMatrix;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox lstbxAltList;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ToolStripMenuItem альтернативаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицаПредпочтенийToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxProblem;
        private System.Windows.Forms.TextBox txtbxAddAlt;
        private System.Windows.Forms.Button btnAddAlt;
        private System.Windows.Forms.Button btnDelAlt;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.ToolStripMenuItem матрицаПредпочтенийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокАльтернативToolStripMenuItem;
        private System.Windows.Forms.Button btnEditing;
        private System.Windows.Forms.TextBox txtbxEditing;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button expEval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtgrdwMatrix2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstbxAltNewList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button del_exp;
        private System.Windows.Forms.Button add_exp;
        private System.Windows.Forms.TextBox txtAddExp;
        private System.Windows.Forms.Button edit_exp;
        private System.Windows.Forms.TextBox txtExpEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox list_Alt_new;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button edit_alt;
        private System.Windows.Forms.Button del_alt;
        private System.Windows.Forms.TextBox txtAltEdit;
        private System.Windows.Forms.Button add_alt;
        private System.Windows.Forms.TextBox txtAddAlt;
        private System.Windows.Forms.ListBox list_Alt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddEval;
        private System.Windows.Forms.DataGridView dtgrdwExp;
        private System.Windows.Forms.ToolStripMenuItem списокЭкспертовToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокЭкспертовToolStripMenuItem;
    }
}

