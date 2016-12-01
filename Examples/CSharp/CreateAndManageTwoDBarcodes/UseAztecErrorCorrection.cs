﻿using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class UseAztecErrorCorrection
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate barcode object and set Barcode CodeText & Symbology
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("123456789", EncodeTypes.Aztec)
            { 
                // Set Error Error Correction level and  Save the Barcode image
                AztectErrorLevel = 10
            };           
            barCodeBuilder.Save(dataDir + "UseAztecErrorCorrection_out.bmp", BarCodeImageFormat.Bmp);
        }
    }
}
