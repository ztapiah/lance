﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace lance.ViewModels
{
    public class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsRunning { get; set; }
        public bool IsRemembered { get; set; }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }
        #endregion

        #region Commands
        public ICommand AceptarCommand { get; set; }
        #endregion
    }
}
