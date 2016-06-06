'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides

'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx

Namespace VisualBasic.Presentations
    Public Class AccessProperties
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Presentations()

            'Accessing the Document Properties of a Password Protected Presentation without Password
            'creating instance of load options to set the presentation access password
            Dim loadOptions As New Aspose.Slides.LoadOptions()

            'Setting the access password to null
            loadOptions.Password = "Password"

            'Setting the access to document properties
            loadOptions.OnlyLoadDocumentProperties = True

            'Opening the presentation file by passing the file path and load options to the constructor of Presentation class
            Dim pres As New Presentation(dataDir & "AccessProperties.pptx", loadOptions)

            'Getting Document Properties
            Dim docProps As IDocumentProperties = pres.DocumentProperties

            System.Console.WriteLine("Name of Application : " & docProps.NameOfApplication)
        End Sub
    End Class
End Namespace