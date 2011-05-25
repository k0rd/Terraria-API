﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Terraria;

namespace TrainerPlugin
{
    public partial class TrainerForm : Form
    {
        public TrainerForm()
        {
            InitializeComponent();
        }

        private void TrainerForm_Shown(object sender, EventArgs e)
        {
            GrabSunChk.Checked = Main.grabSun;
            GodModeChk.Checked = Main.godMode;
            StopSpawnsChk.Checked = Main.stopSpawns;
            DumbAIChk.Checked = Main.dumbAI;
            LightTilesChk.Checked = Main.lightTiles;
        }

        private void GrabSunChk_CheckedChanged(object sender, EventArgs e)
        {
            Main.grabSun = GrabSunChk.Checked;
        }

        private void GodModeChk_CheckedChanged(object sender, EventArgs e)
        {
            Main.godMode = GodModeChk.Checked;
        }

        private void StopSpawnsChk_CheckedChanged(object sender, EventArgs e)
        {
            Main.stopSpawns = StopSpawnsChk.Checked;
        }

        private void DumbAIChk_CheckedChanged(object sender, EventArgs e)
        {
            Main.dumbAI = DumbAIChk.Checked;
        }

        private void LightTilesChk_CheckedChanged(object sender, EventArgs e)
        {
            Main.lightTiles = LightTilesChk.Checked;
        }

        private void TrainerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}