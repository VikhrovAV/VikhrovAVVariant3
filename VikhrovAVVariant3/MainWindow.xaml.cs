using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace VikhrovAVVariant3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadAgent1();
        }

        public class agent
        {
            public string name { get; set; }
            public string email { get; set; }
            public string number { get; set; }
            public string addres { get; set; }
            public string inn { get; set; }
            public string kpp { get; set; }

        }


        void LoadAgent1()
        {
            InitializeComponent();
            List<agent> items = new List<agent>();
            items.Add(new agent() { name = "МонтажОрионУрал", email = "email: pzaitev@blokin.org", number = "(35222) 67-39-26", addres = "027573, Тамбовская область, город Коломна, ул. Ленина, 20", inn = "1692286718", kpp = "181380912" });
            items.Add(new agent() { name = "МетизСтрой", email = "kristina.pakomov@burova.ru", number = "8-800-172-62-56", addres = "254238, Нижегородская область, город Павловский Посад, проезд Балканская, 23", inn = "4024742936", kpp = "295608432" });
            items.Add(new agent() { name = "РадиоСевер", email = "maiy.belov@rogov.ru", number = "(495) 368-86-51", addres = "491360, Московская область, город Одинцово, въезд Ленина, 19", inn = "5889206249", kpp = "372789083" });
            items.Add(new agent() { name = "Компания КазАлмаз", email = "irina.gusina@vlasova.ru", number = "8-800-533-24-75", addres = "848810, Кемеровская область, город Лотошино, пер. Ломоносова, 90", inn = "3084797352", kpp = "123190924" });
            items.Add(new agent() { name = "Компания СервисРадиоГор", email = "nika.nekrasova@kovalev.ru", number = "8-800-676-32-86", addres = "547196, Ульяновская область, город Серебряные Пруды, въезд Балканская, 81", inn = "8880473721", kpp = "729975116" });
            items.Add(new agent() { name = "ВодТверьХозМашина", email = "tkrylov@baranova.net", number = "+7 (922) 849-91-96", addres = "145030, Сахалинская область, город Шатура, въезд Гоголя, 79", inn = "4174253174", kpp = "522227145" });
            items.Add(new agent() { name = "Тех", email = "vasilisa99@belyev.ru", number = "+7 (922) 427-13-31", addres = "731935, Калининградская область, город Павловский Посад, наб. Гагарина, 59", inn = "9282924869", kpp = "587356429" });
            AgentList.ItemsSource = items;
        }
        void LoadAgent2()
        {
            InitializeComponent();
            List<agent> items = new List<agent>();
            items.Add(new agent() { name = "ТверьМетизУралСнос", email = "email: rlazareva@novikov.ru", number = "(35222) 57-92-75", addres = "880551, Ленинградская область, город Красногорск, ул. Гоголя, 61", inn = "1076095397", kpp = "947828491" });
            items.Add(new agent() { name = "МясРеч", email = "bkozlov@volkov.ru", number = "8-800-453-63-45", addres = "903648, Калужская область, город Воскресенск, пр. Будапештсткая, 91", inn = "9254261217", kpp = "656363498" });
            items.Add(new agent() { name = "Флот", email = "gerasim.makarov@kornilov.ru", number = "8-800-453-63-45", addres = "505562, Тюменская область, город Наро-Фоминск, пр. Косиора, 11", inn = "1112170258", kpp = "382584255" });
            items.Add(new agent() { name = "СибПивОмскСнаб", email = "evorontova@potapova.ru", number = "+7 (922) 153-95-22", addres = "816260, Ивановская область, город Москва, ул. Гагарина, 31", inn = "5676173945", kpp = "256512286" });
            items.Add(new agent() { name = "ЦементАсбоцемент", email = "email: polykov.veronika@artemeva.ru", number = "(495) 184-87-92", addres = "619540, Курская область, город Раменское, пл. Балканская, 12", inn = "4345774724", kpp = "352469905" });
            items.Add(new agent() { name = "ТелеГлавВекторСбыт", email = "nsitnikov@kovaleva.ru", number = "8-800-453-63-45", addres = "062489, Челябинская область, город Пушкино, въезд Бухарестская, 07", inn = "9504787157", kpp = "419758597" });
            AgentList.ItemsSource = items;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AgentList.Items.SortDescriptions.Add(new SortDescription("name", ListSortDirection.Ascending));
        }

        private void button_Click1(object sender, RoutedEventArgs e)
        {
            AgentList.Items.SortDescriptions.Clear();
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            LoadAgent1();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            LoadAgent2();
        }
    }
}
