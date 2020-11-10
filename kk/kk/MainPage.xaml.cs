using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kk
{
    public partial class MainPage : ContentPage
    {
        Picker puker, piker;
        public MainPage()
        {
            Grid maakond = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}

                }
            };

            puker = new Picker
            {
                Title = "Ваш Уезд"
            };
            puker.Items.Add("ИДА-ВИРУМАА");
            puker.Items.Add("ЙЫГЕВАМАА");
            piker.Items.Add("v");
            puker.Items.Add("ЛЯЭНЕМАА");
            puker.Items.Add("ЛЯЭНЕ-ВИРУМАА");
            puker.Items.Add("ПЫЛВАМАА");
            puker.Items.Add("ПЯРНУМАА");
            puker.Items.Add("РАПЛАМАА");
            puker.Items.Add("СААРЕМАА");
            puker.Items.Add("ТАРТУМАА");
            puker.Items.Add("ХАРЬЮМАА");
            puker.Items.Add("ХИЙУМАА");
            puker.Items.Add("ЯРВАМАА");
            puker.Items.Add("ВЫРУМАА");
            puker.Items.Add("ВИЛЬЯНДИМАА");
            puker.Items.Add("ВАЛГАМАА");
            maakond.Children.Add(puker, 0, 0);
            puker.SelectedIndexChanged += Puker_SelectedIndexChanged;

            piker = new Picker
            {
                Title = "Центр уезда"
            };
            piker.Items.Add("ИДА-ВИРУМАА");

            piker.Items.Add("ЙЫГЕВАМАА");
            piker.Items.Add("ЛЯЭНЕМАА");
            piker.Items.Add("ЛЯЭНЕ-ВИРУМАА");
            piker.Items.Add("ПЫЛВАМАА");
            piker.Items.Add("ПЯРНУМАА");
            piker.Items.Add("РАПЛАМАА");
            piker.Items.Add("СААРЕМАА");
            piker.Items.Add("ТАРТУМАА");
            piker.Items.Add("ХАРЬЮМАА");
            piker.Items.Add("ХИЙУМАА");
            piker.Items.Add("ЯРВАМАА");
            piker.Items.Add("ВЫРУМАА");
            piker.Items.Add("ВИЛЬЯНДИМАА");
            piker.Items.Add("ВАЛГАМАА");
            maakond.Children.Add(piker, 0, 0);


        }

        private void Puker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = puker.SelectedItem.ToString();
            switch (puker.Title)
            {
                    case "ИДА-ВИРУМАА":
                              piker.SelectedItem;
                break;
            }


        }
    }
}
