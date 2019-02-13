using Contacts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace Contacts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void SaveButton(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = nameEntry.Text,
                LastName = lastNameEntry.Text,
                Email = EmailEntry.Text,
                PhoneNumber = phoneEntry.Text,
                Address = AddressEntry.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Contact>();
                int rowsAdded = conn.Insert(contact);


            }
        }
    }
}



