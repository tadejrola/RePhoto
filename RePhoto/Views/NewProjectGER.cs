using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RePhoto.Views
{
    public partial class NewProjectGER : Form
    {
        public NewProjectGER()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string title = txt_title.Text;
            string typeOfWork = txt_typeOfWork.Text;
            string city = txt_city.Text;
            string country = txt_country.Text;
            string cityCountry = city + " - " + country;
            string description = txt_description.Text;
            int numberOfPhotos = int.Parse(num_numberOfPhotos.Value.ToString());
            string html = File.ReadAllText(@"E:\PROJEKTI\RePhoto\RePhoto\Content\project_template_GER.html");
            html = html.Replace("//NASLOV//", title);
            html = html.Replace("//TIPDELA//", typeOfWork);
            html = html.Replace("//KRAJ-DRZAVA//", cityCountry);
            html = html.Replace("//KRAJ: KRAJ//", "Kraj: " + city);
            html = html.Replace("//DRZAVA: DRZAVA//", "Država: " + country);
            html = html.Replace("//OPIS//", description);
            List<string> listOfPhotos = new List<string>();
            for (int i = 1; i <= numberOfPhotos; i++)
            {
                string linkToPhoto;
                string nameOfPhoto = i + "_" + city;
                string nameOfPhotoSmall = i + "_" + city + "_s";
                linkToPhoto = "<a data-fancybox=\"gallery\" href=\"../images/img/" + city + "/" + nameOfPhoto + ".jpg\"><img src=\"../images/img/" + city + "/" + nameOfPhotoSmall + ".jpg\"></a>";
                listOfPhotos.Add(linkToPhoto);
            }
            if (numberOfPhotos <= 5)
            {
                string listToString = "";
                foreach (var item in listOfPhotos)
                {
                    listToString = listToString + "\n" + item;
                }
                html = html.Replace("//5SLIK_1//", listToString);
                html = html.Replace("//5SLIK_2//", "");
                html = html.Replace("//5SLIK_3//", "");
            }
            else if (numberOfPhotos > 5 && numberOfPhotos <= 10)
            {
                string listToString1 = "";
                var firstFiveItems = listOfPhotos.Take(5).ToList();
                listOfPhotos.RemoveRange(0, 5);
                foreach (var item in firstFiveItems)
                {
                    listToString1 = listToString1 + "\n" + item;
                }
                string listToString2 = "";
                foreach (var item in listOfPhotos)
                {
                    listToString2 = listToString2 + "\n" + item;
                }

                html = html.Replace("//5SLIK_1//", listToString1);
                html = html.Replace("//5SLIK_2//", listToString2);
                html = html.Replace("//5SLIK_3//", "");
            }
            else
            {
                string listToString1 = "";
                var firstFiveItems = listOfPhotos.Take(5).ToList();
                listOfPhotos.RemoveRange(0, 5);
                foreach (var item in firstFiveItems)
                {
                    listToString1 = listToString1 + "\n" + item;
                }
                string listToString2 = "";
                var secondFiveItems = listOfPhotos.Take(5).ToList();
                listOfPhotos.RemoveRange(0, 5);
                foreach (var item in secondFiveItems)
                {
                    listToString2 = listToString2 + "\n" + item;
                }
                string listToString3 = "";
                foreach (var item in listOfPhotos)
                {
                    listToString3 = listToString3 + "\n" + item;
                }

                html = html.Replace("//5SLIK_1//", listToString1);
                html = html.Replace("//5SLIK_2//", listToString2);
                html = html.Replace("//5SLIK_3//", listToString3);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML Files|*.html";
            saveFileDialog.ShowDialog();

            MessageBox.Show("Done! New file created in: " + saveFileDialog.FileName);
            File.WriteAllText(saveFileDialog.FileName, html);
        }
    }
}