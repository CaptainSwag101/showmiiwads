﻿/* This file is part of Wii.cs Tools
 * Copyright (C) 2009 Leathl
 * 
 * Wii.cs Tools is free software: you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as published
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * Wii.cs Tools is distributed in the hope that it will be
 * useful, but WITHOUT ANY WARRANTY; without even the implied warranty
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Windows.Forms;

namespace Wii
{
    public partial class WadMii_KeyDialog : Form
    {
        public string Input;

        public WadMii_KeyDialog()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbInput.Text == "45e")
            {
                Input = tbInput.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else { tbInput.Focus(); tbInput.SelectAll(); }
        }
    }
}
