using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Model3DGroup CreateTriangleModel(Point3D p0, Point3D p1, Point3D p2, Color colorObjeto)
        {
            MeshGeometry3D mymesh = new MeshGeometry3D();
            mymesh.Positions.Add(p0);
            mymesh.Positions.Add(p1);
            mymesh.Positions.Add(p2);
            mymesh.TriangleIndices.Add(0);
            mymesh.TriangleIndices.Add(1);
            mymesh.TriangleIndices.Add(2);
            Vector3D Normal = CalculateTraingleNormal(p0, p1, p2);
            mymesh.Normals.Add(Normal);
            mymesh.Normals.Add(Normal);
            mymesh.Normals.Add(Normal);

            /*
            Material Material = new DiffuseMaterial(
                new SolidColorBrush(Colors.Red));
            */

            Material Material = new DiffuseMaterial(
                new SolidColorBrush(colorObjeto));

            GeometryModel3D model = new GeometryModel3D(
                mymesh, Material);
            Model3DGroup Group = new Model3DGroup();
            Group.Children.Add(model);
            return Group;
        }
        //****************************************
        //****************************************
        //****************************************
        private Vector3D CalculateTraingleNormal(Point3D p0, Point3D p1, Point3D p2)
        {
            Vector3D v0 = new Vector3D(
                p1.X - p0.X, p1.Y - p0.Y, p1.Z - p0.Z);
            Vector3D v1 = new Vector3D(
                p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z);
            return Vector3D.CrossProduct(v0, v1);
        }
        //****************************************
        //****************************************
        //****************************************
        private void triangleButtonClick(object sender, RoutedEventArgs e)
        {
            Model3DGroup triangle = new Model3DGroup();
            Point3D p0 = new Point3D(0, 0, 0);
            Point3D p1 = new Point3D(5, 0, 0);
            Point3D p2 = new Point3D(5, 0, 5);
            Point3D p3 = new Point3D(0, 0, 5);
            Point3D p4 = new Point3D(0, 5, 0);
            Point3D p5 = new Point3D(5, 5, 0);
            Point3D p6 = new Point3D(5, 5, 5);

            Color colorX = Colors.Cyan;
            triangle.Children.Add(CreateTriangleModel(p1, p4, p3, colorX));
            triangle.Children.Add(CreateTriangleModel(p1, p4, p6, colorX));
            triangle.Children.Add(CreateTriangleModel(p3, p1, p6, colorX));



            ModelVisual3D Model = new ModelVisual3D();
            Model.Content = triangle;
            this.MainViewPort.Children.Add(Model);
        }

    
        private void Derecha_Click(object sender, RoutedEventArgs e)
        {
            rotateX.Angle -= 2;
        }

        private void Abajo_Click(object sender, RoutedEventArgs e)
        {
            rotateY.Angle -= 2;
        }

        private void Arriba_Click(object sender, RoutedEventArgs e)
        {
            rotateY.Angle += 2;
        }

        private void Centro_Click(object sender, RoutedEventArgs e)
        {
            rotateY.Angle = 0; rotateX.Angle = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rotateX.Angle += 2;
        }
    }
}
