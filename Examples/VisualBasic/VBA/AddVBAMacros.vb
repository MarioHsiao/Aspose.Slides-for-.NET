﻿Imports System
Imports Aspose.Slides.Export
Imports Aspose.Slides.Vba
Imports Aspose.Slides

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace VisualBasic.Text
    Class AddVBAMacros
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_VBA()

            'ExStart:AddVBAMacros
            ' Instantiate Presentation
            Using presentation As New Presentation()
                ' Create new VBA Project
                presentation.VbaProject = New VbaProject()

                ' Add empty module to the VBA project
                Dim [module] As IVbaModule = presentation.VbaProject.Modules.AddEmptyModule("Module")

                ' Set module source code
                [module].SourceCode = "Sub Test(oShape As Shape) MsgBox ""Test"" End Sub"

                ' Create reference to <stdole>
                Dim stdoleReference As New VbaReferenceOleTypeLib("stdole", "*\G{00020430-0000-0000-C000-000000000046}#2.0#0#C:\Windows\system32\stdole2.tlb#OLE Automation")

                ' Create reference to Office
                Dim officeReference As New VbaReferenceOleTypeLib("Office", "*\G{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}#2.0#0#C:\Program Files\Common Files\Microsoft Shared\OFFICE14\MSO.DLL#Microsoft Office 14.0 Object Library")

                ' Add references to the VBA project
                presentation.VbaProject.References.Add(stdoleReference)
                presentation.VbaProject.References.Add(officeReference)

                'ExStart:AddVBAMacros
                ' Save Presentation
                presentation.Save(dataDir & Convert.ToString("AddVBAMacros.pptm"), SaveFormat.Pptm)
            End Using
        End Sub
    End Class
End Namespace