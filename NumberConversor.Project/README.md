Para publicar o pacote e utilizar como CLI
```bash
dotnet pack -c Release -o ./nupkg
dotnet tool install --global Vitor.MeuCli --add-source ./nupkg
```