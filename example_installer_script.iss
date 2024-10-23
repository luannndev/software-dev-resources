
; Example Inno Setup script for a basic installer

[Setup]
AppName=My Example App
AppVersion=1.0
DefaultDirName={pf}\My Example App
DefaultGroupName=My Example App
OutputBaseFilename=setup

[Files]
Source: "my_example_app.exe"; DestDir: "{app}"

[Icons]
Name: "{group}\My Example App"; Filename: "{app}\my_example_app.exe"
