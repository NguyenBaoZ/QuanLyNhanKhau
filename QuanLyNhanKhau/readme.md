# Database docker
```bash
docker run --name sql_server -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=SQLserver123456" -e "MSSQL_PID=Express" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
```