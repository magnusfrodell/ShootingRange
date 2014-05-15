﻿using System;
using System.IO;
using bpac;
using ShootingRange.Service.Interface;

namespace ShootingRange.BarcodePrinter
{
  public class PtouchBarcodePrinter : IBarcodePrintService
  {
    public void Print(BarcodeInfo barcodeInfo)
    {
      DocumentClass doc = new DocumentClass();
      const string path = @".\Templates\Volksschiessen.lbx";
      string fullPath = Path.GetFullPath(path);
      if (doc.Open(fullPath))
      {
        IObject barcode = doc.GetObject("barcode");
        barcode.Text = Convert.ToString(barcodeInfo.Barcode);

        IObject shooterName = doc.GetObject("shooterName");
        shooterName.Text = Convert.ToString(barcodeInfo.FirstName + " " + barcodeInfo.LastName);

        IObject dateOfBirth = doc.GetObject("dateOfBirth");
        dateOfBirth.Text = Convert.ToString(barcodeInfo.DateOfBirth);

        doc.StartPrint("", PrintOptionConstants.bpoDefault);
        doc.PrintOut(1, PrintOptionConstants.bpoDefault);
        doc.EndPrint();
        doc.Close();
      }
    }
  }
}