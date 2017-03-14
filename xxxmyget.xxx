dotnet restore
dotnet test ./tests/UnitTests/UnitTests.csproj
if not "%errorlevel%"=="0" exit -1
dotnet pack ./src/NewOrbit.AddOne/NewOrbit.AddOne.csproj -c Release --include-source