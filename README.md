# Pubblicare l'Applicazione come Self-Contained

Esegui il comando di pubblicazione:

```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

Sostituisci win-x64 con linux-x64 o osx-x64 se vuoi pubblicare per altri sistemi operativi.

Questo comando creerà una cartella di output con tutti i file necessari per eseguire l’applicazione, incluso il runtime .NET. 

La cartella sarà situata in:

```bash
bin/Release/net7.0/win-x64/publish
```