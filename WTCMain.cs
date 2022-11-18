//Copyright 2022 Brian McMahon, released under GPLv3


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Reflection;
using WolfpackTargetCalculator.Properties;
using System.Resources;

namespace WolfpackTargetCalculator
{

    public class ImportedShipdata
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Engine { get; set; }
        public string? Superstructure { get; set; }
        public string? Islands { get; set; }
        public string? Masts { get; set; }
        public short Tonnage { get; set; }
        public short Length { get; set; }
        public short Draught { get; set; }
        public short Beam { get; set; }
        public short Speed { get; set; }
        public short Height { get; set; }    
    }
    public class Shipdata : ImportedShipdata
    {
        public Bitmap? ImageBitmap { get; set; }
    }
    public class WTCMain
    {
        public static List<string> lbShipListContent = new();
        public static List<ImportedShipdata>? ImportedShipDataList = new();
        public static List<Shipdata>? ShipDataList = new();
        public static Shipdata CurrentShipSelection = new();
        public static FormWTC? frmWTC = new();
        public static string EngineFilter = "U";
        public static string SuperstructureFilter = "U";
        public static string IslandsFilter = "U";
        public static string MastsFilter = "";
        public const string Title = "Wolfpack Target Calculator V1d, 'Der Alte' Approved, Copyright 2022 Brian McMahon, Released Under GPLv3";
        public static string LocalPath = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\")));
        public static Image DefaultShip;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadShipData();
            InitShipListBox(frmWTC);
            frmWTC.Text = Title;
            Application.Run(frmWTC);

        }

        private static void InitShipListBox(FormWTC form)
        {
            for (int i = 0; i < ShipDataList.Count; i++)
            {
                form.AddlbShipListItem(ShipDataList.ElementAt(i).Name);
            }
        }
        private static void LoadShipData()
        {
            try
            {
                //Debug.Write(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\")));
                //StreamReader sr = new(Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\", "shipdata.json"))));
                //string jsonString = sr.ReadToEnd();
                //sr.Close();
                //sr.Dispose();

                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "WolfpackTargetCalculator.shipdata.json";
                var showitall = assembly.GetManifestResourceNames();
                StreamReader file = new(assembly.GetManifestResourceStream(resourceName));
                string jsonString = file.ReadToEnd();
                file.Close();
                file.Dispose();
                ImportedShipDataList = JsonSerializer.Deserialize<List<ImportedShipdata>>(jsonString);
                foreach (ImportedShipdata ship in ImportedShipDataList)
                {

                    ShipDataList.Add(new Shipdata());
                    ShipDataList[^1].Name = ship.Name;
                    ShipDataList[^1].Description = ship.Description;
                    ShipDataList[^1].Image = ship.Image;
                    ShipDataList[^1].Engine = ship.Engine;
                    ShipDataList[^1].Superstructure = ship.Superstructure;
                    ShipDataList[^1].Islands = ship.Islands;
                    ShipDataList[^1].Masts = ship.Masts;
                    ShipDataList[^1].Tonnage = ship.Tonnage;
                    ShipDataList[^1].Length = ship.Length;
                    ShipDataList[^1].Draught = ship.Draught;
                    ShipDataList[^1].Beam = ship.Beam;
                    ShipDataList[^1].Speed = ship.Speed;
                    ShipDataList[^1].Height = ship.Height;
                    resourceName = "WolfpackTargetCalculator.images." + ship.Image.ToLower();
                    Stream bmpfile = assembly.GetManifestResourceStream(resourceName);
                    Bitmap bmp = Image.FromStream(bmpfile) as Bitmap;
                    bmpfile.Close();
                    bmpfile.Dispose();
                    ShipDataList[^1].ImageBitmap = bmp;
                }
            }
            catch (FileNotFoundException)
            {
                Debug.WriteLine("Error trying to read shipdata.json");
            }
            finally
            {
                Debug.WriteLine(ImportedShipDataList[0].Description);
            }
        }
    }
}

