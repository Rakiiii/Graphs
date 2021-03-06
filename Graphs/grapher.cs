﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;



namespace Graphs
{
    class grapher
    {
        //матрица смежности графа
        private List<List<int>> graph = new List<List<int>>();

        //количество вершин
        private int _amountOfVertex;

        public int amountOfVertex
        {
            get { return _amountOfVertex; }
        }

        
            

        //список раскрашенных вершин
        private List<int> colors = new List<int>();
        private List<int> verColr = new List<int>();

        public bool checkEdge(int ferstVertex , int secondVertex)
        {
            if (graph[ferstVertex][secondVertex] != 0) return true;
            else return false;
        }

        //конструктор на вход получаем путь до файла
        public grapher(string path)
        {
            
           
            //читаем файл по переднному в конструктор путь path
            StreamReader file = new StreamReader(path);

            
            //первый символ в файле это количество вершин
            //читаем первый символ файла
            _amountOfVertex = Convert.ToInt32(file.ReadLine());
            
   
            //Logger.writeLog(Convert.ToString(_amountOfVertex));

            //читаем заполняем матрицу смежности графа
            for (int i = 0; i <= _amountOfVertex - 1; i++)
            {
                //читаем строку матрицы смежности из файла
                string lineOfFile = file.ReadLine();

                //разбиваем строку матрицы смежности по пробелу в массив строк
                string[] words = lineOfFile.Split(' ');
                

                //инициализируем строку матрицы смежности
                List<int> lineOfMatrix = new List<int>();

                //заполняем строку матрицы смежности
                for(int j = 0; j <= _amountOfVertex - 1;j++)
                {
                    //переобразуем строку в число
                    
                        lineOfMatrix.Add(Convert.ToInt32(words[j]));
                }

                //добовляем строку матрицы смежности в матрицу смежности
                graph.Add(lineOfMatrix);
            }
            file.Close();
        }

        //удаление ребра
        //на вход получаем номера двух вершин между которыми ребро
        public bool removeEdge(int firstVertex, int secondVertex )
        {
            //если вершины с такими номерами отсутствуют в графе ,тогда выходим
            if ((firstVertex > _amountOfVertex) || (secondVertex > _amountOfVertex)) return false;

            //нет ребра~0 на пересечении столбца и строку с номерами вершин
            //обнуляем пересечение 
            graph[firstVertex - 1][secondVertex - 1] = 0;
            graph[secondVertex - 1][firstVertex - 1] = 0;
            return true;
        }

        //добавление ребра взвешенного графа
        //получаем на вход две вершины и вес нового ребра
        public bool addEdge(int firstVertex, int secondVertex, int weight = 1)
        {
            //если вершины с такими номерами отсутствуют в графе ,тогда выходим
            if ((firstVertex > _amountOfVertex) || (secondVertex > _amountOfVertex)) return false;

            //добовляем наше ребро в матрицу смежности
            graph[firstVertex - 1][secondVertex - 1] = weight;
            graph[secondVertex - 1][firstVertex - 1] = weight;
            return true;
        }

        //удаление вершины
        //на вход получем номер вершины
        public void removeVertex(int vertex)
        {
            //если вершины не существует то удлять ничего не нужно
            if (vertex > _amountOfVertex) return;

            //удалить вершину означает вычеркнуть строку и столбец с ее номером из матрицы смежности
            //удаляем строку из матрицы смежности
            graph.RemoveAt(vertex - 1);

            //удаляем столбец
            //удалить символ с номером этой вершины из каждой строки
            for (int i = 0; i <= _amountOfVertex - 2; i++)
            {
                graph[i].RemoveAt(vertex - 1);
            }

            //уменьшаем количество вершин на 1
            _amountOfVertex--;

            return;
        }

        //добавление вершины
        public void addVertex()
        {
            //добавляем новую строку
            graph.Add(new List<int>());

            //добовляем новый столбец
            for(int i = 0; i <= _amountOfVertex - 1; i ++)
            {
                //добовляем новый столбец
                graph[i].Add(0);

                //заполняем новую строку
                graph[amountOfVertex].Add(0);
            }

            //дописываем последний символ в новую строку
            graph[amountOfVertex].Add(0);

            //инкрементируем коичество вершин
            _amountOfVertex++;

            return;
        }

        //красим граф
        public void colorGraph()
        {
            int amc = colors.Count;
            //выравниваем размер списка задающего раскраску графа
            //если вершин в графе больше, чем вершин для раскрашиванния
            if (_amountOfVertex > amc)
            {
                //дополняем нодостоющими
                for (int i = 0; i < (_amountOfVertex - amc) ; i++)
                {
                    colors.Add(0);
                    verColr.Add(0);
                }
            }
            else
            {
                //если вершин для раскраски больше
                if(_amountOfVertex < amc)
                    //то удаляем лишние
                    for( int i = 0; i < (amc - _amountOfVertex); i++)
                    {
                        colors.RemoveAt(1);
                        verColr.RemoveAt(1);
                    }
            }

            //красим граф в 0 цвет
            for (int i = 0; i < amountOfVertex; i++)
            {
                colors[i] = 0;
                verColr[i] = 0;
            }

            //проходим все вершины
            for(int i = 0; i < amountOfVertex; i++)
            {
                //если вершина не покрашена  - красим в 1
                if (colors[i] == 0) colors[i] = 1;
                //проходим все вершины по строке
                for (int j = 0; j < amountOfVertex; j++)
                {
                    //если есть ребро между 2 вершинами и 2 вершина не покрашена
                    if (graph[i][j] != 0)
                    {
                        if (colors[j] == 0)
                        {
                            //красим ее в следущий цвет
                            colors[j] = colors[i] + 1;
                            verColr[j] = i;
                        }
                        else
                        {
                            if (j < i && colors[j] == 1 && j != 0 && verColr[i] != j)
                            {
                                int counter = 0;
                                for(int k = 0; k < i; k++)
                                {
                                    if (graph[j][k] != 0) counter++;
                                }
                                if (counter == 0)
                                {
                                    colors[j] = colors[i] + 1;
                                    for(int k = 0; k < _amountOfVertex; k++)
                                    {
                                        if (verColr[k] == j) colors[k] = colors[j] + 1;
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
            return;
        }
        
        //проверяем количество цветов
        public int checkAmountOfColors()
        {
            int counter = 0;
            int flag = 0;
            for (int i = 0; i < colors.Count; i++)
            {
                int j = 0;
                while (flag == 0 && j < colors.Count)
                {
                    if (colors[j] == i)
                    {
                        counter++;
                        flag = 1;
                    }
                    j++;
                }
                flag = 0;
            }
            return counter;
        }

        //проверяем цвет конкретной вершины
        public int checkColorOfVertex(int vertex)
        {
            //если вершина существует
            if (vertex < amountOfVertex) return colors[vertex];
            else return -1;
        }

        //проверяем количество вершин определенного цвета, на вход получаем номер цвета
        public int checkAmountOfColor(int clr)
        {
            //счетчик
            int amount = 0;

            //проходим список цветов
            for(int i = 0; i < amountOfVertex; i++)
            {
                if (colors[i] == clr) amount++;
            }
            return amount;
        }

        //рисуем граф
        public Bitmap drawGraph(List<Point> cords , Bitmap btm )
        {
            //инициализируем объект graphics для рисования в битмапе
            Graphics drawerMain = Graphics.FromImage(btm);

            //рисуем граф
            for (int i = 0; i < _amountOfVertex ; i++)
            {
                Point tmp = new Point(cords[i].X + 5, cords[i].Y + 5);
                if (tmp.X > btm.Width - 25) tmp.X -= 30;
                if (tmp.Y > btm.Height - 25) tmp.Y -= 30;
                //рисуем номера вершин
                drawerMain.DrawString(Convert.ToString(i + 1), new Font("Arial", 12), new SolidBrush(Color.Red), tmp.X, tmp.Y);
                
                //рисуем сами вершины
                drawerMain.DrawEllipse(new Pen(Color.Black), new Rectangle(cords[i].X - 2, cords[i].Y - 2, 4, 4));
            }
            //проходим все столбцы координат
            for (int i = 0; i < _amountOfVertex; i++)
            {
               //проходим все строки
                for (int j = 0; j < _amountOfVertex; j++)
                {
                    //если есть ребро то рисуем его
                    if (graph[i][j] != 0) drawerMain.DrawLine(new Pen(Color.Black), cords[i], cords[j]);
                }
            }
            return btm;
        }

        public void saveGraph(string path)
        {
            
            StreamWriter saver = new StreamWriter(path, false);
            saver.WriteLine(_amountOfVertex.ToString());
            for(int i = 0; i < _amountOfVertex; i++)
            {
                string line = "";
                for (int j = 0; j < _amountOfVertex; j++)
                {
                    line += (graph[i][j].ToString() + " ");
                }
                saver.WriteLine(line);
            }
            saver.Close();
            return;
        }
    }
}
