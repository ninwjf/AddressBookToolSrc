# AddressBookTool

## How to Build
This project is developed by Microsoft Visual Studio 2013. You could just
use Microsoft Visual Studio Community Editon or later to build this
project, or just use Microsoft Build Tools 2013 or later and execute the
build.cmd file.

If you want to generate the setup.exe file for the final result, you must
install NSIS(http://nsis.sourceforge.net/Download) and put the
DotNetChecker plug-in (you can download it from
http://nsis.sourceforge.net/DotNetChecker_plug-in) into NSIS plug-in directory
(it usually at C:\Program Files (x86)\NSIS\Plugins in 64-bits Windows or at
C:\Program Files\NSIS\Plugins in 32-bits Windows). Then you just need to execute
the build.cmd and wait the setup.exe to be generated.

## How to do Data Verification
See AddressBook.cs and search "validation".

## Where is the program entry point?
search Main() function.