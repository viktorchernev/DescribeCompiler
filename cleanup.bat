@echo off
setlocal enabledelayedexpansion

REM Iterate through all folders in the current directory
for /d %%D in (*) do (
    REM Check if the folder name starts with a capital letter
    set folderName=%%~nD
    if "!folderName:~0,1!" geq "A" if "!folderName:~0,1!" leq "Z" (
        REM Check if both "bin" and "obj" subfolders exist
        if exist "%%D\bin" if exist "%%D\obj" (
            echo Deleting "bin" and "obj" folders in %%D
            rd /s /q "%%D\bin"
            rd /s /q "%%D\obj"
        )
    )
)

echo Done.
endlocal
pause