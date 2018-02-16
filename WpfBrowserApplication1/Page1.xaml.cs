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
using System.Data.Entity;

namespace WpfBrowserApplication1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        PersonContext _context = new PersonContext();
        public Page1()
        {
            InitializeComponent();
            System.Windows.Data.CollectionViewSource personViewSource =
                    ((System.Windows.Data.CollectionViewSource)(this.FindResource("personViewSource")));


            using (var _context = new PersonContext())
            {
                _context.Configuration.LazyLoadingEnabled = false;
                _context.Configuration.ProxyCreationEnabled = false;
                _context.Persons.Load();
                personViewSource.Source = _context.Persons.Local;

            }



        }
    }
}
