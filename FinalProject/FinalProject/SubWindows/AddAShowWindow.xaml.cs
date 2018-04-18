using FinalProject.Classes;
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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for AddAShowWindow.xaml
    /// </summary>
    public partial class AddAShowWindow : Window
    {
        public AddAShowWindow()
        {
            InitializeComponent();
            GenerateAddAShowWindowComponents();
        }

        public void GenerateAddAShowWindowComponents()
        {

            

            Grid mainGrid = new Grid();
            mainGrid.ShowGridLines = true;
            mainGrid.Name = "top_Grid";
            mainGrid.Width = 800;
            mainGrid.Height = 600;
            mainGrid.Margin = new Thickness(0, 0, 0, 0);

            
            RowDefinition row1 = new RowDefinition();
            row1.Height = new GridLength(1, GridUnitType.Star);
            mainGrid.RowDefinitions.Add(row1);
            RowDefinition row2 = new RowDefinition();
            row2.Height = new GridLength(2, GridUnitType.Star);
            mainGrid.RowDefinitions.Add(row2);


            Label lbl_Title = new Label();
            lbl_Title.Name = "lbl_AddAShow";
            lbl_Title.Content = "Add A Show";
            lbl_Title.Width = 200;
            lbl_Title.Height = 50;
            lbl_Title.Margin = new Thickness(40, 10, 0, 0);
            lbl_Title.HorizontalAlignment = HorizontalAlignment.Left;
            
            mainGrid.Children.Add(lbl_Title);

            StackPanel stack_PickAShowType = new StackPanel();
            stack_PickAShowType.HorizontalAlignment = HorizontalAlignment.Left;
            stack_PickAShowType.Orientation = Orientation.Horizontal;
            stack_PickAShowType.Margin = new Thickness(40, 100, 0, 0);

            Label lbl_PickAShowType = new Label();
            lbl_PickAShowType.Name = "lbl_PickAShowType";
            lbl_PickAShowType.Content = "Pick A Show Type :";
            lbl_PickAShowType.Width = 200;
            lbl_PickAShowType.Height = 50;
            lbl_PickAShowType.HorizontalAlignment = HorizontalAlignment.Left;
            
            stack_PickAShowType.Children.Add(lbl_PickAShowType);
            


            ComboBox cbox_PickAShowType = new ComboBox();
            cbox_PickAShowType.Name = "cbox_PickAShowType";
            cbox_PickAShowType.Width = 100;
            cbox_PickAShowType.Height = 25;
            cbox_PickAShowType.ItemsSource = Helper.TypesOfShows;
            cbox_PickAShowType.SelectionChanged += Cbox_PickAShowType_SelectionChanged;
            cbox_PickAShowType.HorizontalAlignment = HorizontalAlignment.Left;
            stack_PickAShowType.Children.Add(cbox_PickAShowType);

            mainGrid.Children.Add(stack_PickAShowType);
            

            this.Content = mainGrid;

            Console.WriteLine(Content.ToString());

           

        }


        public void ResetWindow()
        {

            

            Grid mainGrid = new Grid();
            Label lbl_Title = new Label();
            lbl_Title.Name = "lbl_AddAShow";
            lbl_Title.Content = "Add A Show";
            mainGrid.Children.Add(lbl_Title);

            Label lbl_PickAShowType = new Label();
            lbl_PickAShowType.Name = "lbl_PickAShowType";
            lbl_PickAShowType.Content = "Pick A Show Type :";
            mainGrid.Children.Add(lbl_PickAShowType);

            ComboBox cbox_PickAShowType = new ComboBox();
            cbox_PickAShowType.Name = "cbox_PickAShowType";
            cbox_PickAShowType.ItemsSource = Helper.TypesOfShows;
            cbox_PickAShowType.SelectedIndex = 0;
            cbox_PickAShowType.SelectionChanged += Cbox_PickAShowType_SelectionChanged;
            mainGrid.Children.Add(cbox_PickAShowType);

            AddChild(mainGrid);

            Width = mainGrid.Width;
            Height = mainGrid.Height;
        }

        private void Cbox_PickAShowType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBox tempCbox = (ComboBox)sender;
                if(tempCbox.SelectedItem != null)
                {
                    
                    if(tempCbox.SelectedItem.ToString() == "TV Show")
                    {
                        Grid newGrid = new Grid();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
