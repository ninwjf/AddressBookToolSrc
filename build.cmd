if exist "C:\Program Files (x86)\Microsoft Visual Studio 13.0\VC\bin\vcvars32.bat" (
    call "C:\Program Files (x86)\Microsoft Visual Studio 13.0\VC\bin\vcvars32.bat"
)
if exist "C:\Program Files\Microsoft Visual Studio 13.0\VC\bin\vcvars32.bat" (
    call "C:\Program Files\Microsoft Visual Studio 13.0\VC\bin\vcvars32.bat"
)

if exist "C:\Program Files (x86)\Microsoft Visual Studio 12.0\VC\bin\vcvars32.bat" (
    call "C:\Program Files (x86)\Microsoft Visual Studio 12.0\VC\bin\vcvars32.bat"
)
if exist "C:\Program Files\Microsoft Visual Studio 12.0\VC\bin\vcvars32.bat" (
    call "C:\Program Files\Microsoft Visual Studio 12.0\VC\bin\vcvars32.bat"
)

if exist "C:\Program Files (x86)\NSIS\makensis.exe" (
    set NSIS="C:\Program Files (x86)\NSIS\makensis.exe"
)
if exist "C:\Program Files\NSIS\makensis.exe" (
    set NSIS="C:\Program Files (x86)\NSIS\makensis.exe"
)

@echo on
msbuild "%cd%\AddressbookTool.sln" /p:Configuration=Release
::devenv "%cd%\AddressbookTool.sln" /build Debug
::Release
call %NSIS% "%cd%\AddressBookTool.nsi"

pause