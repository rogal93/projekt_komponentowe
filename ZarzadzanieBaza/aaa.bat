@ECHO OFF
set TOOLS_ROOT=%~dp0\tools
set POSTGRESQL_ROOT=%TOOLS_ROOT%\PostgreSQL\pgsql

REM Ustawianie zmiennych srodowiskowych
@SET PATH="%~dp0\bin";%PATH%
@SET PGDATA=%~dp0\data
@SET PGDATABASE=trs_db
@SET PGUSER=postgres
@SET PGPORT=9009
@SET PGLOCALEDIR=%~dp0\share\locale
REM poniższa linijka musi być odkomentowana za pierwszym uruchomieniem, potem można zakomentować
"%~dp0\bin\initdb" -U postgres -A trust
"%~dp0\bin\pg_ctl" -D "%~dp0/data" -l logfile start
ECHO Nacisnij klawisz aby zakonczyc dzialanie serwera bazy danych
pause
"%~dp0\bin\pg_ctl" -D "%~dp0/data" stop