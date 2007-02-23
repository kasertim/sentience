/*
    Sentience 3D Perception System
    Copyright (C) 2000-2007 Bob Mottram
    fuzzgun@gmail.com

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sentience.core;

namespace robotDesigner
{
    public partial class frmMain : Form
    {
        robot rob = new robot(1, 100);

        public frmMain()
        {
            InitializeComponent();
            LoadRobot("robotdesign.xml");
        }

        public void LoadRobot(String filename)
        {            
            if (rob.Load(filename))
            {
                txtName.Text = rob.Name;
                txtTotalMass.Text = Convert.ToString(rob.TotalMass_kg);
                txtBodyWidth.Text = Convert.ToString(rob.BodyWidth_mm);
                txtBodyLength.Text = Convert.ToString(rob.BodyLength_mm);
                txtBodyHeight.Text = Convert.ToString(rob.BodyHeight_mm);
                cmbPropulsion.SelectedIndex = rob.propulsionType;
                txtWheelDiameter.Text = Convert.ToString(rob.WheelDiameter_mm);
                cmbWheelFeedback.SelectedIndex = rob.WheelPositionFeedbackType;
                txtGearRatio.Text = Convert.ToString(rob.GearRatio);
                txtCountsPerRev.Text = Convert.ToString(rob.CountsPerRev);
                txtCameraBaseline.Text = Convert.ToString(rob.head.calibration[0].baseline);
                txtCameraFOV.Text = Convert.ToString(rob.head.calibration[0].leftcam.camera_FOV_degrees);
                cmbHeadType.SelectedIndex = rob.HeadType;
                txtHeadSize.Text = Convert.ToString(rob.HeadSize_mm);
                cmbHeadShape.SelectedIndex = rob.HeadShape;
                txtHeadHeightFromGround.Text = Convert.ToString(rob.HeadHeight_mm);
                txtNoOfCameras.Text = Convert.ToString(rob.head.no_of_cameras);
                cmbCameraOrientation.SelectedIndex = rob.CameraOrientation;
            }
        }

        public void update()
        {
            rob.Name = txtName.Text;
            rob.TotalMass_kg = Convert.ToSingle(txtTotalMass.Text);
            rob.BodyWidth_mm = Convert.ToSingle(txtBodyWidth.Text);
            rob.BodyLength_mm = Convert.ToSingle(txtBodyLength.Text);
            rob.BodyHeight_mm = Convert.ToSingle(txtBodyHeight.Text);
            rob.propulsionType = Convert.ToInt32(cmbPropulsion.SelectedIndex);
            rob.WheelDiameter_mm = Convert.ToSingle(txtWheelDiameter.Text);
            rob.WheelPositionFeedbackType = Convert.ToInt32(cmbWheelFeedback.SelectedIndex);
            rob.GearRatio = Convert.ToInt32(txtGearRatio.Text);
            rob.CountsPerRev = Convert.ToInt32(txtCountsPerRev.Text);
            rob.head.calibration[0].baseline = Convert.ToSingle(txtCameraBaseline.Text);
            rob.head.calibration[0].leftcam.camera_FOV_degrees = Convert.ToSingle(txtCameraFOV.Text);
            rob.HeadType = Convert.ToInt32(cmbHeadType.SelectedIndex);
            rob.HeadSize_mm = Convert.ToSingle(txtHeadSize.Text);
            rob.HeadShape = Convert.ToInt32(cmbHeadShape.SelectedIndex);
            rob.HeadHeight_mm = Convert.ToSingle(txtHeadHeightFromGround.Text);
            rob.head.no_of_cameras = Convert.ToInt32(txtNoOfCameras.Text);
            rob.CameraOrientation = Convert.ToInt32(cmbCameraOrientation.SelectedIndex);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPropulsion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPropulsion.SelectedIndex > 1)
                grpWheels.Visible = false;
            else
                grpWheels.Visible = true;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update();

            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.FileName = rob.Name + ".xml";
            saveFileDialog1.Filter = "Xml files|*.xml";
            saveFileDialog1.Title = "Save robot design file";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                rob.Save(saveFileDialog1.FileName);

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.FileName = ".xml";
            openFileDialog1.Filter = "Xml files|*.xml";
            openFileDialog1.Title = "Load robot design file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadRobot(openFileDialog1.FileName);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            update();
            rob.Save("robotdesign.xml");
        }
    }
}