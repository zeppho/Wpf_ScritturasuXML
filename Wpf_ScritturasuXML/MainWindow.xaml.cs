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
using System.IO;
using System.Xml;
using System.Windows.Shapes;

namespace Wpf_ScritturasuXML
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // PRESSIONE PULSANTE "CANCELLA TUTTO"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nome.Text = "";
            cognome.Text = "";
            indirizzo.Text = "";
            citta.Text = "";
            cap.Text = "";
            email.Text = "";
            telefono.Text = "";
            nomeazienda.Text = "";
            partitaiva.Text = "";
            Calendario.DisplayDate= DateTime.Today;
        }

        // PRESSIONE PULSANTE "SALVA SU XML"
        private void Salva_Click(object sender, RoutedEventArgs e)
        {
            //CREAZIONE TEXTWRITER XML + LOCATION + ENCODING + FORMATTING INDENTED(A CAPO INVECE CHE TUTTO SU UNA SINGOLA RIGA)
            XmlTextWriter xml = new XmlTextWriter("D:\\Andre_ScritturaSuXML.xml", Encoding.UTF8);
            xml.Formatting = Formatting.Indented;
            xml.WriteStartElement("Persona");
            xml.WriteStartElement("Dati Anagrafici");

            xml.WriteStartElement("Nome");
            xml.WriteString(nome.Text);
            xml.WriteEndElement(); //nome

            xml.WriteStartElement("Cognome");
            xml.WriteString(cognome.Text);
            xml.WriteEndElement(); //cognome

            xml.WriteStartElement("Indirizzo");
            xml.WriteString(indirizzo.Text);
            xml.WriteEndElement(); //indirizzo

            xml.WriteStartElement("Luogo di Nascita");
            xml.WriteString(citta.Text);
            xml.WriteEndElement(); // città

            xml.WriteStartElement("Codice Postale");
            xml.WriteString(cap.Text);
            xml.WriteEndElement(); //cap

            xml.WriteStartElement("Data di Nascita");
            xml.WriteString(Calendario.SelectedDate.ToString());
            xml.WriteEndElement(); // data di nascita

            xml.WriteEndElement(); // DATI ANAGRAFICI

            xml.WriteStartElement("Informazioni Aggiuntive");

            xml.WriteStartElement("Email");
            xml.WriteString(email.Text);
            xml.WriteEndElement(); //email

            xml.WriteStartElement("Telefono");
            xml.WriteString(telefono.Text);
            xml.WriteEndElement(); //telefono

            xml.WriteStartElement("Azienda");
            xml.WriteString(nomeazienda.Text);
            xml.WriteEndElement(); //azienda

            xml.WriteStartElement("Partita IVA");
            xml.WriteString(partitaiva.Text);
            xml.WriteEndElement(); //partita iva

            xml.WriteEndElement(); // INFORMAZIONI AGGIUNTIVE
            xml.WriteEndElement(); // PERSONA

            xml.Close();
        }
    }
}
