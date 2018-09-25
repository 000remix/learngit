using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三周_简单工厂模式
{
    public interface Chart        //抽象图标接口：抽象产品类
    {
        int a { get; set; }
        int b { get; set; }
        int c { get; set; }

        void Area();
    }

    class Triangle : Chart               //三角形类
    {
        public int a { set; get; }
        public int b { set; get; }
        public int c { set; get; }
        public Triangle()
        {
            Console.Write("创建三角形");
        }
        public void Area()
        {
            int p = (a + b + c) / 2;
            double s = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("如果一个三角形的三边分别为: " + a +"," + b + "," + c);
            Console.WriteLine("那么此三角形的面积为: " + s);
        }
    }

    class Square : Chart                 //正方形类
    {
        public int a { set; get; }
        public int b { set; get; }
        public int c { set; get; }
        public Square()
        {
            Console.Write("创建正方形");
        }
        public void Area()
        {
            int s = a * a;
            Console.WriteLine("如果一个正方形的边长为: " + a );
            Console.WriteLine("那么此正方形的面积为: " + s);
        }
    }

    class Circle : Chart                    //圆形类
    {
        public int a { set; get; }
        public int b { set; get; }
        public int c { set; get; }
        public Circle()
        {
            Console.Write("创建圆形");
        }
        public void Area()
        {
            double s = a * a * 3.14;
            Console.WriteLine("如果一个圆形的半径为: " + a);
            Console.WriteLine("那么此圆形的面积为: " + s);
        }
    }

    class Rectangle : Chart                  //长方形类
    {
        public int a { set; get; }
        public int b { set; get; }
        public int c { set; get; }
        public Rectangle()
        {
            Console.Write("创建圆形");
        }
        public void Area()
        {
            double s = a * b;
            Console.WriteLine("如果一个长方形的长宽分别为为: " + a + "," + b);
            Console.WriteLine("那么此长方形的面积为: " + s);
        }
    }

    //图表工厂类：工厂类  
    class ChartFactory
    {
        //静态工厂方法  
        public static Chart getChart(String type)
        {
            Chart chart = null;
            switch (type)
            {
                case "triangle":
                    {
                        chart = new Triangle();
                        Console.WriteLine("初始化设置三角形！");
                        break;
                    }
                case "square":
                    {
                        chart = new Square();
                        Console.WriteLine("初始化设置正方形！");
                        break;
                    }
                case "circle":
                    {
                        chart = new Circle();
                        Console.WriteLine("初始化设置圆形！");
                        break;
                    }
                case "rectangle":
                    {
                        chart = new Rectangle();
                        Console.WriteLine("初始化设置长方形！");
                        break;
                    }
            }
            return chart;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Chart chart1;
            chart1 = ChartFactory.getChart("triangle");
            chart1.a = 3;
            chart1.b = 4;
            chart1.c = 5;
            chart1.Area();
            Chart chart2;
            chart2 = ChartFactory.getChart("square");
            chart2.a = 3;
            chart2.Area();
            Chart chart3;
            chart3 = ChartFactory.getChart("circle");
            chart3.a = 3;
            chart3.Area();
            Chart chart4;
            chart4 = ChartFactory.getChart("rectangle");
            chart4.a = 3;
            chart4.b = 4;
            chart4.Area();
        }
    }
}
