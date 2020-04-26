@echo off
set ignore=%~dp0ignore.txt
set dest=%~dp0..\..\


cd /d %dest%
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec2
:job
for /f %%k in (%ignore%) do if /I %1==%%k GOTO:EOF
rd /s /q %1
del %1


:sec2
cd /d %dest%install
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec3


:sec3
cd /d %dest%repo
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec4


:sec4
cd /d %dest%repo\mockup
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec5


:sec5
cd /d %dest%repo\plan
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec6


:sec6
cd /d %dest%repo\profiling
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec7



:sec7
cd /d %dest%repo\src
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec8



:sec8
cd /d %dest%repo\src\ivs_project2
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec9



:sec9
cd /d %dest%repo\src\Profiling
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec10



:sec10
cd /d %dest%repo\src\Tests
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec11



:sec11
cd /d %dest%repo\src\xpastu04_xcaras00_xsenic00_xtomas34
for /f %%i in ('dir /b') do call:job %%i
GOTO:sec12



:sec12
cd /d %dest%repo\src