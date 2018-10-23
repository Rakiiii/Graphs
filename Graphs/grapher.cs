using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Graphs
{
    class grapher
    {
        //матрица смежности графа
        private List<List<int>> graph;

        //количество вершин
        private int amountOfVertex;

        //список раскрашенных вершин
        private List<int> colors;

        //конструктор на вход получаем путь до файла
        public grapher(string path)
        {
            //читаем файл по переднному в конструктор путь path
            StreamReader file = new StreamReader(path);
            
            //первый символ в файле это количество вершин
            //читаем первый символ файла
            amountOfVertex = Convert.ToInt32(file.Peek());

            //перехлдим на следующую строку
            file.ReadLine();

            //читаем заполняем матрицу смежности графа
            for (int i = 0; i < amountOfVertex - 1; i++)
            {
                //читаем строку матрицы смежности из файла
                string lineOfFile = file.ReadLine();

                //разбиваем строку матрицы смежности по пробелу в массив строк
                string[] words = lineOfFile.Split(' ');

                //инициализируем строку матрицы смежности
                List<int> lineOfMatrix = new List<int>;

                //заполняем строку матрицы смежности
                for(int j = 0; j < amountOfVertex - 1;j++)
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
            if ((firstVertex > amountOfVertex) || (secondVertex > amountOfVertex)) return;

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
            if ((firstVertex > amountOfVertex) || (secondVertex > amountOfVertex)) return;

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
            if (vertex > amountOfVertex) return;

            //удалить вершину означает вычеркнуть строку и столбец с ее номером из матрицы смежности
            //удаляем строку из матрицы смежности
            graph.RemoveAt(vertex - 1);

            //удаляем столбец
            //удалить символ с номером этой вершины из каждой строки
            for (int i = 0; i < amountOfVertex - 2; i++)
            {
                graph[i].RemoveAt(vertex - 1);
            }

            //уменьшаем количество вершин на 1
            amountOfVertex--;

            return;
        }

        //добавление вершины
        public void addVertex()
        {
            //добавляем новую строку
            graph.Add(new List<int>);

            //добовляем новый столбец
            for(int i = 0; i < amountOfVertex - 1; i ++)
            {
                //добовляем новый столбец
                graph[i].Add(0);

                //заполняем новую строку
                graph[amountOfVertex].Add(0);
            }

            //дописываем последний символ в новую строку
            graph[amountOfVertex].Add(0);

            //инкрементируем коичество вершин
            amountOfVertex++;

            return;
        }

        //раскрасска графа
        public void colorGraph()
        {
            //первичная раскраска графа 0
            for (int i = 0; i < amountOfVertex - 1; i++)
                colors.Add(0);

            //вторичная раскраска графа
            for(int i = 0; i < amountOfVertex - 1; i++)
            {
                //если вершина еще не окрашена Значит красим в мин цвет
                if (colors[i] == 0) colors[i] = 1;

                //обходим матрицу смежности
                for (int j = i + 1; j < amountOfVertex - 2; j++ )
                {
                    //если вершины смежны
                    if (graph[i][j] != 0)
                    {
                        //если они уже покрашены одним цветом, то цвет смежно вершины повышаем на тон
                        if (colors[i] == colors[j]) colors[j]++;
                        
                        //если вторая вершина не покрашена
                        if (colors[j] == 0 )
                        {
                            //определяем минимальный доступный цвет
                            //если цвет смежно вершины не 1
                            if (colors[i] != 1)
                                //красим в 1
                                colors[j] = 1;
                            //иначе красив в 2
                            else colors[j] = 2;
                        }
                    }
                }
            }

            //красим не покрашенные вершины в 1
            for (int i = 0; i < amountOfVertex - 1; i++)
                if (colors[i] == 0) colors[i] = 1;

            return;
        }


    }
}
