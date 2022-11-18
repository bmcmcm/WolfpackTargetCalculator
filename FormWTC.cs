//Copyright 2022 Brian McMahon, released under GPLv3

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfpackTargetCalculator
{
    public partial class FormWTC : Form
    {
        int mastHeight = 0;
        int shipLength = 0;
        string shipAspect = "ABL";
        public FormWTC()
        {
            InitializeComponent();
            ResetFormComponents();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWTC));
            WTCMain.DefaultShip = (Image)resources.GetObject("pbShipImage.Image");
            pbShipImage.Image = WTCMain.DefaultShip;
        }

        private void ResetFormComponents()
        {
            cbEUnspecified.Checked = true;
            cbEAmidship.Checked = false;
            cbEAft.Checked = false;
            cbSSUnspecified.Checked = true;
            cbSSSplit.Checked = false;
            cbSSComposite.Checked = false;
            cbSSPassenger.Checked = false;
            cbIUnspecified.Checked = true;
            cbIFore.Checked = false;
            cbIAmidship.Checked = false;
            cbIAft.Checked = false;
            lbShipList.Items.Clear();
            tbMasts.Text = null;
            pbShipImage.Image = WTCMain.DefaultShip;
            tbTSTonnage.Text = null;
            tbTSBeam.Text = null;
            tbTSMaxSpeed.Text = null;
            tbTSDraught.Text = null;
            tbTSLength.Text = null;
            tbTSMastHeight.Text = null;
            bApproachingBowLeft.BackColor = Color.Red;
            bApproachingBowRight.BackColor = Color.DimGray;
            bRecedingBowLeft.BackColor = Color.DimGray;
            bRecedingBowRight.BackColor = Color.DimGray;
            numTargetBearing.Value = 0;
            numTargetPassTime.Value = 60;
            numVerticalMeasurement.Value = 1.0m;
            numHorizontalMeasurement.Value = 2.0m;
            tbEstRange.Text = null;
            tbEstHeading.Text = null;
            tbEstSpeed.Text = null;
            tbAOB.Text = null;
        }

        public void AddlbShipListItem(string collectionItem)
        {
            lbShipList.Items.Add(collectionItem);
        }

        private void EstimatedTargetData()
        {
            double distanceBias = 0.95;
            double horizonalBias = 0.2;
            int targetBearing = (int)numTargetBearing.Value;
            int timeToPass = (int)numTargetPassTime.Value;
            double vertical = (double)numVerticalMeasurement.Value;
            double horizontal = (double)numHorizontalMeasurement.Value;
            decimal speed = (decimal)Math.Round(shipLength * 1.94 / timeToPass, 1);
            //Distance bias figured out through in-game testing to correct optics/game camera mis-scaling
            int distance = (int)Math.Round((mastHeight / Math.Tan(vertical / 64) * 6) * distanceBias);
            //Horizontal bias figured out through in-game testing to correct optics/game camera mis-scaling
            double aobCalculated = Math.Asin((distance * Math.Tan(horizontal * horizonalBias * (Math.PI / 180))) / (double)shipLength);
            int aob = 0;
            int heading = 0;
            string aobBlurb = "";

            switch (shipAspect)
            {
                case "RBL":
                    aob = (int)(90 - aobCalculated * 90) + 90;
                    if (aob > 180) { aob = 180; } else if (aob < 90) { aob = 90; }
                    heading = targetBearing + 180 + aob;
                    aobBlurb = "° Bow Left";
                    break;
                case "ABL":
                    aob = (int)(aobCalculated * 90);
                    if (aob > 90) { aob = 90; } else if (aob < 0) { aob = 0; }
                    heading = targetBearing + 180 + aob;
                    aobBlurb = "° Bow Left";
                    break;
                case "RBR":
                    aob = (int)(90 - aobCalculated * 90) + 90;
                    if (aob > 180) { aob = 180; } else if (aob < 90) { aob = 90; }
                    heading = targetBearing + 180 - aob;
                    aobBlurb = "° Bow Right";
                    break;
                case "ABR":
                    aob = (int)(aobCalculated * 90);
                    if (aob > 90) { aob = 90; } else if (aob < 0) { aob = 0; }
                    heading = targetBearing + 180 - aob;
                    aobBlurb = "° Bow Right";
                    break;
            }

            if (heading < 0) { heading += 360; }
            if (heading > 360) { heading -= 360; }
            decimal hm = (decimal)Math.Round((decimal)distance / 100, 1);
            tbEstRange.Text = distance.ToString() + " m : " + hm.ToString() + " hm";
            tbEstHeading.Text = heading.ToString() + "°";
            tbEstSpeed.Text = speed.ToString() + " knots";
            tbAOB.Text = aob.ToString() + aobBlurb;
        }

        private void UpdateFormShipData(Shipdata currentShipSelection)
        {
            bLockShip.Text = currentShipSelection.Description + " Unlocked";
            pbShipImage.Image = currentShipSelection.ImageBitmap;
            tbTSTonnage.Text = currentShipSelection.Tonnage.ToString();
            tbTSBeam.Text = currentShipSelection.Beam.ToString() + " m";
            tbTSMaxSpeed.Text = currentShipSelection.Speed.ToString() + " knots";
            tbTSDraught.Text = currentShipSelection.Draught.ToString() + " m";
            tbTSLength.Text = currentShipSelection.Length.ToString() + " m";
            tbTSMastHeight.Text = currentShipSelection.Height.ToString() + " m";
            mastHeight = currentShipSelection.Height;
            shipLength = currentShipSelection.Length;
            EstimatedTargetData();
        }

        private void lbShipList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = lbShipList.SelectedItem.ToString();
            IEnumerable<Shipdata> c = WTCMain.ShipDataList as IEnumerable<Shipdata>;
            Shipdata ship = c.First(s => s.Name == selected);
            WTCMain.CurrentShipSelection = ship;
            UpdateFormShipData(WTCMain.CurrentShipSelection);
            bLockShip.Enabled = true;
            bLockShip.BackColor = Color.LightBlue;
        }

        private void numTargetBearing_ValueChanged(object sender, EventArgs e)
        {
            if (numTargetBearing.Value == -1)
            {
                numTargetBearing.Value = 359;
            }
            if (numTargetBearing.Value == 360)
            {
                numTargetBearing.Value = 0;
            }
            EstimatedTargetData();
        }

        private void bLockShip_Click(object sender, EventArgs e)
        {
            if (WTCMain.CurrentShipSelection != null)
            {
                if (bLockShip.BackColor == Color.LightBlue)
                {
                    bLockShip.BackColor = Color.LightYellow;
                    bLockShip.Text = WTCMain.CurrentShipSelection.Description + " Locked";
                    lbShipList.Enabled = false;
                    cbEAft.Enabled = false;
                    cbEAmidship.Enabled = false;
                    cbEUnspecified.Enabled = false;
                    cbIAft.Enabled = false;
                    cbIAmidship.Enabled = false;
                    cbIFore.Enabled = false;
                    cbIUnspecified.Enabled = false;
                    cbSSComposite.Enabled = false;
                    cbSSPassenger.Enabled = false;
                    cbSSSplit.Enabled = false;
                    cbSSUnspecified.Enabled = false;
                    tbMasts.Enabled = false;
                    bMast.Enabled = false;
                    bKingpost.Enabled = false;
                    bFunnel.Enabled = false;
                    return;
                }
                else if (bLockShip.BackColor == Color.LightYellow)
                {
                    bLockShip.BackColor = Color.LightBlue;
                    bLockShip.Text = WTCMain.CurrentShipSelection.Description + " Unlocked";
                    lbShipList.Enabled = true;
                    cbEAft.Enabled = true;
                    cbEAmidship.Enabled = true;
                    cbEUnspecified.Enabled = true;
                    cbIAft.Enabled = true;
                    cbIAmidship.Enabled = true;
                    cbIFore.Enabled = true;
                    cbIUnspecified.Enabled = true;
                    cbSSComposite.Enabled = true;
                    cbSSPassenger.Enabled = true;
                    cbSSSplit.Enabled = true;
                    cbSSUnspecified.Enabled = true;
                    tbMasts.Enabled = true;
                    bMast.Enabled = true;
                    bKingpost.Enabled = true;
                    bFunnel.Enabled = true;
                }
            }
        }

        private void UpdateLBShipList(string filterType, string filter)
        {
            List<Shipdata>? filtered = WTCMain.ShipDataList;
            if (filterType == "Engine")
            {
                WTCMain.EngineFilter = filter;
            }
            if (filterType == "Superstructure")
            {
                WTCMain.SuperstructureFilter = filter;
            }
            if (filterType == "Islands")
            {
                WTCMain.IslandsFilter = filter;
            }
            if (filterType == "Masts")
            {
                WTCMain.MastsFilter = filter;
            }
            if (WTCMain.EngineFilter != "U" && WTCMain.EngineFilter != "")
            {
                filtered = filtered.FindAll(f => f.Engine == WTCMain.EngineFilter);
            }
            if (WTCMain.SuperstructureFilter != "U" && WTCMain.SuperstructureFilter != "")
            {
                filtered = filtered.FindAll(f => f.Superstructure == WTCMain.SuperstructureFilter);
            }
            if (WTCMain.IslandsFilter != "U")
            {
                filtered = filtered.FindAll(f => f.Islands == WTCMain.IslandsFilter);
            }
            if (WTCMain.MastsFilter != "")
            {
                filtered = filtered.FindAll(f => f.Masts.StartsWith(WTCMain.MastsFilter));
            }
            lbShipList.Items.Clear();
            lbShipList.SelectedItem = null;
            pbShipImage.Image = WTCMain.DefaultShip;
            bLockShip.Text = "No Ship Selected Unlocked";
            WTCMain.CurrentShipSelection = null;
            for (int i = 0; i < filtered.Count; i++)
            {
                AddlbShipListItem(filtered.ElementAt(i).Name);
            }
        }
        private void bMast_Click(object sender, EventArgs e)
        {
            if (lbShipList.Enabled == true)
            {
                tbMasts.Text += "M";
                UpdateLBShipList("Masts", tbMasts.Text);
            }
        }
        private void bKingpost_Click(object sender, EventArgs e)
        {
            if (lbShipList.Enabled == true)
            {
                tbMasts.Text += "K";
                UpdateLBShipList("Masts", tbMasts.Text);
            }
        }
        private void bFunnel_Click(object sender, EventArgs e)
        {
            if (lbShipList.Enabled == true)
            {
                tbMasts.Text += "F";
                UpdateLBShipList("Masts", tbMasts.Text);
            }
        }

        private void bClearMasts_Click(object sender, EventArgs e)
        {
            if (lbShipList.Enabled == true)
            {
                tbMasts.Text = "";
                UpdateLBShipList("Masts", tbMasts.Text);
            }
        }

        private void EvalIslands()
        {
            string eval = "";
            if (cbIFore.Checked == true) { eval += "F"; }
            if (cbIAmidship.Checked == true) { eval += "M"; }
            if (cbIAft.Checked == true) { eval += "A"; }
            UpdateLBShipList("Islands", eval);
        }

        private void cbIFore_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIUnspecified.Checked == true && cbIFore.Checked == true)
            {
                cbIUnspecified.Checked = false;
            }
            EvalIslands();
        }

        private void cbIAmidship_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIUnspecified.Checked == true && cbIAmidship.Checked == true)
            {
                cbIUnspecified.Checked = false;
            }
            EvalIslands();
        }

        private void cbIAft_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIUnspecified.Checked == true && cbIAft.Checked == true)
            {
                cbIUnspecified.Checked = false;
            }
            EvalIslands();
        }

        private void cbIUnspecified_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbIUnspecified.Checked && !cbIFore.Checked && !cbIAmidship.Checked && !cbIAft.Checked)
            {
                UpdateLBShipList("Islands", "");
            }
            else if (cbIUnspecified.Checked)
            {
                cbIUnspecified.Checked = true;
                cbIFore.Checked = false;
                cbIAmidship.Checked = false;
                cbIAft.Checked = false;
                UpdateLBShipList("Islands", "U");
            }
        }

        private void EvalSuperstructure()
        {
            string eval = "";
            if (cbSSSplit.Checked == true) { eval = "S"; }
            if (cbSSComposite.Checked == true) { eval = "C"; }
            if (cbSSPassenger.Checked == true) { eval = "P"; }
            UpdateLBShipList("Superstructure", eval);
        }

        private void cbSSUnspecified_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbSSUnspecified.Checked && !cbSSSplit.Checked && !cbSSComposite.Checked && !cbSSPassenger.Checked)
            {
                UpdateLBShipList("Superstructure", "");
            }
            else if (cbSSUnspecified.Checked)
            {
                cbSSSplit.Checked = false;
                cbSSComposite.Checked = false;
                cbSSPassenger.Checked = false;
                cbSSUnspecified.Checked = true;
                UpdateLBShipList("Superstructure", "U");
            }
        }

        private void cbSSSplit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSSSplit.Checked)
            {
                cbSSUnspecified.Checked = false;
                cbSSComposite.Checked = false;
                cbSSPassenger.Checked = false;
                cbSSSplit.Checked = true;
            }
            EvalSuperstructure();
        }

        private void cbSSComposite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSSComposite.Checked)
            {
                cbSSUnspecified.Checked = false;
                cbSSSplit.Checked = false;
                cbSSPassenger.Checked = false;
                cbSSComposite.Checked = true;
            }
            EvalSuperstructure();
        }

        private void cbSSPassenger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSSPassenger.Checked)
            {
                cbSSUnspecified.Checked = false;
                cbSSComposite.Checked = false;
                cbSSSplit.Checked = false;
                cbSSPassenger.Checked = true;
            }
            EvalSuperstructure();
        }

        private void EvalEngine()
        {
            string eval = "";
            if (cbEAmidship.Checked == true) { eval = "M"; }
            if (cbEAft.Checked == true) { eval = "A"; }
            UpdateLBShipList("Engine", eval);
        }

        private void cbEUnspecified_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbEUnspecified.Checked && !cbEAmidship.Checked && !cbSSComposite.Checked)
            {
                UpdateLBShipList("Engine", "");
            }
            else if (cbEUnspecified.Checked)
            {
                cbEUnspecified.Checked = true;
                cbEAmidship.Checked = false;
                cbEAft.Checked = false;
                UpdateLBShipList("Engine", "U");
            }
        }
        private void cbEAmidship_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEAmidship.Checked)
            {
                cbEUnspecified.Checked = false;
                cbEAft.Checked = false;
                cbEAmidship.Checked = true;
            }
            EvalEngine();
        }

        private void cbEAft_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEAft.Checked)
            {
                cbEUnspecified.Checked = false;
                cbEAmidship.Checked = false;
                cbEAft.Checked = true;
            }
            EvalEngine();
        }

        private void numTargetPassTime_ValueChanged(object sender, EventArgs e)
        {
            EstimatedTargetData();
        }

        private void numVerticalMeasurement_ValueChanged(object sender, EventArgs e)
        {
            EstimatedTargetData();
        }

        private void numHorizontalMeasurement_ValueChanged(object sender, EventArgs e)
        {
            EstimatedTargetData();
        }

        private void bApproachingBowLeft_Click(object sender, EventArgs e)
        {
            shipAspect = "ABL";
            bApproachingBowLeft.BackColor = Color.Red;
            bRecedingBowLeft.BackColor = Color.DimGray;
            bApproachingBowRight.BackColor = Color.DimGray;
            bRecedingBowRight.BackColor = Color.DimGray;
            EstimatedTargetData();
        }

        private void bRecedingBowLeft_Click(object sender, EventArgs e)
        {
            shipAspect = "RBL";
            bApproachingBowLeft.BackColor = Color.DimGray;
            bRecedingBowLeft.BackColor = Color.Red;
            bApproachingBowRight.BackColor = Color.DimGray;
            bRecedingBowRight.BackColor = Color.DimGray;
            EstimatedTargetData();
        }

        private void bApproachingBowRight_Click(object sender, EventArgs e)
        {
            shipAspect = "ABR";
            bApproachingBowLeft.BackColor = Color.DimGray;
            bRecedingBowLeft.BackColor = Color.DimGray;
            bApproachingBowRight.BackColor = Color.Green;
            bRecedingBowRight.BackColor = Color.DimGray;
            EstimatedTargetData();
        }

        private void bRecedingBowRight_Click(object sender, EventArgs e)
        {
            shipAspect = "RBR";
            bApproachingBowLeft.BackColor = Color.DimGray;
            bRecedingBowLeft.BackColor = Color.DimGray;
            bApproachingBowRight.BackColor = Color.DimGray;
            bRecedingBowRight.BackColor = Color.Green;
            EstimatedTargetData();
        }

        private void ToggleFormBorder()
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.Location = new System.Drawing.Point(x - 8, y - 30);
            } else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Location = new System.Drawing.Point(x + 8, y + 30);
            }
        }

        private void ToggleRecognitionGroupBox()
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            if (this.gbTargetRecognition.Visible)
            {
                this.gbTargetRecognition.Visible = false;
                this.gbObservations.Left = 7;
                this.gbETD.Left = 3 + this.gbObservations.Right;
                this.bTargetRecognitionGroup.Left = 7;
                this.bFormBorder.Left = 3 + this.bTargetRecognitionGroup.Right;
                this.Width = 28 + this.gbObservations.Width + this.gbETD.Width;
                this.Location = new System.Drawing.Point(x + 3 + this.gbTargetRecognition.Width,y);
            } else
            {
                this.gbObservations.Left = 3 + this.gbTargetRecognition.Right;
                this.gbETD.Left = 3 + this.gbObservations.Right;
                this.bTargetRecognitionGroup.Left = 3 + this.gbTargetRecognition.Right;
                this.bFormBorder.Left = 3 + this.bTargetRecognitionGroup.Right;
                this.gbTargetRecognition.Visible = true;
                this.Width = 34 + this.gbTargetRecognition.Width + this.gbObservations.Width + this.gbETD.Width;
                this.Location = new System.Drawing.Point(x - 3 - this.gbTargetRecognition.Width, y);
            }
        }

        private void bFormBorder_Click(object sender, EventArgs e)
        {
            ToggleFormBorder();
        }

        private void bTargetRecognitionGroup_Click(object sender, EventArgs e)
        {
            ToggleRecognitionGroupBox();
        }

        private void pbShipImage_Click(object sender, EventArgs e)
        {
            if (pbShipImage.Image == WTCMain.DefaultShip)
            {
                Process.Start(new ProcessStartInfo("https://www.subsim.com") { UseShellExecute = true });
            }
        }
    }
}
