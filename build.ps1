Param([Parameter(Mandatory=$true)][string]$version)

$ErrorActionPreference = "Stop"

dotnet pack --nologo --output "$pwd\artifacts" --configuration Release /p:Version=$version /p:PackageVersion=$version
