using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace SisAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[] el = {"0", "1", "0.5", "_"};

        bool load = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgrdwMatrix.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            dtgrdwMatrix2.AllowUserToAddRows = false;
            dtgrdwExp.AllowUserToAddRows = false;
            dtgrdwExp.Columns.Add("exp", "эксперт");
            dtgrdwExp.Columns.Add("eval", "оценка");
        }

        #region

        private void button1_Click(object sender, EventArgs e) //сам алгоритм
        {
            int count = lstbxAltList.Items.Count;
            float[] C = new float[count];
            string[] sortedList = new string[count];
            for (int i = 0; i < count; i++)
            {
                sortedList[i] = lstbxAltList.Items[i].ToString();
            }
            if (!check())
            {
                return;
            }
            float R = 0;
            for (int i = 0; i < count; i++)
                C[i] = 0;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (j != i)
                    {
                        C[i] += Convert.ToSingle(dtgrdwMatrix[i, j].Value.ToString().Replace(".", ","));
                        R += Convert.ToSingle(dtgrdwMatrix[i, j].Value.ToString().Replace(".", ","));
                    }
                }

            }
            for (int i = 0; i < count; i++)
                C[i] = C[i]/R;
            BubbleSort(C, sortedList);
            lstbxAltNewList.Items.AddRange(sortedList);
        }

        void BubbleSort(float[] A, string[] sortedList) //сортировка альтернатив
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] > A[i])
                    {
                        var temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                        var tmp = sortedList[i];
                        sortedList[i] = sortedList[j];
                        sortedList[j] = tmp;
                    }
                }
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) //очистка матрицы
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: //метод парных сравнений
                {
                    for (int i = 0; i < dtgrdwMatrix.Rows.Count; ++i)
                    {

                        for (int j = 0; j < dtgrdwMatrix.Columns.Count; ++j)
                        {

                            if (i != j)
                            {
                                dtgrdwMatrix[j, i].Style.BackColor = Color.White;
                                dtgrdwMatrix[i, j].Value = "1";
                                dtgrdwMatrix[j, i].Value = "0";
                            }
                            else
                            {
                                dtgrdwMatrix[i, i].Style.BackColor = Color.Aqua;
                                dtgrdwMatrix[i, i].ReadOnly = true;
                            }

                        }
                    }
                }
                    break;
                case 1: //метод взвешенных экспертных оценок
                {
                    for (int i = 0; i < dtgrdwMatrix2.Rows.Count; ++i)
                    {

                        for (int j = 0; j < dtgrdwMatrix2.Columns.Count; ++j)
                        {
                            dtgrdwMatrix2[i, j].Value = "";
                        }
                    }
                }
                    break;

            }


        }

        bool check() //проверки
        {

            for (int i = 0; i < dtgrdwMatrix.Rows.Count; i++)
            {
                for (int j = 0; j < dtgrdwMatrix.Columns.Count; j++)
                {
                    if (i != j)
                        if ((!el.Contains(dtgrdwMatrix[i, j].Value)))
                        {
                            MessageBox.Show("Неверно задана матрица предпочтений!");
                            dtgrdwMatrix[i, j].Value = "1";
                            dtgrdwMatrix[j, i].Value = "0";
                            return false;
                        }
                        else
                        {
                            float a = Convert.ToSingle(dtgrdwMatrix[i, j].Value) +
                                      Convert.ToSingle(dtgrdwMatrix[j, i].Value);
                            if (a !=
                                1.0)
                            {
                                MessageBox.Show("Неверно задана матрица предпочтений!");
                                dtgrdwMatrix[i, j].Style.BackColor = dtgrdwMatrix[j, i].Style.BackColor = Color.Red;
                                return false;
                            }
                            else
                                return true;
                        }
                }
            }
            return true;
        }

        private void Add_altern_Click(object sender, EventArgs e) //добавить альтернативу

        {
            if (txtbxAddAlt.Text != "")
            {
                lstbxAltList.Items.Add("[" + (lstbxAltList.Items.Count + 1).ToString() + "] " + txtbxAddAlt.Text);
                txtbxAddAlt.Text = "";
                dtgrdwMatrix.Columns.Add("z" + lstbxAltList.Items.Count.ToString(),
                    "z" + lstbxAltList.Items.Count.ToString());
                dtgrdwMatrix.Rows.Add();
                dtgrdwMatrix.Rows[lstbxAltList.Items.Count - 1].HeaderCell.Value = "z" +
                                                                                   lstbxAltList.Items.Count.ToString();
                for (int i = 0; i < dtgrdwMatrix.Rows.Count; ++i)
                {
                    int j = dtgrdwMatrix.Rows.Count - 1;
                    if (i == j)
                    {
                        dtgrdwMatrix[i, i].Style.BackColor = Color.Aqua;
                        dtgrdwMatrix[i, i].ReadOnly = true;
                    }
                    else
                    {
                        dtgrdwMatrix[j, i].Value = "0";
                        dtgrdwMatrix[i, j].Value = "1";
                    }

                }
            }

        }

        private void Del_altern_Click(object sender, EventArgs e) //удаление выбранных альтернатив
        {
            if ((lstbxAltList.Items.Count != 0) && (lstbxAltList.SelectedIndex != -1))
            {
                int ch = lstbxAltList.SelectedItem.ToString().IndexOf("]");
                int k = int.Parse(lstbxAltList.SelectedItem.ToString().Substring(1, ch - 1));
                dtgrdwMatrix.Rows.RemoveAt(k - 1);
                dtgrdwMatrix.Columns.RemoveAt(k - 1);
                lstbxAltList.Items.RemoveAt(lstbxAltList.SelectedIndex);
                for (int i = 0; i < lstbxAltList.Items.Count; i++)
                {
                    dtgrdwMatrix.Rows[i].HeaderCell.Value = "z" + (i + 1).ToString();
                    dtgrdwMatrix.Columns[i].HeaderText = "z" + (i + 1).ToString();
                    int buf = lstbxAltList.Items[i].ToString().IndexOf("]", StringComparison.Ordinal);
                    int ind = int.Parse(lstbxAltList.Items[i].ToString().Substring(1, buf - 1));
                    if (ind > k)
                    {
                        //для изменения нумерации при удалении
                        lstbxAltList.Items[i] = "[" + (ind - 1).ToString() + "] " +
                                                lstbxAltList.Items[i].ToString().Remove(0, buf + 2);
                    }
                }
            }
        }

        private void Del_All_Click(object sender, EventArgs e) //очистить все
        {
            dtgrdwMatrix.Rows.Clear();
            dtgrdwMatrix.Columns.Clear();
            lstbxAltList.Items.Clear();
            load = false;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) //автоподстановка
        {
            dtgrdwMatrix[e.RowIndex, e.ColumnIndex].Value =
                (1.0 - Convert.ToSingle(dtgrdwMatrix[e.ColumnIndex, e.RowIndex].Value));
            check();
        }

        private void матрицаПредпочтенийToolStripMenuItem1_Click(object sender, EventArgs e) //сохранение МП
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string Out = string.Empty;
                        for (int i = 0; i < dtgrdwMatrix.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtgrdwMatrix.Columns.Count; j++)
                            {
                                if (i == j)
                                    Out += "_\t";
                                else
                                    Out += dtgrdwMatrix[j, i].Value + "\t";
                            }
                            Out += "\n";
                        }
                        File.WriteAllText(saveFileDialog1.FileName, Out);
                    }
                }
                    break;
                case 1:
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string Out = string.Empty;
                        for (int i = 0; i < dtgrdwMatrix2.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtgrdwMatrix2.Columns.Count; j++)
                            {
                                Out += dtgrdwMatrix2[j, i].Value + "\t";
                            }
                            Out += "\n";
                        }
                        File.WriteAllText(saveFileDialog1.FileName, Out);
                    }
                }
                    break;
            }
        }

        private void списокАльтернативToolStripMenuItem_Click(object sender, EventArgs e)
            //сохранение списка альтернатив
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Out = string.Empty;
                for (int i = 0; i < lstbxAltList.Items.Count; i++)
                {
                    Out += lstbxAltList.Items[i].ToString().Substring(4) + "\n";
                }
                File.WriteAllText(saveFileDialog1.FileName, Out, Encoding.Default);
            }
        }

        private void альтернативаToolStripMenuItem_Click(object sender, EventArgs e) //загрузка из файла
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                {
                    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string[] alts = File.ReadAllLines(openFileDialog1.FileName, Encoding.Default);
                        if ((dtgrdwMatrix.Rows.Count != 0) && (dtgrdwMatrix.Rows.Count != alts.Length))
                        {
                            MessageBox.Show("Несовпадение по размеру", "Ошибка");
                            return;
                        }
                        int pos = 0;
                        dtgrdwMatrix.Rows.Clear();

                        for (int i = 0; i < alts.Length; i++)
                        {
                            dtgrdwMatrix.Columns.Add("z" + (i + 1).ToString(), "z" + (i + 1).ToString());
                        }

                        dtgrdwMatrix.Rows.Add(alts.Length);
                        if (!load)
                        {
                            for (int j = 0; j < alts.Length; j++)
                            {
                                dtgrdwMatrix.Rows[j].HeaderCell.Value = "z" + (j + 1).ToString();
                                for (int i = 0; i < alts.Length; i++)
                                {
                                    if (j == i)
                                    {
                                        dtgrdwMatrix[i, i].Style.BackColor = Color.Aqua;
                                        dtgrdwMatrix[j, i].ReadOnly = true;
                                    }
                                    else
                                    {
                                        dtgrdwMatrix[j, i].Value = "0";
                                        dtgrdwMatrix[i, j].Value = "1";
                                    }
                                }
                            }
                        }
                        load = true;
                        lstbxAltList.Items.Clear();
                        for (int i = 1; i <= alts.Length; i++)
                        {
                            alts[i - 1] = "[" + i.ToString() + "] " + alts[i - 1];
                        }
                        lstbxAltList.Items.AddRange(alts);
                    }
                }
                    break;
                case 1:
                {
                    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string[] alts = File.ReadAllLines(openFileDialog1.FileName, Encoding.Default);
                        int pos = 0;
                        dtgrdwMatrix2.Rows.Clear();
                        
                        for (int i = 0; i < alts.Length; i++)
                        {
                            dtgrdwMatrix2.Columns.Add("z" + (i + 1).ToString(), "z" + (i + 1).ToString());
                        }
                        load = true;
                        list_Alt.Items.Clear();
                        for (int i = 1; i <= alts.Length; i++)
                        {
                            alts[i - 1] = "[" + i.ToString() + "] " + alts[i - 1];
                        }
                        list_Alt.Items.AddRange(alts);
                    }
                }
                    break;
            }

        }

        private void матрицаПредпочтенийToolStripMenuItem_Click(object sender, EventArgs e) //загрузка
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: //1 метод
                {
                    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string[] str = File.ReadAllLines(openFileDialog1.FileName, Encoding.Default);
                        if ((dtgrdwMatrix.Rows.Count != 0) && (dtgrdwMatrix.Rows.Count != str.Length))
                        {
                            MessageBox.Show("Несовпадение по размеру", "Ошибка");
                            return;
                        }
                        int pos = 0;
                        dtgrdwMatrix.Rows.Clear();
                        dtgrdwMatrix.Columns.Clear();
                        string[] c = new string[str.Length];
                        for (int i = 0; i < c.Length; i++)
                            c[i] = "[" + (i + 1).ToString() + "] ";

                        for (int i = 0; i < str.Length; i++)
                        {
                            dtgrdwMatrix.Columns.Add("z" + (i + 1).ToString(), "z" + (i + 1).ToString());
                        }

                        dtgrdwMatrix.Rows.Add(str.Length);

                        for (int i = 0; i < dtgrdwMatrix.RowCount; i++)
                        {
                            string[] buf = str[i].Split('\t');
                            for (int j = 0; j < dtgrdwMatrix.ColumnCount; j++)
                            {
                                dtgrdwMatrix[j, i].Value = buf[j];
                                pos++;
                                if (i == j)
                                {
                                    dtgrdwMatrix[i, i].Value = "";
                                    dtgrdwMatrix[i, i].ReadOnly = true;
                                    dtgrdwMatrix[i, i].Style.BackColor = Color.Aqua;
                                }
                            }
                        }
                        if (!load)
                        {
                            lstbxAltList.Items.Clear();
                            lstbxAltList.Items.AddRange(c);
                        }
                        load = true;
                    }
                }
                    break;
                case 1: //2 метод
                {
                    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string[] str = File.ReadAllLines(openFileDialog1.FileName, Encoding.Default);
                        int pos = 0;
                        dtgrdwMatrix2.Rows.Clear();
                        dtgrdwMatrix2.Columns.Clear();
                        string[] buf = str[0].Split('\t');
                        for (int i = 0; i < buf.Length; i++)
                        {
                            dtgrdwMatrix2.Columns.Add("z" + (i + 1).ToString(), "z" + (i + 1).ToString());
                        }

                        dtgrdwMatrix2.Rows.Add(str.Length);
                        for (int i = 0; i < str.Length; i++)
                        {
                            
                            for (int j = 0; j < buf.Length; j++)
                            {
                                dtgrdwMatrix2[j, i].Value = buf[j];
                                pos++;
                                dtgrdwMatrix2.Rows[i].HeaderCell.Value = "Э" + (i + 1).ToString();
                            }
                        }
                        load = true;
                    }
                    break;
                }
            }
        }

        private void btnEditing_Click(object sender, EventArgs e) //редактирование
        {
            lstbxAltList.Items[lstbxAltList.SelectedIndex] = lstbxAltList.SelectedItem.ToString().Substring(0, 4) +
                                                             txtbxEditing.Text;
            txtbxEditing.Text = "";
        }

        private void lstbxAltList_DoubleClick(object sender, EventArgs e)
            //при двойном щелчке переместить в форму для редактирвоания
        {
            if (lstbxAltList.SelectedIndices.Count != 0)
            {
                txtbxEditing.Text = lstbxAltList.Items[lstbxAltList.SelectedIndex].ToString().Substring(4);
            }
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////
        //2 LABA

        #region

        private void clear_all_Click(object sender, EventArgs e) //очистить все
        {
            dtgrdwMatrix2.Rows.Clear();
            dtgrdwMatrix2.Columns.Clear();
            list_Alt.Items.Clear();
            list_Alt_new.Items.Clear();
            dtgrdwExp.Rows.Clear();
            dtgrdwExp.Columns.Clear();
            load = false;
        }

        private void add_alt_Click(object sender, EventArgs e) //добавить альтернативу
        {
            if (txtAddAlt.Text != "")
            {
                list_Alt.Items.Add("[" + (list_Alt.Items.Count + 1).ToString() + "] " + txtAddAlt.Text);
                txtAddAlt.Text = "";
                dtgrdwMatrix2.Columns.Add("z" + list_Alt.Items.Count.ToString(), "z" + list_Alt.Items.Count.ToString());

            }
        }

        private void add_exp_Click(object sender, EventArgs e) //добавить эксперта
        {
            if (txtAddExp.Text != "" && txtAddEval.Text != "")
            {

                dtgrdwExp.Rows.Add(txtAddExp.Text, txtAddEval.Text);
                txtAddExp.Text = "";
                txtAddEval.Text = "";
                dtgrdwMatrix2.Rows.Add();
                dtgrdwMatrix2.Rows[dtgrdwExp.Rows.Count - 1].HeaderCell.Value = "Э" + dtgrdwExp.Rows.Count.ToString();
            }
        }

        //редактирование
        private void edit_alt_Click(object sender, EventArgs e) //альтернативы
        {
            list_Alt.Items[list_Alt.SelectedIndex] = list_Alt.SelectedItem.ToString().Substring(0, 4) + txtAltEdit.Text;
            txtAltEdit.Text = "";
        }

        private void edit_exp_Click(object sender, EventArgs e) //эксперта
        {
            if ((txtExpEdit.Text != "")&&(dtgrdwExp.RowCount!=0))
            {
                dtgrdwExp.CurrentCell.Value = txtExpEdit.Text;
            }
            txtExpEdit.Text = "";
        }

        //при двойном клике перемещение в форму редактирования
        private void list_Alt_DoubleClick(object sender, EventArgs e) //альтернативу
        {
            if (list_Alt.SelectedIndices.Count != 0)
            {
                txtAltEdit.Text = list_Alt.Items[list_Alt.SelectedIndex].ToString().Substring(4);
            }
        }

        private void dtgrdwExp_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) //эксперта
        {
            if (dtgrdwExp.SelectedCells.Count != 0)
            {
                txtExpEdit.Text = dtgrdwExp.CurrentCell.Value.ToString();
            }
        }

        //удаление выбранной
        private void del_alt_Click(object sender, EventArgs e) //альтернативы
        {
            if ((list_Alt.Items.Count != 0) && (list_Alt.SelectedIndex != -1))
            {
                int ch = list_Alt.SelectedItem.ToString().IndexOf("]");
                int k = int.Parse(list_Alt.SelectedItem.ToString().Substring(1, ch - 1));
                //dtgrdwMatrix2.Rows.RemoveAt(k-1);
                dtgrdwMatrix2.Columns.RemoveAt(k - 1);
                list_Alt.Items.RemoveAt(list_Alt.SelectedIndex);
                for (int i = 0; i < list_Alt.Items.Count; i++)
                {
                    //dtgrdwMatrix2.Rows[i].HeaderCell.Value = "z" + (i+1).ToString();
                    dtgrdwMatrix2.Columns[i].HeaderText = "z" + (i + 1).ToString();
                    int buf = list_Alt.Items[i].ToString().IndexOf("]", StringComparison.Ordinal);
                    int ind = int.Parse(list_Alt.Items[i].ToString().Substring(1, buf - 1));
                    if (ind > k)
                    {
                        //для изменения нумерации при удалении
                        list_Alt.Items[i] = "[" + (ind - 1).ToString() + "] " +
                                            list_Alt.Items[i].ToString().Remove(0, buf + 2);
                    }
                }
            }
        }
        private void del_exp_Click(object sender, EventArgs e) //эксперта
        {
            if ((dtgrdwExp.Rows.Count != 0) && (dtgrdwExp.SelectedRows.Count != 0))
            {
                dtgrdwMatrix2.Rows.RemoveAt(dtgrdwExp.SelectedRows[0].Index);
                dtgrdwExp.Rows.RemoveAt(dtgrdwExp.SelectedRows[0].Index);
                for (int i = 0; i < dtgrdwExp.Rows.Count; i++)
                {
                    dtgrdwMatrix2.Rows[i].HeaderCell.Value = "Э" + (i + 1).ToString();
                }
            }

        }
        private void expEval_Click(object sender, EventArgs e) //сам алгоритм
        {
            float R = 0;
            list_Alt_new.Items.Clear();
            if (!check2())
                return;

            int countExp = dtgrdwExp.Rows.Count;
            int countAlt = list_Alt.Items.Count;
            string[] sortedList = new string[countAlt];
            for (int i = 0; i < countAlt; i++)
            {
                sortedList[i] = list_Alt.Items[i].ToString();
            }
            float[] R_i = new float[countExp];
            float[] S = new float[countExp];
            float[] V = new float[countAlt];
            for (int i = 0; i < countExp; i++)
            {
                R_i[i] = Convert.ToSingle(dtgrdwExp.Rows[i].Cells[1].Value.ToString().Replace(".", ","));
                R += R_i[i];
            }
            for (int j = 0; j < countExp; j++) //относительные оценки компетенции экспертов
            {
                S[j] = R_i[j]/R;
            }
            for (int j = 0; j < countAlt; j++)
            {
                for (int i = 0; i < countExp; i++) //определяем веса
                {
                    V[j] += Convert.ToSingle(dtgrdwMatrix2[j, i].Value.ToString())*S[i];
                }

            }
            BubbleSort(V, sortedList); //сортируем
            list_Alt_new.Items.AddRange(sortedList);

        }
        private void списокЭкспертовToolStripMenuItem1_Click(object sender, EventArgs e) //загрузка списка экспертов
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1: //для второго
                {
                    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string[] alts = File.ReadAllLines(openFileDialog1.FileName, Encoding.Default);
                        int pos = 0;
                        dtgrdwExp.Rows.Clear();
                        dtgrdwExp.Columns.Clear();
                        //для списка альтернатив
                        string[] c = new string[alts.Length];
                        for (int i = 0; i < c.Length; i++)
                            c[i] = "[" + (i + 1).ToString() + "] ";
                        //для списка экспертов
                        dtgrdwExp.Columns.Add("exp", "Эксперт");
                        dtgrdwExp.Columns.Add("Eval", "Оценка");
                        dtgrdwExp.Rows.Add(alts.Length);
                        for (int i = 0; i < dtgrdwExp.RowCount; i++)
                        {
                            string[] buf = alts[i].Split('\t');
                            for (int j = 0; j < dtgrdwExp.ColumnCount; j++)
                            {
                                dtgrdwExp[j, i].Value = buf[j];
                                pos++;
                                dtgrdwExp.Rows[i].HeaderCell.Value = (i + 1).ToString();
                            }
                        }
                        if (!load)
                        {
                            list_Alt.Items.Clear();
                            list_Alt.Items.AddRange(c);
                        }
                        load = true;
                        //для матрицы
                        int posit = 0;
                        dtgrdwMatrix2.Rows.Clear();

                        dtgrdwMatrix2.Rows.Add(alts.Length);
                        for (int i = 0; i < alts.Length; i++)
                        {
                            dtgrdwMatrix2.Rows[i].HeaderCell.Value = "Э" + (i+1).ToString();
                        }

                        if (!load)
                        {
                            for (int j = 0; j < alts.Length; j++)
                            {

                                for (int i = 0; i < alts.Length; i++)
                                {
                                    dtgrdwMatrix2[j, i].Value = "";
                                }
                            }
                        }
                    }
                }
                    break;
            }
        }
        private void списокЭкспертовToolStripMenuItem_Click(object sender, EventArgs e)//сохранение списка экспертов
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string Out = string.Empty;
                        for (int i = 0; i < dtgrdwExp.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtgrdwExp.Columns.Count; j++)
                            {
                                Out += dtgrdwExp[j, i].Value + "\t";
                            }
                            Out += "\n";
                        }
                        File.WriteAllText(saveFileDialog1.FileName, Out);
                    }
                }
                    break;
            }
        }
        #endregion

        private void txtExpEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                txtExpEdit.Text += e.KeyChar;
            if ((e.KeyChar == 8)&&(txtExpEdit.Text!=""))
                txtExpEdit.Text = txtExpEdit.Text.Remove(txtExpEdit.TextLength - 1, 1);
            if ((e.KeyChar == (char) Keys.Return)&& (txtExpEdit.Text != ""))
            {
                if(dtgrdwExp.RowCount != 0)
                    dtgrdwExp.CurrentCell.Value = txtExpEdit.Text;
                txtExpEdit.Text = "";
            }
        
        }

        private void txtAddEval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                txtAddEval.Text += e.KeyChar;
            if ((e.KeyChar == 8) && (txtAddEval.Text != ""))
                txtAddEval.Text = txtAddEval.Text.Remove(txtAddEval.TextLength - 1, 1);

        }

        private void dtgrdwMatrix2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            check2();
        }

        private bool check2()
        {
            List<int> ls=new List<int>();
            for (int i = 0; i < dtgrdwMatrix2.Rows.Count; i++)
            {
                bool flag = false;
                double summ = 0;
                for (int j = 0; j < dtgrdwMatrix2.Columns.Count; j++)
                {
                    if((Convert.ToString(dtgrdwMatrix2[j, i].Value)==""))
                        flag = true;
                    summ += Convert.ToSingle(dtgrdwMatrix2[j, i].Value);
                    dtgrdwMatrix2.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
                if ((Convert.ToSingle(summ) != 1.0) || (flag))
                {
                    ls.Add(i);
                }
      
                
            }
            if (ls.Count != 0)
            {
                MessageBox.Show("Неверно задана матрица предпочтений!");
                for (int i=0; i<ls.Count; i++)
                    for (int j = 0; j < dtgrdwMatrix2.Columns.Count; j++)
                    {
                        dtgrdwMatrix2.Rows[ls[i]].Cells[j].Style.BackColor = Color.Red;
                    }
                return false;
            }
            return true;
        }

    }
    
}

