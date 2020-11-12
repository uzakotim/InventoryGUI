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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace InventoryGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        private void Save_Click(object sender, RoutedEventArgs e)
        {   
            var p1 = new Person(UserName.Text,UserAge.Text);
            var i1 = new Item(Cell01.Text, Cell11.Text);    
            var i2 = new Item(Cell02.Text, Cell12.Text);
            var i3 = new Item(Cell03.Text, Cell13.Text);
            var i4 = new Item(Cell04.Text, Cell14.Text);
            var i5 = new Item(Cell05.Text, Cell15.Text);
            var i6 = new Item(Cell06.Text, Cell16.Text);
            var i7 = new Item(Cell07.Text, Cell17.Text);
            var i8 = new Item(Cell08.Text, Cell18.Text);
            var i9 = new Item(Cell09.Text, Cell19.Text);
            var i10 = new Item(Cell010.Text, Cell110.Text);
            var i11 = new Item(Cell011.Text, Cell111.Text);
            var i12 = new Item(Cell012.Text, Cell112.Text);
            var items = new List<Item>{i1,i2,i3,i4,i5,i6,i7,i8,i9,i10,i11,i12};
            
            var data = new List<String>{};
            data.Add($"|{$"Инвентарь пользователя: {p1.Name}", -50}|{$"Возраст: {p1.Age}", -15}|{$"Дата создания: {DateTime.Now}", -30}|");
            data.Add($"|{"Наименование:", -50}|{"Количество:", -15}|");
            foreach(var item in items){
                data.Add($"|{item.Name, -50}|{item.Quantity, -15}|");
            }
            string folderName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileName = $"data/{p1.Name}.txt";
            string pathString = System.IO.Path.Combine(folderName, fileName);
            string[] save = data.ToArray();
            File.WriteAllLines(pathString,save);
            MessageBox.Show("Данные успешно сохранены");
            
            UserName.Text = "";
            UserAge.Text = "";
            Cell01.Text = "";
            Cell11.Text = "";
            Cell02.Text = "";
            Cell12.Text = "";
            Cell03.Text = "";
            Cell13.Text = "";
            Cell04.Text = "";
            Cell14.Text = "";
            Cell05.Text = "";
            Cell15.Text = "";
            Cell06.Text = "";
            Cell16.Text = "";
            Cell07.Text = "";
            Cell17.Text = "";
            Cell08.Text = "";
            Cell18.Text = "";
            Cell09.Text = "";
            Cell19.Text = "";
            Cell010.Text = "";
            Cell110.Text = "";
            Cell011.Text = "";
            Cell111.Text = "";
            Cell012.Text = "";
            Cell112.Text = "";
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        
    }
}
