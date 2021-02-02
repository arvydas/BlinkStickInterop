@ECHO OFF
REM C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe /u /codebase /tlb BlinkStickInterop\bin\%1\BlinkStickInterop.dll
C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe "BlinkStickInterop\bin\x86\Debug\BlinkStickInterop.dll" /tlb /unregister
REM C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe "BlinkStickInterop\bin\Debug\BlinkStickInterop.dll" /tlb /codebase /unregister 
REM C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe "BlinkStickInterop\bin\Debug\BlinkStickInterop.dll" /tlb /codebase /unregister

