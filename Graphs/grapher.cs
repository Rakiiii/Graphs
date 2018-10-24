using System;
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

        public bool checkEdge(int ferstVertex , int secondVertex)
        {
            if (graph[ferstVertex][secondVertex] != 0) return true;
            else return false;
        }

        //конструктор на вход получаем путь до файла
        public grapher(string path)
        {
            
           // Logger.writeLog("we can go inside at least");
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
        }

        //удаление ребра
        //на вход получаем номера двух вершин между которыми ребро
        public void removeEdge(int firstVertex, int secondVertex )
        {
            //если вершины с такими номерами отсутствуют в графе ,тогда выходим
            if ((firstVertex > _amountOfVertex) || (secondVertex > _amountOfVertex)) return;

            //нет ребра~0 на пересечении столбца и строку с номерами вершин
            //обнуляем пересечение 
            graph[firstVertex][secondVertex - 1] = 0;
            graph[secondVertex][firstVertex - 1] = 0;
            return;
        }

        //добавление ребра взвешенного графа
        //получаем на вход две вершины и вес нового ребра
        public void addEdge(int firstVertex, int secondVertex, int weight = 1)
        {
            //если вершины с такими номерами отсутствуют в графе ,тогда выходим
            if ((firstVertex > _amountOfVertex) || (secondVertex > _amountOfVertex)) return;

            //добовляем наше ребро в матрицу смежности
            graph[firstVertex - 1][secondVertex - 1] = weight;
            graph[secondVertex - 1][firstVertex - 1] = weight;
            return;
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
            //первичная раскраска
            for(int i = 0;i < amountOfVertex; i++)
            {
                colors.Add(0);
            }

            //проходим все вершины
            for(int i = 0; i < amountOfVertex; i++)
            {
                //если вершина не покрашена  - красим в 1
                if (colors[i] == 0) colors[i] = 1;
                //проходим все вершины по строке
                for(int j = 0; j < amountOfVertex; j++)
                {
                    //если есть ребро между 2 вершинами и 2 вершина не покрашена
                    if ((graph[i][j] != 0) && (colors[j] == 0))
                        //красим ее в следущий цвет
                        colors[j] = colors[i] + 1;
                }
            }
            return;
        }
        
        //проверяем количество цветов
        public int checkAmountOfColors()
        {
            return colors.Capacity;
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
                //ртсуем номера вершин
                drawerMain.DrawString(Convert.ToString(i + 1), new Font("Arial", 16), new SolidBrush(Color.Red), cords[i].X + 5, cords[i].Y + 5);
                
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
    }
}
