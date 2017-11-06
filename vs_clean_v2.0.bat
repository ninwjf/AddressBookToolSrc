::@echo off
::search and delete unused files...

rmdir %cd%\bin /s/q
rmdir %cd%\AddressbookTool\bin /s/q
rmdir %cd%\AddressbookTool\obj /s/q
rmdir %cd%\IPAddressControlLib\bin /s/q
rmdir %cd%\IPAddressControlLib\obj /s/q
del %cd%\*.suo /s/q
del %cd%\*.user /s/q
del %cd%\*.sdf /s/q
del %cd%\AddressBookToolSetup_*.exe

::rem finish
::pause