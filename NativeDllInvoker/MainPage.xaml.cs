// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace NativeDllInvoker
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                button.Content = add(5, 7);
            }
            catch (Exception exception)
            {
                log.Text = exception.Message;
            }
        }

        [DllImport("NativeDll")]
        private static extern int add(int a, int b);
    }
}
