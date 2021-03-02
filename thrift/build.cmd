set COMPILER=thrift-0.14.0.exe
set COMPILE_OUTPUT=%cd%\protocol

if not exist %COMPILE_OUTPUT% mkdir %COMPILE_OUTPUT%

call %COMPILER% -r -gen netstd -out %COMPILE_OUTPUT% GameObject.thrift
if %ERRORLEVEL% NEQ 0 EXIT /B %ERRORLEVEL%