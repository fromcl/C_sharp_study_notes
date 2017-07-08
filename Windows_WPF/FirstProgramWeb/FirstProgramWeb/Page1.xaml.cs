﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace FirstProgramWeb
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void toggleButton_Click(object sender, RoutedEventArgs e)
        {
            Storyboard spinStoryboard = Resources["Spin"] as Storyboard;
            if (spinStoryboard != null)
            {
                if (spinStoryboard.GetIsPaused(this))
                {
                    spinStoryboard.Resume(this);
                }
                else
                {
                    spinStoryboard.Pause(this);
                }
            }
        }
    }
}
