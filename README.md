# C-shapr-code-to-convert-jpg-to-pdf

1) Open Visual Studio 2017.

2) Select Visual C# -> Console Application.

3) Type the Project name and click OK.

4) To install Aspose.Words Package:
      Tools -> NuGet Package Manager -> Package Manager Console
      
5) Type the command in the Package Manager console: 
      Install-Package Aspose.Words
      
6) Add the following library:
      using Aspose.Words
   
7) To add the reference:
    Poject -> Add Reference -> Assemblies -> select System.Drawing
    
    Project -> Add Reference -> Select Browse, then select Aspose.Words.dll (Go to the folder where the project is saved , 
    inside that folder, open packages folder, open Aspose.Words.18.10.0 folder, open Lib folder, open net40 folder, 
    then select Aspose.Words.dll)
    
8) Create a folder to store the images and output pdf file. (create those folders inside the project folder) -> create a new folder (Data)    , in that Data folder , save the images (pic1.jpg and pic2.jpg), the output pdf file (output.pdf) is also stored in that Data folder.

9) Then type the c# code.

10) Finally run the code and check the Data folder for the converted pdf.
    
