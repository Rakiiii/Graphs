using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graphs;

namespace Graphs
{
    //TODO : add file save for graph

    public partial class Form1 : Form
    {
        //объявляем переменнуб для хранения пути
        string path = @"C:\someTestStuff.txt";

        //инициализируем объект для работы с выбором папки
        OpenFileDialog fbd = new OpenFileDialog();

        //инициализируем объект для работы с выбором пути до файла
        FrmError frmError = new FrmError();

        //инициалтхзируем список координат для случайного расположения графа
        List<Point> cordsRand;

        //инициализируем список координат для графа по уровням
        List<Point> cordsLvled;

        //иницаилиируем объект для работы с псевдослучайными велечинами
        Random rnd = new Random((int)DateTimeOffset.Now.ToUnixTimeSeconds());

        grapher gr;


        public Form1()
        {
            InitializeComponent();

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //выбор пути к папке
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            try
            {
                //инициалтзируем битмап для рисования
                Bitmap mainBtm = new Bitmap(pctrbxMain.Width, pctrbxMain.Height);

                //если путь не выбран выкинуть ошибку
                if (path == null)
                {
                    frmError.ShowDialog();
                    return;
                }
                //если выбран случайное расположение вершин
                if (rdbtnAsAgraph.Checked)
                {
                    //инициализируем наш граф
                    if (gr == null)
                        gr = new grapher(path);
                    if(cordsRand == null)
                        cordsRand = new List<Point>();

                    //заполняем кооринаты графа случайным образом
                    for (int i = 0; i <= gr.amountOfVertex - 1; i++)
                    {
                        cordsRand.Add( new Point( rnd.Next(pctrbxMain.Width), rnd.Next(pctrbxMain.Height) ) );
                    }
                    //ртсуем граф
                    mainBtm = gr.drawGraph(cordsRand, mainBtm);
                    pctrbxMain.Image = mainBtm;
                }
                else
                {
                    //инициализируем граф
                    if(gr == null)
                    gr = new grapher(path);
                    if(cordsLvled == null)
                        cordsLvled = new List<Point>();

                    //красим граф
                    gr.colorGraph();

                    //расчитываем самый глупый вариант развития событий
                    if (cordsRand == null)
                        cordsRand = new List<Point>();

                    //заполняем кооринаты графа случайным образом
                    for (int i = 0; i <= gr.amountOfVertex - 1; i++)
                    {
                        cordsRand.Add(new Point(rnd.Next(pctrbxMain.Width), rnd.Next(pctrbxMain.Height)));
                    }

                    //перфоманс
                    int amOfCol = gr.checkAmountOfColors();

                    //заполням первично список
                    for(int i = 0; i < gr.amountOfVertex; i ++)
                    {
                        cordsLvled.Add(new Point(0, 0));
                    }
                    //считаем координаты раскрагенного графа
                    for ( int i = 1; i <= amOfCol; i++)
                    {
                        //коэффицкнт для расположения вершин на 1 уровне
                        int k = 1;

                        for(int j = 0; j < gr.amountOfVertex; j++)
                        {
                            //если цвет вершины сопадает с считаемым уровнем
                            if(gr.checkColorOfVertex(j) == i)
                            {
                                //то присваиваем ей координату 
                                cordsLvled[j] =( new Point( k*pctrbxMain.Width/(gr.checkAmountOfColor(i) + 1), i * ( pctrbxMain.Height / (amOfCol + 1) ) ) );

                                //инкрементируем коэффицент красоты
                                k++;
                            }
                        }
                    }

                    //рисуем левелный граф
                    mainBtm = gr.drawGraph(cordsLvled, mainBtm);
                    pctrbxMain.Image = mainBtm;
                }
            }catch(Exception error)
            {
                //отправляем ошибку в логгер
                Logger.writeLog( Convert.ToString(error));
            }
        }

        //выбор папки
        private void selectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //если кликнут ок
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    //если в пути имеется расширение .txt
                    if (fbd.FileName.IndexOf(".txt") != -1)
                    {
                        path = fbd.FileName;
                    }
                    //если выбран не текстовый файл , то выдать ошибку
                    else frmError.ShowDialog();
                }
            }catch(Exception er)
            {
                Logger.writeLog(Convert.ToString(er));
            }
        }

        private void txtbxFirstVertex_KeyPress(object sender, KeyPressEventArgs e)
        {
            //отлавливаем случайные ошибки

            try
            {
                //отсеиваем все кроме чисел
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    return;
                }
                else
                {
                  //разарешаем удаление 
                  if (e.KeyChar == '\b')
                  {
                   return;
                  }
                  //двигаем фокус на следующий элемент
                  if (e.KeyChar == (char)Keys.Enter)
                  {
                        txtbxSecondVertex.Focus();
                  }
                  else
                  {
                   e.Handled = true;
                   return;
                  }
                    
                }
            }
            catch (Exception InputE)
            {
                Logger.writeLog(Convert.ToString(InputE));
            }
        }

        private void txtbxSecondVertex_KeyPress(object sender, KeyPressEventArgs e)
        {
            //отлавливаем случайные ошибки

            try
            {
                //отсеиваем все кроме чисел
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    return;
                }
                else
                {
                    //разарешаем удаление 
                    if (e.KeyChar == '\b')
                    {
                        return;
                    }
                    //двигаем фокус на следующий элемент
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        btnShowGraph.Focus();
                    }
                    else
                    {
                        e.Handled = true;
                        return;
                    }

                }
            }
            catch (Exception InputE)
            {
                Logger.writeLog(Convert.ToString(InputE));
            }
        }

        private void btnAddVertex_Click(object sender, EventArgs e)
        {
            try
            {
                if (gr != null)
                {
                    Bitmap btm = new Bitmap(pctrbxMain.Width, pctrbxMain.Height);                    
                    gr.addVertex();
                    cordsRand.Add(new Point(rnd.Next(pctrbxMain.Width), rnd.Next(pctrbxMain.Height)));
                    cordsLvled.Add(new Point(rnd.Next(pctrbxMain.Width), rnd.Next(pctrbxMain.Height)));
                    rdbtnAsAgraph.Checked = true;
                    btm = gr.drawGraph(cordsRand, btm);
                    pctrbxMain.Image = btm;

                }

            }catch(Exception er)
            {
                Logger.writeLog(Convert.ToString(er));
            }
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            try
            {
                if (gr != null)
                {
                    Bitmap btm = new Bitmap(pctrbxMain.Width, pctrbxMain.Height);
                    if (txtbxFirstVertex.Text != "" && txtbxSecondVertex.Text != "")
                    {
                        gr.addEdge(firstVertex: Convert.ToInt32(txtbxFirstVertex.Text) , secondVertex: Convert.ToInt32(txtbxSecondVertex.Text));
                        rdbtnAsAgraph.Checked = true;                        
                        btm = gr.drawGraph(cordsRand, btm);
                        pctrbxMain.Image = btm;
                    }
                }

            }
            catch (Exception er)
            {
                Logger.writeLog(Convert.ToString(er));
            }
        }

        private void btnRemoveVertex_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap btm = new Bitmap(pctrbxMain.Width, pctrbxMain.Height);
                if(txtbxFirstVertex.Text != "")
                {
                    gr.removeVertex(Convert.ToInt32(txtbxFirstVertex.Text));
                    cordsRand.RemoveAt(Convert.ToInt32(txtbxFirstVertex.Text));
                    cordsLvled.RemoveAt(Convert.ToInt32(txtbxFirstVertex.Text));
                    if (rdbtnAsAgraph.Checked) btm = gr.drawGraph(cordsRand, btm);
                    else btm = gr.drawGraph(cordsLvled, btm);
                }
                else
                {
                    if (txtbxSecondVertex.Text != "")
                    {
                        gr.removeVertex(Convert.ToInt32(txtbxSecondVertex.Text));
                        cordsRand.RemoveAt(Convert.ToInt32(txtbxSecondVertex.Text));
                        cordsLvled.RemoveAt(Convert.ToInt32(txtbxSecondVertex.Text));
                        if (rdbtnAsAgraph.Checked) btm = gr.drawGraph(cordsRand, btm);
                        else btm = gr.drawGraph(cordsLvled, btm);
                    }
                    else return;
                }
            }catch(Exception er)
            {
                Logger.writeLog(Convert.ToString(er));
            }
        }
    }
}
