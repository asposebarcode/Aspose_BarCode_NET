﻿using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class GeneratingCodablockF
    {
        public static void Run()
        {
            // ExStart:GeneratingCodablockF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarCodeBuilder class.
            BarCodeBuilder b = new BarCodeBuilder();

            // Specify code text and set encode type.
            b.CodeText = "CODABLOCKF 01234567890123456789012digits";           
            b.EncodeType = EncodeTypes.CodablockF;

            // Save the image to disk in PNG format
            b.BarCodeImage.Save("CodablockF_out.png");
            // ExEnd:GeneratingCodablockF
        }
    }
}
