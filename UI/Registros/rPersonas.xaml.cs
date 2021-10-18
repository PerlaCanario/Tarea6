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
using System.Windows.Shapes;
using Tarea6.BLL;
using Tarea6.Entidades;

namespace Tarea6.UI.Registros
{
    /// <summary>
    /// Lógica de interacción para rPersonas.xaml
    /// </summary>
    public partial class rPersonas : Window
    {
        private Persona persona = new Persona();
        public rPersonas()
        {
            InitializeComponent();
            this.DataContext = persona;
            RolesComboBox.ItemsSource = RolesBLL.GetRoles();
            RolesComboBox.SelectedValuePath = "RolId";
            RolesComboBox.DisplayMemberPath = "Descripcion";
        }
        private void Limpiar()
        {
            this.persona = new Persona();
            this.DataContext = persona;
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
