using System.Windows.Forms;

namespace WolfpackTargetCalculator
{
    partial class FormWTC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWTC));
            this.gbTargetRecognition = new System.Windows.Forms.GroupBox();
            this.tbTSBeam = new System.Windows.Forms.TextBox();
            this.tbTSMaxSpeed = new System.Windows.Forms.TextBox();
            this.tbTSDraught = new System.Windows.Forms.TextBox();
            this.tbTSLength = new System.Windows.Forms.TextBox();
            this.tbTSMastHeight = new System.Windows.Forms.TextBox();
            this.tbTSTonnage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbShipImage = new System.Windows.Forms.PictureBox();
            this.bLockShip = new System.Windows.Forms.Button();
            this.lbShipList = new System.Windows.Forms.ListBox();
            this.bClearMasts = new System.Windows.Forms.Button();
            this.tbMasts = new System.Windows.Forms.TextBox();
            this.bFunnel = new System.Windows.Forms.Button();
            this.bKingpost = new System.Windows.Forms.Button();
            this.bMast = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cbIUnspecified = new System.Windows.Forms.CheckBox();
            this.cbSSUnspecified = new System.Windows.Forms.CheckBox();
            this.cbEUnspecified = new System.Windows.Forms.CheckBox();
            this.cbIAft = new System.Windows.Forms.CheckBox();
            this.cbIAmidship = new System.Windows.Forms.CheckBox();
            this.cbIFore = new System.Windows.Forms.CheckBox();
            this.cbSSPassenger = new System.Windows.Forms.CheckBox();
            this.cbSSComposite = new System.Windows.Forms.CheckBox();
            this.cbSSSplit = new System.Windows.Forms.CheckBox();
            this.cbEAft = new System.Windows.Forms.CheckBox();
            this.cbEAmidship = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbObservations = new System.Windows.Forms.GroupBox();
            this.numTargetPassTime = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.numHorizontalMeasurement = new System.Windows.Forms.NumericUpDown();
            this.numVerticalMeasurement = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numTargetBearing = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.bRecedingBowRight = new System.Windows.Forms.Button();
            this.bApproachingBowRight = new System.Windows.Forms.Button();
            this.bApproachingBowLeft = new System.Windows.Forms.Button();
            this.bRecedingBowLeft = new System.Windows.Forms.Button();
            this.gbETD = new System.Windows.Forms.GroupBox();
            this.tbEstSpeed = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbAOB = new System.Windows.Forms.TextBox();
            this.tbEstHeading = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbEstRange = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bFormBorder = new System.Windows.Forms.Button();
            this.bTargetRecognitionGroup = new System.Windows.Forms.Button();
            this.bCollapse = new System.Windows.Forms.Button();
            this.gbTargetRecognition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShipImage)).BeginInit();
            this.gbObservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetPassTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontalMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVerticalMeasurement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetBearing)).BeginInit();
            this.gbETD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTargetRecognition
            // 
            this.gbTargetRecognition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbTargetRecognition.Controls.Add(this.tbTSBeam);
            this.gbTargetRecognition.Controls.Add(this.tbTSMaxSpeed);
            this.gbTargetRecognition.Controls.Add(this.tbTSDraught);
            this.gbTargetRecognition.Controls.Add(this.tbTSLength);
            this.gbTargetRecognition.Controls.Add(this.tbTSMastHeight);
            this.gbTargetRecognition.Controls.Add(this.tbTSTonnage);
            this.gbTargetRecognition.Controls.Add(this.label12);
            this.gbTargetRecognition.Controls.Add(this.label13);
            this.gbTargetRecognition.Controls.Add(this.label11);
            this.gbTargetRecognition.Controls.Add(this.label4);
            this.gbTargetRecognition.Controls.Add(this.label3);
            this.gbTargetRecognition.Controls.Add(this.label2);
            this.gbTargetRecognition.Controls.Add(this.pbShipImage);
            this.gbTargetRecognition.Controls.Add(this.bLockShip);
            this.gbTargetRecognition.Controls.Add(this.lbShipList);
            this.gbTargetRecognition.Controls.Add(this.bClearMasts);
            this.gbTargetRecognition.Controls.Add(this.tbMasts);
            this.gbTargetRecognition.Controls.Add(this.bFunnel);
            this.gbTargetRecognition.Controls.Add(this.bKingpost);
            this.gbTargetRecognition.Controls.Add(this.bMast);
            this.gbTargetRecognition.Controls.Add(this.label17);
            this.gbTargetRecognition.Controls.Add(this.cbIUnspecified);
            this.gbTargetRecognition.Controls.Add(this.cbSSUnspecified);
            this.gbTargetRecognition.Controls.Add(this.cbEUnspecified);
            this.gbTargetRecognition.Controls.Add(this.cbIAft);
            this.gbTargetRecognition.Controls.Add(this.cbIAmidship);
            this.gbTargetRecognition.Controls.Add(this.cbIFore);
            this.gbTargetRecognition.Controls.Add(this.cbSSPassenger);
            this.gbTargetRecognition.Controls.Add(this.cbSSComposite);
            this.gbTargetRecognition.Controls.Add(this.cbSSSplit);
            this.gbTargetRecognition.Controls.Add(this.cbEAft);
            this.gbTargetRecognition.Controls.Add(this.cbEAmidship);
            this.gbTargetRecognition.Controls.Add(this.label16);
            this.gbTargetRecognition.Controls.Add(this.label15);
            this.gbTargetRecognition.Controls.Add(this.label14);
            this.gbTargetRecognition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTargetRecognition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbTargetRecognition.ForeColor = System.Drawing.Color.Red;
            this.gbTargetRecognition.Location = new System.Drawing.Point(11, 10);
            this.gbTargetRecognition.Margin = new System.Windows.Forms.Padding(2);
            this.gbTargetRecognition.Name = "gbTargetRecognition";
            this.gbTargetRecognition.Padding = new System.Windows.Forms.Padding(2);
            this.gbTargetRecognition.Size = new System.Drawing.Size(875, 287);
            this.gbTargetRecognition.TabIndex = 0;
            this.gbTargetRecognition.TabStop = false;
            this.gbTargetRecognition.Text = "Target Recognition";
            // 
            // tbTSBeam
            // 
            this.tbTSBeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTSBeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTSBeam.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTSBeam.ForeColor = System.Drawing.Color.Red;
            this.tbTSBeam.Location = new System.Drawing.Point(594, 223);
            this.tbTSBeam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTSBeam.Name = "tbTSBeam";
            this.tbTSBeam.ReadOnly = true;
            this.tbTSBeam.Size = new System.Drawing.Size(72, 22);
            this.tbTSBeam.TabIndex = 107;
            this.tbTSBeam.Text = "18 m";
            // 
            // tbTSMaxSpeed
            // 
            this.tbTSMaxSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTSMaxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTSMaxSpeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTSMaxSpeed.ForeColor = System.Drawing.Color.Red;
            this.tbTSMaxSpeed.Location = new System.Drawing.Point(594, 254);
            this.tbTSMaxSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTSMaxSpeed.Name = "tbTSMaxSpeed";
            this.tbTSMaxSpeed.ReadOnly = true;
            this.tbTSMaxSpeed.Size = new System.Drawing.Size(72, 22);
            this.tbTSMaxSpeed.TabIndex = 106;
            this.tbTSMaxSpeed.Text = "11 knots";
            // 
            // tbTSDraught
            // 
            this.tbTSDraught.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTSDraught.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTSDraught.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTSDraught.ForeColor = System.Drawing.Color.Red;
            this.tbTSDraught.Location = new System.Drawing.Point(790, 193);
            this.tbTSDraught.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTSDraught.Name = "tbTSDraught";
            this.tbTSDraught.ReadOnly = true;
            this.tbTSDraught.Size = new System.Drawing.Size(72, 22);
            this.tbTSDraught.TabIndex = 105;
            this.tbTSDraught.Text = "6 m";
            // 
            // tbTSLength
            // 
            this.tbTSLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTSLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTSLength.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTSLength.ForeColor = System.Drawing.Color.Red;
            this.tbTSLength.Location = new System.Drawing.Point(790, 223);
            this.tbTSLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTSLength.Name = "tbTSLength";
            this.tbTSLength.ReadOnly = true;
            this.tbTSLength.Size = new System.Drawing.Size(72, 22);
            this.tbTSLength.TabIndex = 104;
            this.tbTSLength.Text = "125 m";
            // 
            // tbTSMastHeight
            // 
            this.tbTSMastHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTSMastHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTSMastHeight.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTSMastHeight.ForeColor = System.Drawing.Color.Red;
            this.tbTSMastHeight.Location = new System.Drawing.Point(791, 254);
            this.tbTSMastHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTSMastHeight.Name = "tbTSMastHeight";
            this.tbTSMastHeight.ReadOnly = true;
            this.tbTSMastHeight.Size = new System.Drawing.Size(72, 22);
            this.tbTSMastHeight.TabIndex = 103;
            this.tbTSMastHeight.Text = "32 m";
            // 
            // tbTSTonnage
            // 
            this.tbTSTonnage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbTSTonnage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTSTonnage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTSTonnage.ForeColor = System.Drawing.Color.Red;
            this.tbTSTonnage.Location = new System.Drawing.Point(594, 193);
            this.tbTSTonnage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTSTonnage.Name = "tbTSTonnage";
            this.tbTSTonnage.ReadOnly = true;
            this.tbTSTonnage.Size = new System.Drawing.Size(72, 22);
            this.tbTSTonnage.TabIndex = 102;
            this.tbTSTonnage.Text = "32000 tons";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(540, 225);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 12);
            this.label12.TabIndex = 101;
            this.label12.Text = "Beam";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(509, 256);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 100;
            this.label13.Text = "Max Speed";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(724, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 12);
            this.label11.TabIndex = 99;
            this.label11.Text = "Draught";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(728, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 98;
            this.label4.Text = "Length";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(700, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 97;
            this.label3.Text = "Mast Height";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(522, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 96;
            this.label2.Text = "Tonnage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbShipImage
            // 
            this.pbShipImage.Image = ((System.Drawing.Image)(resources.GetObject("pbShipImage.Image")));
            this.pbShipImage.InitialImage = null;
            this.pbShipImage.Location = new System.Drawing.Point(512, 18);
            this.pbShipImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbShipImage.Name = "pbShipImage";
            this.pbShipImage.Size = new System.Drawing.Size(350, 166);
            this.pbShipImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShipImage.TabIndex = 95;
            this.pbShipImage.TabStop = false;
            this.pbShipImage.Click += new System.EventHandler(this.pbShipImage_Click);
            // 
            // bLockShip
            // 
            this.bLockShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bLockShip.Enabled = false;
            this.bLockShip.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bLockShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLockShip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bLockShip.ForeColor = System.Drawing.Color.Red;
            this.bLockShip.Location = new System.Drawing.Point(6, 136);
            this.bLockShip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bLockShip.Name = "bLockShip";
            this.bLockShip.Size = new System.Drawing.Size(313, 28);
            this.bLockShip.TabIndex = 94;
            this.bLockShip.Text = "Target Ship Unlocked";
            this.bLockShip.UseVisualStyleBackColor = false;
            this.bLockShip.Click += new System.EventHandler(this.bLockShip_Click);
            // 
            // lbShipList
            // 
            this.lbShipList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbShipList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShipList.ColumnWidth = 60;
            this.lbShipList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbShipList.ForeColor = System.Drawing.Color.Red;
            this.lbShipList.FormattingEnabled = true;
            this.lbShipList.Location = new System.Drawing.Point(6, 170);
            this.lbShipList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbShipList.MultiColumn = true;
            this.lbShipList.Name = "lbShipList";
            this.lbShipList.Size = new System.Drawing.Size(498, 106);
            this.lbShipList.Sorted = true;
            this.lbShipList.TabIndex = 93;
            this.lbShipList.SelectedIndexChanged += new System.EventHandler(this.lbShipList_SelectedIndexChanged);
            // 
            // bClearMasts
            // 
            this.bClearMasts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bClearMasts.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bClearMasts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClearMasts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bClearMasts.ForeColor = System.Drawing.Color.Red;
            this.bClearMasts.Location = new System.Drawing.Point(448, 135);
            this.bClearMasts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bClearMasts.Name = "bClearMasts";
            this.bClearMasts.Size = new System.Drawing.Size(56, 30);
            this.bClearMasts.TabIndex = 92;
            this.bClearMasts.Text = "Clear";
            this.bClearMasts.UseVisualStyleBackColor = false;
            this.bClearMasts.Click += new System.EventHandler(this.bClearMasts_Click);
            // 
            // tbMasts
            // 
            this.tbMasts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbMasts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMasts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbMasts.ForeColor = System.Drawing.Color.Red;
            this.tbMasts.Location = new System.Drawing.Point(342, 136);
            this.tbMasts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMasts.MaxLength = 5;
            this.tbMasts.Name = "tbMasts";
            this.tbMasts.Size = new System.Drawing.Size(98, 25);
            this.tbMasts.TabIndex = 91;
            this.tbMasts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMasts.WordWrap = false;
            // 
            // bFunnel
            // 
            this.bFunnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bFunnel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bFunnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFunnel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bFunnel.ForeColor = System.Drawing.Color.Red;
            this.bFunnel.Image = ((System.Drawing.Image)(resources.GetObject("bFunnel.Image")));
            this.bFunnel.Location = new System.Drawing.Point(448, 36);
            this.bFunnel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bFunnel.Name = "bFunnel";
            this.bFunnel.Size = new System.Drawing.Size(56, 90);
            this.bFunnel.TabIndex = 90;
            this.bFunnel.UseVisualStyleBackColor = false;
            this.bFunnel.Click += new System.EventHandler(this.bFunnel_Click);
            // 
            // bKingpost
            // 
            this.bKingpost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bKingpost.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bKingpost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKingpost.ForeColor = System.Drawing.Color.Red;
            this.bKingpost.Image = ((System.Drawing.Image)(resources.GetObject("bKingpost.Image")));
            this.bKingpost.Location = new System.Drawing.Point(384, 36);
            this.bKingpost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bKingpost.Name = "bKingpost";
            this.bKingpost.Size = new System.Drawing.Size(56, 90);
            this.bKingpost.TabIndex = 89;
            this.bKingpost.UseVisualStyleBackColor = false;
            this.bKingpost.Click += new System.EventHandler(this.bKingpost_Click);
            // 
            // bMast
            // 
            this.bMast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bMast.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bMast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMast.ForeColor = System.Drawing.Color.Red;
            this.bMast.Image = ((System.Drawing.Image)(resources.GetObject("bMast.Image")));
            this.bMast.Location = new System.Drawing.Point(320, 36);
            this.bMast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bMast.Name = "bMast";
            this.bMast.Size = new System.Drawing.Size(56, 90);
            this.bMast.TabIndex = 88;
            this.bMast.UseVisualStyleBackColor = false;
            this.bMast.Click += new System.EventHandler(this.bMast_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(318, 17);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 14);
            this.label17.TabIndex = 87;
            this.label17.Text = "Masts";
            // 
            // cbIUnspecified
            // 
            this.cbIUnspecified.AutoSize = true;
            this.cbIUnspecified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbIUnspecified.Checked = true;
            this.cbIUnspecified.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIUnspecified.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbIUnspecified.Location = new System.Drawing.Point(212, 43);
            this.cbIUnspecified.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIUnspecified.Name = "cbIUnspecified";
            this.cbIUnspecified.Size = new System.Drawing.Size(90, 16);
            this.cbIUnspecified.TabIndex = 86;
            this.cbIUnspecified.Text = "Unspecified";
            this.cbIUnspecified.UseVisualStyleBackColor = false;
            this.cbIUnspecified.CheckedChanged += new System.EventHandler(this.cbIUnspecified_CheckedChanged);
            // 
            // cbSSUnspecified
            // 
            this.cbSSUnspecified.AutoSize = true;
            this.cbSSUnspecified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSSUnspecified.Checked = true;
            this.cbSSUnspecified.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSSUnspecified.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSSUnspecified.Location = new System.Drawing.Point(105, 43);
            this.cbSSUnspecified.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSSUnspecified.Name = "cbSSUnspecified";
            this.cbSSUnspecified.Size = new System.Drawing.Size(90, 16);
            this.cbSSUnspecified.TabIndex = 85;
            this.cbSSUnspecified.Text = "Unspecified";
            this.cbSSUnspecified.UseVisualStyleBackColor = false;
            this.cbSSUnspecified.CheckedChanged += new System.EventHandler(this.cbSSUnspecified_CheckedChanged);
            // 
            // cbEUnspecified
            // 
            this.cbEUnspecified.AutoSize = true;
            this.cbEUnspecified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEUnspecified.Checked = true;
            this.cbEUnspecified.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEUnspecified.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEUnspecified.Location = new System.Drawing.Point(4, 43);
            this.cbEUnspecified.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEUnspecified.Name = "cbEUnspecified";
            this.cbEUnspecified.Size = new System.Drawing.Size(90, 16);
            this.cbEUnspecified.TabIndex = 84;
            this.cbEUnspecified.Text = "Unspecified";
            this.cbEUnspecified.UseVisualStyleBackColor = false;
            this.cbEUnspecified.CheckedChanged += new System.EventHandler(this.cbEUnspecified_CheckedChanged);
            // 
            // cbIAft
            // 
            this.cbIAft.AutoSize = true;
            this.cbIAft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbIAft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbIAft.Location = new System.Drawing.Point(212, 109);
            this.cbIAft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIAft.Name = "cbIAft";
            this.cbIAft.Size = new System.Drawing.Size(40, 16);
            this.cbIAft.TabIndex = 83;
            this.cbIAft.Text = "Aft";
            this.cbIAft.UseVisualStyleBackColor = false;
            this.cbIAft.CheckedChanged += new System.EventHandler(this.cbIAft_CheckedChanged);
            // 
            // cbIAmidship
            // 
            this.cbIAmidship.AutoSize = true;
            this.cbIAmidship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbIAmidship.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbIAmidship.Location = new System.Drawing.Point(212, 87);
            this.cbIAmidship.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIAmidship.Name = "cbIAmidship";
            this.cbIAmidship.Size = new System.Drawing.Size(76, 16);
            this.cbIAmidship.TabIndex = 82;
            this.cbIAmidship.Text = "AmidShip";
            this.cbIAmidship.UseVisualStyleBackColor = false;
            this.cbIAmidship.CheckedChanged += new System.EventHandler(this.cbIAmidship_CheckedChanged);
            // 
            // cbIFore
            // 
            this.cbIFore.AutoSize = true;
            this.cbIFore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbIFore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbIFore.Location = new System.Drawing.Point(212, 65);
            this.cbIFore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIFore.Name = "cbIFore";
            this.cbIFore.Size = new System.Drawing.Size(71, 16);
            this.cbIFore.TabIndex = 81;
            this.cbIFore.Text = "Forward";
            this.cbIFore.UseVisualStyleBackColor = false;
            this.cbIFore.CheckedChanged += new System.EventHandler(this.cbIFore_CheckedChanged);
            // 
            // cbSSPassenger
            // 
            this.cbSSPassenger.AutoSize = true;
            this.cbSSPassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSSPassenger.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSSPassenger.Location = new System.Drawing.Point(105, 109);
            this.cbSSPassenger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSSPassenger.Name = "cbSSPassenger";
            this.cbSSPassenger.Size = new System.Drawing.Size(83, 16);
            this.cbSSPassenger.TabIndex = 80;
            this.cbSSPassenger.Text = "Passenger";
            this.cbSSPassenger.UseVisualStyleBackColor = false;
            this.cbSSPassenger.CheckedChanged += new System.EventHandler(this.cbSSPassenger_CheckedChanged);
            // 
            // cbSSComposite
            // 
            this.cbSSComposite.AutoSize = true;
            this.cbSSComposite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSSComposite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSSComposite.Location = new System.Drawing.Point(105, 87);
            this.cbSSComposite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSSComposite.Name = "cbSSComposite";
            this.cbSSComposite.Size = new System.Drawing.Size(83, 16);
            this.cbSSComposite.TabIndex = 79;
            this.cbSSComposite.Text = "Composite";
            this.cbSSComposite.UseVisualStyleBackColor = false;
            this.cbSSComposite.CheckedChanged += new System.EventHandler(this.cbSSComposite_CheckedChanged);
            // 
            // cbSSSplit
            // 
            this.cbSSSplit.AutoSize = true;
            this.cbSSSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSSSplit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSSSplit.Location = new System.Drawing.Point(105, 65);
            this.cbSSSplit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSSSplit.Name = "cbSSSplit";
            this.cbSSSplit.Size = new System.Drawing.Size(48, 16);
            this.cbSSSplit.TabIndex = 78;
            this.cbSSSplit.Text = "Split";
            this.cbSSSplit.UseVisualStyleBackColor = false;
            this.cbSSSplit.CheckedChanged += new System.EventHandler(this.cbSSSplit_CheckedChanged);
            // 
            // cbEAft
            // 
            this.cbEAft.AutoSize = true;
            this.cbEAft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEAft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEAft.Location = new System.Drawing.Point(4, 87);
            this.cbEAft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEAft.Name = "cbEAft";
            this.cbEAft.Size = new System.Drawing.Size(40, 16);
            this.cbEAft.TabIndex = 77;
            this.cbEAft.Text = "Aft";
            this.cbEAft.UseVisualStyleBackColor = false;
            this.cbEAft.CheckedChanged += new System.EventHandler(this.cbEAft_CheckedChanged);
            // 
            // cbEAmidship
            // 
            this.cbEAmidship.AutoSize = true;
            this.cbEAmidship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEAmidship.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEAmidship.Location = new System.Drawing.Point(4, 65);
            this.cbEAmidship.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEAmidship.Name = "cbEAmidship";
            this.cbEAmidship.Size = new System.Drawing.Size(75, 16);
            this.cbEAmidship.TabIndex = 76;
            this.cbEAmidship.Text = "Amidship";
            this.cbEAmidship.UseVisualStyleBackColor = false;
            this.cbEAmidship.CheckedChanged += new System.EventHandler(this.cbEAmidship_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(208, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 14);
            this.label16.TabIndex = 75;
            this.label16.Text = "Islands";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(102, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 14);
            this.label15.TabIndex = 74;
            this.label15.Text = "Superstructure";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(6, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 14);
            this.label14.TabIndex = 73;
            this.label14.Text = "Engine";
            // 
            // gbObservations
            // 
            this.gbObservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbObservations.Controls.Add(this.numTargetPassTime);
            this.gbObservations.Controls.Add(this.label18);
            this.gbObservations.Controls.Add(this.numHorizontalMeasurement);
            this.gbObservations.Controls.Add(this.numVerticalMeasurement);
            this.gbObservations.Controls.Add(this.label6);
            this.gbObservations.Controls.Add(this.label5);
            this.gbObservations.Controls.Add(this.numTargetBearing);
            this.gbObservations.Controls.Add(this.label9);
            this.gbObservations.Controls.Add(this.bRecedingBowRight);
            this.gbObservations.Controls.Add(this.bApproachingBowRight);
            this.gbObservations.Controls.Add(this.bApproachingBowLeft);
            this.gbObservations.Controls.Add(this.bRecedingBowLeft);
            this.gbObservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbObservations.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbObservations.ForeColor = System.Drawing.Color.Red;
            this.gbObservations.Location = new System.Drawing.Point(892, 10);
            this.gbObservations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbObservations.Name = "gbObservations";
            this.gbObservations.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbObservations.Size = new System.Drawing.Size(213, 246);
            this.gbObservations.TabIndex = 1;
            this.gbObservations.TabStop = false;
            this.gbObservations.Text = "Observations";
            // 
            // numTargetPassTime
            // 
            this.numTargetPassTime.AccessibleDescription = "Time in seconds passing bow to stern on the parascope vertical";
            this.numTargetPassTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numTargetPassTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTargetPassTime.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numTargetPassTime.ForeColor = System.Drawing.Color.Red;
            this.numTargetPassTime.Location = new System.Drawing.Point(10, 207);
            this.numTargetPassTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numTargetPassTime.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numTargetPassTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTargetPassTime.Name = "numTargetPassTime";
            this.numTargetPassTime.Size = new System.Drawing.Size(95, 30);
            this.numTargetPassTime.TabIndex = 53;
            this.numTargetPassTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTargetPassTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numTargetPassTime.ValueChanged += new System.EventHandler(this.numTargetPassTime_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(10, 180);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 24);
            this.label18.TabIndex = 52;
            this.label18.Text = "Target Time\r\nTo Pass";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numHorizontalMeasurement
            // 
            this.numHorizontalMeasurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numHorizontalMeasurement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numHorizontalMeasurement.DecimalPlaces = 1;
            this.numHorizontalMeasurement.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numHorizontalMeasurement.ForeColor = System.Drawing.Color.Red;
            this.numHorizontalMeasurement.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numHorizontalMeasurement.Location = new System.Drawing.Point(106, 207);
            this.numHorizontalMeasurement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numHorizontalMeasurement.Maximum = new decimal(new int[] {
            259,
            0,
            0,
            65536});
            this.numHorizontalMeasurement.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numHorizontalMeasurement.Name = "numHorizontalMeasurement";
            this.numHorizontalMeasurement.Size = new System.Drawing.Size(99, 30);
            this.numHorizontalMeasurement.TabIndex = 27;
            this.numHorizontalMeasurement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numHorizontalMeasurement.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numHorizontalMeasurement.ValueChanged += new System.EventHandler(this.numHorizontalMeasurement_ValueChanged);
            // 
            // numVerticalMeasurement
            // 
            this.numVerticalMeasurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numVerticalMeasurement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numVerticalMeasurement.DecimalPlaces = 1;
            this.numVerticalMeasurement.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numVerticalMeasurement.ForeColor = System.Drawing.Color.Red;
            this.numVerticalMeasurement.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numVerticalMeasurement.Location = new System.Drawing.Point(106, 142);
            this.numVerticalMeasurement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numVerticalMeasurement.Maximum = new decimal(new int[] {
            259,
            0,
            0,
            65536});
            this.numVerticalMeasurement.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numVerticalMeasurement.Name = "numVerticalMeasurement";
            this.numVerticalMeasurement.Size = new System.Drawing.Size(99, 30);
            this.numVerticalMeasurement.TabIndex = 26;
            this.numVerticalMeasurement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numVerticalMeasurement.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numVerticalMeasurement.ValueChanged += new System.EventHandler(this.numVerticalMeasurement_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(106, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "6x Horizontal\r\nMeasurement";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(106, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "6x Vertical\r\nMeasurement";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numTargetBearing
            // 
            this.numTargetBearing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numTargetBearing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTargetBearing.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numTargetBearing.ForeColor = System.Drawing.Color.Red;
            this.numTargetBearing.Location = new System.Drawing.Point(10, 142);
            this.numTargetBearing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numTargetBearing.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numTargetBearing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numTargetBearing.Name = "numTargetBearing";
            this.numTargetBearing.Size = new System.Drawing.Size(95, 30);
            this.numTargetBearing.TabIndex = 23;
            this.numTargetBearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTargetBearing.ValueChanged += new System.EventHandler(this.numTargetBearing_ValueChanged);
            // 
            // label9
            // 
            this.label9.AccessibleDescription = "Target\'s relative bearing from the Uboot position";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Target Magnetic \r\nBearing\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bRecedingBowRight
            // 
            this.bRecedingBowRight.BackColor = System.Drawing.Color.DimGray;
            this.bRecedingBowRight.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bRecedingBowRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRecedingBowRight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRecedingBowRight.ForeColor = System.Drawing.Color.DarkGray;
            this.bRecedingBowRight.Location = new System.Drawing.Point(106, 61);
            this.bRecedingBowRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bRecedingBowRight.Name = "bRecedingBowRight";
            this.bRecedingBowRight.Size = new System.Drawing.Size(99, 42);
            this.bRecedingBowRight.TabIndex = 3;
            this.bRecedingBowRight.Text = " Receding   Bow Right";
            this.bRecedingBowRight.UseVisualStyleBackColor = false;
            this.bRecedingBowRight.Click += new System.EventHandler(this.bRecedingBowRight_Click);
            // 
            // bApproachingBowRight
            // 
            this.bApproachingBowRight.BackColor = System.Drawing.Color.DimGray;
            this.bApproachingBowRight.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bApproachingBowRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApproachingBowRight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bApproachingBowRight.ForeColor = System.Drawing.Color.DarkGray;
            this.bApproachingBowRight.Location = new System.Drawing.Point(106, 18);
            this.bApproachingBowRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bApproachingBowRight.Name = "bApproachingBowRight";
            this.bApproachingBowRight.Size = new System.Drawing.Size(99, 40);
            this.bApproachingBowRight.TabIndex = 2;
            this.bApproachingBowRight.Text = "Approaching Bow Right";
            this.bApproachingBowRight.UseVisualStyleBackColor = false;
            this.bApproachingBowRight.Click += new System.EventHandler(this.bApproachingBowRight_Click);
            // 
            // bApproachingBowLeft
            // 
            this.bApproachingBowLeft.BackColor = System.Drawing.Color.Red;
            this.bApproachingBowLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bApproachingBowLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApproachingBowLeft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bApproachingBowLeft.ForeColor = System.Drawing.Color.DarkGray;
            this.bApproachingBowLeft.Location = new System.Drawing.Point(6, 18);
            this.bApproachingBowLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bApproachingBowLeft.Name = "bApproachingBowLeft";
            this.bApproachingBowLeft.Size = new System.Drawing.Size(99, 40);
            this.bApproachingBowLeft.TabIndex = 1;
            this.bApproachingBowLeft.Text = "Approaching Bow Left";
            this.bApproachingBowLeft.UseVisualStyleBackColor = false;
            this.bApproachingBowLeft.Click += new System.EventHandler(this.bApproachingBowLeft_Click);
            // 
            // bRecedingBowLeft
            // 
            this.bRecedingBowLeft.BackColor = System.Drawing.Color.DimGray;
            this.bRecedingBowLeft.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bRecedingBowLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRecedingBowLeft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRecedingBowLeft.ForeColor = System.Drawing.Color.DarkGray;
            this.bRecedingBowLeft.Location = new System.Drawing.Point(6, 61);
            this.bRecedingBowLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bRecedingBowLeft.Name = "bRecedingBowLeft";
            this.bRecedingBowLeft.Size = new System.Drawing.Size(99, 42);
            this.bRecedingBowLeft.TabIndex = 0;
            this.bRecedingBowLeft.Text = " Receding   Bow Left";
            this.bRecedingBowLeft.UseVisualStyleBackColor = false;
            this.bRecedingBowLeft.Click += new System.EventHandler(this.bRecedingBowLeft_Click);
            // 
            // gbETD
            // 
            this.gbETD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbETD.Controls.Add(this.tbEstSpeed);
            this.gbETD.Controls.Add(this.label24);
            this.gbETD.Controls.Add(this.tbAOB);
            this.gbETD.Controls.Add(this.tbEstHeading);
            this.gbETD.Controls.Add(this.label20);
            this.gbETD.Controls.Add(this.tbEstRange);
            this.gbETD.Controls.Add(this.label19);
            this.gbETD.Controls.Add(this.label10);
            this.gbETD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbETD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbETD.ForeColor = System.Drawing.Color.Red;
            this.gbETD.Location = new System.Drawing.Point(1113, 10);
            this.gbETD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbETD.Name = "gbETD";
            this.gbETD.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbETD.Size = new System.Drawing.Size(193, 246);
            this.gbETD.TabIndex = 23;
            this.gbETD.TabStop = false;
            this.gbETD.Text = "Estimated Target Data";
            // 
            // tbEstSpeed
            // 
            this.tbEstSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbEstSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEstSpeed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbEstSpeed.ForeColor = System.Drawing.Color.Red;
            this.tbEstSpeed.Location = new System.Drawing.Point(7, 93);
            this.tbEstSpeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEstSpeed.Name = "tbEstSpeed";
            this.tbEstSpeed.ReadOnly = true;
            this.tbEstSpeed.Size = new System.Drawing.Size(177, 26);
            this.tbEstSpeed.TabIndex = 12;
            this.tbEstSpeed.Text = "35";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(7, 76);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 14);
            this.label24.TabIndex = 11;
            this.label24.Text = "Speed";
            // 
            // tbAOB
            // 
            this.tbAOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbAOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAOB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbAOB.ForeColor = System.Drawing.Color.Red;
            this.tbAOB.Location = new System.Drawing.Point(7, 197);
            this.tbAOB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAOB.Name = "tbAOB";
            this.tbAOB.ReadOnly = true;
            this.tbAOB.Size = new System.Drawing.Size(177, 26);
            this.tbAOB.TabIndex = 7;
            this.tbAOB.Text = "45 Bow Left";
            // 
            // tbEstHeading
            // 
            this.tbEstHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbEstHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEstHeading.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbEstHeading.ForeColor = System.Drawing.Color.Red;
            this.tbEstHeading.Location = new System.Drawing.Point(7, 141);
            this.tbEstHeading.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEstHeading.Name = "tbEstHeading";
            this.tbEstHeading.ReadOnly = true;
            this.tbEstHeading.Size = new System.Drawing.Size(177, 26);
            this.tbEstHeading.TabIndex = 4;
            this.tbEstHeading.Text = "35";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(7, 125);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 14);
            this.label20.TabIndex = 3;
            this.label20.Text = "Heading";
            // 
            // tbEstRange
            // 
            this.tbEstRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbEstRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEstRange.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbEstRange.ForeColor = System.Drawing.Color.Red;
            this.tbEstRange.Location = new System.Drawing.Point(7, 40);
            this.tbEstRange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEstRange.Name = "tbEstRange";
            this.tbEstRange.ReadOnly = true;
            this.tbEstRange.Size = new System.Drawing.Size(177, 26);
            this.tbEstRange.TabIndex = 2;
            this.tbEstRange.Text = "3000 m : 30.0 hm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(7, 22);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 14);
            this.label19.TabIndex = 1;
            this.label19.Text = "Range";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(7, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "Angle on Bow";
            // 
            // bFormBorder
            // 
            this.bFormBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bFormBorder.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bFormBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFormBorder.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bFormBorder.ForeColor = System.Drawing.Color.Red;
            this.bFormBorder.Location = new System.Drawing.Point(1072, 262);
            this.bFormBorder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bFormBorder.Name = "bFormBorder";
            this.bFormBorder.Size = new System.Drawing.Size(116, 35);
            this.bFormBorder.TabIndex = 93;
            this.bFormBorder.Text = "Toggle Form Border";
            this.bFormBorder.UseVisualStyleBackColor = false;
            this.bFormBorder.Click += new System.EventHandler(this.bFormBorder_Click);
            // 
            // bTargetRecognitionGroup
            // 
            this.bTargetRecognitionGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bTargetRecognitionGroup.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bTargetRecognitionGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTargetRecognitionGroup.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bTargetRecognitionGroup.ForeColor = System.Drawing.Color.Red;
            this.bTargetRecognitionGroup.Location = new System.Drawing.Point(892, 262);
            this.bTargetRecognitionGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bTargetRecognitionGroup.Name = "bTargetRecognitionGroup";
            this.bTargetRecognitionGroup.Size = new System.Drawing.Size(172, 35);
            this.bTargetRecognitionGroup.TabIndex = 94;
            this.bTargetRecognitionGroup.Text = "Toggle Target Recognition Panel";
            this.bTargetRecognitionGroup.UseVisualStyleBackColor = false;
            this.bTargetRecognitionGroup.Click += new System.EventHandler(this.bTargetRecognitionGroup_Click);
            // 
            // bCollapse
            // 
            this.bCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bCollapse.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCollapse.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCollapse.ForeColor = System.Drawing.Color.Red;
            this.bCollapse.Location = new System.Drawing.Point(1196, 262);
            this.bCollapse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCollapse.Name = "bCollapse";
            this.bCollapse.Size = new System.Drawing.Size(109, 35);
            this.bCollapse.TabIndex = 95;
            this.bCollapse.Text = "Collapse";
            this.bCollapse.UseVisualStyleBackColor = false;
            this.bCollapse.Click += new System.EventHandler(this.bCollapse_Click);
            // 
            // FormWTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1318, 308);
            this.Controls.Add(this.bCollapse);
            this.Controls.Add(this.bTargetRecognitionGroup);
            this.Controls.Add(this.bFormBorder);
            this.Controls.Add(this.gbETD);
            this.Controls.Add(this.gbObservations);
            this.Controls.Add(this.gbTargetRecognition);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormWTC";
            this.Text = "FormWTC";
            this.gbTargetRecognition.ResumeLayout(false);
            this.gbTargetRecognition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShipImage)).EndInit();
            this.gbObservations.ResumeLayout(false);
            this.gbObservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetPassTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorizontalMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVerticalMeasurement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetBearing)).EndInit();
            this.gbETD.ResumeLayout(false);
            this.gbETD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbTargetRecognition;
        private CheckBox cbIUnspecified;
        private CheckBox cbSSUnspecified;
        private CheckBox cbEUnspecified;
        private CheckBox cbIAft;
        private CheckBox cbIAmidship;
        private CheckBox cbIFore;
        private CheckBox cbSSPassenger;
        private CheckBox cbSSComposite;
        private CheckBox cbSSSplit;
        private CheckBox cbEAft;
        private CheckBox cbEAmidship;
        private Label label16;
        private Label label15;
        private Label label14;
        private Button bClearMasts;
        private TextBox tbMasts;
        private Button bFunnel;
        private Button bKingpost;
        private Button bMast;
        private Label label17;
        private ListBox lbShipList;
        private Button bLockShip;
        private PictureBox pbShipImage;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbTSBeam;
        private TextBox tbTSMaxSpeed;
        private TextBox tbTSDraught;
        private TextBox tbTSLength;
        private TextBox tbTSMastHeight;
        private TextBox tbTSTonnage;
        private GroupBox gbObservations;
        private Button bRecedingBowRight;
        private Button bApproachingBowRight;
        private Button bApproachingBowLeft;
        private Button bRecedingBowLeft;
        private NumericUpDown numTargetBearing;
        private Label label9;
        private NumericUpDown numHorizontalMeasurement;
        private NumericUpDown numVerticalMeasurement;
        private Label label6;
        private Label label5;
        private NumericUpDown numTargetPassTime;
        private Label label18;
        private GroupBox gbETD;
        private TextBox tbEstSpeed;
        private Label label24;
        private TextBox tbAOB;
        private TextBox tbEstHeading;
        private Label label20;
        private TextBox tbEstRange;
        private Label label19;
        private Label label10;
        private Button bFormBorder;
        private Button bTargetRecognitionGroup;
        private Button bCollapse;
    }
}