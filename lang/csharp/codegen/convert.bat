REM Call the avrogen.exe to convert all schemas [-s] located in this folder [file path] and output in folder [folder path]
if exist ..\CssMessages\schemas\eu (
rmdir ..\CssMessages\schemas\eu /s /q
)

cd ..\..\..\data\avro-schemas

for /R %%f in (*.avsc) do (
..\..\lang\csharp\codegen\avrogen.exe -s %%f ..\..\lang\csharp\CssMessages\schemas
)

@pause