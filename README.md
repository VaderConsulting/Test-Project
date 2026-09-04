# Test Project

Test Project is a VB.NET WinForms experiment that zips every file on D:\ into D:\test.zip using ICSharpCode.SharpZipLib. Clicking Button1 enumerates the drive root with `Directory.GetFiles`, writes each file into a `ZipOutputStream` at compression level 9, then shows Operation complete. The form is the default Form1 with a single unnamed Button1; source and destination paths are hardcoded.

**Source last updated:** 2007-12-06 · **Language:** VB.NET · **Target:** .NET Framework 2.0 · **Output:** WinForms WinExe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `Test Project` | VB.NET | WinForms WinExe (.NET 2.0) | Zips every file on D:\ into D:\test.zip via SharpZipLib |

## How to open

Open `Test Project.sln` in Visual Studio 2008 (solution format 10.00) or later. The project was converted from Visual Studio 2005 (`ProductVersion` 8.0.50727, `ToolsVersion` 3.5).

## Requirements

- Visual Studio 2005 to 2008

## Attribution and provenance

Working copy from Dave Robinson's OneDrive Historical Dev folder `Test Project`. Assembly title/product `Test Project`, blank company, copyright © 2007. References `ICSharpCode.SharpZipLib` 0.85.2.329 (`ICSharpCode.SharpZipLib.dll` in the project folder). Upgrade log dated 6 December 2007 records a Visual Studio 2005 → 2008 conversion (`Backup/` and `_UpgradeReport_Files/`).

## License

MIT. Copyright (c) 2026 VaderConsulting, for Dave Robinson's code. See `LICENSE`. SharpZipLib is a third-party library (see the bundled DLL).
