﻿using Framework.Constants;
using Game.DataStorage;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spell_Editor
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();

            FormClosed += Loading_FormClosed;
        }

        private void Loading_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private delegate void CloseDelegate();

        private static Loading loadingForm;

        static public void ShowLoadingScreen()
        {
            // Make sure it is only launched once.    
            if (loadingForm != null) return;
            loadingForm = new Loading();
            Thread thread = new Thread(new ThreadStart(Loading.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            if (loadingForm != null) Application.Run(loadingForm);
        }

        static public void CloseForm()
        {
            if (loadingForm != null && !loadingForm.IsDisposed) loadingForm?.Invoke(new CloseDelegate(Loading.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            if (loadingForm != null)
            {
                loadingForm.FormClosed -= loadingForm.Loading_FormClosed;
                loadingForm.Close();
                loadingForm = null;
            };
        }
    }
}
